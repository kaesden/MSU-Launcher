
namespace MSU_Launcher
{
    partial class Form1
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
            this.lstboxMSU = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSUPath = new System.Windows.Forms.TextBox();
            this.txtSNES9xPath = new System.Windows.Forms.TextBox();
            this.txtLiveSplitPath = new System.Windows.Forms.TextBox();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.txtEmoTrackerPath = new System.Windows.Forms.TextBox();
            this.checkBoxTracker = new System.Windows.Forms.CheckBox();
            this.btnBrowseMSU = new System.Windows.Forms.Button();
            this.btnBrowseSNES9X = new System.Windows.Forms.Button();
            this.btnBrowseLiveSplit = new System.Windows.Forms.Button();
            this.btnBrowseEmotracker = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseDownloads = new System.Windows.Forms.Button();
            this.txtDownloadsPath = new System.Windows.Forms.TextBox();
            this.lstboxSFC = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lstboxMSU
            // 
            this.lstboxMSU.FormattingEnabled = true;
            this.lstboxMSU.Location = new System.Drawing.Point(12, 158);
            this.lstboxMSU.Name = "lstboxMSU";
            this.lstboxMSU.Size = new System.Drawing.Size(82, 160);
            this.lstboxMSU.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MSU\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MSU Path";
            // 
            // txtMSUPath
            // 
            this.txtMSUPath.Location = new System.Drawing.Point(127, 11);
            this.txtMSUPath.Name = "txtMSUPath";
            this.txtMSUPath.Size = new System.Drawing.Size(419, 20);
            this.txtMSUPath.TabIndex = 3;
            this.txtMSUPath.Leave += new System.EventHandler(this.txtMSUPath_Leave);
            // 
            // txtSNES9xPath
            // 
            this.txtSNES9xPath.Location = new System.Drawing.Point(127, 37);
            this.txtSNES9xPath.Name = "txtSNES9xPath";
            this.txtSNES9xPath.Size = new System.Drawing.Size(419, 20);
            this.txtSNES9xPath.TabIndex = 5;
            this.txtSNES9xPath.Leave += new System.EventHandler(this.txtSNES9xPath_Leave);
            // 
            // txtLiveSplitPath
            // 
            this.txtLiveSplitPath.Location = new System.Drawing.Point(127, 89);
            this.txtLiveSplitPath.Name = "txtLiveSplitPath";
            this.txtLiveSplitPath.Size = new System.Drawing.Size(419, 20);
            this.txtLiveSplitPath.TabIndex = 7;
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
            this.checkBoxTimer.TabIndex = 6;
            this.checkBoxTimer.Text = "Live Split Path";
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.checkBoxTimer_CheckedChanged);
            // 
            // txtEmoTrackerPath
            // 
            this.txtEmoTrackerPath.Location = new System.Drawing.Point(127, 115);
            this.txtEmoTrackerPath.Name = "txtEmoTrackerPath";
            this.txtEmoTrackerPath.Size = new System.Drawing.Size(419, 20);
            this.txtEmoTrackerPath.TabIndex = 9;
            this.txtEmoTrackerPath.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            this.checkBoxTracker.TabIndex = 8;
            this.checkBoxTracker.Text = "EmoTracker Path";
            this.checkBoxTracker.UseVisualStyleBackColor = true;
            this.checkBoxTracker.CheckedChanged += new System.EventHandler(this.checkBoxTracker_CheckedChanged);
            // 
            // btnBrowseMSU
            // 
            this.btnBrowseMSU.Location = new System.Drawing.Point(567, 11);
            this.btnBrowseMSU.Name = "btnBrowseMSU";
            this.btnBrowseMSU.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseMSU.TabIndex = 10;
            this.btnBrowseMSU.Text = "...";
            this.btnBrowseMSU.UseVisualStyleBackColor = true;
            this.btnBrowseMSU.Click += new System.EventHandler(this.btnBrowseMSU_Click);
            // 
            // btnBrowseSNES9X
            // 
            this.btnBrowseSNES9X.Location = new System.Drawing.Point(567, 39);
            this.btnBrowseSNES9X.Name = "btnBrowseSNES9X";
            this.btnBrowseSNES9X.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseSNES9X.TabIndex = 11;
            this.btnBrowseSNES9X.Text = "...";
            this.btnBrowseSNES9X.UseVisualStyleBackColor = true;
            this.btnBrowseSNES9X.Click += new System.EventHandler(this.btnBrowseSNES9X_Click);
            // 
            // btnBrowseLiveSplit
            // 
            this.btnBrowseLiveSplit.Location = new System.Drawing.Point(567, 91);
            this.btnBrowseLiveSplit.Name = "btnBrowseLiveSplit";
            this.btnBrowseLiveSplit.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseLiveSplit.TabIndex = 12;
            this.btnBrowseLiveSplit.Text = "...";
            this.btnBrowseLiveSplit.UseVisualStyleBackColor = true;
            this.btnBrowseLiveSplit.Click += new System.EventHandler(this.btnBrowseLiveSplit_Click);
            // 
            // btnBrowseEmotracker
            // 
            this.btnBrowseEmotracker.Location = new System.Drawing.Point(567, 117);
            this.btnBrowseEmotracker.Name = "btnBrowseEmotracker";
            this.btnBrowseEmotracker.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseEmotracker.TabIndex = 13;
            this.btnBrowseEmotracker.Text = "...";
            this.btnBrowseEmotracker.UseVisualStyleBackColor = true;
            this.btnBrowseEmotracker.Click += new System.EventHandler(this.btnBrowseEmotracker_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "SNES9X Path";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(503, 331);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(86, 23);
            this.btnSaveSettings.TabIndex = 15;
            this.btnSaveSettings.Text = "&Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Downloads Path";
            // 
            // btnBrowseDownloads
            // 
            this.btnBrowseDownloads.Location = new System.Drawing.Point(567, 65);
            this.btnBrowseDownloads.Name = "btnBrowseDownloads";
            this.btnBrowseDownloads.Size = new System.Drawing.Size(22, 20);
            this.btnBrowseDownloads.TabIndex = 17;
            this.btnBrowseDownloads.Text = "...";
            this.btnBrowseDownloads.UseVisualStyleBackColor = true;
            this.btnBrowseDownloads.Click += new System.EventHandler(this.btnBrowseDownloads_Click);
            // 
            // txtDownloadsPath
            // 
            this.txtDownloadsPath.Location = new System.Drawing.Point(127, 63);
            this.txtDownloadsPath.Name = "txtDownloadsPath";
            this.txtDownloadsPath.Size = new System.Drawing.Size(419, 20);
            this.txtDownloadsPath.TabIndex = 16;
            this.txtDownloadsPath.Leave += new System.EventHandler(this.txtDownloadsPath_Leave);
            // 
            // lstboxSFC
            // 
            this.lstboxSFC.FormattingEnabled = true;
            this.lstboxSFC.Location = new System.Drawing.Point(100, 158);
            this.lstboxSFC.Name = "lstboxSFC";
            this.lstboxSFC.Size = new System.Drawing.Size(489, 160);
            this.lstboxSFC.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Game Files Found";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(100, 324);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(133, 37);
            this.btnLaunch.TabIndex = 21;
            this.btnLaunch.Text = "Launch Game";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 373);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstboxSFC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseDownloads);
            this.Controls.Add(this.txtDownloadsPath);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseEmotracker);
            this.Controls.Add(this.btnBrowseLiveSplit);
            this.Controls.Add(this.btnBrowseSNES9X);
            this.Controls.Add(this.btnBrowseMSU);
            this.Controls.Add(this.txtEmoTrackerPath);
            this.Controls.Add(this.checkBoxTracker);
            this.Controls.Add(this.txtLiveSplitPath);
            this.Controls.Add(this.checkBoxTimer);
            this.Controls.Add(this.txtSNES9xPath);
            this.Controls.Add(this.txtMSUPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstboxMSU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxMSU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSUPath;
        private System.Windows.Forms.TextBox txtSNES9xPath;
        private System.Windows.Forms.TextBox txtLiveSplitPath;
        private System.Windows.Forms.CheckBox checkBoxTimer;
        private System.Windows.Forms.TextBox txtEmoTrackerPath;
        private System.Windows.Forms.CheckBox checkBoxTracker;
        private System.Windows.Forms.Button btnBrowseMSU;
        private System.Windows.Forms.Button btnBrowseSNES9X;
        private System.Windows.Forms.Button btnBrowseLiveSplit;
        private System.Windows.Forms.Button btnBrowseEmotracker;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstboxSFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowseDownloads;
        private System.Windows.Forms.TextBox txtDownloadsPath;
        private System.Windows.Forms.Button btnLaunch;
    }
}

