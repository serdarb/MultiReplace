namespace MultiReplace
{
    partial class frmMain
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
            this.lblDictionary = new System.Windows.Forms.Label();
            this.lblReplacingFiles = new System.Windows.Forms.Label();
            this.btnDictionaryFileSelector = new System.Windows.Forms.Button();
            this.btnReplacingFilesSelector = new System.Windows.Forms.Button();
            this.txtDictionaryFile = new System.Windows.Forms.TextBox();
            this.lstReplacingFiles = new System.Windows.Forms.ListBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.fbOutputPath = new System.Windows.Forms.FolderBrowserDialog();
            this.fdDictionaryFile = new System.Windows.Forms.OpenFileDialog();
            this.fdReplacingFiles = new System.Windows.Forms.OpenFileDialog();
            this.lblDictionarySeperator = new System.Windows.Forms.Label();
            this.txtDictionarySeperator = new System.Windows.Forms.TextBox();
            this.btnTr = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDictionary
            // 
            this.lblDictionary.AutoSize = true;
            this.lblDictionary.Location = new System.Drawing.Point(12, 18);
            this.lblDictionary.Name = "lblDictionary";
            this.lblDictionary.Size = new System.Drawing.Size(73, 13);
            this.lblDictionary.TabIndex = 0;
            this.lblDictionary.Text = "Dictionary File";
            // 
            // lblReplacingFiles
            // 
            this.lblReplacingFiles.AutoSize = true;
            this.lblReplacingFiles.Location = new System.Drawing.Point(12, 84);
            this.lblReplacingFiles.Name = "lblReplacingFiles";
            this.lblReplacingFiles.Size = new System.Drawing.Size(79, 13);
            this.lblReplacingFiles.TabIndex = 1;
            this.lblReplacingFiles.Text = "Replacing Files";
            // 
            // btnDictionaryFileSelector
            // 
            this.btnDictionaryFileSelector.Location = new System.Drawing.Point(493, 18);
            this.btnDictionaryFileSelector.Name = "btnDictionaryFileSelector";
            this.btnDictionaryFileSelector.Size = new System.Drawing.Size(31, 23);
            this.btnDictionaryFileSelector.TabIndex = 2;
            this.btnDictionaryFileSelector.Text = "...";
            this.btnDictionaryFileSelector.UseVisualStyleBackColor = true;
            this.btnDictionaryFileSelector.Click += new System.EventHandler(this.btnDictionaryFileSelector_Click);
            // 
            // btnReplacingFilesSelector
            // 
            this.btnReplacingFilesSelector.Location = new System.Drawing.Point(493, 84);
            this.btnReplacingFilesSelector.Name = "btnReplacingFilesSelector";
            this.btnReplacingFilesSelector.Size = new System.Drawing.Size(31, 23);
            this.btnReplacingFilesSelector.TabIndex = 3;
            this.btnReplacingFilesSelector.Text = "...";
            this.btnReplacingFilesSelector.UseVisualStyleBackColor = true;
            this.btnReplacingFilesSelector.Click += new System.EventHandler(this.btnReplacingFilesSelector_Click);
            // 
            // txtDictionaryFile
            // 
            this.txtDictionaryFile.Location = new System.Drawing.Point(137, 18);
            this.txtDictionaryFile.Name = "txtDictionaryFile";
            this.txtDictionaryFile.Size = new System.Drawing.Size(350, 20);
            this.txtDictionaryFile.TabIndex = 4;
            // 
            // lstReplacingFiles
            // 
            this.lstReplacingFiles.FormattingEnabled = true;
            this.lstReplacingFiles.Location = new System.Drawing.Point(137, 84);
            this.lstReplacingFiles.Name = "lstReplacingFiles";
            this.lstReplacingFiles.Size = new System.Drawing.Size(350, 95);
            this.lstReplacingFiles.TabIndex = 5;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Coral;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.Location = new System.Drawing.Point(137, 227);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(150, 50);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Replace All";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.AutoSize = true;
            this.lblOutputPath.Location = new System.Drawing.Point(12, 192);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(64, 13);
            this.lblOutputPath.TabIndex = 7;
            this.lblOutputPath.Text = "Output Path";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(137, 192);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(350, 20);
            this.txtOutputPath.TabIndex = 9;
            this.txtOutputPath.Text = "C:\\MultiReplace";
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(493, 192);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(31, 23);
            this.btnOutputPath.TabIndex = 8;
            this.btnOutputPath.Text = "...";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // fdDictionaryFile
            // 
            this.fdDictionaryFile.FileName = "fdDictionaryFile";
            // 
            // fdReplacingFiles
            // 
            this.fdReplacingFiles.FileName = "fdReplacingFiles";
            this.fdReplacingFiles.Multiselect = true;
            // 
            // lblDictionarySeperator
            // 
            this.lblDictionarySeperator.AutoSize = true;
            this.lblDictionarySeperator.Location = new System.Drawing.Point(12, 51);
            this.lblDictionarySeperator.Name = "lblDictionarySeperator";
            this.lblDictionarySeperator.Size = new System.Drawing.Size(103, 13);
            this.lblDictionarySeperator.TabIndex = 10;
            this.lblDictionarySeperator.Text = "Dictionary Seperator";
            // 
            // txtDictionarySeperator
            // 
            this.txtDictionarySeperator.Location = new System.Drawing.Point(137, 51);
            this.txtDictionarySeperator.Name = "txtDictionarySeperator";
            this.txtDictionarySeperator.Size = new System.Drawing.Size(350, 20);
            this.txtDictionarySeperator.TabIndex = 11;
            this.txtDictionarySeperator.Text = "é";
            // 
            // btnTr
            // 
            this.btnTr.Location = new System.Drawing.Point(456, 250);
            this.btnTr.Name = "btnTr";
            this.btnTr.Size = new System.Drawing.Size(30, 30);
            this.btnTr.TabIndex = 12;
            this.btnTr.UseVisualStyleBackColor = true;
            this.btnTr.Click += new System.EventHandler(this.btnTr_Click);
            // 
            // btnEng
            // 
            this.btnEng.Location = new System.Drawing.Point(493, 250);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(30, 30);
            this.btnEng.TabIndex = 13;
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(536, 292);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnTr);
            this.Controls.Add(this.txtDictionarySeperator);
            this.Controls.Add(this.lblDictionarySeperator);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lstReplacingFiles);
            this.Controls.Add(this.txtDictionaryFile);
            this.Controls.Add(this.btnReplacingFilesSelector);
            this.Controls.Add(this.btnDictionaryFileSelector);
            this.Controls.Add(this.lblReplacingFiles);
            this.Controls.Add(this.lblDictionary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Replace - Replaces multiple file with a dictionary source";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDictionary;
        private System.Windows.Forms.Label lblReplacingFiles;
        private System.Windows.Forms.Button btnDictionaryFileSelector;
        private System.Windows.Forms.Button btnReplacingFilesSelector;
        private System.Windows.Forms.TextBox txtDictionaryFile;
        private System.Windows.Forms.ListBox lstReplacingFiles;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.FolderBrowserDialog fbOutputPath;
        private System.Windows.Forms.OpenFileDialog fdDictionaryFile;
        private System.Windows.Forms.OpenFileDialog fdReplacingFiles;
        private System.Windows.Forms.Label lblDictionarySeperator;
        private System.Windows.Forms.TextBox txtDictionarySeperator;
        private System.Windows.Forms.Button btnTr;
        private System.Windows.Forms.Button btnEng;
    }
}

