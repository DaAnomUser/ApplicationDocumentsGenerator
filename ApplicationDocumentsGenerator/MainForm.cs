using System;
using System.IO;
using System.Windows.Forms;

namespace bewerbungsemailer
{
    public partial class MainForm : Form
    {
        readonly SautinSoft.PdfMetamorphosis pdfMetamorphosis = new SautinSoft.PdfMetamorphosis();

        public MainForm()
        {
            InitializeComponent();
        }

        void SelectFilesButton_Click(object sender, EventArgs e)
        {
            openFileDialogWord.ShowDialog();
            //saveFileDialogPDF.ShowDialog();
        }

        void CreatePdfsButton_Click(object sender, EventArgs e)
        {
            var docxPath = openFileDialogWord.FileName;
            var pdfPath = Path.ChangeExtension(docxPath, ".pdf");

            var retVal = pdfMetamorphosis.DocxToPdfConvertFile(docxPath, pdfPath);

            if (retVal == 0)
                System.Diagnostics.Process.Start(pdfPath);
            else
                MessageBox.Show("Conversion failed!");
        }
    }
}