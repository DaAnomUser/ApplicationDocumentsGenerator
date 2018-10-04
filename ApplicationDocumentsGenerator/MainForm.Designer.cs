namespace bewerbungsemailer
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFilesButton = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.CreatePdfsButton = new System.Windows.Forms.Button();
            this.ExcelFileLabel = new System.Windows.Forms.Label();
            this.WordFileLabel = new System.Windows.Forms.Label();
            this.ExcelFileTextBox = new System.Windows.Forms.TextBox();
            this.WordFileTextBox = new System.Windows.Forms.TextBox();
            this.SelectFilesGroupBox = new System.Windows.Forms.GroupBox();
            this.excelColumnnameWithFilenameForOutputInOutputFolderLabel = new System.Windows.Forms.Label();
            this.ExcelColumnnameWithFilenameForOutputTextBox = new System.Windows.Forms.TextBox();
            this.TargetOutputLabel = new System.Windows.Forms.Label();
            this.TargetOutputTextBox = new System.Windows.Forms.TextBox();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialogWord = new System.Windows.Forms.OpenFileDialog();
            this.SmtpServerGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveConfigrationButton = new System.Windows.Forms.Button();
            this.ExcelColumnNameWithTargetEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.ExcelColumnNameWithTargetEmailAddressLabel = new System.Windows.Forms.Label();
            this.SmtpServerPasswordLabel = new System.Windows.Forms.Label();
            this.SmtpServerUsernameLabel = new System.Windows.Forms.Label();
            this.SmtpServerPortLabel = new System.Windows.Forms.Label();
            this.SmtpServerAddressLabel = new System.Windows.Forms.Label();
            this.SmtpServerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SmtpServerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.SmtpServerPortTextBox = new System.Windows.Forms.TextBox();
            this.SmtpServerAddressTextBox = new System.Windows.Forms.TextBox();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoTextForEmail = new System.Windows.Forms.TextBox();
            this.SelectFilesGroupBox.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            this.SmtpServerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFilesButton
            // 
            this.SelectFilesButton.Location = new System.Drawing.Point(1088, 25);
            this.SelectFilesButton.Name = "SelectFilesButton";
            this.SelectFilesButton.Size = new System.Drawing.Size(152, 50);
            this.SelectFilesButton.TabIndex = 0;
            this.SelectFilesButton.Text = "Select files";
            this.SelectFilesButton.UseVisualStyleBackColor = true;
            this.SelectFilesButton.Click += new System.EventHandler(this.SelectFilesButton_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialogXlsx";
            this.openFileDialogExcel.Filter = "Excel Files|*.xlsx";
            this.openFileDialogExcel.RestoreDirectory = true;
            // 
            // CreatePdfsButton
            // 
            this.CreatePdfsButton.Location = new System.Drawing.Point(1088, 78);
            this.CreatePdfsButton.Name = "CreatePdfsButton";
            this.CreatePdfsButton.Size = new System.Drawing.Size(152, 50);
            this.CreatePdfsButton.TabIndex = 1;
            this.CreatePdfsButton.Text = "Create PDF files";
            this.CreatePdfsButton.UseVisualStyleBackColor = true;
            this.CreatePdfsButton.Click += new System.EventHandler(this.CreatePdfsButton_Click);
            // 
            // ExcelFileLabel
            // 
            this.ExcelFileLabel.AutoSize = true;
            this.ExcelFileLabel.Location = new System.Drawing.Point(99, 28);
            this.ExcelFileLabel.Name = "ExcelFileLabel";
            this.ExcelFileLabel.Size = new System.Drawing.Size(226, 17);
            this.ExcelFileLabel.TabIndex = 3;
            this.ExcelFileLabel.Text = "Excel File with Table of Textblocks:";
            // 
            // WordFileLabel
            // 
            this.WordFileLabel.AutoSize = true;
            this.WordFileLabel.Location = new System.Drawing.Point(214, 55);
            this.WordFileLabel.Name = "WordFileLabel";
            this.WordFileLabel.Size = new System.Drawing.Size(111, 17);
            this.WordFileLabel.TabIndex = 4;
            this.WordFileLabel.Text = "Word sourcefile:";
            // 
            // ExcelFileTextBox
            // 
            this.ExcelFileTextBox.Enabled = false;
            this.ExcelFileTextBox.Location = new System.Drawing.Point(331, 25);
            this.ExcelFileTextBox.Name = "ExcelFileTextBox";
            this.ExcelFileTextBox.Size = new System.Drawing.Size(751, 22);
            this.ExcelFileTextBox.TabIndex = 5;
            // 
            // WordFileTextBox
            // 
            this.WordFileTextBox.Enabled = false;
            this.WordFileTextBox.Location = new System.Drawing.Point(331, 52);
            this.WordFileTextBox.Name = "WordFileTextBox";
            this.WordFileTextBox.Size = new System.Drawing.Size(751, 22);
            this.WordFileTextBox.TabIndex = 6;
            // 
            // SelectFilesGroupBox
            // 
            this.SelectFilesGroupBox.Controls.Add(this.label1);
            this.SelectFilesGroupBox.Controls.Add(this.InfoTextForEmail);
            this.SelectFilesGroupBox.Controls.Add(this.excelColumnnameWithFilenameForOutputInOutputFolderLabel);
            this.SelectFilesGroupBox.Controls.Add(this.ExcelColumnnameWithFilenameForOutputTextBox);
            this.SelectFilesGroupBox.Controls.Add(this.TargetOutputLabel);
            this.SelectFilesGroupBox.Controls.Add(this.TargetOutputTextBox);
            this.SelectFilesGroupBox.Controls.Add(this.SelectFilesButton);
            this.SelectFilesGroupBox.Controls.Add(this.CreatePdfsButton);
            this.SelectFilesGroupBox.Controls.Add(this.ExcelFileLabel);
            this.SelectFilesGroupBox.Controls.Add(this.WordFileLabel);
            this.SelectFilesGroupBox.Controls.Add(this.WordFileTextBox);
            this.SelectFilesGroupBox.Controls.Add(this.ExcelFileTextBox);
            this.SelectFilesGroupBox.Location = new System.Drawing.Point(2, 12);
            this.SelectFilesGroupBox.Name = "SelectFilesGroupBox";
            this.SelectFilesGroupBox.Size = new System.Drawing.Size(1246, 162);
            this.SelectFilesGroupBox.TabIndex = 7;
            this.SelectFilesGroupBox.TabStop = false;
            this.SelectFilesGroupBox.Text = "Selected files";
            // 
            // excelColumnnameWithFilenameForOutputInOutputFolderLabel
            // 
            this.excelColumnnameWithFilenameForOutputInOutputFolderLabel.AutoSize = true;
            this.excelColumnnameWithFilenameForOutputInOutputFolderLabel.Location = new System.Drawing.Point(6, 109);
            this.excelColumnnameWithFilenameForOutputInOutputFolderLabel.Name = "excelColumnnameWithFilenameForOutputInOutputFolderLabel";
            this.excelColumnnameWithFilenameForOutputInOutputFolderLabel.Size = new System.Drawing.Size(319, 17);
            this.excelColumnnameWithFilenameForOutputInOutputFolderLabel.TabIndex = 9;
            this.excelColumnnameWithFilenameForOutputInOutputFolderLabel.Text = "Excel Columnname with PDF Filename for Output:";
            // 
            // ExcelColumnnameWithFilenameForOutputTextBox
            // 
            this.ExcelColumnnameWithFilenameForOutputTextBox.Location = new System.Drawing.Point(331, 106);
            this.ExcelColumnnameWithFilenameForOutputTextBox.Name = "ExcelColumnnameWithFilenameForOutputTextBox";
            this.ExcelColumnnameWithFilenameForOutputTextBox.Size = new System.Drawing.Size(751, 22);
            this.ExcelColumnnameWithFilenameForOutputTextBox.TabIndex = 10;
            // 
            // TargetOutputLabel
            // 
            this.TargetOutputLabel.AutoSize = true;
            this.TargetOutputLabel.Location = new System.Drawing.Point(149, 81);
            this.TargetOutputLabel.Name = "TargetOutputLabel";
            this.TargetOutputLabel.Size = new System.Drawing.Size(176, 17);
            this.TargetOutputLabel.TabIndex = 7;
            this.TargetOutputLabel.Text = "Target Output foldername:";
            // 
            // TargetOutputTextBox
            // 
            this.TargetOutputTextBox.Enabled = false;
            this.TargetOutputTextBox.Location = new System.Drawing.Point(331, 78);
            this.TargetOutputTextBox.Name = "TargetOutputTextBox";
            this.TargetOutputTextBox.Size = new System.Drawing.Size(751, 22);
            this.TargetOutputTextBox.TabIndex = 8;
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.OutputTextBox);
            this.OutputGroupBox.Location = new System.Drawing.Point(2, 266);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(1246, 308);
            this.OutputGroupBox.TabIndex = 8;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Output";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(6, 21);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(1234, 283);
            this.OutputTextBox.TabIndex = 7;
            // 
            // openFileDialogWord
            // 
            this.openFileDialogWord.FileName = "openFileDialogXlsx";
            this.openFileDialogWord.Filter = "Word files|*.docx";
            this.openFileDialogWord.RestoreDirectory = true;
            // 
            // SmtpServerGroupBox
            // 
            this.SmtpServerGroupBox.Controls.Add(this.SaveConfigrationButton);
            this.SmtpServerGroupBox.Controls.Add(this.ExcelColumnNameWithTargetEmailAddressTextBox);
            this.SmtpServerGroupBox.Controls.Add(this.ExcelColumnNameWithTargetEmailAddressLabel);
            this.SmtpServerGroupBox.Controls.Add(this.SmtpServerPasswordLabel);
            this.SmtpServerGroupBox.Controls.Add(this.SmtpServerUsernameLabel);
            this.SmtpServerGroupBox.Controls.Add(this.SmtpServerPortLabel);
            this.SmtpServerGroupBox.Controls.Add(this.SmtpServerAddressLabel);
            this.SmtpServerGroupBox.Controls.Add(this.SmtpServerPasswordTextBox);
            this.SmtpServerGroupBox.Controls.Add(this.SmtpServerUsernameTextBox);
            this.SmtpServerGroupBox.Controls.Add(this.SmtpServerPortTextBox);
            this.SmtpServerGroupBox.Controls.Add(this.SmtpServerAddressTextBox);
            this.SmtpServerGroupBox.Location = new System.Drawing.Point(2, 180);
            this.SmtpServerGroupBox.Name = "SmtpServerGroupBox";
            this.SmtpServerGroupBox.Size = new System.Drawing.Size(1246, 80);
            this.SmtpServerGroupBox.TabIndex = 9;
            this.SmtpServerGroupBox.TabStop = false;
            this.SmtpServerGroupBox.Text = "SMTP E-Mail Server Configuration";
            // 
            // SaveConfigrationButton
            // 
            this.SaveConfigrationButton.Location = new System.Drawing.Point(1088, 22);
            this.SaveConfigrationButton.Name = "SaveConfigrationButton";
            this.SaveConfigrationButton.Size = new System.Drawing.Size(152, 46);
            this.SaveConfigrationButton.TabIndex = 10;
            this.SaveConfigrationButton.Text = "Save Configuration";
            this.SaveConfigrationButton.UseVisualStyleBackColor = true;
            this.SaveConfigrationButton.Click += new System.EventHandler(this.SaveConfigrationButton_Click);
            // 
            // ExcelColumnNameWithTargetEmailAddressTextBox
            // 
            this.ExcelColumnNameWithTargetEmailAddressTextBox.Location = new System.Drawing.Point(786, 46);
            this.ExcelColumnNameWithTargetEmailAddressTextBox.Name = "ExcelColumnNameWithTargetEmailAddressTextBox";
            this.ExcelColumnNameWithTargetEmailAddressTextBox.Size = new System.Drawing.Size(296, 22);
            this.ExcelColumnNameWithTargetEmailAddressTextBox.TabIndex = 9;
            // 
            // ExcelColumnNameWithTargetEmailAddressLabel
            // 
            this.ExcelColumnNameWithTargetEmailAddressLabel.AutoSize = true;
            this.ExcelColumnNameWithTargetEmailAddressLabel.Location = new System.Drawing.Point(783, 22);
            this.ExcelColumnNameWithTargetEmailAddressLabel.Name = "ExcelColumnNameWithTargetEmailAddressLabel";
            this.ExcelColumnNameWithTargetEmailAddressLabel.Size = new System.Drawing.Size(299, 17);
            this.ExcelColumnNameWithTargetEmailAddressLabel.TabIndex = 8;
            this.ExcelColumnNameWithTargetEmailAddressLabel.Text = "Excel Columnname with target E-Mail Address:";
            // 
            // SmtpServerPasswordLabel
            // 
            this.SmtpServerPasswordLabel.AutoSize = true;
            this.SmtpServerPasswordLabel.Location = new System.Drawing.Point(616, 22);
            this.SmtpServerPasswordLabel.Name = "SmtpServerPasswordLabel";
            this.SmtpServerPasswordLabel.Size = new System.Drawing.Size(161, 17);
            this.SmtpServerPasswordLabel.TabIndex = 7;
            this.SmtpServerPasswordLabel.Text = "SMTP Server Password:";
            // 
            // SmtpServerUsernameLabel
            // 
            this.SmtpServerUsernameLabel.AutoSize = true;
            this.SmtpServerUsernameLabel.Location = new System.Drawing.Point(422, 22);
            this.SmtpServerUsernameLabel.Name = "SmtpServerUsernameLabel";
            this.SmtpServerUsernameLabel.Size = new System.Drawing.Size(165, 17);
            this.SmtpServerUsernameLabel.TabIndex = 6;
            this.SmtpServerUsernameLabel.Text = "SMTP Server Username:";
            // 
            // SmtpServerPortLabel
            // 
            this.SmtpServerPortLabel.AutoSize = true;
            this.SmtpServerPortLabel.Location = new System.Drawing.Point(235, 22);
            this.SmtpServerPortLabel.Name = "SmtpServerPortLabel";
            this.SmtpServerPortLabel.Size = new System.Drawing.Size(126, 17);
            this.SmtpServerPortLabel.TabIndex = 5;
            this.SmtpServerPortLabel.Text = "SMTP Server Port:";
            // 
            // SmtpServerAddressLabel
            // 
            this.SmtpServerAddressLabel.AutoSize = true;
            this.SmtpServerAddressLabel.Location = new System.Drawing.Point(46, 22);
            this.SmtpServerAddressLabel.Name = "SmtpServerAddressLabel";
            this.SmtpServerAddressLabel.Size = new System.Drawing.Size(152, 17);
            this.SmtpServerAddressLabel.TabIndex = 4;
            this.SmtpServerAddressLabel.Text = "SMTP Server Address:";
            // 
            // SmtpServerPasswordTextBox
            // 
            this.SmtpServerPasswordTextBox.Location = new System.Drawing.Point(619, 46);
            this.SmtpServerPasswordTextBox.Name = "SmtpServerPasswordTextBox";
            this.SmtpServerPasswordTextBox.Size = new System.Drawing.Size(161, 22);
            this.SmtpServerPasswordTextBox.TabIndex = 3;
            // 
            // SmtpServerUsernameTextBox
            // 
            this.SmtpServerUsernameTextBox.Location = new System.Drawing.Point(425, 46);
            this.SmtpServerUsernameTextBox.Name = "SmtpServerUsernameTextBox";
            this.SmtpServerUsernameTextBox.Size = new System.Drawing.Size(188, 22);
            this.SmtpServerUsernameTextBox.TabIndex = 2;
            // 
            // SmtpServerPortTextBox
            // 
            this.SmtpServerPortTextBox.Location = new System.Drawing.Point(238, 46);
            this.SmtpServerPortTextBox.Name = "SmtpServerPortTextBox";
            this.SmtpServerPortTextBox.Size = new System.Drawing.Size(181, 22);
            this.SmtpServerPortTextBox.TabIndex = 1;
            // 
            // SmtpServerAddressTextBox
            // 
            this.SmtpServerAddressTextBox.Location = new System.Drawing.Point(49, 46);
            this.SmtpServerAddressTextBox.Name = "SmtpServerAddressTextBox";
            this.SmtpServerAddressTextBox.Size = new System.Drawing.Size(183, 22);
            this.SmtpServerAddressTextBox.TabIndex = 0;
            // 
            // outputFolderBrowserDialog
            // 
            this.outputFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Word sourcefile:";
            // 
            // InfoTextForEmail
            // 
            this.InfoTextForEmail.Enabled = false;
            this.InfoTextForEmail.Location = new System.Drawing.Point(331, 134);
            this.InfoTextForEmail.Name = "InfoTextForEmail";
            this.InfoTextForEmail.Size = new System.Drawing.Size(751, 22);
            this.InfoTextForEmail.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 574);
            this.Controls.Add(this.SmtpServerGroupBox);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.SelectFilesGroupBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ApplicationDocumentsGenerator";
            this.SelectFilesGroupBox.ResumeLayout(false);
            this.SelectFilesGroupBox.PerformLayout();
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.SmtpServerGroupBox.ResumeLayout(false);
            this.SmtpServerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFilesButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.Button CreatePdfsButton;
        private System.Windows.Forms.Label ExcelFileLabel;
        private System.Windows.Forms.Label WordFileLabel;
        private System.Windows.Forms.TextBox ExcelFileTextBox;
        private System.Windows.Forms.TextBox WordFileTextBox;
        private System.Windows.Forms.GroupBox SelectFilesGroupBox;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label TargetOutputLabel;
        private System.Windows.Forms.TextBox TargetOutputTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogWord;
        private System.Windows.Forms.GroupBox SmtpServerGroupBox;
        private System.Windows.Forms.Label SmtpServerPasswordLabel;
        private System.Windows.Forms.Label SmtpServerUsernameLabel;
        private System.Windows.Forms.Label SmtpServerPortLabel;
        private System.Windows.Forms.Label SmtpServerAddressLabel;
        private System.Windows.Forms.TextBox SmtpServerPasswordTextBox;
        private System.Windows.Forms.TextBox SmtpServerUsernameTextBox;
        private System.Windows.Forms.TextBox SmtpServerPortTextBox;
        private System.Windows.Forms.TextBox SmtpServerAddressTextBox;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.TextBox ExcelColumnNameWithTargetEmailAddressTextBox;
        private System.Windows.Forms.Label ExcelColumnNameWithTargetEmailAddressLabel;
        private System.Windows.Forms.Button SaveConfigrationButton;
        private System.Windows.Forms.Label excelColumnnameWithFilenameForOutputInOutputFolderLabel;
        private System.Windows.Forms.TextBox ExcelColumnnameWithFilenameForOutputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InfoTextForEmail;
    }
}

