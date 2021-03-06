﻿namespace GitUI
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.LocalSettings = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.lblLocalAutoCRLF = new System.Windows.Forms.Label();
            this.LocalAutoCRLF = new System.Windows.Forms.ComboBox();
            this.InvalidGitPathLocal = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NoGitRepo = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.MergeTool = new System.Windows.Forms.ComboBox();
            this.KeepMergeBackup = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Editor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SmtpServer = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SshConfig = new System.Windows.Forms.Button();
            this.GitBinFound = new System.Windows.Forms.Button();
            this.Rescan = new System.Windows.Forms.Button();
            this.CheckAtStartup = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GitFound = new System.Windows.Forms.Button();
            this.DiffTool = new System.Windows.Forms.Button();
            this.UserNameSet = new System.Windows.Forms.Button();
            this.ShellExtensionsRegistered = new System.Windows.Forms.Button();
            this.GitExtensionsInstall = new System.Windows.Forms.Button();
            this.TabPageGitExtensions = new System.Windows.Forms.TabPage();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.EncodingLabel = new System.Windows.Forms.Label();
            this.Encoding = new System.Windows.Forms.ComboBox();
            this.Dictionary = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ShowRelativeDate = new System.Windows.Forms.CheckBox();
            this.UseFastChecks = new System.Windows.Forms.CheckBox();
            this.ShowGitCommandLine = new System.Windows.Forms.CheckBox();
            this.ShowRevisionGraph = new System.Windows.Forms.CheckBox();
            this.CloseProcessDialog = new System.Windows.Forms.CheckBox();
            this.BrowseGitBinPath = new System.Windows.Forms.Button();
            this.GitBinPath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BrowseGitPath = new System.Windows.Forms.Button();
            this.GitPath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MaxCommits = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.AppearancePage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.ColorRemoteBranchLabel = new System.Windows.Forms.Label();
            this.ColorOtherLabel = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ColorTagLabel = new System.Windows.Forms.Label();
            this.ColorBranchLabel = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.RevisionGraphColorLabel = new System.Windows.Forms.Label();
            this.RevisionGraphColorSelected = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.ColorSectionLabel = new System.Windows.Forms.Label();
            this.ColorRemovedLine = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ColorAddedLineLabel = new System.Windows.Forms.Label();
            this.GlobalSettingsPage = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.lblGlobalAutoCRLF = new System.Windows.Forms.Label();
            this.GlobalAutoCRLF = new System.Windows.Forms.ComboBox();
            this.InvalidGitPathGlobal = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MergeToolCmd = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.BrowseMergeTool = new System.Windows.Forms.Button();
            this.GlobalMergeTool = new System.Windows.Forms.ComboBox();
            this.PathToKDiff3 = new System.Windows.Forms.Label();
            this.MergetoolPath = new System.Windows.Forms.TextBox();
            this.GlobalKeepMergeBackup = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GlobalEditor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GlobalUserEmail = new System.Windows.Forms.TextBox();
            this.GlobalUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ssh = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AutostartPageant = new System.Windows.Forms.CheckBox();
            this.PageantPath = new System.Windows.Forms.TextBox();
            this.PageantBrowse = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.PuttygenPath = new System.Windows.Forms.TextBox();
            this.PuttygenBrowse = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PlinkPath = new System.Windows.Forms.TextBox();
            this.PlinkBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OtherSsh = new System.Windows.Forms.TextBox();
            this.OtherSshBrowse = new System.Windows.Forms.Button();
            this.Other = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.OpenSSH = new System.Windows.Forms.RadioButton();
            this.Putty = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Ok = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label40 = new System.Windows.Forms.Label();
            this.FollowRenamesInFileHistory = new System.Windows.Forms.CheckBox();
            this.LocalSettings.SuspendLayout();
            this.InvalidGitPathLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.TabPageGitExtensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCommits)).BeginInit();
            this.AppearancePage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GlobalSettingsPage.SuspendLayout();
            this.InvalidGitPathGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Ssh.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalSettings
            // 
            this.LocalSettings.Controls.Add(this.label30);
            this.LocalSettings.Controls.Add(this.lblLocalAutoCRLF);
            this.LocalSettings.Controls.Add(this.LocalAutoCRLF);
            this.LocalSettings.Controls.Add(this.InvalidGitPathLocal);
            this.LocalSettings.Controls.Add(this.NoGitRepo);
            this.LocalSettings.Controls.Add(this.label20);
            this.LocalSettings.Controls.Add(this.MergeTool);
            this.LocalSettings.Controls.Add(this.KeepMergeBackup);
            this.LocalSettings.Controls.Add(this.label8);
            this.LocalSettings.Controls.Add(this.Editor);
            this.LocalSettings.Controls.Add(this.label5);
            this.LocalSettings.Controls.Add(this.UserEmail);
            this.LocalSettings.Controls.Add(this.UserName);
            this.LocalSettings.Controls.Add(this.label2);
            this.LocalSettings.Controls.Add(this.label1);
            this.LocalSettings.Location = new System.Drawing.Point(4, 22);
            this.LocalSettings.Name = "LocalSettings";
            this.LocalSettings.Padding = new System.Windows.Forms.Padding(3);
            this.LocalSettings.Size = new System.Drawing.Size(710, 322);
            this.LocalSettings.TabIndex = 0;
            this.LocalSettings.Text = "Local settings";
            this.LocalSettings.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(8, 127);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(156, 13);
            this.label30.TabIndex = 23;
            this.label30.Text = "Keep backup (.orig) after merge";
            // 
            // lblLocalAutoCRLF
            // 
            this.lblLocalAutoCRLF.AutoSize = true;
            this.lblLocalAutoCRLF.Location = new System.Drawing.Point(8, 156);
            this.lblLocalAutoCRLF.Name = "lblLocalAutoCRLF";
            this.lblLocalAutoCRLF.Size = new System.Drawing.Size(295, 13);
            this.lblLocalAutoCRLF.TabIndex = 22;
            this.lblLocalAutoCRLF.Text = "Convert CRLF at the end of lines in text files to LF, AutoCRLF";
            // 
            // LocalAutoCRLF
            // 
            this.LocalAutoCRLF.FormattingEnabled = true;
            this.LocalAutoCRLF.Items.AddRange(new object[] {
            "true",
            "false",
            "input"});
            this.LocalAutoCRLF.Location = new System.Drawing.Point(405, 149);
            this.LocalAutoCRLF.Name = "LocalAutoCRLF";
            this.LocalAutoCRLF.Size = new System.Drawing.Size(121, 21);
            this.LocalAutoCRLF.TabIndex = 21;
            // 
            // InvalidGitPathLocal
            // 
            this.InvalidGitPathLocal.BackColor = System.Drawing.SystemColors.Info;
            this.InvalidGitPathLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InvalidGitPathLocal.Controls.Add(this.label21);
            this.InvalidGitPathLocal.Controls.Add(this.pictureBox3);
            this.InvalidGitPathLocal.Location = new System.Drawing.Point(405, 8);
            this.InvalidGitPathLocal.Name = "InvalidGitPathLocal";
            this.InvalidGitPathLocal.Size = new System.Drawing.Size(297, 65);
            this.InvalidGitPathLocal.TabIndex = 20;
            this.InvalidGitPathLocal.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(63, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(175, 39);
            this.label21.TabIndex = 19;
            this.label21.Text = "You need to set the correct path to \r\ngit.cmd before you can change\r\nlocal settin" +
                "gs.\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GitUI.Properties.Resources.error;
            this.pictureBox3.Location = new System.Drawing.Point(3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 50);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // NoGitRepo
            // 
            this.NoGitRepo.AutoSize = true;
            this.NoGitRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoGitRepo.ForeColor = System.Drawing.Color.Red;
            this.NoGitRepo.Location = new System.Drawing.Point(460, 76);
            this.NoGitRepo.Name = "NoGitRepo";
            this.NoGitRepo.Size = new System.Drawing.Size(106, 13);
            this.NoGitRepo.TabIndex = 12;
            this.NoGitRepo.Text = "Not in a git repository";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Info;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(440, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 54);
            this.label20.TabIndex = 11;
            this.label20.Text = "You only need local settings\r\nif you want to override the \r\nglobal settings for t" +
                "he current\r\nrepository.";
            // 
            // MergeTool
            // 
            this.MergeTool.FormattingEnabled = true;
            this.MergeTool.Items.AddRange(new object[] {
            "kdiff3",
            "p4merge"});
            this.MergeTool.Location = new System.Drawing.Point(118, 94);
            this.MergeTool.Name = "MergeTool";
            this.MergeTool.Size = new System.Drawing.Size(159, 21);
            this.MergeTool.TabIndex = 10;
            // 
            // KeepMergeBackup
            // 
            this.KeepMergeBackup.AutoSize = true;
            this.KeepMergeBackup.Checked = true;
            this.KeepMergeBackup.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.KeepMergeBackup.Location = new System.Drawing.Point(405, 127);
            this.KeepMergeBackup.Name = "KeepMergeBackup";
            this.KeepMergeBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KeepMergeBackup.Size = new System.Drawing.Size(15, 14);
            this.KeepMergeBackup.TabIndex = 9;
            this.KeepMergeBackup.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mergetool";
            // 
            // Editor
            // 
            this.Editor.Location = new System.Drawing.Point(118, 67);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(159, 20);
            this.Editor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Editor";
            // 
            // UserEmail
            // 
            this.UserEmail.Location = new System.Drawing.Point(118, 40);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(159, 20);
            this.UserEmail.TabIndex = 3;
            this.UserEmail.TextChanged += new System.EventHandler(this.UserEmail_TextChanged);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(118, 12);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(159, 20);
            this.UserName.TabIndex = 1;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // SmtpServer
            // 
            this.SmtpServer.Location = new System.Drawing.Point(382, 140);
            this.SmtpServer.Name = "SmtpServer";
            this.SmtpServer.Size = new System.Drawing.Size(242, 20);
            this.SmtpServer.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(159, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Smtp server for sending patches";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.TabPageGitExtensions);
            this.tabControl1.Controls.Add(this.AppearancePage);
            this.tabControl1.Controls.Add(this.GlobalSettingsPage);
            this.tabControl1.Controls.Add(this.LocalSettings);
            this.tabControl1.Controls.Add(this.Ssh);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SshConfig);
            this.tabPage3.Controls.Add(this.GitBinFound);
            this.tabPage3.Controls.Add(this.Rescan);
            this.tabPage3.Controls.Add(this.CheckAtStartup);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.GitFound);
            this.tabPage3.Controls.Add(this.DiffTool);
            this.tabPage3.Controls.Add(this.UserNameSet);
            this.tabPage3.Controls.Add(this.ShellExtensionsRegistered);
            this.tabPage3.Controls.Add(this.GitExtensionsInstall);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(710, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Checklist";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SshConfig
            // 
            this.SshConfig.BackColor = System.Drawing.Color.Gray;
            this.SshConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SshConfig.FlatAppearance.BorderSize = 0;
            this.SshConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SshConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SshConfig.Location = new System.Drawing.Point(9, 203);
            this.SshConfig.Name = "SshConfig";
            this.SshConfig.Size = new System.Drawing.Size(693, 23);
            this.SshConfig.TabIndex = 10;
            this.SshConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SshConfig.UseVisualStyleBackColor = false;
            this.SshConfig.Click += new System.EventHandler(this.SshConfig_Click);
            // 
            // GitBinFound
            // 
            this.GitBinFound.BackColor = System.Drawing.Color.Gray;
            this.GitBinFound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitBinFound.FlatAppearance.BorderSize = 0;
            this.GitBinFound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GitBinFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitBinFound.Location = new System.Drawing.Point(9, 58);
            this.GitBinFound.Name = "GitBinFound";
            this.GitBinFound.Size = new System.Drawing.Size(693, 23);
            this.GitBinFound.TabIndex = 9;
            this.GitBinFound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GitBinFound.UseVisualStyleBackColor = false;
            this.GitBinFound.Click += new System.EventHandler(this.GitBinFound_Click);
            // 
            // Rescan
            // 
            this.Rescan.Location = new System.Drawing.Point(574, 286);
            this.Rescan.Name = "Rescan";
            this.Rescan.Size = new System.Drawing.Size(128, 24);
            this.Rescan.TabIndex = 8;
            this.Rescan.Text = "Save and rescan";
            this.Rescan.UseVisualStyleBackColor = true;
            this.Rescan.Click += new System.EventHandler(this.Rescan_Click);
            // 
            // CheckAtStartup
            // 
            this.CheckAtStartup.AutoSize = true;
            this.CheckAtStartup.Location = new System.Drawing.Point(12, 286);
            this.CheckAtStartup.Name = "CheckAtStartup";
            this.CheckAtStartup.Size = new System.Drawing.Size(368, 17);
            this.CheckAtStartup.TabIndex = 7;
            this.CheckAtStartup.Text = "Check settings at startup (disables automatically if all settings are correct)";
            this.CheckAtStartup.UseVisualStyleBackColor = true;
            this.CheckAtStartup.CheckedChanged += new System.EventHandler(this.CheckAtStartup_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(434, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "The checklist below validates the basic settings needed for GitExtensions to work" +
                " properly.";
            // 
            // GitFound
            // 
            this.GitFound.BackColor = System.Drawing.Color.Gray;
            this.GitFound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitFound.FlatAppearance.BorderSize = 0;
            this.GitFound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GitFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitFound.Location = new System.Drawing.Point(9, 29);
            this.GitFound.Name = "GitFound";
            this.GitFound.Size = new System.Drawing.Size(693, 23);
            this.GitFound.TabIndex = 5;
            this.GitFound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GitFound.UseVisualStyleBackColor = false;
            this.GitFound.Click += new System.EventHandler(this.GitFound_Click);
            // 
            // DiffTool
            // 
            this.DiffTool.BackColor = System.Drawing.Color.Gray;
            this.DiffTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiffTool.FlatAppearance.BorderSize = 0;
            this.DiffTool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DiffTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiffTool.Location = new System.Drawing.Point(9, 145);
            this.DiffTool.Name = "DiffTool";
            this.DiffTool.Size = new System.Drawing.Size(693, 23);
            this.DiffTool.TabIndex = 4;
            this.DiffTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiffTool.UseVisualStyleBackColor = false;
            this.DiffTool.Click += new System.EventHandler(this.DiffTool_Click);
            // 
            // UserNameSet
            // 
            this.UserNameSet.BackColor = System.Drawing.Color.Gray;
            this.UserNameSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserNameSet.FlatAppearance.BorderSize = 0;
            this.UserNameSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UserNameSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserNameSet.Location = new System.Drawing.Point(9, 116);
            this.UserNameSet.Name = "UserNameSet";
            this.UserNameSet.Size = new System.Drawing.Size(693, 23);
            this.UserNameSet.TabIndex = 3;
            this.UserNameSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserNameSet.UseVisualStyleBackColor = false;
            this.UserNameSet.Click += new System.EventHandler(this.UserNameSet_Click);
            // 
            // ShellExtensionsRegistered
            // 
            this.ShellExtensionsRegistered.BackColor = System.Drawing.Color.Gray;
            this.ShellExtensionsRegistered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShellExtensionsRegistered.FlatAppearance.BorderSize = 0;
            this.ShellExtensionsRegistered.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShellExtensionsRegistered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShellExtensionsRegistered.Location = new System.Drawing.Point(9, 87);
            this.ShellExtensionsRegistered.Name = "ShellExtensionsRegistered";
            this.ShellExtensionsRegistered.Size = new System.Drawing.Size(693, 23);
            this.ShellExtensionsRegistered.TabIndex = 2;
            this.ShellExtensionsRegistered.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShellExtensionsRegistered.UseVisualStyleBackColor = false;
            this.ShellExtensionsRegistered.Click += new System.EventHandler(this.ShellExtensionsRegistered_Click);
            // 
            // GitExtensionsInstall
            // 
            this.GitExtensionsInstall.BackColor = System.Drawing.Color.Gray;
            this.GitExtensionsInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitExtensionsInstall.FlatAppearance.BorderSize = 0;
            this.GitExtensionsInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GitExtensionsInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitExtensionsInstall.Location = new System.Drawing.Point(9, 174);
            this.GitExtensionsInstall.Name = "GitExtensionsInstall";
            this.GitExtensionsInstall.Size = new System.Drawing.Size(693, 23);
            this.GitExtensionsInstall.TabIndex = 1;
            this.GitExtensionsInstall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GitExtensionsInstall.UseVisualStyleBackColor = false;
            this.GitExtensionsInstall.Click += new System.EventHandler(this.GitExtensionsInstall_Click);
            // 
            // TabPageGitExtensions
            // 
            this.TabPageGitExtensions.Controls.Add(this.label40);
            this.TabPageGitExtensions.Controls.Add(this.FollowRenamesInFileHistory);
            this.TabPageGitExtensions.Controls.Add(this.label39);
            this.TabPageGitExtensions.Controls.Add(this.label38);
            this.TabPageGitExtensions.Controls.Add(this.label37);
            this.TabPageGitExtensions.Controls.Add(this.label35);
            this.TabPageGitExtensions.Controls.Add(this.label34);
            this.TabPageGitExtensions.Controls.Add(this.EncodingLabel);
            this.TabPageGitExtensions.Controls.Add(this.Encoding);
            this.TabPageGitExtensions.Controls.Add(this.label23);
            this.TabPageGitExtensions.Controls.Add(this.SmtpServer);
            this.TabPageGitExtensions.Controls.Add(this.Dictionary);
            this.TabPageGitExtensions.Controls.Add(this.label22);
            this.TabPageGitExtensions.Controls.Add(this.ShowRelativeDate);
            this.TabPageGitExtensions.Controls.Add(this.UseFastChecks);
            this.TabPageGitExtensions.Controls.Add(this.ShowGitCommandLine);
            this.TabPageGitExtensions.Controls.Add(this.ShowRevisionGraph);
            this.TabPageGitExtensions.Controls.Add(this.CloseProcessDialog);
            this.TabPageGitExtensions.Controls.Add(this.BrowseGitBinPath);
            this.TabPageGitExtensions.Controls.Add(this.GitBinPath);
            this.TabPageGitExtensions.Controls.Add(this.label14);
            this.TabPageGitExtensions.Controls.Add(this.BrowseGitPath);
            this.TabPageGitExtensions.Controls.Add(this.GitPath);
            this.TabPageGitExtensions.Controls.Add(this.label13);
            this.TabPageGitExtensions.Controls.Add(this.MaxCommits);
            this.TabPageGitExtensions.Controls.Add(this.label12);
            this.TabPageGitExtensions.Location = new System.Drawing.Point(4, 22);
            this.TabPageGitExtensions.Name = "TabPageGitExtensions";
            this.TabPageGitExtensions.Size = new System.Drawing.Size(710, 358);
            this.TabPageGitExtensions.TabIndex = 3;
            this.TabPageGitExtensions.Text = "Git extensions";
            this.TabPageGitExtensions.UseVisualStyleBackColor = true;
            this.TabPageGitExtensions.Click += new System.EventHandler(this.TabPageGitExtensions_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(8, 263);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(184, 13);
            this.label39.TabIndex = 25;
            this.label39.Text = "Show relative date instead of full date";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(8, 240);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(256, 13);
            this.label38.TabIndex = 24;
            this.label38.Text = "Use FileSystemWatcher to check if index is changed";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(8, 218);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(167, 13);
            this.label37.TabIndex = 23;
            this.label37.Text = "Show revision graph in commit log";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(8, 197);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(264, 13);
            this.label35.TabIndex = 22;
            this.label35.Text = "Show Git commandline dialog when executing process";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(8, 175);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(295, 13);
            this.label34.TabIndex = 21;
            this.label34.Text = "Close process dialog automaticly when process is succeeded";
            // 
            // EncodingLabel
            // 
            this.EncodingLabel.AutoSize = true;
            this.EncodingLabel.Location = new System.Drawing.Point(324, 318);
            this.EncodingLabel.Name = "EncodingLabel";
            this.EncodingLabel.Size = new System.Drawing.Size(52, 13);
            this.EncodingLabel.TabIndex = 20;
            this.EncodingLabel.Text = "Encoding";
            // 
            // Encoding
            // 
            this.Encoding.FormattingEnabled = true;
            this.Encoding.Items.AddRange(new object[] {
            "Default",
            "ASCII",
            "Unicode",
            "UTF7",
            "UTF8",
            "UTF32"});
            this.Encoding.Location = new System.Drawing.Point(382, 315);
            this.Encoding.Name = "Encoding";
            this.Encoding.Size = new System.Drawing.Size(242, 21);
            this.Encoding.TabIndex = 19;
            // 
            // Dictionary
            // 
            this.Dictionary.FormattingEnabled = true;
            this.Dictionary.Location = new System.Drawing.Point(382, 109);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(242, 21);
            this.Dictionary.TabIndex = 15;
            this.Dictionary.SelectedIndexChanged += new System.EventHandler(this.Dictionary_SelectedIndexChanged);
            this.Dictionary.DropDown += new System.EventHandler(this.Dictionary_DropDown);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(152, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Dictionary for spelling checker.";
            // 
            // ShowRelativeDate
            // 
            this.ShowRelativeDate.AutoSize = true;
            this.ShowRelativeDate.Location = new System.Drawing.Point(382, 262);
            this.ShowRelativeDate.Name = "ShowRelativeDate";
            this.ShowRelativeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowRelativeDate.Size = new System.Drawing.Size(15, 14);
            this.ShowRelativeDate.TabIndex = 13;
            this.ShowRelativeDate.UseVisualStyleBackColor = true;
            // 
            // UseFastChecks
            // 
            this.UseFastChecks.AutoSize = true;
            this.UseFastChecks.Location = new System.Drawing.Point(382, 240);
            this.UseFastChecks.Name = "UseFastChecks";
            this.UseFastChecks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UseFastChecks.Size = new System.Drawing.Size(15, 14);
            this.UseFastChecks.TabIndex = 12;
            this.UseFastChecks.UseVisualStyleBackColor = true;
            // 
            // ShowGitCommandLine
            // 
            this.ShowGitCommandLine.AutoSize = true;
            this.ShowGitCommandLine.Location = new System.Drawing.Point(382, 196);
            this.ShowGitCommandLine.Name = "ShowGitCommandLine";
            this.ShowGitCommandLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowGitCommandLine.Size = new System.Drawing.Size(15, 14);
            this.ShowGitCommandLine.TabIndex = 11;
            this.ShowGitCommandLine.UseVisualStyleBackColor = true;
            // 
            // ShowRevisionGraph
            // 
            this.ShowRevisionGraph.AutoSize = true;
            this.ShowRevisionGraph.Location = new System.Drawing.Point(382, 218);
            this.ShowRevisionGraph.Name = "ShowRevisionGraph";
            this.ShowRevisionGraph.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowRevisionGraph.Size = new System.Drawing.Size(15, 14);
            this.ShowRevisionGraph.TabIndex = 10;
            this.ShowRevisionGraph.UseVisualStyleBackColor = true;
            this.ShowRevisionGraph.CheckedChanged += new System.EventHandler(this.ShowRevisionGraph_CheckedChanged);
            // 
            // CloseProcessDialog
            // 
            this.CloseProcessDialog.AutoSize = true;
            this.CloseProcessDialog.Location = new System.Drawing.Point(382, 174);
            this.CloseProcessDialog.Name = "CloseProcessDialog";
            this.CloseProcessDialog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CloseProcessDialog.Size = new System.Drawing.Size(15, 14);
            this.CloseProcessDialog.TabIndex = 9;
            this.CloseProcessDialog.UseVisualStyleBackColor = true;
            // 
            // BrowseGitBinPath
            // 
            this.BrowseGitBinPath.Location = new System.Drawing.Point(627, 34);
            this.BrowseGitBinPath.Name = "BrowseGitBinPath";
            this.BrowseGitBinPath.Size = new System.Drawing.Size(75, 23);
            this.BrowseGitBinPath.TabIndex = 8;
            this.BrowseGitBinPath.Text = "Browse";
            this.BrowseGitBinPath.UseVisualStyleBackColor = true;
            this.BrowseGitBinPath.Click += new System.EventHandler(this.BrowseGitBinPath_Click);
            // 
            // GitBinPath
            // 
            this.GitBinPath.Location = new System.Drawing.Point(382, 35);
            this.GitBinPath.Name = "GitBinPath";
            this.GitBinPath.Size = new System.Drawing.Size(242, 20);
            this.GitBinPath.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Path to git.exe (leave empty when git.exe is in the path)";
            // 
            // BrowseGitPath
            // 
            this.BrowseGitPath.Location = new System.Drawing.Point(627, 8);
            this.BrowseGitPath.Name = "BrowseGitPath";
            this.BrowseGitPath.Size = new System.Drawing.Size(75, 23);
            this.BrowseGitPath.TabIndex = 5;
            this.BrowseGitPath.Text = "Browse";
            this.BrowseGitPath.UseVisualStyleBackColor = true;
            this.BrowseGitPath.Click += new System.EventHandler(this.BrowseGitPath_Click);
            // 
            // GitPath
            // 
            this.GitPath.Location = new System.Drawing.Point(382, 9);
            this.GitPath.Name = "GitPath";
            this.GitPath.Size = new System.Drawing.Size(242, 20);
            this.GitPath.TabIndex = 4;
            this.GitPath.TextChanged += new System.EventHandler(this.GitPath_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(273, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Path to git.cmd (leave empty when git.cmd is in the path)";
            // 
            // MaxCommits
            // 
            this.MaxCommits.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MaxCommits.Location = new System.Drawing.Point(382, 63);
            this.MaxCommits.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxCommits.Name = "MaxCommits";
            this.MaxCommits.Size = new System.Drawing.Size(123, 20);
            this.MaxCommits.TabIndex = 2;
            this.MaxCommits.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 39);
            this.label12.TabIndex = 0;
            this.label12.Text = "Limit number of commits that will be loaded at startup.\r\nOther commits will be lo" +
                "aded when needed. Lower number \r\nresult is shorter startup time, but slower scro" +
                "lling.";
            // 
            // AppearancePage
            // 
            this.AppearancePage.Controls.Add(this.groupBox4);
            this.AppearancePage.Controls.Add(this.groupBox3);
            this.AppearancePage.Location = new System.Drawing.Point(4, 22);
            this.AppearancePage.Name = "AppearancePage";
            this.AppearancePage.Size = new System.Drawing.Size(710, 322);
            this.AppearancePage.TabIndex = 5;
            this.AppearancePage.Text = "Appearance";
            this.AppearancePage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.ColorRemoteBranchLabel);
            this.groupBox4.Controls.Add(this.ColorOtherLabel);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.ColorTagLabel);
            this.groupBox4.Controls.Add(this.ColorBranchLabel);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.RevisionGraphColorLabel);
            this.groupBox4.Controls.Add(this.RevisionGraphColorSelected);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 205);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Revision graph";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 133);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(102, 13);
            this.label33.TabIndex = 8;
            this.label33.Text = "Color remote branch";
            // 
            // ColorRemoteBranchLabel
            // 
            this.ColorRemoteBranchLabel.AutoSize = true;
            this.ColorRemoteBranchLabel.BackColor = System.Drawing.Color.Red;
            this.ColorRemoteBranchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorRemoteBranchLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorRemoteBranchLabel.Location = new System.Drawing.Point(211, 133);
            this.ColorRemoteBranchLabel.Name = "ColorRemoteBranchLabel";
            this.ColorRemoteBranchLabel.Size = new System.Drawing.Size(29, 15);
            this.ColorRemoteBranchLabel.TabIndex = 9;
            this.ColorRemoteBranchLabel.Text = "Red";
            this.ColorRemoteBranchLabel.Click += new System.EventHandler(this.ColorRemoteBranchLabel_Click);
            // 
            // ColorOtherLabel
            // 
            this.ColorOtherLabel.AutoSize = true;
            this.ColorOtherLabel.BackColor = System.Drawing.Color.Red;
            this.ColorOtherLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorOtherLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorOtherLabel.Location = new System.Drawing.Point(211, 161);
            this.ColorOtherLabel.Name = "ColorOtherLabel";
            this.ColorOtherLabel.Size = new System.Drawing.Size(29, 15);
            this.ColorOtherLabel.TabIndex = 11;
            this.ColorOtherLabel.Text = "Red";
            this.ColorOtherLabel.Click += new System.EventHandler(this.ColorOtherLabel_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 161);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 13);
            this.label36.TabIndex = 10;
            this.label36.Text = "Color other label";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 76);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Color tag";
            // 
            // ColorTagLabel
            // 
            this.ColorTagLabel.AutoSize = true;
            this.ColorTagLabel.BackColor = System.Drawing.Color.Red;
            this.ColorTagLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorTagLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorTagLabel.Location = new System.Drawing.Point(211, 76);
            this.ColorTagLabel.Name = "ColorTagLabel";
            this.ColorTagLabel.Size = new System.Drawing.Size(29, 15);
            this.ColorTagLabel.TabIndex = 5;
            this.ColorTagLabel.Text = "Red";
            this.ColorTagLabel.Click += new System.EventHandler(this.ColorTagLabel_Click);
            // 
            // ColorBranchLabel
            // 
            this.ColorBranchLabel.AutoSize = true;
            this.ColorBranchLabel.BackColor = System.Drawing.Color.Red;
            this.ColorBranchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBranchLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorBranchLabel.Location = new System.Drawing.Point(211, 104);
            this.ColorBranchLabel.Name = "ColorBranchLabel";
            this.ColorBranchLabel.Size = new System.Drawing.Size(29, 15);
            this.ColorBranchLabel.TabIndex = 7;
            this.ColorBranchLabel.Text = "Red";
            this.ColorBranchLabel.Click += new System.EventHandler(this.ColorBranchLabel_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 104);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(67, 13);
            this.label32.TabIndex = 6;
            this.label32.Text = "Color branch";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Color revision graph";
            // 
            // RevisionGraphColorLabel
            // 
            this.RevisionGraphColorLabel.AutoSize = true;
            this.RevisionGraphColorLabel.BackColor = System.Drawing.Color.Red;
            this.RevisionGraphColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RevisionGraphColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevisionGraphColorLabel.Location = new System.Drawing.Point(211, 19);
            this.RevisionGraphColorLabel.Name = "RevisionGraphColorLabel";
            this.RevisionGraphColorLabel.Size = new System.Drawing.Size(29, 15);
            this.RevisionGraphColorLabel.TabIndex = 1;
            this.RevisionGraphColorLabel.Text = "Red";
            this.RevisionGraphColorLabel.Click += new System.EventHandler(this.label25_Click);
            // 
            // RevisionGraphColorSelected
            // 
            this.RevisionGraphColorSelected.AutoSize = true;
            this.RevisionGraphColorSelected.BackColor = System.Drawing.Color.Red;
            this.RevisionGraphColorSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RevisionGraphColorSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevisionGraphColorSelected.Location = new System.Drawing.Point(211, 47);
            this.RevisionGraphColorSelected.Name = "RevisionGraphColorSelected";
            this.RevisionGraphColorSelected.Size = new System.Drawing.Size(29, 15);
            this.RevisionGraphColorSelected.TabIndex = 3;
            this.RevisionGraphColorSelected.Text = "Red";
            this.RevisionGraphColorSelected.Click += new System.EventHandler(this.label25_Click_1);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 47);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Color revision graph selected";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.ColorSectionLabel);
            this.groupBox3.Controls.Add(this.ColorRemovedLine);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.ColorAddedLineLabel);
            this.groupBox3.Location = new System.Drawing.Point(8, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 102);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Difference view";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(94, 13);
            this.label27.TabIndex = 4;
            this.label27.Text = "Color removed line";
            // 
            // ColorSectionLabel
            // 
            this.ColorSectionLabel.AutoSize = true;
            this.ColorSectionLabel.BackColor = System.Drawing.Color.Red;
            this.ColorSectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorSectionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorSectionLabel.Location = new System.Drawing.Point(208, 78);
            this.ColorSectionLabel.Name = "ColorSectionLabel";
            this.ColorSectionLabel.Size = new System.Drawing.Size(29, 15);
            this.ColorSectionLabel.TabIndex = 9;
            this.ColorSectionLabel.Text = "Red";
            this.ColorSectionLabel.Click += new System.EventHandler(this.ColorSectionLabel_Click);
            // 
            // ColorRemovedLine
            // 
            this.ColorRemovedLine.AutoSize = true;
            this.ColorRemovedLine.BackColor = System.Drawing.Color.Red;
            this.ColorRemovedLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorRemovedLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorRemovedLine.Location = new System.Drawing.Point(208, 19);
            this.ColorRemovedLine.Name = "ColorRemovedLine";
            this.ColorRemovedLine.Size = new System.Drawing.Size(29, 15);
            this.ColorRemovedLine.TabIndex = 5;
            this.ColorRemovedLine.Text = "Red";
            this.ColorRemovedLine.Click += new System.EventHandler(this.ColorRemovedLine_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 78);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(68, 13);
            this.label31.TabIndex = 8;
            this.label31.Text = "Color section";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 49);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 13);
            this.label29.TabIndex = 6;
            this.label29.Text = "Color added line";
            // 
            // ColorAddedLineLabel
            // 
            this.ColorAddedLineLabel.AutoSize = true;
            this.ColorAddedLineLabel.BackColor = System.Drawing.Color.Red;
            this.ColorAddedLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorAddedLineLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorAddedLineLabel.Location = new System.Drawing.Point(208, 49);
            this.ColorAddedLineLabel.Name = "ColorAddedLineLabel";
            this.ColorAddedLineLabel.Size = new System.Drawing.Size(29, 15);
            this.ColorAddedLineLabel.TabIndex = 7;
            this.ColorAddedLineLabel.Text = "Red";
            this.ColorAddedLineLabel.Click += new System.EventHandler(this.label28_Click);
            // 
            // GlobalSettingsPage
            // 
            this.GlobalSettingsPage.Controls.Add(this.label28);
            this.GlobalSettingsPage.Controls.Add(this.lblGlobalAutoCRLF);
            this.GlobalSettingsPage.Controls.Add(this.GlobalAutoCRLF);
            this.GlobalSettingsPage.Controls.Add(this.InvalidGitPathGlobal);
            this.GlobalSettingsPage.Controls.Add(this.button1);
            this.GlobalSettingsPage.Controls.Add(this.MergeToolCmd);
            this.GlobalSettingsPage.Controls.Add(this.label19);
            this.GlobalSettingsPage.Controls.Add(this.BrowseMergeTool);
            this.GlobalSettingsPage.Controls.Add(this.GlobalMergeTool);
            this.GlobalSettingsPage.Controls.Add(this.PathToKDiff3);
            this.GlobalSettingsPage.Controls.Add(this.MergetoolPath);
            this.GlobalSettingsPage.Controls.Add(this.GlobalKeepMergeBackup);
            this.GlobalSettingsPage.Controls.Add(this.label7);
            this.GlobalSettingsPage.Controls.Add(this.GlobalEditor);
            this.GlobalSettingsPage.Controls.Add(this.label6);
            this.GlobalSettingsPage.Controls.Add(this.GlobalUserEmail);
            this.GlobalSettingsPage.Controls.Add(this.GlobalUserName);
            this.GlobalSettingsPage.Controls.Add(this.label4);
            this.GlobalSettingsPage.Controls.Add(this.label3);
            this.GlobalSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.GlobalSettingsPage.Name = "GlobalSettingsPage";
            this.GlobalSettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.GlobalSettingsPage.Size = new System.Drawing.Size(710, 322);
            this.GlobalSettingsPage.TabIndex = 1;
            this.GlobalSettingsPage.Text = "Global settings";
            this.GlobalSettingsPage.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 179);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(156, 13);
            this.label28.TabIndex = 22;
            this.label28.Text = "Keep backup (.orig) after merge";
            // 
            // lblGlobalAutoCRLF
            // 
            this.lblGlobalAutoCRLF.AutoSize = true;
            this.lblGlobalAutoCRLF.Location = new System.Drawing.Point(10, 206);
            this.lblGlobalAutoCRLF.Name = "lblGlobalAutoCRLF";
            this.lblGlobalAutoCRLF.Size = new System.Drawing.Size(295, 13);
            this.lblGlobalAutoCRLF.TabIndex = 21;
            this.lblGlobalAutoCRLF.Text = "Convert CRLF at the end of lines in text files to LF, AutoCRLF";
            // 
            // GlobalAutoCRLF
            // 
            this.GlobalAutoCRLF.FormattingEnabled = true;
            this.GlobalAutoCRLF.Items.AddRange(new object[] {
            "true",
            "false",
            "input"});
            this.GlobalAutoCRLF.Location = new System.Drawing.Point(411, 201);
            this.GlobalAutoCRLF.Name = "GlobalAutoCRLF";
            this.GlobalAutoCRLF.Size = new System.Drawing.Size(121, 21);
            this.GlobalAutoCRLF.TabIndex = 20;
            // 
            // InvalidGitPathGlobal
            // 
            this.InvalidGitPathGlobal.BackColor = System.Drawing.SystemColors.Info;
            this.InvalidGitPathGlobal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InvalidGitPathGlobal.Controls.Add(this.label9);
            this.InvalidGitPathGlobal.Controls.Add(this.pictureBox1);
            this.InvalidGitPathGlobal.Location = new System.Drawing.Point(395, 8);
            this.InvalidGitPathGlobal.Name = "InvalidGitPathGlobal";
            this.InvalidGitPathGlobal.Size = new System.Drawing.Size(296, 68);
            this.InvalidGitPathGlobal.TabIndex = 19;
            this.InvalidGitPathGlobal.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 39);
            this.label9.TabIndex = 19;
            this.label9.Text = "You need to set the correct path to \r\ngit.cmd before you can change\r\nglobal setti" +
                "ngs.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GitUI.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Suggest command";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MergeToolCmd
            // 
            this.MergeToolCmd.FormattingEnabled = true;
            this.MergeToolCmd.Items.AddRange(new object[] {
            "\"c:/Program Files/Perforce/p4merge.exe\" \"$BASE\" \"$LOCAL\" \"$REMOTE\" \"$MERGED\"",
            "\"c:/Program Files/TortoiseSVN/bin/TortoiseMerge.exe\" /base:\"$BASE\" /mine:\"$LOCAL\"" +
                " /theirs:\"$REMOTE\" /merged:\"$MERGED\"",
            "\"c:/Program Files/Araxis/Araxis Merge/Compare.exe\" -wait -merge -3 -a1 \"$BASE\" \"$" +
                "LOCAL\" \"$REMOTE\" \"$MERGED\"",
            "\"c:/Program Files/SourceGear/DiffMerge/DiffMerge.exe\" /m /r=\"$MERGED\" \"$LOCAL\" \"$" +
                "BASE\" \"$REMOTE\""});
            this.MergeToolCmd.Location = new System.Drawing.Point(153, 147);
            this.MergeToolCmd.Name = "MergeToolCmd";
            this.MergeToolCmd.Size = new System.Drawing.Size(347, 21);
            this.MergeToolCmd.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Mergetool command";
            // 
            // BrowseMergeTool
            // 
            this.BrowseMergeTool.Location = new System.Drawing.Point(506, 117);
            this.BrowseMergeTool.Name = "BrowseMergeTool";
            this.BrowseMergeTool.Size = new System.Drawing.Size(75, 23);
            this.BrowseMergeTool.TabIndex = 13;
            this.BrowseMergeTool.Text = "Browse";
            this.BrowseMergeTool.UseVisualStyleBackColor = true;
            this.BrowseMergeTool.Click += new System.EventHandler(this.BrowseMergeTool_Click);
            // 
            // GlobalMergeTool
            // 
            this.GlobalMergeTool.FormattingEnabled = true;
            this.GlobalMergeTool.Items.AddRange(new object[] {
            "Araxis",
            "DiffMerge",
            "kdiff3",
            "p4merge",
            "TortoiseMerge"});
            this.GlobalMergeTool.Location = new System.Drawing.Point(153, 92);
            this.GlobalMergeTool.Name = "GlobalMergeTool";
            this.GlobalMergeTool.Size = new System.Drawing.Size(164, 21);
            this.GlobalMergeTool.TabIndex = 12;
            this.GlobalMergeTool.SelectedIndexChanged += new System.EventHandler(this.GlobalMergeTool_SelectedIndexChanged);
            this.GlobalMergeTool.TextChanged += new System.EventHandler(this.GlobalMergeTool_TextChanged);
            // 
            // PathToKDiff3
            // 
            this.PathToKDiff3.AutoSize = true;
            this.PathToKDiff3.Location = new System.Drawing.Point(9, 124);
            this.PathToKDiff3.Name = "PathToKDiff3";
            this.PathToKDiff3.Size = new System.Drawing.Size(90, 13);
            this.PathToKDiff3.TabIndex = 11;
            this.PathToKDiff3.Text = "Path to mergetool";
            // 
            // MergetoolPath
            // 
            this.MergetoolPath.Location = new System.Drawing.Point(153, 120);
            this.MergetoolPath.Name = "MergetoolPath";
            this.MergetoolPath.Size = new System.Drawing.Size(347, 20);
            this.MergetoolPath.TabIndex = 10;
            // 
            // GlobalKeepMergeBackup
            // 
            this.GlobalKeepMergeBackup.AutoSize = true;
            this.GlobalKeepMergeBackup.Checked = true;
            this.GlobalKeepMergeBackup.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.GlobalKeepMergeBackup.Location = new System.Drawing.Point(411, 179);
            this.GlobalKeepMergeBackup.Name = "GlobalKeepMergeBackup";
            this.GlobalKeepMergeBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GlobalKeepMergeBackup.Size = new System.Drawing.Size(15, 14);
            this.GlobalKeepMergeBackup.TabIndex = 9;
            this.GlobalKeepMergeBackup.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mergetool";
            // 
            // GlobalEditor
            // 
            this.GlobalEditor.Location = new System.Drawing.Point(153, 65);
            this.GlobalEditor.Name = "GlobalEditor";
            this.GlobalEditor.Size = new System.Drawing.Size(164, 20);
            this.GlobalEditor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Editor";
            // 
            // GlobalUserEmail
            // 
            this.GlobalUserEmail.Location = new System.Drawing.Point(153, 37);
            this.GlobalUserEmail.Name = "GlobalUserEmail";
            this.GlobalUserEmail.Size = new System.Drawing.Size(164, 20);
            this.GlobalUserEmail.TabIndex = 3;
            // 
            // GlobalUserName
            // 
            this.GlobalUserName.Location = new System.Drawing.Point(153, 8);
            this.GlobalUserName.Name = "GlobalUserName";
            this.GlobalUserName.Size = new System.Drawing.Size(164, 20);
            this.GlobalUserName.TabIndex = 2;
            this.GlobalUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "User email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Ssh
            // 
            this.Ssh.Controls.Add(this.groupBox2);
            this.Ssh.Controls.Add(this.groupBox1);
            this.Ssh.Location = new System.Drawing.Point(4, 22);
            this.Ssh.Name = "Ssh";
            this.Ssh.Padding = new System.Windows.Forms.Padding(3);
            this.Ssh.Size = new System.Drawing.Size(710, 322);
            this.Ssh.TabIndex = 4;
            this.Ssh.Text = "Ssh";
            this.Ssh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AutostartPageant);
            this.groupBox2.Controls.Add(this.PageantPath);
            this.groupBox2.Controls.Add(this.PageantBrowse);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.PuttygenPath);
            this.groupBox2.Controls.Add(this.PuttygenBrowse);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.PlinkPath);
            this.groupBox2.Controls.Add(this.PlinkBrowse);
            this.groupBox2.Location = new System.Drawing.Point(8, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 126);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configure PuTTY";
            // 
            // AutostartPageant
            // 
            this.AutostartPageant.AutoSize = true;
            this.AutostartPageant.Checked = true;
            this.AutostartPageant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutostartPageant.Location = new System.Drawing.Point(118, 103);
            this.AutostartPageant.Name = "AutostartPageant";
            this.AutostartPageant.Size = new System.Drawing.Size(424, 17);
            this.AutostartPageant.TabIndex = 11;
            this.AutostartPageant.Text = "Automatically start authentication client when a private key is configured for a " +
                "remote";
            this.AutostartPageant.UseVisualStyleBackColor = true;
            // 
            // PageantPath
            // 
            this.PageantPath.Location = new System.Drawing.Point(118, 76);
            this.PageantPath.Name = "PageantPath";
            this.PageantPath.Size = new System.Drawing.Size(323, 20);
            this.PageantPath.TabIndex = 9;
            // 
            // PageantBrowse
            // 
            this.PageantBrowse.Location = new System.Drawing.Point(463, 75);
            this.PageantBrowse.Name = "PageantBrowse";
            this.PageantBrowse.Size = new System.Drawing.Size(75, 23);
            this.PageantBrowse.TabIndex = 10;
            this.PageantBrowse.Text = "Browse";
            this.PageantBrowse.UseVisualStyleBackColor = true;
            this.PageantBrowse.Click += new System.EventHandler(this.PageantBrowse_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Path to pageant";
            // 
            // PuttygenPath
            // 
            this.PuttygenPath.Location = new System.Drawing.Point(118, 46);
            this.PuttygenPath.Name = "PuttygenPath";
            this.PuttygenPath.Size = new System.Drawing.Size(323, 20);
            this.PuttygenPath.TabIndex = 6;
            // 
            // PuttygenBrowse
            // 
            this.PuttygenBrowse.Location = new System.Drawing.Point(463, 45);
            this.PuttygenBrowse.Name = "PuttygenBrowse";
            this.PuttygenBrowse.Size = new System.Drawing.Size(75, 23);
            this.PuttygenBrowse.TabIndex = 7;
            this.PuttygenBrowse.Text = "Browse";
            this.PuttygenBrowse.UseVisualStyleBackColor = true;
            this.PuttygenBrowse.Click += new System.EventHandler(this.PuttygenBrowse_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Path to puttygen";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Path to plink.exe";
            // 
            // PlinkPath
            // 
            this.PlinkPath.Location = new System.Drawing.Point(118, 17);
            this.PlinkPath.Name = "PlinkPath";
            this.PlinkPath.Size = new System.Drawing.Size(323, 20);
            this.PlinkPath.TabIndex = 2;
            // 
            // PlinkBrowse
            // 
            this.PlinkBrowse.Location = new System.Drawing.Point(463, 16);
            this.PlinkBrowse.Name = "PlinkBrowse";
            this.PlinkBrowse.Size = new System.Drawing.Size(75, 23);
            this.PlinkBrowse.TabIndex = 3;
            this.PlinkBrowse.Text = "Browse";
            this.PlinkBrowse.UseVisualStyleBackColor = true;
            this.PlinkBrowse.Click += new System.EventHandler(this.PuttyBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OtherSsh);
            this.groupBox1.Controls.Add(this.OtherSshBrowse);
            this.groupBox1.Controls.Add(this.Other);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.OpenSSH);
            this.groupBox1.Controls.Add(this.Putty);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specify which ssh client to use";
            // 
            // OtherSsh
            // 
            this.OtherSsh.Location = new System.Drawing.Point(143, 80);
            this.OtherSsh.Name = "OtherSsh";
            this.OtherSsh.Size = new System.Drawing.Size(323, 20);
            this.OtherSsh.TabIndex = 4;
            // 
            // OtherSshBrowse
            // 
            this.OtherSshBrowse.Location = new System.Drawing.Point(488, 79);
            this.OtherSshBrowse.Name = "OtherSshBrowse";
            this.OtherSshBrowse.Size = new System.Drawing.Size(75, 23);
            this.OtherSshBrowse.TabIndex = 5;
            this.OtherSshBrowse.Text = "Browse";
            this.OtherSshBrowse.UseVisualStyleBackColor = true;
            this.OtherSshBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(9, 81);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(98, 17);
            this.Other.TabIndex = 3;
            this.Other.Text = "Other ssh client";
            this.Other.UseVisualStyleBackColor = true;
            this.Other.CheckedChanged += new System.EventHandler(this.Other_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Info;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(121, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(418, 41);
            this.label18.TabIndex = 2;
            this.label18.Text = resources.GetString("label18.Text");
            // 
            // OpenSSH
            // 
            this.OpenSSH.AutoSize = true;
            this.OpenSSH.Location = new System.Drawing.Point(9, 50);
            this.OpenSSH.Name = "OpenSSH";
            this.OpenSSH.Size = new System.Drawing.Size(73, 17);
            this.OpenSSH.TabIndex = 1;
            this.OpenSSH.Text = "OpenSSH";
            this.OpenSSH.UseVisualStyleBackColor = true;
            this.OpenSSH.CheckedChanged += new System.EventHandler(this.OpenSSH_CheckedChanged);
            // 
            // Putty
            // 
            this.Putty.AutoSize = true;
            this.Putty.Checked = true;
            this.Putty.Location = new System.Drawing.Point(9, 20);
            this.Putty.Name = "Putty";
            this.Putty.Size = new System.Drawing.Size(59, 17);
            this.Putty.TabIndex = 0;
            this.Putty.TabStop = true;
            this.Putty.Text = "PuTTY";
            this.Putty.UseVisualStyleBackColor = true;
            this.Putty.CheckedChanged += new System.EventHandler(this.Putty_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Ok);
            this.splitContainer1.Size = new System.Drawing.Size(718, 417);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 1;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(639, 2);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 39);
            this.label10.TabIndex = 19;
            this.label10.Text = "You need to set the correct path to \r\ngit.cmd before you can change\r\nany global s" +
                "etting.\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GitUI.Properties.Resources.error;
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(8, 285);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(208, 13);
            this.label40.TabIndex = 27;
            this.label40.Text = "Follow renames in file history (experimental)";
            // 
            // FollowRenamesInFileHistory
            // 
            this.FollowRenamesInFileHistory.AutoSize = true;
            this.FollowRenamesInFileHistory.Location = new System.Drawing.Point(382, 284);
            this.FollowRenamesInFileHistory.Name = "FollowRenamesInFileHistory";
            this.FollowRenamesInFileHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FollowRenamesInFileHistory.Size = new System.Drawing.Size(15, 14);
            this.FollowRenamesInFileHistory.TabIndex = 26;
            this.FollowRenamesInFileHistory.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 417);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettigns_Load);
            this.Shown += new System.EventHandler(this.FormSettigns_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettigns_FormClosing);
            this.LocalSettings.ResumeLayout(false);
            this.LocalSettings.PerformLayout();
            this.InvalidGitPathLocal.ResumeLayout(false);
            this.InvalidGitPathLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.TabPageGitExtensions.ResumeLayout(false);
            this.TabPageGitExtensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCommits)).EndInit();
            this.AppearancePage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GlobalSettingsPage.ResumeLayout(false);
            this.GlobalSettingsPage.PerformLayout();
            this.InvalidGitPathGlobal.ResumeLayout(false);
            this.InvalidGitPathGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Ssh.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage LocalSettings;
        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TabPage GlobalSettingsPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GlobalUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GlobalUserEmail;
        private System.Windows.Forms.TextBox Editor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GlobalEditor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox KeepMergeBackup;
        private System.Windows.Forms.CheckBox GlobalKeepMergeBackup;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button GitExtensionsInstall;
        private System.Windows.Forms.Button ShellExtensionsRegistered;
        private System.Windows.Forms.Button UserNameSet;
        private System.Windows.Forms.Button DiffTool;
        private System.Windows.Forms.Button GitFound;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CheckAtStartup;
        private System.Windows.Forms.Button Rescan;
        private System.Windows.Forms.TabPage TabPageGitExtensions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown MaxCommits;
        private System.Windows.Forms.Button BrowseGitPath;
        private System.Windows.Forms.TextBox GitPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BrowseGitBinPath;
        private System.Windows.Forms.TextBox GitBinPath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button GitBinFound;
        private System.Windows.Forms.TabPage Ssh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PlinkBrowse;
        private System.Windows.Forms.TextBox PlinkPath;
        private System.Windows.Forms.RadioButton OpenSSH;
        private System.Windows.Forms.RadioButton Putty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PageantPath;
        private System.Windows.Forms.Button PageantBrowse;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox PuttygenPath;
        private System.Windows.Forms.Button PuttygenBrowse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox OtherSsh;
        private System.Windows.Forms.Button OtherSshBrowse;
        private System.Windows.Forms.RadioButton Other;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.Button SshConfig;
        private System.Windows.Forms.CheckBox AutostartPageant;
        private System.Windows.Forms.Label PathToKDiff3;
        private System.Windows.Forms.TextBox MergetoolPath;
        private System.Windows.Forms.ComboBox GlobalMergeTool;
        private System.Windows.Forms.ComboBox MergeTool;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BrowseMergeTool;
        private System.Windows.Forms.ComboBox MergeToolCmd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CloseProcessDialog;
        private System.Windows.Forms.CheckBox ShowRevisionGraph;
        private System.Windows.Forms.CheckBox ShowGitCommandLine;
        private System.Windows.Forms.CheckBox UseFastChecks;
        private System.Windows.Forms.Label NoGitRepo;
		private System.Windows.Forms.CheckBox ShowRelativeDate;
        private System.Windows.Forms.Panel InvalidGitPathGlobal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel InvalidGitPathLocal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox Dictionary;
		private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox SmtpServer;
		private System.Windows.Forms.Label lblGlobalAutoCRLF;
		private System.Windows.Forms.ComboBox GlobalAutoCRLF;
		private System.Windows.Forms.Label lblLocalAutoCRLF;
		private System.Windows.Forms.ComboBox LocalAutoCRLF;
        private System.Windows.Forms.Label EncodingLabel;
        private System.Windows.Forms.ComboBox Encoding;
        private System.Windows.Forms.TabPage AppearancePage;
        private System.Windows.Forms.Label RevisionGraphColorLabel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label RevisionGraphColorSelected;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label ColorSectionLabel;
        private System.Windows.Forms.Label ColorRemovedLine;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label ColorAddedLineLabel;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label ColorRemoteBranchLabel;
        private System.Windows.Forms.Label ColorOtherLabel;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label ColorTagLabel;
        private System.Windows.Forms.Label ColorBranchLabel;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.CheckBox FollowRenamesInFileHistory;

    }
}