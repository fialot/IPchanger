namespace IPchanger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbIP = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.rbIPmanual = new System.Windows.Forms.RadioButton();
            this.txtIPmask = new System.Windows.Forms.TextBox();
            this.chbSetIP = new System.Windows.Forms.CheckBox();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.lblGateway = new System.Windows.Forms.Label();
            this.rbIPauto = new System.Windows.Forms.RadioButton();
            this.lblIPmask = new System.Windows.Forms.Label();
            this.lblIPaddress = new System.Windows.Forms.Label();
            this.cbNetwork = new System.Windows.Forms.ComboBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblNetwork = new System.Windows.Forms.Label();
            this.gbDNS = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDNS2 = new System.Windows.Forms.Label();
            this.txtDNS2 = new System.Windows.Forms.TextBox();
            this.lblDNS1 = new System.Windows.Forms.Label();
            this.rbDNSmanual = new System.Windows.Forms.RadioButton();
            this.txtDNS1 = new System.Windows.Forms.TextBox();
            this.chbSetDNS = new System.Windows.Forms.CheckBox();
            this.rbDNSauto = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuProfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGetIP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNetRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetIP = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbIP.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbDNS.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.notifyMenu.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProfile
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cbProfile, 4);
            this.cbProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(85, 3);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(322, 21);
            this.cbProfile.TabIndex = 0;
            this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.cbProfile_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(413, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbIP
            // 
            this.gbIP.AutoSize = true;
            this.gbIP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.SetColumnSpan(this.gbIP, 3);
            this.gbIP.Controls.Add(this.tableLayoutPanel2);
            this.gbIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIP.Location = new System.Drawing.Point(3, 61);
            this.gbIP.Name = "gbIP";
            this.gbIP.Size = new System.Drawing.Size(240, 171);
            this.gbIP.TabIndex = 3;
            this.gbIP.TabStop = false;
            this.gbIP.Text = "IP";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.txtGateway, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.rbIPmanual, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtIPmask, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.chbSetIP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtIPaddress, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblGateway, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.rbIPauto, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIPmask, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblIPaddress, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 152);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(73, 123);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(139, 20);
            this.txtGateway.TabIndex = 13;
            // 
            // rbIPmanual
            // 
            this.rbIPmanual.AutoSize = true;
            this.rbIPmanual.Location = new System.Drawing.Point(73, 33);
            this.rbIPmanual.Name = "rbIPmanual";
            this.rbIPmanual.Size = new System.Drawing.Size(77, 17);
            this.rbIPmanual.TabIndex = 14;
            this.rbIPmanual.TabStop = true;
            this.rbIPmanual.Text = "use this IP:";
            this.rbIPmanual.UseVisualStyleBackColor = true;
            this.rbIPmanual.CheckedChanged += new System.EventHandler(this.chbSetIP_CheckedChanged);
            // 
            // txtIPmask
            // 
            this.txtIPmask.Location = new System.Drawing.Point(73, 93);
            this.txtIPmask.Name = "txtIPmask";
            this.txtIPmask.Size = new System.Drawing.Size(139, 20);
            this.txtIPmask.TabIndex = 12;
            // 
            // chbSetIP
            // 
            this.chbSetIP.AutoSize = true;
            this.chbSetIP.Location = new System.Drawing.Point(3, 3);
            this.chbSetIP.Name = "chbSetIP";
            this.chbSetIP.Size = new System.Drawing.Size(40, 17);
            this.chbSetIP.TabIndex = 7;
            this.chbSetIP.Text = "set";
            this.chbSetIP.UseVisualStyleBackColor = true;
            this.chbSetIP.CheckedChanged += new System.EventHandler(this.chbSetIP_CheckedChanged);
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.Location = new System.Drawing.Point(73, 63);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(139, 20);
            this.txtIPaddress.TabIndex = 8;
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGateway.Location = new System.Drawing.Point(3, 120);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(64, 32);
            this.lblGateway.TabIndex = 11;
            this.lblGateway.Text = "Gateway:";
            // 
            // rbIPauto
            // 
            this.rbIPauto.AutoSize = true;
            this.rbIPauto.Location = new System.Drawing.Point(73, 3);
            this.rbIPauto.Name = "rbIPauto";
            this.rbIPauto.Size = new System.Drawing.Size(97, 17);
            this.rbIPauto.TabIndex = 9;
            this.rbIPauto.TabStop = true;
            this.rbIPauto.Text = "automaticaly IP";
            this.rbIPauto.UseVisualStyleBackColor = true;
            this.rbIPauto.CheckedChanged += new System.EventHandler(this.chbSetIP_CheckedChanged);
            // 
            // lblIPmask
            // 
            this.lblIPmask.AutoSize = true;
            this.lblIPmask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIPmask.Location = new System.Drawing.Point(3, 90);
            this.lblIPmask.Name = "lblIPmask";
            this.lblIPmask.Size = new System.Drawing.Size(64, 30);
            this.lblIPmask.TabIndex = 10;
            this.lblIPmask.Text = "Mask:";
            // 
            // lblIPaddress
            // 
            this.lblIPaddress.AutoSize = true;
            this.lblIPaddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIPaddress.Location = new System.Drawing.Point(3, 60);
            this.lblIPaddress.Name = "lblIPaddress";
            this.lblIPaddress.Size = new System.Drawing.Size(64, 30);
            this.lblIPaddress.TabIndex = 9;
            this.lblIPaddress.Text = "IP address:";
            // 
            // cbNetwork
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cbNetwork, 4);
            this.cbNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNetwork.FormattingEnabled = true;
            this.cbNetwork.Location = new System.Drawing.Point(85, 32);
            this.cbNetwork.Name = "cbNetwork";
            this.cbNetwork.Size = new System.Drawing.Size(322, 21);
            this.cbNetwork.TabIndex = 4;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfile.Location = new System.Drawing.Point(3, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(76, 29);
            this.lblProfile.TabIndex = 5;
            this.lblProfile.Text = "Profile:";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNetwork
            // 
            this.lblNetwork.AutoSize = true;
            this.lblNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNetwork.Location = new System.Drawing.Point(3, 29);
            this.lblNetwork.Name = "lblNetwork";
            this.lblNetwork.Size = new System.Drawing.Size(76, 29);
            this.lblNetwork.TabIndex = 6;
            this.lblNetwork.Text = "Network:";
            this.lblNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbDNS
            // 
            this.gbDNS.AutoSize = true;
            this.gbDNS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.SetColumnSpan(this.gbDNS, 3);
            this.gbDNS.Controls.Add(this.tableLayoutPanel4);
            this.gbDNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDNS.Location = new System.Drawing.Point(249, 61);
            this.gbDNS.Name = "gbDNS";
            this.gbDNS.Size = new System.Drawing.Size(244, 171);
            this.gbDNS.TabIndex = 7;
            this.gbDNS.TabStop = false;
            this.gbDNS.Text = "DNS";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.lblDNS2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtDNS2, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblDNS1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.rbDNSmanual, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtDNS1, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.chbSetDNS, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbDNSauto, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(238, 152);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // lblDNS2
            // 
            this.lblDNS2.AutoSize = true;
            this.lblDNS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDNS2.Location = new System.Drawing.Point(3, 90);
            this.lblDNS2.Name = "lblDNS2";
            this.lblDNS2.Size = new System.Drawing.Size(65, 30);
            this.lblDNS2.TabIndex = 15;
            this.lblDNS2.Text = "DNS2:";
            // 
            // txtDNS2
            // 
            this.txtDNS2.Location = new System.Drawing.Point(74, 93);
            this.txtDNS2.Name = "txtDNS2";
            this.txtDNS2.Size = new System.Drawing.Size(139, 20);
            this.txtDNS2.TabIndex = 17;
            // 
            // lblDNS1
            // 
            this.lblDNS1.AutoSize = true;
            this.lblDNS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDNS1.Location = new System.Drawing.Point(3, 60);
            this.lblDNS1.Name = "lblDNS1";
            this.lblDNS1.Size = new System.Drawing.Size(65, 30);
            this.lblDNS1.TabIndex = 14;
            this.lblDNS1.Text = "DNS1:";
            // 
            // rbDNSmanual
            // 
            this.rbDNSmanual.AutoSize = true;
            this.rbDNSmanual.Location = new System.Drawing.Point(74, 33);
            this.rbDNSmanual.Name = "rbDNSmanual";
            this.rbDNSmanual.Size = new System.Drawing.Size(90, 17);
            this.rbDNSmanual.TabIndex = 19;
            this.rbDNSmanual.TabStop = true;
            this.rbDNSmanual.Text = "use this DNS:";
            this.rbDNSmanual.UseVisualStyleBackColor = true;
            this.rbDNSmanual.CheckedChanged += new System.EventHandler(this.chbSetDNS_CheckedChanged);
            // 
            // txtDNS1
            // 
            this.txtDNS1.Location = new System.Drawing.Point(74, 63);
            this.txtDNS1.Name = "txtDNS1";
            this.txtDNS1.Size = new System.Drawing.Size(139, 20);
            this.txtDNS1.TabIndex = 16;
            // 
            // chbSetDNS
            // 
            this.chbSetDNS.AutoSize = true;
            this.chbSetDNS.Location = new System.Drawing.Point(3, 3);
            this.chbSetDNS.Name = "chbSetDNS";
            this.chbSetDNS.Size = new System.Drawing.Size(40, 17);
            this.chbSetDNS.TabIndex = 7;
            this.chbSetDNS.Text = "set";
            this.chbSetDNS.UseVisualStyleBackColor = true;
            this.chbSetDNS.CheckedChanged += new System.EventHandler(this.chbSetDNS_CheckedChanged);
            // 
            // rbDNSauto
            // 
            this.rbDNSauto.AutoSize = true;
            this.rbDNSauto.Location = new System.Drawing.Point(74, 3);
            this.rbDNSauto.Name = "rbDNSauto";
            this.rbDNSauto.Size = new System.Drawing.Size(110, 17);
            this.rbDNSauto.TabIndex = 18;
            this.rbDNSauto.TabStop = true;
            this.rbDNSauto.Text = "automaticaly DNS";
            this.rbDNSauto.UseVisualStyleBackColor = true;
            this.rbDNSauto.CheckedChanged += new System.EventHandler(this.chbSetDNS_CheckedChanged);
            // 
            // btnSet
            // 
            this.btnSet.AutoSize = true;
            this.btnSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSet.Location = new System.Drawing.Point(85, 238);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(76, 25);
            this.btnSet.TabIndex = 8;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "aaa";
            this.notifyIcon1.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "IP change";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProfiles,
            this.mnuGetIP,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(114, 76);
            // 
            // mnuProfiles
            // 
            this.mnuProfiles.Name = "mnuProfiles";
            this.mnuProfiles.Size = new System.Drawing.Size(113, 22);
            this.mnuProfiles.Text = "Profiles";
            // 
            // mnuGetIP
            // 
            this.mnuGetIP.Name = "mnuGetIP";
            this.mnuGetIP.Size = new System.Drawing.Size(113, 22);
            this.mnuGetIP.Text = "Get IP";
            this.mnuGetIP.Click += new System.EventHandler(this.mnuGetIP_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(113, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnNetRefresh
            // 
            this.btnNetRefresh.AutoSize = true;
            this.btnNetRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNetRefresh.Location = new System.Drawing.Point(413, 32);
            this.btnNetRefresh.Name = "btnNetRefresh";
            this.btnNetRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnNetRefresh.TabIndex = 9;
            this.btnNetRefresh.Text = "Refresh";
            this.btnNetRefresh.UseVisualStyleBackColor = true;
            this.btnNetRefresh.Click += new System.EventHandler(this.btnNetRefresh_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.btnGetIP, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbNetwork, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnNetRefresh, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbProfile, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDelete, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblProfile, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNetwork, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.gbIP, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.gbDNS, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnSet, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(496, 266);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // btnGetIP
            // 
            this.btnGetIP.AutoSize = true;
            this.btnGetIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetIP.Location = new System.Drawing.Point(413, 238);
            this.btnGetIP.Name = "btnGetIP";
            this.btnGetIP.Size = new System.Drawing.Size(80, 23);
            this.btnGetIP.TabIndex = 11;
            this.btnGetIP.Text = "Get IP";
            this.btnGetIP.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(496, 266);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "IP changer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.gbIP.ResumeLayout(false);
            this.gbIP.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbDNS.ResumeLayout(false);
            this.gbDNS.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.notifyMenu.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbIP;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtIPmask;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblIPmask;
        private System.Windows.Forms.Label lblIPaddress;
        private System.Windows.Forms.TextBox txtIPaddress;
        private System.Windows.Forms.CheckBox chbSetIP;
        private System.Windows.Forms.ComboBox cbNetwork;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblNetwork;
        private System.Windows.Forms.GroupBox gbDNS;
        private System.Windows.Forms.TextBox txtDNS2;
        private System.Windows.Forms.TextBox txtDNS1;
        private System.Windows.Forms.Label lblDNS2;
        private System.Windows.Forms.Label lblDNS1;
        private System.Windows.Forms.CheckBox chbSetDNS;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuProfiles;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.RadioButton rbIPmanual;
        private System.Windows.Forms.RadioButton rbIPauto;
        private System.Windows.Forms.RadioButton rbDNSmanual;
        private System.Windows.Forms.RadioButton rbDNSauto;
        private System.Windows.Forms.Button btnNetRefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuGetIP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnGetIP;
        private System.Windows.Forms.Timer timer1;
    }
}

