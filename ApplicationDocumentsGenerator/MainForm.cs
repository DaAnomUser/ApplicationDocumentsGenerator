using ApplicationDocumentsGenerator;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using DocumentFormat.OpenXml;
using System.IO;
using System.Text.RegularExpressions;

namespace bewerbungsemailer
{
    public partial class MainForm : Form
    {
        readonly SautinSoft.PdfMetamorphosis pdfMetamorphosis = new SautinSoft.PdfMetamorphosis();

        public MainForm()
        {
            InitializeComponent();
            
            // Load Configuration
            SmtpServerAddressTextBox.Text = MainConfiguration.SmtpServer;
            SmtpServerPortTextBox.Text = MainConfiguration.SmtpPort;
            SmtpServerUsernameTextBox.Text = MainConfiguration.SmtpUsername;
            SmtpServerPasswordTextBox.Text = MainConfiguration.SmtpPassword;
            ExcelColumnNameWithTargetEmailAddressTextBox.Text = MainConfiguration.ExcelColumnNameForEmailAddress;
        }

        void SelectFilesButton_Click(object sender, EventArgs e)
        {
            openFileDialogWord.ShowDialog();
            openFileDialogExcel.ShowDialog();
            outputFolderBrowserDialog.ShowDialog();
        }

        void CreatePdfsButton_Click(object sender, EventArgs e)
        {
            var excelColumnnameWithFilenameForOutput = ExcelColumnnameWithFilenameForOutputTextBox.Text;
            var excelColumnNameWithTargetEmailAddress = ExcelColumnNameWithTargetEmailAddressTextBox.Text;

            if (excelColumnnameWithFilenameForOutput.Length < 1)
            {
                MessageBox.Show("Please enter Columnname with PDF Filename to use in Outputfolder and E-Mail Attachment");
                WriteMessage("Abortet.");
                return;
            }

            var dialogResult = MessageBox.Show("Do you want to send E-Mail with the application documents?", "Question",MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes && string.IsNullOrWhiteSpace(excelColumnNameWithTargetEmailAddress))
            {
                MessageBox.Show("Please enter Columnname with target E-Mail Address");
                WriteMessage("Abortet.");
                return;
            }

            var docxPath = openFileDialogWord.FileName;
            var xlsxPath = openFileDialogExcel.FileName;

            var dataTable = ReadExcelToDataTable(xlsxPath);
            if (dataTable.Rows.Count <= 2)
            {
                WriteMessage("Warning: No Data found in Excel File");
                WriteMessage("Abortet.");
                return;
            }

            using (var mainDoc = WordprocessingDocument.Open(docxPath, false))
                for (int i = 1, dtRowsCount = dataTable.Rows.Count; i < dtRowsCount; i++)
                {
                    var row = dataTable.Rows[i];

                    var invalidFileNameChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                    var regex = new Regex($"[{Regex.Escape(invalidFileNameChars)}]");
                    excelColumnnameWithFilenameForOutput = regex.Replace(excelColumnnameWithFilenameForOutput, "");

                    var newDocxFileName = Path.Combine(outputFolderBrowserDialog.SelectedPath, row[excelColumnnameWithFilenameForOutput]+ ".docx");
                    var newPdfFileName = Path.Combine(outputFolderBrowserDialog.SelectedPath, row[excelColumnnameWithFilenameForOutput] + ".pdf");
                    
                    using (var resultDoc = WordprocessingDocument.Create(newDocxFileName, WordprocessingDocumentType.Document))
                    {
                        foreach (var part in mainDoc.Parts)
                            resultDoc.AddPart(part.OpenXmlPart, part.RelationshipId);

                        foreach (var descendant in resultDoc.MainDocumentPart.Document.Body.Descendants<Text>())
                        {
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                var placeholder = dataTable.Rows[0][column].ToString();

                                if (descendant.Text.Contains(placeholder))
                                {
                                    var newText = row[column].ToString();
                                    descendant.Text = descendant.Text.Replace(placeholder, newText);
                                }
                            }

                            descendant.Text.Replace("<EmailSubject>","");
                            descendant.Text.Replace("</EmailSubject>", "");
                            descendant.Text.Replace("<EmailBody>", "");
                            descendant.Text.Replace("</EmailBody>", "");
                            descendant.Text.Replace("<InfoTextForEmail>", "");
                        }
                    }
                
                    // Create PDF file
                    var retVal = pdfMetamorphosis.DocxToPdfConvertFile(newDocxFileName, newPdfFileName);
                    if (retVal != 0)
                    {
                        WriteMessage("Warning: Error while creating PDF File: " + newPdfFileName);
                        return;
                    }

                    // Send Email with Attachment
                    throw new NotImplementedException();
                }
        }

        private void WriteMessage(string message)
        {
            OutputTextBox.AppendText(message);
        }

        static DataTable ReadExcelToDataTable(string fileName)
        {
            var dt = new DataTable();

            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                var workbookPart = spreadSheetDocument.WorkbookPart;
                var sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                var relationshipId = sheets.First().Id.Value;
                var worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                var workSheet = worksheetPart.Worksheet;
                var sheetData = workSheet.GetFirstChild<SheetData>();
                var rows = sheetData.Descendants<Row>();

                foreach (Cell cell in rows.ElementAt(0))
                    dt.Columns.Add(GetCellValue(spreadSheetDocument, cell));

                foreach (Row row in rows)
                {
                    var tempRow = dt.NewRow();

                    for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                        tempRow[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));

                    dt.Rows.Add(tempRow);
                }
            }

            return dt;
        }

        public static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            var stringTablePart = document.WorkbookPart.SharedStringTablePart;
            var value = cell.CellValue.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            else
            {
                return value;
            }
        }

        void SaveConfigrationButton_Click(object sender, EventArgs e)
        {
            MainConfiguration.SmtpServer = SmtpServerAddressTextBox.Text;
            MainConfiguration.SmtpPort = SmtpServerPortTextBox.Text;
            MainConfiguration.SmtpUsername = SmtpServerUsernameTextBox.Text;
            MainConfiguration.SmtpPassword = SmtpServerPasswordTextBox.Text;
            MainConfiguration.ExcelColumnNameForEmailAddress = ExcelColumnNameWithTargetEmailAddressTextBox.Text;
        }

        static void SmtpServerPortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
    }
}