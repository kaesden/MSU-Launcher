
namespace MSU_Launcher
{
    partial class MSULauncherForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSULauncherForm));
            this.lstboxMSU = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSUPath = new System.Windows.Forms.TextBox();
            this.txtQUSB2SNESPath = new System.Windows.Forms.TextBox();
            this.txtLiveSplitPath = new System.Windows.Forms.TextBox();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.txtEmoTrackerPath = new System.Windows.Forms.TextBox();
            this.checkBoxTracker = new System.Windows.Forms.CheckBox();
            this.btnBrowseMSU = new System.Windows.Forms.Button();
            this.btnBrowseQusb2Snes = new System.Windows.Forms.Button();
            this.btnBrowseLiveSplit = new System.Windows.Forms.Button();
            this.btnBrowseEmotracker = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseDownloads = new System.Windows.Forms.Button();
            this.txtDownloadsPath = new System.Windows.Forms.TextBox();
            this.lstboxSFC = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.checkboxOverwrite = new System.Windows.Forms.CheckBox();
            this.checkboxRandomMSU = new System.Windows.Forms.CheckBox();
            this.checkboxQUsb2SnesPath = new System.Windows.Forms.CheckBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.checkBoxExitAfterLaunch = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxMSU
            // 
            this.lstboxMSU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstboxMSU.FormattingEnabled = true;
            this.lstboxMSU.Location = new System.Drawing.Point(3, 22);
            this.lstboxMSU.Name = "lstboxMSU";
            this.lstboxMSU.Size = new System.Drawing.Size(90, 134);
            this.lstboxMSU.TabIndex = 18;
            this.lstboxMSU.SelectedValueChanged += new System.EventHandler(this.lstboxMSU_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "MSU\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSU Path";
            // 
            // txtMSUPath
            // 
            this.txtMSUPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMSUPath.Location = new System.Drawing.Point(127, 11);
            this.txtMSUPath.Name = "txtMSUPath";
            this.txtMSUPath.Size = new System.Drawing.Size(418, 20);
            this.txtMSUPath.TabIndex = 1;
            this.txtMSUPath.Leave += new System.EventHandler(this.txtMSUPath_Leave);
            // 
            // txtQUSB2SNESPath
            // 
            this.txtQUSB2SNESPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQUSB2SNESPath.Location = new System.Drawing.Point(127, 64);
            this.txtQUSB2SNESPath.Name = "txtQUSB2SNESPath";
            this.txtQUSB2SNESPath.Size = new System.Drawing.Size(418, 20);
            this.txtQUSB2SNESPath.TabIndex = 7;
            this.txtQUSB2SNESPath.Leave += new System.EventHandler(this.txtQUsb2SnesPath_Leave);
            // 
            // txtLiveSplitPath
            // 
            this.txtLiveSplitPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLiveSplitPath.Location = new System.Drawing.Point(127, 89);
            this.txtLiveSplitPath.Name = "txtLiveSplitPath";
            this.txtLiveSplitPath.Size = new System.Drawing.Size(418, 20);
            this.txtLiveSplitPath.TabIndex = 10;
            this.txtLiveSplitPath.Leave += new System.EventHandler(this.txtLiveSplitPath_Leave);
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.Checked = true;
            this.checkBoxTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTimer.Location = new System.Drawing.Point(12, 91);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(94, 17);
            this.checkBoxTimer.TabIndex = 9;
            this.checkBoxTimer.Text = "Live Split Path";
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.checkBoxTimer_CheckedChanged);
            // 
            // txtEmoTrackerPath
            // 
            this.txtEmoTrackerPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmoTrackerPath.Location = new System.Drawing.Point(127, 115);
            this.txtEmoTrackerPath.Name = "txtEmoTrackerPath";
            this.txtEmoTrackerPath.Size = new System.Drawing.Size(418, 20);
            this.txtEmoTrackerPath.TabIndex = 13;
            this.txtEmoTrackerPath.Leave += new System.EventHandler(this.txtEmoTrackerPath_Leave);
            // 
            // checkBoxTracker
            // 
            this.checkBoxTracker.AutoSize = true;
            this.checkBoxTracker.Checked = true;
            this.checkBoxTracker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTracker.Location = new System.Drawing.Point(12, 117);
            this.checkBoxTracker.Name = "checkBoxTracker";
            this.checkBoxTracker.Size = new System.Drawing.Size(109, 17);
            this.checkBoxTracker.TabIndex = 12;
            this.checkBoxTracker.Text = "EmoTracker Path";
            this.checkBoxTracker.UseVisualStyleBackColor = true;
            this.checkBoxTracker.CheckedChanged += new System.EventHandler(this.checkBoxTracker_CheckedChanged);
            // 
            // btnBrowseMSU
            // 
            this.btnBrowseMSU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMSU.Location = new System.Drawing.Point(566, 11);
            this.btnBrowseMSU.Name = "btnBrowseMSU";
            this.btnBrowseMSU.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseMSU.TabIndex = 2;
            this.btnBrowseMSU.Text = "...";
            this.btnBrowseMSU.UseVisualStyleBackColor = true;
            this.btnBrowseMSU.Click += new System.EventHandler(this.btnBrowseMSU_Click);
            // 
            // btnBrowseQusb2Snes
            // 
            this.btnBrowseQusb2Snes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseQusb2Snes.Location = new System.Drawing.Point(566, 65);
            this.btnBrowseQusb2Snes.Name = "btnBrowseQusb2Snes";
            this.btnBrowseQusb2Snes.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseQusb2Snes.TabIndex = 8;
            this.btnBrowseQusb2Snes.Text = "...";
            this.btnBrowseQusb2Snes.UseVisualStyleBackColor = true;
            this.btnBrowseQusb2Snes.Click += new System.EventHandler(this.btnBrowseSNES9X_Click);
            // 
            // btnBrowseLiveSplit
            // 
            this.btnBrowseLiveSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseLiveSplit.Location = new System.Drawing.Point(566, 91);
            this.btnBrowseLiveSplit.Name = "btnBrowseLiveSplit";
            this.btnBrowseLiveSplit.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseLiveSplit.TabIndex = 11;
            this.btnBrowseLiveSplit.Text = "...";
            this.btnBrowseLiveSplit.UseVisualStyleBackColor = true;
            this.btnBrowseLiveSplit.Click += new System.EventHandler(this.btnBrowseLiveSplit_Click);
            // 
            // btnBrowseEmotracker
            // 
            this.btnBrowseEmotracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseEmotracker.Location = new System.Drawing.Point(566, 117);
            this.btnBrowseEmotracker.Name = "btnBrowseEmotracker";
            this.btnBrowseEmotracker.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseEmotracker.TabIndex = 14;
            this.btnBrowseEmotracker.Text = "...";
            this.btnBrowseEmotracker.UseVisualStyleBackColor = true;
            this.btnBrowseEmotracker.Click += new System.EventHandler(this.btnBrowseEmotracker_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.Location = new System.Drawing.Point(384, 169);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(83, 23);
            this.btnSaveSettings.TabIndex = 23;
            this.btnSaveSettings.Text = "&Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Downloads Path";
            // 
            // btnBrowseDownloads
            // 
            this.btnBrowseDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloads.Location = new System.Drawing.Point(566, 38);
            this.btnBrowseDownloads.Name = "btnBrowseDownloads";
            this.btnBrowseDownloads.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseDownloads.TabIndex = 5;
            this.btnBrowseDownloads.Text = "...";
            this.btnBrowseDownloads.UseVisualStyleBackColor = true;
            this.btnBrowseDownloads.Click += new System.EventHandler(this.btnBrowseDownloads_Click);
            // 
            // txtDownloadsPath
            // 
            this.txtDownloadsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadsPath.Location = new System.Drawing.Point(127, 38);
            this.txtDownloadsPath.Name = "txtDownloadsPath";
            this.txtDownloadsPath.Size = new System.Drawing.Size(418, 20);
            this.txtDownloadsPath.TabIndex = 4;
            this.txtDownloadsPath.Leave += new System.EventHandler(this.txtDownloadsPath_Leave);
            // 
            // lstboxSFC
            // 
            this.lstboxSFC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstboxSFC.FormattingEnabled = true;
            this.lstboxSFC.Location = new System.Drawing.Point(3, 22);
            this.lstboxSFC.Name = "lstboxSFC";
            this.lstboxSFC.Size = new System.Drawing.Size(472, 134);
            this.lstboxSFC.TabIndex = 19;
            this.lstboxSFC.SelectedValueChanged += new System.EventHandler(this.lstboxSFC_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Game Files Found";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(303, 169);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkboxOverwrite
            // 
            this.checkboxOverwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxOverwrite.AutoSize = true;
            this.checkboxOverwrite.Location = new System.Drawing.Point(320, 5);
            this.checkboxOverwrite.Name = "checkboxOverwrite";
            this.checkboxOverwrite.Size = new System.Drawing.Size(154, 17);
            this.checkboxOverwrite.TabIndex = 17;
            this.checkboxOverwrite.Text = "&Overwrite existing game file";
            this.checkboxOverwrite.UseVisualStyleBackColor = true;
            this.checkboxOverwrite.CheckedChanged += new System.EventHandler(this.checkboxOverwrite_CheckedChanged);
            // 
            // checkboxRandomMSU
            // 
            this.checkboxRandomMSU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxRandomMSU.AutoSize = true;
            this.checkboxRandomMSU.Location = new System.Drawing.Point(6, 173);
            this.checkboxRandomMSU.Name = "checkboxRandomMSU";
            this.checkboxRandomMSU.Size = new System.Drawing.Size(93, 17);
            this.checkboxRandomMSU.TabIndex = 20;
            this.checkboxRandomMSU.Text = "&Random MSU";
            this.checkboxRandomMSU.UseVisualStyleBackColor = true;
            this.checkboxRandomMSU.CheckedChanged += new System.EventHandler(this.checkboxRandomMSU_CheckedChanged);
            // 
            // checkboxQUsb2SnesPath
            // 
            this.checkboxQUsb2SnesPath.AutoSize = true;
            this.checkboxQUsb2SnesPath.Checked = true;
            this.checkboxQUsb2SnesPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxQUsb2SnesPath.Location = new System.Drawing.Point(12, 66);
            this.checkboxQUsb2SnesPath.Name = "checkboxQUsb2SnesPath";
            this.checkboxQUsb2SnesPath.Size = new System.Drawing.Size(108, 17);
            this.checkboxQUsb2SnesPath.TabIndex = 6;
            this.checkboxQUsb2SnesPath.Text = "QUsb2Snes Path";
            this.checkboxQUsb2SnesPath.UseVisualStyleBackColor = true;
            this.checkboxQUsb2SnesPath.CheckedChanged += new System.EventHandler(this.checkboxQUsb2SnesPath_CheckedChanged);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLaunch.BackgroundImage = global::MSU_Launcher.Properties.Resources.triforce_wide;
            this.btnLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(6, 162);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(140, 37);
            this.btnLaunch.TabIndex = 21;
            this.btnLaunch.Text = "Launch &Game";
            this.btnLaunch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Location = new System.Drawing.Point(12, 143);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lstboxMSU);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.checkboxRandomMSU);
            this.splitContainer.Panel1MinSize = 100;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.checkBoxExitAfterLaunch);
            this.splitContainer.Panel2.Controls.Add(this.lstboxSFC);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.btnRefresh);
            this.splitContainer.Panel2.Controls.Add(this.checkboxOverwrite);
            this.splitContainer.Panel2.Controls.Add(this.btnLaunch);
            this.splitContainer.Panel2.Controls.Add(this.btnSaveSettings);
            this.splitContainer.Panel2MinSize = 335;
            this.splitContainer.Size = new System.Drawing.Size(576, 206);
            this.splitContainer.SplitterDistance = 100;
            this.splitContainer.SplitterWidth = 2;
            this.splitContainer.TabIndex = 24;
            // 
            // checkBoxExitAfterLaunch
            // 
            this.checkBoxExitAfterLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxExitAfterLaunch.AutoSize = true;
            this.checkBoxExitAfterLaunch.Location = new System.Drawing.Point(152, 173);
            this.checkBoxExitAfterLaunch.Name = "checkBoxExitAfterLaunch";
            this.checkBoxExitAfterLaunch.Size = new System.Drawing.Size(106, 17);
            this.checkBoxExitAfterLaunch.TabIndex = 24;
            this.checkBoxExitAfterLaunch.Text = "E&xit after Launch";
            this.checkBoxExitAfterLaunch.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 361);
            this.splitter1.TabIndex = 25;
            this.splitter1.TabStop = false;
            // 
            // MSULauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 361);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.checkboxQUsb2SnesPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseDownloads);
            this.Controls.Add(this.txtDownloadsPath);
            this.Controls.Add(this.btnBrowseEmotracker);
            this.Controls.Add(this.btnBrowseLiveSplit);
            this.Controls.Add(this.btnBrowseQusb2Snes);
            this.Controls.Add(this.btnBrowseMSU);
            this.Controls.Add(this.txtEmoTrackerPath);
            this.Controls.Add(this.checkBoxTracker);
            this.Controls.Add(this.txtLiveSplitPath);
            this.Controls.Add(this.checkBoxTimer);
            this.Controls.Add(this.txtQUSB2SNESPath);
            this.Controls.Add(this.txtMSUPath);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(615, 400);
            this.Name = "MSULauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSU-Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxMSU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSUPath;
        private System.Windows.Forms.TextBox txtQUSB2SNESPath;
        private System.Windows.Forms.TextBox txtLiveSplitPath;
        private System.Windows.Forms.CheckBox checkBoxTimer;
        private System.Windows.Forms.TextBox txtEmoTrackerPath;
        private System.Windows.Forms.CheckBox checkBoxTracker;
        private System.Windows.Forms.Button btnBrowseMSU;
        private System.Windows.Forms.Button btnBrowseQusb2Snes;
        private System.Windows.Forms.Button btnBrowseLiveSplit;
        private System.Windows.Forms.Button btnBrowseEmotracker;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstboxSFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowseDownloads;
        private System.Windows.Forms.TextBox txtDownloadsPath;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox checkboxOverwrite;
        private System.Windows.Forms.CheckBox checkboxRandomMSU;
        private System.Windows.Forms.CheckBox checkboxQUsb2SnesPath;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox checkBoxExitAfterLaunch;
    }
}

