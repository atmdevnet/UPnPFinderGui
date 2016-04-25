namespace Finder.net
{
    partial class FinderForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinderForm));
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileDeviceOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileServiceOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFilePresentation = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileManufacturer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileModel = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileDeviceSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileServiceSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewLog = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsSsdp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsSsdpState = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsSsdpStart = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsSsdpStop = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsPorts = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsPorts2869 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsPorts1900 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsPortsOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsPortsClose = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpLinks = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLinksCPRef = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLinksDescr = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLinksXP = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuLinksConfig = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLinksFirewall = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLinksUPnP = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAboutAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stsStatus = new System.Windows.Forms.StatusStrip();
			this.stsLog = new System.Windows.Forms.ToolStripStatusLabel();
			this.stsCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lvArgs = new System.Windows.Forms.ListView();
			this.Arg_name = new System.Windows.Forms.ColumnHeader();
			this.Direction = new System.Windows.Forms.ColumnHeader();
			this.Type = new System.Windows.Forms.ColumnHeader();
			this.Var_name = new System.Windows.Forms.ColumnHeader();
			this.Events = new System.Windows.Forms.ColumnHeader();
			this.Default = new System.Windows.Forms.ColumnHeader();
			this.Allowed_values = new System.Windows.Forms.ColumnHeader();
			this.Min = new System.Windows.Forms.ColumnHeader();
			this.Max = new System.Windows.Forms.ColumnHeader();
			this.Step = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAction = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tbxOutput = new System.Windows.Forms.TextBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tvDevices = new System.Windows.Forms.TreeView();
			this.ilDevice = new System.Windows.Forms.ImageList(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.pgdProps = new System.Windows.Forms.PropertyGrid();
			this.label4 = new System.Windows.Forms.Label();
			this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.cboDevices = new System.Windows.Forms.ToolStripComboBox();
			this.cboFilter = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnStop = new System.Windows.Forms.ToolStripButton();
			this.btnFind = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.mnuMain.SuspendLayout();
			this.stsStatus.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.viewToolStripMenuItem1,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem1});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(632, 24);
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.toolStripMenuItem1,
            this.mnuFileExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(35, 20);
			this.mnuFile.Text = "&File";
			this.mnuFile.DropDownOpening += new System.EventHandler(this.mnuFile_DropDownOpening);
			// 
			// mnuOpen
			// 
			this.mnuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileDeviceOpen,
            this.mnuFileServiceOpen,
            this.toolStripMenuItem3,
            this.mnuFilePresentation,
            this.mnuFileManufacturer,
            this.mnuFileModel});
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.Size = new System.Drawing.Size(143, 22);
			this.mnuOpen.Text = "&Open";
			this.mnuOpen.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuOpen_DropDownItemClicked);
			this.mnuOpen.DropDownOpening += new System.EventHandler(this.mnuOpen_DropDownOpening);
			// 
			// mnuFileDeviceOpen
			// 
			this.mnuFileDeviceOpen.Name = "mnuFileDeviceOpen";
			this.mnuFileDeviceOpen.Size = new System.Drawing.Size(171, 22);
			this.mnuFileDeviceOpen.Text = "&Device Document";
			// 
			// mnuFileServiceOpen
			// 
			this.mnuFileServiceOpen.Name = "mnuFileServiceOpen";
			this.mnuFileServiceOpen.Size = new System.Drawing.Size(171, 22);
			this.mnuFileServiceOpen.Text = "&Service Document";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(168, 6);
			// 
			// mnuFilePresentation
			// 
			this.mnuFilePresentation.Name = "mnuFilePresentation";
			this.mnuFilePresentation.Size = new System.Drawing.Size(171, 22);
			this.mnuFilePresentation.Text = "&Presentation Link";
			// 
			// mnuFileManufacturer
			// 
			this.mnuFileManufacturer.Name = "mnuFileManufacturer";
			this.mnuFileManufacturer.Size = new System.Drawing.Size(171, 22);
			this.mnuFileManufacturer.Text = "&Manufacturer Link";
			// 
			// mnuFileModel
			// 
			this.mnuFileModel.Name = "mnuFileModel";
			this.mnuFileModel.Size = new System.Drawing.Size(171, 22);
			this.mnuFileModel.Text = "M&odel Link";
			// 
			// mnuSave
			// 
			this.mnuSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileDeviceSave,
            this.mnuFileServiceSave});
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.Size = new System.Drawing.Size(143, 22);
			this.mnuSave.Text = "&Save";
			this.mnuSave.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuSave_DropDownItemClicked);
			this.mnuSave.DropDownOpening += new System.EventHandler(this.mnuSave_DropDownOpening);
			// 
			// mnuFileDeviceSave
			// 
			this.mnuFileDeviceSave.Name = "mnuFileDeviceSave";
			this.mnuFileDeviceSave.Size = new System.Drawing.Size(171, 22);
			this.mnuFileDeviceSave.Text = "&Device Document";
			// 
			// mnuFileServiceSave
			// 
			this.mnuFileServiceSave.Name = "mnuFileServiceSave";
			this.mnuFileServiceSave.Size = new System.Drawing.Size(171, 22);
			this.mnuFileServiceSave.Text = "&Service Document";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 6);
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Name = "mnuFileExit";
			this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.mnuFileExit.Size = new System.Drawing.Size(143, 22);
			this.mnuFileExit.Text = "&Exit";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// viewToolStripMenuItem1
			// 
			this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewLog});
			this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
			this.viewToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
			this.viewToolStripMenuItem1.Text = "&View";
			// 
			// mnuViewLog
			// 
			this.mnuViewLog.Name = "mnuViewLog";
			this.mnuViewLog.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.mnuViewLog.Size = new System.Drawing.Size(152, 22);
			this.mnuViewLog.Text = "&Event Log";
			this.mnuViewLog.Click += new System.EventHandler(this.mnuViewLog_Click);
			// 
			// toolsToolStripMenuItem1
			// 
			this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsSsdp,
            this.mnuToolsPorts,
            this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
			this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
			this.toolsToolStripMenuItem1.Text = "&Tools";
			// 
			// mnuToolsSsdp
			// 
			this.mnuToolsSsdp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsSsdpState,
            this.mnuToolsSsdpStart,
            this.mnuToolsSsdpStop});
			this.mnuToolsSsdp.Name = "mnuToolsSsdp";
			this.mnuToolsSsdp.Size = new System.Drawing.Size(192, 22);
			this.mnuToolsSsdp.Text = "&Ssdp Service";
			this.mnuToolsSsdp.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuToolsSsdp_DropDownItemClicked);
			this.mnuToolsSsdp.DropDownOpening += new System.EventHandler(this.mnuToolsSsdp_DropDownOpening);
			// 
			// mnuToolsSsdpState
			// 
			this.mnuToolsSsdpState.BackColor = System.Drawing.SystemColors.Info;
			this.mnuToolsSsdpState.Enabled = false;
			this.mnuToolsSsdpState.Name = "mnuToolsSsdpState";
			this.mnuToolsSsdpState.Size = new System.Drawing.Size(111, 22);
			this.mnuToolsSsdpState.Text = "State";
			// 
			// mnuToolsSsdpStart
			// 
			this.mnuToolsSsdpStart.Name = "mnuToolsSsdpStart";
			this.mnuToolsSsdpStart.Size = new System.Drawing.Size(111, 22);
			this.mnuToolsSsdpStart.Text = "&Start";
			// 
			// mnuToolsSsdpStop
			// 
			this.mnuToolsSsdpStop.Name = "mnuToolsSsdpStop";
			this.mnuToolsSsdpStop.Size = new System.Drawing.Size(111, 22);
			this.mnuToolsSsdpStop.Text = "S&top";
			// 
			// mnuToolsPorts
			// 
			this.mnuToolsPorts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsPorts2869,
            this.mnuToolsPorts1900,
            this.mnuToolsPortsOpen,
            this.mnuToolsPortsClose});
			this.mnuToolsPorts.Name = "mnuToolsPorts";
			this.mnuToolsPorts.Size = new System.Drawing.Size(192, 22);
			this.mnuToolsPorts.Text = "&UPnP Ports on Firewall";
			this.mnuToolsPorts.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuToolsPorts_DropDownItemClicked);
			this.mnuToolsPorts.DropDownOpening += new System.EventHandler(this.mnuToolsPorts_DropDownOpening);
			// 
			// mnuToolsPorts2869
			// 
			this.mnuToolsPorts2869.BackColor = System.Drawing.SystemColors.Info;
			this.mnuToolsPorts2869.Enabled = false;
			this.mnuToolsPorts2869.Name = "mnuToolsPorts2869";
			this.mnuToolsPorts2869.Size = new System.Drawing.Size(111, 22);
			this.mnuToolsPorts2869.Text = "2869";
			// 
			// mnuToolsPorts1900
			// 
			this.mnuToolsPorts1900.BackColor = System.Drawing.SystemColors.Info;
			this.mnuToolsPorts1900.Enabled = false;
			this.mnuToolsPorts1900.Name = "mnuToolsPorts1900";
			this.mnuToolsPorts1900.Size = new System.Drawing.Size(111, 22);
			this.mnuToolsPorts1900.Text = "1900";
			// 
			// mnuToolsPortsOpen
			// 
			this.mnuToolsPortsOpen.Name = "mnuToolsPortsOpen";
			this.mnuToolsPortsOpen.Size = new System.Drawing.Size(111, 22);
			this.mnuToolsPortsOpen.Text = "&Open";
			// 
			// mnuToolsPortsClose
			// 
			this.mnuToolsPortsClose.Name = "mnuToolsPortsClose";
			this.mnuToolsPortsClose.Size = new System.Drawing.Size(111, 22);
			this.mnuToolsPortsClose.Text = "&Close";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpLinks,
            this.mnuAboutAbout});
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem1.Text = "&Help";
			// 
			// mnuHelpLinks
			// 
			this.mnuHelpLinks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLinksCPRef,
            this.mnuLinksDescr,
            this.mnuLinksXP,
            this.toolStripMenuItem2,
            this.mnuLinksConfig,
            this.mnuLinksFirewall,
            this.mnuLinksUPnP});
			this.mnuHelpLinks.Name = "mnuHelpLinks";
			this.mnuHelpLinks.Size = new System.Drawing.Size(133, 22);
			this.mnuHelpLinks.Text = "&Links";
			this.mnuHelpLinks.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuHelpLinks_DropDownItemClicked);
			// 
			// mnuLinksCPRef
			// 
			this.mnuLinksCPRef.Name = "mnuLinksCPRef";
			this.mnuLinksCPRef.Size = new System.Drawing.Size(349, 22);
			this.mnuLinksCPRef.Text = "Control Point API Reference";
			// 
			// mnuLinksDescr
			// 
			this.mnuLinksDescr.Name = "mnuLinksDescr";
			this.mnuLinksDescr.Size = new System.Drawing.Size(349, 22);
			this.mnuLinksDescr.Text = "Description of UPnP Features in Windows XP";
			// 
			// mnuLinksXP
			// 
			this.mnuLinksXP.Name = "mnuLinksXP";
			this.mnuLinksXP.Size = new System.Drawing.Size(349, 22);
			this.mnuLinksXP.Text = "UPnP in Windows XP (MS TechNet Article)";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(346, 6);
			// 
			// mnuLinksConfig
			// 
			this.mnuLinksConfig.Name = "mnuLinksConfig";
			this.mnuLinksConfig.Size = new System.Drawing.Size(349, 22);
			this.mnuLinksConfig.Text = "Configuration Settings";
			// 
			// mnuLinksFirewall
			// 
			this.mnuLinksFirewall.Name = "mnuLinksFirewall";
			this.mnuLinksFirewall.Size = new System.Drawing.Size(349, 22);
			this.mnuLinksFirewall.Text = "How Windows Firewall affects UPnP in Windows XP SP2";
			// 
			// mnuLinksUPnP
			// 
			this.mnuLinksUPnP.Name = "mnuLinksUPnP";
			this.mnuLinksUPnP.Size = new System.Drawing.Size(349, 22);
			this.mnuLinksUPnP.Text = "UPnP Forum";
			// 
			// mnuAboutAbout
			// 
			this.mnuAboutAbout.Name = "mnuAboutAbout";
			this.mnuAboutAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.mnuAboutAbout.Size = new System.Drawing.Size(133, 22);
			this.mnuAboutAbout.Text = "&About";
			this.mnuAboutAbout.Click += new System.EventHandler(this.mnuAboutAbout_Click);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// stsStatus
			// 
			this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLog,
            this.stsCount});
			this.stsStatus.Location = new System.Drawing.Point(0, 506);
			this.stsStatus.Name = "stsStatus";
			this.stsStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.stsStatus.Size = new System.Drawing.Size(632, 22);
			this.stsStatus.TabIndex = 1;
			this.stsStatus.Text = "statusStrip1";
			// 
			// stsLog
			// 
			this.stsLog.Name = "stsLog";
			this.stsLog.Size = new System.Drawing.Size(560, 17);
			this.stsLog.Spring = true;
			this.stsLog.Text = "Not initialized";
			this.stsLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// stsCount
			// 
			this.stsCount.Name = "stsCount";
			this.stsCount.Size = new System.Drawing.Size(57, 17);
			this.stsCount.Text = "Devices: 0";
			this.stsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Panel1.Controls.Add(this.lvArgs);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1MinSize = 54;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label6);
			this.splitContainer1.Panel2.Controls.Add(this.tbxOutput);
			this.splitContainer1.Panel2MinSize = 40;
			this.splitContainer1.Size = new System.Drawing.Size(632, 169);
			this.splitContainer1.SplitterDistance = 111;
			this.splitContainer1.TabIndex = 3;
			// 
			// lvArgs
			// 
			this.lvArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lvArgs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Arg_name,
            this.Direction,
            this.Type,
            this.Var_name,
            this.Events,
            this.Default,
            this.Allowed_values,
            this.Min,
            this.Max,
            this.Step});
			this.lvArgs.FullRowSelect = true;
			this.lvArgs.GridLines = true;
			this.lvArgs.HideSelection = false;
			this.lvArgs.LabelWrap = false;
			this.lvArgs.Location = new System.Drawing.Point(15, 16);
			this.lvArgs.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.lvArgs.Name = "lvArgs";
			this.lvArgs.Size = new System.Drawing.Size(605, 95);
			this.lvArgs.TabIndex = 0;
			this.lvArgs.UseCompatibleStateImageBehavior = false;
			this.lvArgs.View = System.Windows.Forms.View.Details;
			// 
			// Arg_name
			// 
			this.Arg_name.Text = "Arg name";
			// 
			// Direction
			// 
			this.Direction.Text = "Direction";
			// 
			// Type
			// 
			this.Type.Text = "Type";
			// 
			// Var_name
			// 
			this.Var_name.Text = "Var name";
			// 
			// Events
			// 
			this.Events.Text = "Events";
			// 
			// Default
			// 
			this.Default.Text = "Default";
			// 
			// Allowed_values
			// 
			this.Allowed_values.Text = "Allowed values";
			// 
			// Min
			// 
			this.Min.Text = "Min";
			// 
			// Max
			// 
			this.Max.Text = "Max";
			// 
			// Step
			// 
			this.Step.Text = "Step";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label5.Location = new System.Drawing.Point(15, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(605, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Action\'s arguments:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAction
			// 
			this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnAction.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAction.Location = new System.Drawing.Point(0, 261);
			this.btnAction.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(259, 23);
			this.btnAction.TabIndex = 2;
			this.btnAction.Text = "&Action";
			this.tipHelp.SetToolTip(this.btnAction, "Invokes selected action");
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label6.Location = new System.Drawing.Point(15, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(605, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Action\'s result:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbxOutput
			// 
			this.tbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbxOutput.HideSelection = false;
			this.tbxOutput.Location = new System.Drawing.Point(15, 16);
			this.tbxOutput.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.tbxOutput.Multiline = true;
			this.tbxOutput.Name = "tbxOutput";
			this.tbxOutput.ReadOnly = true;
			this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxOutput.Size = new System.Drawing.Size(605, 35);
			this.tbxOutput.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer2.Panel1.Controls.Add(this.tvDevices);
			this.splitContainer2.Panel1.Controls.Add(this.label3);
			this.splitContainer2.Panel1MinSize = 300;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.btnAction);
			this.splitContainer2.Panel2.Controls.Add(this.pgdProps);
			this.splitContainer2.Panel2.Controls.Add(this.label4);
			this.splitContainer2.Panel2MinSize = 10;
			this.splitContainer2.Size = new System.Drawing.Size(632, 284);
			this.splitContainer2.SplitterDistance = 357;
			this.splitContainer2.TabIndex = 4;
			// 
			// tvDevices
			// 
			this.tvDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tvDevices.Cursor = System.Windows.Forms.Cursors.Default;
			this.tvDevices.HideSelection = false;
			this.tvDevices.ImageIndex = 1;
			this.tvDevices.ImageList = this.ilDevice;
			this.tvDevices.Location = new System.Drawing.Point(15, 19);
			this.tvDevices.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.tvDevices.Name = "tvDevices";
			this.tvDevices.SelectedImageIndex = 1;
			this.tvDevices.Size = new System.Drawing.Size(342, 265);
			this.tvDevices.TabIndex = 1;
			this.tvDevices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDevices_AfterSelect);
			// 
			// ilDevice
			// 
			this.ilDevice.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDevice.ImageStream")));
			this.ilDevice.TransparentColor = System.Drawing.Color.Transparent;
			this.ilDevice.Images.SetKeyName(0, "root.ico");
			this.ilDevice.Images.SetKeyName(1, "dev.ico");
			this.ilDevice.Images.SetKeyName(2, "srv.ico");
			this.ilDevice.Images.SetKeyName(3, "act.ico");
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label3.Location = new System.Drawing.Point(15, 3);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(342, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Device\'s structure:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pgdProps
			// 
			this.pgdProps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pgdProps.Location = new System.Drawing.Point(0, 19);
			this.pgdProps.Margin = new System.Windows.Forms.Padding(0);
			this.pgdProps.Name = "pgdProps";
			this.pgdProps.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			this.pgdProps.Size = new System.Drawing.Size(259, 242);
			this.pgdProps.TabIndex = 1;
			this.pgdProps.PropertySortChanged += new System.EventHandler(this.pgdProps_PropertySortChanged);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label4.Location = new System.Drawing.Point(0, 3);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(259, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Properties:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// splitContainer3
			// 
			this.splitContainer3.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
			this.splitContainer3.Panel1MinSize = 200;
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
			this.splitContainer3.Panel2MinSize = 150;
			this.splitContainer3.Size = new System.Drawing.Size(632, 457);
			this.splitContainer3.SplitterDistance = 284;
			this.splitContainer3.TabIndex = 5;
			// 
			// toolStrip1
			// 
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboDevices,
            this.cboFilter,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.btnStop,
            this.btnFind});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
			this.toolStrip1.Size = new System.Drawing.Size(632, 25);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStrip1_Paint);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
			this.toolStripLabel1.Text = "Devices";
			// 
			// cboDevices
			// 
			this.cboDevices.AutoSize = false;
			this.cboDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDevices.Name = "cboDevices";
			this.cboDevices.Size = new System.Drawing.Size(320, 21);
			this.cboDevices.ToolTipText = "Found devices";
			this.cboDevices.SelectedIndexChanged += new System.EventHandler(this.cboDevices_SelectedIndexChanged);
			// 
			// cboFilter
			// 
			this.cboFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.cboFilter.Name = "cboFilter";
			this.cboFilter.Size = new System.Drawing.Size(150, 25);
			this.cboFilter.ToolTipText = "Devices types to search for";
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(31, 22);
			this.toolStripLabel2.Text = "Filter";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnStop
			// 
			this.btnStop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnStop.Image = global::Finder.net.Properties.Resources.delete;
			this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(23, 22);
			this.btnStop.Text = "toolStripButton2";
			this.btnStop.ToolTipText = "Cancels searching";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnFind
			// 
			this.btnFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFind.Image = global::Finder.net.Properties.Resources.zoom;
			this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(23, 22);
			this.btnFind.Text = "toolStripButton1";
			this.btnFind.ToolTipText = "Starts search for devices";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer3);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(632, 457);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(632, 482);
			this.toolStripContainer1.TabIndex = 7;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// FinderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 528);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.stsStatus);
			this.Controls.Add(this.mnuMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.mnuMain;
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "FinderForm";
			this.Text = "Finder.net";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FinderForm_KeyDown);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.stsStatus.ResumeLayout(false);
			this.stsStatus.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuViewLog;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutAbout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView tvDevices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvArgs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel stsLog;
        private System.Windows.Forms.ToolStripStatusLabel stsCount;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.ImageList ilDevice;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PropertyGrid pgdProps;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboDevices;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripComboBox cboFilter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ColumnHeader Arg_name;
		private System.Windows.Forms.ColumnHeader Direction;
		private System.Windows.Forms.ColumnHeader Type;
		private System.Windows.Forms.ColumnHeader Var_name;
		private System.Windows.Forms.ColumnHeader Events;
		private System.Windows.Forms.ColumnHeader Default;
		private System.Windows.Forms.ColumnHeader Allowed_values;
		private System.Windows.Forms.ColumnHeader Min;
		private System.Windows.Forms.ColumnHeader Max;
		private System.Windows.Forms.ColumnHeader Step;
		private System.Windows.Forms.ToolStripMenuItem mnuOpen;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuFilePresentation;
		private System.Windows.Forms.ToolStripMenuItem mnuFileManufacturer;
		private System.Windows.Forms.ToolStripMenuItem mnuFileModel;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mnuFileDeviceOpen;
		private System.Windows.Forms.ToolStripMenuItem mnuFileServiceOpen;
		private System.Windows.Forms.ToolStripMenuItem mnuFileDeviceSave;
		private System.Windows.Forms.ToolStripMenuItem mnuFileServiceSave;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsSsdp;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsSsdpState;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsSsdpStart;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsSsdpStop;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsPorts;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsPorts2869;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsPorts1900;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsPortsOpen;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsPortsClose;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpLinks;
		private System.Windows.Forms.ToolStripMenuItem mnuLinksCPRef;
		private System.Windows.Forms.ToolStripMenuItem mnuLinksDescr;
		private System.Windows.Forms.ToolStripMenuItem mnuLinksXP;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mnuLinksConfig;
		private System.Windows.Forms.ToolStripMenuItem mnuLinksFirewall;
		private System.Windows.Forms.ToolStripMenuItem mnuLinksUPnP;
    }
}