﻿using System;
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
    public partial class MSULauncherForm : Form
    {
        string[] msudirs;
        string[] sfcfiles;

        public MSULauncherForm()
        {
            InitializeComponent();
            AddVersionNumber();
        }

        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.Text += $" v.{ versionInfo.FileVersion }";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            ValidatePaths();

        }

        private void LoadSettings()
        {
            txtMSUPath.Text = Settings1.Default.MSUPathSetting;
            txtLiveSplitPath.Text = Settings1.Default.LiveSplitPathSetting;
            txtQUSB2SNESPath.Text = Settings1.Default.QUsb2SnesPathSetting;
            txtEmoTrackerPath.Text = Settings1.Default.EmoTrackerPathSetting;
            checkBoxTimer.Checked = Settings1.Default.LiveSplitEnabledSetting;
            checkBoxTracker.Checked = Settings1.Default.EmoTrackerEnabledSetting;
            txtDownloadsPath.Text = Settings1.Default.DownloadsPathSetting;
            checkboxOverwrite.Checked = Settings1.Default.OverwriteSetting;
            checkboxRandomMSU.Checked = Settings1.Default.RandomMSUSetting;
            checkboxQUsb2SnesPath.Checked = Settings1.Default.QUsb2SnesEnabledSetting;
            this.Size = new Size(Settings1.Default.SizeXSetting, Settings1.Default.SizeYSetting);
            splitContainer.SplitterDistance = Settings1.Default.SplitDistanceSetting;
            checkBoxExitAfterLaunch.Checked = Settings1.Default.ExitOnLaunchSetting;
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
            sfcfiles = Directory.GetFiles(txtDownloadsPath.Text, "*.sfc", SearchOption.TopDirectoryOnly);
            lstboxSFC.Items.Clear();
            foreach (string sfcfile in sfcfiles)
            {
                FileInfo fi = new FileInfo(sfcfile);
                lstboxSFC.Items.Add(Path.GetFileName(sfcfile) + " / " + fi.CreationTime);
            }
            if (lstboxSFC.Items.Count == 1)
            {
                lstboxSFC.SelectedIndex = 0;
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

            //check if QUsb2Snes path is valid
            if (File.Exists(txtQUSB2SNESPath.Text))
            {
                FileInfo fi = new FileInfo(txtQUSB2SNESPath.Text);
                //selected file should be qusb2snes.exe
                if (fi.Name.ToLower() != "qusb2snes.exe")
                {
                    errorProvider.SetError(txtQUSB2SNESPath, "Please select qusb2snes.exe file");
                    isValid = false;
                }
            }
            else
            {
                errorProvider.SetError(txtQUSB2SNESPath, "QUsb2Snes.exe not found!");
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
                if(lstboxSFC.Items.Count == 0)
                    LoadSFCList();
            }

            if (isValid)
            {
                errorProvider.Clear();
                if ((lstboxMSU.SelectedIndex >= 0 || checkboxRandomMSU.Checked) && lstboxSFC.SelectedIndex >= 0)
                    btnLaunch.Enabled = true;
                else
                    btnLaunch.Enabled = false;
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
            fd.InitialDirectory = Path.GetDirectoryName(txtQUSB2SNESPath.Text);
            fd.Filter = "QUsb2Snes Executable|qusb2snes.exe";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtQUSB2SNESPath.Text = fd.FileName;
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
            ValidatePaths();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            Settings1.Default.MSUPathSetting = txtMSUPath.Text;
            Settings1.Default.QUsb2SnesPathSetting = txtQUSB2SNESPath.Text;
            Settings1.Default.LiveSplitEnabledSetting = checkBoxTimer.Checked;
            Settings1.Default.LiveSplitPathSetting = txtLiveSplitPath.Text;
            Settings1.Default.EmoTrackerEnabledSetting = checkBoxTracker.Checked;
            Settings1.Default.EmoTrackerPathSetting = txtEmoTrackerPath.Text;
            Settings1.Default.DownloadsPathSetting = txtDownloadsPath.Text;
            Settings1.Default.OverwriteSetting = checkboxOverwrite.Checked;
            Settings1.Default.RandomMSUSetting = checkboxRandomMSU.Checked;
            Settings1.Default.QUsb2SnesEnabledSetting = checkboxQUsb2SnesPath.Checked;
            Settings1.Default.SizeXSetting = Size.Width;
            Settings1.Default.SizeYSetting = Size.Height;
            Settings1.Default.SplitDistanceSetting = splitContainer.SplitterDistance;
            Settings1.Default.ExitOnLaunchSetting = checkBoxExitAfterLaunch.Checked;
            Settings1.Default.Save();
        }

        private void txtMSUPath_Leave(object sender, EventArgs e)
        {
            if (ValidatePaths())
                LoadMSUList();
        }

        private void txtQUsb2SnesPath_Leave(object sender, EventArgs e)
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

            //MSU Folder name
            string MSUPath;
            if (checkboxRandomMSU.Checked)
            {
                Random rnd = new Random();
                int r = rnd.Next(0, lstboxMSU.Items.Count);
                MSUPath = msudirs[r];
            }
            else
            {
                MSUPath = msudirs[lstboxMSU.SelectedIndex];
            }
            string SFCPath;
            string SFCDestination;
            string[] MSUFileName;
            MSUFileName = Directory.GetFiles(MSUPath, "*.msu", SearchOption.TopDirectoryOnly);
            if(MSUFileName.Length != 1)
            {
                MessageBox.Show("MSU not created properly. Make sure the blank .msu file exists and there is not more than one of them");
                return;
            }
            MSUFileName[0] = Path.GetFileNameWithoutExtension(MSUFileName[0]) + ".sfc";
            SFCPath = sfcfiles[lstboxSFC.SelectedIndex];
            SFCDestination = MSUPath + "\\" + MSUFileName[0];
            
            if (File.Exists(SFCDestination) && checkboxOverwrite.Checked == false)
            {
                if (MessageBox.Show($"Game file already exists {SFCDestination}! Click Yes to replace this file with {SFCPath}. " +
                    $"Click No to cancel launch(no action will be taken)", "warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            if (checkBoxTimer.Checked)
            {
                Process[] p = Process.GetProcessesByName("livesplit");
                if (p.Length == 0)
                {
                    Process.Start(txtLiveSplitPath.Text);
                }
            }

            if (checkBoxTracker.Checked)
            {
                Process[] p = Process.GetProcessesByName("emotracker");
                if (p.Length == 0)
                {
                    Process.Start(txtEmoTrackerPath.Text);
                }
            }

            if (checkboxQUsb2SnesPath.Checked)
            {
                Process[] p = Process.GetProcessesByName("QUsb2Snes");
                if (p.Length == 0)
                {
                    Process.Start(txtQUSB2SNESPath.Text);
                }
            }

            File.Delete(SFCDestination);
            File.Move(SFCPath, SFCDestination);

            Process.Start(SFCDestination);
            ClearMSUList();
            ClearSFCList();
            ValidatePaths();
            if (checkBoxExitAfterLaunch.Checked)
            {
                Application.Exit();
            }
        }

        private void lstboxMSU_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidatePaths();
        }

        private void lstboxSFC_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidatePaths();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearMSUList();
            ClearSFCList();
            ValidatePaths();
        }

        private void checkboxRandomMSU_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxRandomMSU.Checked && lstboxMSU.Items.Count > 0)
            {
                lstboxMSU.Enabled = false;
            }
            else
            {
                lstboxMSU.Enabled = true;
            }
            ValidatePaths();
        }

        private void checkboxQUsb2SnesPath_CheckedChanged(object sender, EventArgs e)
        {
            txtQUSB2SNESPath.Enabled = checkboxQUsb2SnesPath.Checked;
            btnBrowseQusb2Snes.Enabled = checkboxQUsb2SnesPath.Checked;
        }

        private void checkboxOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxOverwrite.Checked && Settings1.Default.OverwriteSetting == false)
            {
                string warningmessage = "WARNING! Enabling this option allows this program to overwrite your rom game files without additional confirmation or warning." +
                    @"(eg. C:\msu\track.sfc is your old game file, it will be deleted and replaced with the new rom selected and unrecoverable." +
                    @"Please click OK to accept, or cancel to disable this option";
               
                if (MessageBox.Show(warningmessage, "WARNING!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    checkboxOverwrite.Checked = false;
                    Settings1.Default.OverwriteSetting = false;
                }

            }
            if (checkboxOverwrite.Checked == false)
            {
                Settings1.Default.OverwriteSetting = false;
            }
        }
    }
}
