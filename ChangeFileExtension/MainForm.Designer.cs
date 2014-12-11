namespace ChangeFileExtension
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_selectDirectory = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtBox_selectedDirectory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstBox_directoryContents = new System.Windows.Forms.ListBox();
            this.chkBox_selectAll = new System.Windows.Forms.CheckBox();
            this.lbl_selectExtension = new System.Windows.Forms.Label();
            this.cmbBox_selectedExtension = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox_targetExtension = new System.Windows.Forms.ComboBox();
            this.btn_changeFileExtension = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbl_selectDirectory
            // 
            this.lbl_selectDirectory.AutoSize = true;
            this.lbl_selectDirectory.Location = new System.Drawing.Point(21, 37);
            this.lbl_selectDirectory.Name = "lbl_selectDirectory";
            this.lbl_selectDirectory.Size = new System.Drawing.Size(92, 15);
            this.lbl_selectDirectory.TabIndex = 0;
            this.lbl_selectDirectory.Text = "Select Directory:";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select a folder";
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // txtBox_selectedDirectory
            // 
            this.txtBox_selectedDirectory.Location = new System.Drawing.Point(128, 37);
            this.txtBox_selectedDirectory.Name = "txtBox_selectedDirectory";
            this.txtBox_selectedDirectory.ReadOnly = true;
            this.txtBox_selectedDirectory.Size = new System.Drawing.Size(399, 23);
            this.txtBox_selectedDirectory.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstBox_directoryContents
            // 
            this.lstBox_directoryContents.FormattingEnabled = true;
            this.lstBox_directoryContents.HorizontalScrollbar = true;
            this.lstBox_directoryContents.ItemHeight = 15;
            this.lstBox_directoryContents.Location = new System.Drawing.Point(21, 123);
            this.lstBox_directoryContents.Name = "lstBox_directoryContents";
            this.lstBox_directoryContents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBox_directoryContents.Size = new System.Drawing.Size(695, 214);
            this.lstBox_directoryContents.Sorted = true;
            this.lstBox_directoryContents.TabIndex = 3;
            // 
            // chkBox_selectAll
            // 
            this.chkBox_selectAll.AutoSize = true;
            this.chkBox_selectAll.Location = new System.Drawing.Point(28, 348);
            this.chkBox_selectAll.Name = "chkBox_selectAll";
            this.chkBox_selectAll.Size = new System.Drawing.Size(74, 19);
            this.chkBox_selectAll.TabIndex = 4;
            this.chkBox_selectAll.Text = "Select All";
            this.chkBox_selectAll.UseVisualStyleBackColor = true;
            this.chkBox_selectAll.CheckedChanged += new System.EventHandler(this.chkBox_selectAll_CheckedChanged);
            // 
            // lbl_selectExtension
            // 
            this.lbl_selectExtension.AutoSize = true;
            this.lbl_selectExtension.Location = new System.Drawing.Point(19, 89);
            this.lbl_selectExtension.Name = "lbl_selectExtension";
            this.lbl_selectExtension.Size = new System.Drawing.Size(94, 15);
            this.lbl_selectExtension.TabIndex = 6;
            this.lbl_selectExtension.Text = "Select Extension:";
            // 
            // cmbBox_selectedExtension
            // 
            this.cmbBox_selectedExtension.FormattingEnabled = true;
            this.cmbBox_selectedExtension.Items.AddRange(new object[] {
            ".avi",
            ".flv",
            ".mkv",
            ".mov",
            ".mp4",
            ".mpeg",
            ".mpg",
            ".rmpg"});
            this.cmbBox_selectedExtension.Location = new System.Drawing.Point(130, 80);
            this.cmbBox_selectedExtension.Name = "cmbBox_selectedExtension";
            this.cmbBox_selectedExtension.Size = new System.Drawing.Size(140, 23);
            this.cmbBox_selectedExtension.Sorted = true;
            this.cmbBox_selectedExtension.TabIndex = 7;
            this.cmbBox_selectedExtension.SelectedIndexChanged += new System.EventHandler(this.cmbBox_selectedExtension_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Target Extension:";
            // 
            // cmbBox_targetExtension
            // 
            this.cmbBox_targetExtension.FormattingEnabled = true;
            this.cmbBox_targetExtension.Items.AddRange(new object[] {
            ".avi",
            ".flv",
            ".mkv",
            ".mov",
            ".mp4",
            ".mpeg",
            ".mpg",
            ".rmpg"});
            this.cmbBox_targetExtension.Location = new System.Drawing.Point(487, 80);
            this.cmbBox_targetExtension.Name = "cmbBox_targetExtension";
            this.cmbBox_targetExtension.Size = new System.Drawing.Size(140, 23);
            this.cmbBox_targetExtension.Sorted = true;
            this.cmbBox_targetExtension.TabIndex = 9;
            // 
            // btn_changeFileExtension
            // 
            this.btn_changeFileExtension.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeFileExtension.Location = new System.Drawing.Point(255, 394);
            this.btn_changeFileExtension.Name = "btn_changeFileExtension";
            this.btn_changeFileExtension.Size = new System.Drawing.Size(230, 58);
            this.btn_changeFileExtension.TabIndex = 10;
            this.btn_changeFileExtension.Text = "CHANGE EXTENSION";
            this.btn_changeFileExtension.UseVisualStyleBackColor = true;
            this.btn_changeFileExtension.Click += new System.EventHandler(this.btn_changeFileExtension_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(236, 423);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(273, 27);
            this.progressBar.TabIndex = 11;
            this.progressBar.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 480);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_changeFileExtension);
            this.Controls.Add(this.cmbBox_targetExtension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBox_selectedExtension);
            this.Controls.Add(this.lbl_selectExtension);
            this.Controls.Add(this.chkBox_selectAll);
            this.Controls.Add(this.lstBox_directoryContents);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_selectedDirectory);
            this.Controls.Add(this.lbl_selectDirectory);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Change File Extension";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selectDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtBox_selectedDirectory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstBox_directoryContents;
        private System.Windows.Forms.CheckBox chkBox_selectAll;
        private System.Windows.Forms.Label lbl_selectExtension;
        private System.Windows.Forms.ComboBox cmbBox_selectedExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox_targetExtension;
        private System.Windows.Forms.Button btn_changeFileExtension;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

