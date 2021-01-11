using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MSU_Launcher
{
    public partial class Form1 : Form
    {
        string[] msudirs;
        string[] sfcfiles;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMSUPath.Text = Settings1.Default.MSUPathSetting;
            txtLiveSplitPath.Text = Settings1.Default.LiveSplitPathSetting;
            txtSNES9xPath.Text = Settings1.Default.SNES9xPathSetting;
            txtEmoTrackerPath.Text = Settings1.Default.EmoTrackerPathSetting;
            checkBoxTimer.Checked = Settings1.Default.LiveSplitEnabled;
            checkBoxTracker.Checked = Settings1.Default.EmoTrackerEnabled;
            txtDownloadsPath.Text = Settings1.Default.DownloadsPathSetting;
            if (ValidatePaths())
            {
                LoadMSUList();
                LoadSFCList();
            }

        }

        void LoadMSUList()
        {
            msudirs = null;
            msudirs = Directory.GetDirectories(txtMSUPath.Text);
            lstboxMSU.Items.Clear();
            foreach (string msudir in msudirs)
            {
                lstboxMSU.Items.Add(Path.GetFileName(msudir));
            }
        }

        void LoadSFCList()
        {
            sfcfiles = null;
            sfcfiles = Directory.GetFiles(txtDownloadsPath.Text);
            lstboxSFC.Items.Clear();
            foreach (string sfcfile in sfcfiles)
            {
                if(Path.GetExtension(sfcfile) == ".sfc")
                {
                    FileInfo fi = new FileInfo(sfcfile);
                    lstboxSFC.Items.Add(Path.GetFileName(sfcfile) + " / " + fi.CreationTime);
                }
                //lstboxSFC.
            }

        }

        void ClearMSUList()
        {
            msudirs = null;
            lstboxMSU.Items.Clear();
        }

        void ClearSFCList()
        {
            sfcfiles = null;
            lstboxSFC.Items.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void checkBoxTimer_CheckedChanged(object sender, EventArgs e)
        {
            txtLiveSplitPath.Enabled = checkBoxTimer.Checked;
            btnBrowseLiveSplit.Enabled = checkBoxTimer.Checked;
        }

        private void checkBoxTracker_CheckedChanged(object sender, EventArgs e)
        {
            txtEmoTrackerPath.Enabled = checkBoxTracker.Checked;
            btnBrowseEmotracker.Enabled = checkBoxTracker.Checked;
        }

        bool ValidatePaths()
        {
            bool isValid = true; // variable to store if everything is valid or not. If any one check fails, false is returned and will prevent the launch button from working.
            errorProvider.Clear();
            //check if the MSU directory exists
            if (!Directory.Exists(txtMSUPath.Text))
            {
                errorProvider.SetError(txtMSUPath, "Invalid MSU Path");
                if (lstboxMSU.Items.Count > 0)
                    ClearMSUList();
                isValid = false;
            }
            else
            {
                if (lstboxMSU.Items.Count == 0)
                    LoadMSUList();
            }

            //check if timer launching is enabled
            if (checkBoxTimer.Checked)
            {

                //we only care if the path is valid when enabled. Check first if the selected file exists.
                if (File.Exists(txtLiveSplitPath.Text))
                {
                    FileInfo fi = new FileInfo(txtLiveSplitPath.Text);
                    //If file exists, validate that it is either a live split layout or splits file, if not, set as invalid.
                    if (!(fi.Extension.ToLower() == ".lsl" || fi.Extension.ToLower() == ".lss"))
                    {
                        errorProvider.SetError(txtLiveSplitPath, "Timer Path requires a live split layout or split file(.lsl, .lss)");
                        isValid = false;
                    }
                }
                else
                {
                    errorProvider.SetError(txtLiveSplitPath, "Timer file not found.");
                    isValid = false;
                }
            }

            //check if Tracker launching is enabled
            if (checkBoxTracker.Checked)
            {
                //we only care if if the path is valid when enabled. Check first if the file exists.
                if (File.Exists(txtEmoTrackerPath.Text))
                {
                    FileInfo fi = new FileInfo(txtEmoTrackerPath.Text);
                    //selected file should be emotracker.exe, if not, set as invalid.
                    if (fi.Name.ToLower() != "emotracker.exe")
                    {
                        errorProvider.SetError(txtEmoTrackerPath, "Please select emotracker executable file");
                        isValid = false;
                    }
                }
                else
                {
                    errorProvider.SetError(txtEmoTrackerPath, "Emotracker not found!");
                    isValid = false;
                }
            }

            //check if snes9x path is valid
            if (File.Exists(txtSNES9xPath.Text))
            {
                FileInfo fi = new FileInfo(txtSNES9xPath.Text);
                //selected file should be snes9x.exe
                if (fi.Name.ToLower() != "snes9x.exe")
                {
                    errorProvider.SetError(txtSNES9xPath, "Please select snes9x emulator file");
                    isValid = false;
                }
            }
            else
            {
                errorProvider.SetError(txtSNES9xPath, "SNES9X not found!");
                isValid = false;
            }

            //check if downloads path is valid
            if (!Directory.Exists(txtDownloadsPath.Text))
            {
                errorProvider.SetError(txtDownloadsPath, "Invalid Downloads Path");
                if (lstboxSFC.Items.Count > 0)
                    ClearSFCList();
                isValid = false;
            }
            else
            {
                if (lstboxSFC.Items.Count == 0)
                    LoadSFCList();
            }

            if (isValid)
            {
                errorProvider.Clear();
                btnLaunch.Enabled = true;
            }
            else
            {
                btnLaunch.Enabled = false;
            }
            return isValid;
        }

        private void btnBrowseMSU_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = txtMSUPath.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
            {

                txtMSUPath.Text = fbd.SelectedPath;
                if (ValidatePaths())
                    LoadMSUList();
            }

        }

        private void btnBrowseSNES9X_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = Path.GetDirectoryName(txtSNES9xPath.Text);
            fd.Filter = "SNES9X Executable|snes9x.exe";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtSNES9xPath.Text = fd.FileName;
            }
            ValidatePaths();
        }

        private void btnBrowseLiveSplit_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = Path.GetDirectoryName(txtLiveSplitPath.Text);
            fd.Filter = "LiveSplit Layout or Split file|*.ls*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtLiveSplitPath.Text = fd.FileName;
            }
            ValidatePaths();
        }

        private void btnBrowseEmotracker_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = Path.GetDirectoryName(txtEmoTrackerPath.Text);
            fd.Filter = "Emotracker Executable|emotracker.exe";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtEmoTrackerPath.Text = fd.FileName;
            }
            ValidatePaths();
        }

        private void btnBrowseDownloads_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = txtDownloadsPath.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDownloadsPath.Text = fbd.SelectedPath;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Settings1.Default.MSUPathSetting = txtMSUPath.Text;
            Settings1.Default.SNES9xPathSetting = txtSNES9xPath.Text;
            Settings1.Default.LiveSplitEnabled = checkBoxTimer.Checked;
            Settings1.Default.LiveSplitPathSetting = txtLiveSplitPath.Text;
            Settings1.Default.EmoTrackerEnabled = checkBoxTracker.Checked;
            Settings1.Default.EmoTrackerPathSetting = txtEmoTrackerPath.Text;
            Settings1.Default.DownloadsPathSetting = txtDownloadsPath.Text;
            Settings1.Default.Save();
        }

        private void txtMSUPath_Leave(object sender, EventArgs e)
        {
            if (ValidatePaths())
                LoadMSUList();
        }

        private void txtSNES9xPath_Leave(object sender, EventArgs e)
        {
            ValidatePaths();
        }

        private void txtLiveSplitPath_Leave(object sender, EventArgs e)
        {
            ValidatePaths();
        }

        private void txtEmoTrackerPath_Leave(object sender, EventArgs e)
        {
            ValidatePaths();
        }

        private void txtDownloadsPath_Leave(object sender, EventArgs e)
        {
            if (ValidatePaths())
            {
                LoadSFCList();
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {

        }
    }
}
