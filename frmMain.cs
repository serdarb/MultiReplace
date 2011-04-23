using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Drawing;
using MultiReplace.Properties;

namespace MultiReplace
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDictionaryFileSelector_Click(object sender, EventArgs e)
        {
            if (fdDictionaryFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDictionaryFile.Text = fdDictionaryFile.FileName;
            }
        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {
            if (fbOutputPath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtOutputPath.Text = fbOutputPath.SelectedPath;
            }
        }

        private void btnReplacingFilesSelector_Click(object sender, EventArgs e)
        {
            if (fdReplacingFiles.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int fileCount = fdReplacingFiles.FileNames.Length;
                for (int i = 0; i < fileCount; i++)
                {
                    lstReplacingFiles.Items.Add(fdReplacingFiles.FileNames[i]);
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            bool isCancelled = false;
            string[] dict = File.ReadAllLines(txtDictionaryFile.Text.Trim(), Encoding.GetEncoding(0));

            int dictItemCount = dict.Length;
            int fileCount = lstReplacingFiles.Items.Count;

            for (int i = 0; i < fileCount; i++)
            {
                string fileName = lstReplacingFiles.Items[i].ToString();
                string content = File.ReadAllText(fileName, Encoding.GetEncoding(0));

                for (int j = 0; j < dictItemCount; j++)
                {
                    string[] dictKeyValue = dict[j].Split(
                                        new string[] { txtDictionarySeperator.Text.Trim() },
                                        StringSplitOptions.RemoveEmptyEntries);

                    string dictKey = dictKeyValue[0];
                    string dictValue = dictKeyValue[1];

                    content = content.Replace(dictKey, dictValue);
                }

                string outputFolder = txtOutputPath.Text.Trim();
                if (!Directory.Exists(outputFolder))
                {
                    Directory.CreateDirectory(outputFolder);
                }

                string outputFileName = string.Format("{0}\\{1}", outputFolder, Path.GetFileName(fileName));
                if (File.Exists(outputFileName))
                {
                    DialogResult dr = MessageBox.Show(string.Format("File Already Exists!{0}Do you want to overwrite?{0}{1}", Environment.NewLine, outputFileName), "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                    if (dr == DialogResult.Yes)
                    {
                        File.WriteAllText(outputFileName, content);
                    }
                    else if (dr == DialogResult.No)
                    { }
                    else
                    {
                        isCancelled = true;
                        break; 
                    }
                }
                else
                {
                    File.WriteAllText(outputFileName, content, Encoding.GetEncoding(0));
                }
            }

            MessageBox.Show(isCancelled ?  "Operation Completed With Cancellation" : "Operation Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process.Start("explorer.exe", txtOutputPath.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            SettingCulture("en-US");

            btnTr.Image = Resources.tr;
            btnEng.Image = Resources.en;
            btnEng.Enabled = false;

        }

        private void SettingCulture(string cultureLang)
        {
            ResourceManager resource = new ResourceManager("MultiReplace.UILang", Type.GetType("MultiReplace.frmMain").Assembly);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureLang);

            this.lblDictionary.Text = resource.GetString("lblDictionary");
            this.lblDictionarySeperator.Text = resource.GetString("lblDictionarySeperator");
            this.lblOutputPath.Text = resource.GetString("lblOutputPath");
            this.lblReplacingFiles.Text = resource.GetString("lblReplacingFiles");
            this.Text = resource.GetString("frmMainTitle");
            this.btnRun.Text = resource.GetString("btnRun");

        }

        private void btnTr_Click(object sender, EventArgs e)
        {
            SettingCulture("tr-TR");
            btnEng.Enabled=true;
            btnTr.Enabled = false;
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            SettingCulture("en-US");
            btnEng.Enabled = false;
            btnTr.Enabled = true;
        }
    }
}
