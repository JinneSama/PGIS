namespace PGISLauncher
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan4 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colImage = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAppName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colAppAbbrev = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pnlAdminButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnOfficeAccess = new DevExpress.XtraEditors.SimpleButton();
            this.btnDefaultApps = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddApp = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserAccess = new DevExpress.XtraEditors.SimpleButton();
            this.btnAppSettings = new DevExpress.XtraEditors.SimpleButton();
            this.panelDetails = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcApps = new DevExpress.XtraGrid.GridControl();
            this.gridApps = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnNotifLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotifExit = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdminButtons)).BeginInit();
            this.pnlAdminButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifyMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // colImage
            // 
            this.colImage.FieldName = "AppImage";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            // 
            // colAppName
            // 
            this.colAppName.FieldName = "SystemInformation.AcrName";
            this.colAppName.Name = "colAppName";
            this.colAppName.Visible = true;
            this.colAppName.VisibleIndex = 1;
            // 
            // colAppAbbrev
            // 
            this.colAppAbbrev.FieldName = "SystemInformation.AbbrevName";
            this.colAppAbbrev.Name = "colAppAbbrev";
            this.colAppAbbrev.Visible = true;
            this.colAppAbbrev.VisibleIndex = 2;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "InstallInfo";
            this.colInfo.Name = "colInfo";
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Brown;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnLogout);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.lblUsername);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1133, 40);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnLogout.Appearance.Options.UseBackColor = true;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1057, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 26);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(1029, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Teal;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(26, 26);
            this.pictureEdit1.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Appearance.Options.UseFont = true;
            this.lblUsername.Appearance.Options.UseForeColor = true;
            this.lblUsername.Appearance.Options.UseTextOptions = true;
            this.lblUsername.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblUsername.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUsername.Location = new System.Drawing.Point(829, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(195, 13);
            this.lblUsername.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(491, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nueva Vizcaya Provincial Government Information Systems";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.pnlAdminButtons);
            this.panelControl2.Controls.Add(this.panelDetails);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Location = new System.Drawing.Point(0, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1133, 587);
            this.panelControl2.TabIndex = 1;
            // 
            // pnlAdminButtons
            // 
            this.pnlAdminButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdminButtons.Appearance.BackColor = System.Drawing.Color.Wheat;
            this.pnlAdminButtons.Appearance.Options.UseBackColor = true;
            this.pnlAdminButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlAdminButtons.Controls.Add(this.btnOfficeAccess);
            this.pnlAdminButtons.Controls.Add(this.btnDefaultApps);
            this.pnlAdminButtons.Controls.Add(this.btnAddApp);
            this.pnlAdminButtons.Controls.Add(this.btnUserAccess);
            this.pnlAdminButtons.Controls.Add(this.btnAppSettings);
            this.pnlAdminButtons.Location = new System.Drawing.Point(391, 0);
            this.pnlAdminButtons.Name = "pnlAdminButtons";
            this.pnlAdminButtons.Size = new System.Drawing.Size(742, 49);
            this.pnlAdminButtons.TabIndex = 2;
            // 
            // btnOfficeAccess
            // 
            this.btnOfficeAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfficeAccess.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnOfficeAccess.Appearance.Options.UseBackColor = true;
            this.btnOfficeAccess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOfficeAccess.ImageOptions.Image")));
            this.btnOfficeAccess.Location = new System.Drawing.Point(272, 10);
            this.btnOfficeAccess.Name = "btnOfficeAccess";
            this.btnOfficeAccess.Size = new System.Drawing.Size(110, 28);
            this.btnOfficeAccess.TabIndex = 4;
            this.btnOfficeAccess.Text = "Office Access";
            this.btnOfficeAccess.Click += new System.EventHandler(this.btnOfficeAccess_Click);
            // 
            // btnDefaultApps
            // 
            this.btnDefaultApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultApps.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnDefaultApps.Appearance.Options.UseBackColor = true;
            this.btnDefaultApps.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDefaultApps.ImageOptions.Image")));
            this.btnDefaultApps.Location = new System.Drawing.Point(156, 10);
            this.btnDefaultApps.Name = "btnDefaultApps";
            this.btnDefaultApps.Size = new System.Drawing.Size(110, 28);
            this.btnDefaultApps.TabIndex = 3;
            this.btnDefaultApps.Text = "Default Apps";
            this.btnDefaultApps.Click += new System.EventHandler(this.btnDefaultApps_Click);
            // 
            // btnAddApp
            // 
            this.btnAddApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddApp.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnAddApp.Appearance.Options.UseBackColor = true;
            this.btnAddApp.ImageOptions.Image = global::PGISLauncher.Properties.Resources.add_16x16;
            this.btnAddApp.Location = new System.Drawing.Point(620, 10);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(110, 28);
            this.btnAddApp.TabIndex = 2;
            this.btnAddApp.Text = "Add New App";
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // btnUserAccess
            // 
            this.btnUserAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserAccess.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnUserAccess.Appearance.Options.UseBackColor = true;
            this.btnUserAccess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAccess.ImageOptions.Image")));
            this.btnUserAccess.Location = new System.Drawing.Point(388, 10);
            this.btnUserAccess.Name = "btnUserAccess";
            this.btnUserAccess.Size = new System.Drawing.Size(110, 28);
            this.btnUserAccess.TabIndex = 1;
            this.btnUserAccess.Text = "User Access";
            this.btnUserAccess.Click += new System.EventHandler(this.btnUserAccess_Click);
            // 
            // btnAppSettings
            // 
            this.btnAppSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppSettings.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnAppSettings.Appearance.Options.UseBackColor = true;
            this.btnAppSettings.ImageOptions.Image = global::PGISLauncher.Properties.Resources.properties_16x16;
            this.btnAppSettings.Location = new System.Drawing.Point(504, 10);
            this.btnAppSettings.Name = "btnAppSettings";
            this.btnAppSettings.Size = new System.Drawing.Size(110, 28);
            this.btnAppSettings.TabIndex = 0;
            this.btnAppSettings.Text = "App Settings";
            this.btnAppSettings.Click += new System.EventHandler(this.btnAppSettings_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetails.Location = new System.Drawing.Point(391, 49);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(740, 536);
            this.panelDetails.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcApps);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(389, 583);
            this.panelControl3.TabIndex = 0;
            // 
            // gcApps
            // 
            this.gcApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcApps.Location = new System.Drawing.Point(2, 2);
            this.gcApps.MainView = this.gridApps;
            this.gcApps.Name = "gcApps";
            this.gcApps.Size = new System.Drawing.Size(385, 579);
            this.gcApps.TabIndex = 1;
            this.gcApps.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridApps});
            // 
            // gridApps
            // 
            this.gridApps.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImage,
            this.colAppName,
            this.colAppAbbrev,
            this.colInfo});
            this.gridApps.GridControl = this.gcApps;
            this.gridApps.Name = "gridApps";
            this.gridApps.OptionsFind.AlwaysVisible = true;
            this.gridApps.OptionsFind.FindNullPrompt = "Enter text to a System...";
            this.gridApps.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.gridApps.OptionsTiles.IndentBetweenGroups = 0;
            this.gridApps.OptionsTiles.IndentBetweenItems = 0;
            this.gridApps.OptionsTiles.ItemSize = new System.Drawing.Size(462, 60);
            this.gridApps.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.gridApps.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.gridApps.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.gridApps.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 54D;
            tableColumnDefinition2.Length.Value = 95D;
            tableColumnDefinition3.Length.Value = 75D;
            this.gridApps.TileColumns.Add(tableColumnDefinition1);
            this.gridApps.TileColumns.Add(tableColumnDefinition2);
            this.gridApps.TileColumns.Add(tableColumnDefinition3);
            tableRowDefinition1.Length.Value = 8D;
            tableRowDefinition2.Length.Value = 8D;
            tableRowDefinition3.Length.Value = 8D;
            this.gridApps.TileRows.Add(tableRowDefinition1);
            this.gridApps.TileRows.Add(tableRowDefinition2);
            this.gridApps.TileRows.Add(tableRowDefinition3);
            tableSpan1.RowSpan = 3;
            tableSpan2.ColumnIndex = 1;
            tableSpan2.ColumnSpan = 2;
            tableSpan3.ColumnIndex = 1;
            tableSpan3.ColumnSpan = 2;
            tableSpan3.RowIndex = 1;
            tableSpan4.ColumnIndex = 1;
            tableSpan4.ColumnSpan = 2;
            tableSpan4.RowIndex = 2;
            this.gridApps.TileSpans.Add(tableSpan1);
            this.gridApps.TileSpans.Add(tableSpan2);
            this.gridApps.TileSpans.Add(tableSpan3);
            this.gridApps.TileSpans.Add(tableSpan4);
            tileViewItemElement1.Column = this.colImage;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.RowIndex = 1;
            tileViewItemElement1.Text = "colImage";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colAppName;
            tileViewItemElement2.ColumnIndex = 2;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.Text = "colAppName";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement3.Column = this.colAppAbbrev;
            tileViewItemElement3.ColumnIndex = 2;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "colAppAbbrev";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement4.Appearance.Normal.BackColor = System.Drawing.Color.Firebrick;
            tileViewItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            tileViewItemElement4.Appearance.Normal.Options.UseBackColor = true;
            tileViewItemElement4.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement4.Column = this.colInfo;
            tileViewItemElement4.ColumnIndex = 2;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 2;
            tileViewItemElement4.Text = "colInfo";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.gridApps.TileTemplate.Add(tileViewItemElement1);
            this.gridApps.TileTemplate.Add(tileViewItemElement2);
            this.gridApps.TileTemplate.Add(tileViewItemElement3);
            this.gridApps.TileTemplate.Add(tileViewItemElement4);
            this.gridApps.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.tvApps_FocusedRowObjectChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "NVPGIS Launcher";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNotifLogout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNotifExit)});
            this.notifyMenu.Manager = this.barManager;
            this.notifyMenu.Name = "notifyMenu";
            // 
            // btnNotifLogout
            // 
            this.btnNotifLogout.Caption = "Logout";
            this.btnNotifLogout.Id = 0;
            this.btnNotifLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifLogout.ImageOptions.Image")));
            this.btnNotifLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotifLogout.ImageOptions.LargeImage")));
            this.btnNotifLogout.Name = "btnNotifLogout";
            this.btnNotifLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotifLogout_ItemClick);
            // 
            // btnNotifExit
            // 
            this.btnNotifExit.Caption = "Exit";
            this.btnNotifExit.Id = 1;
            this.btnNotifExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifExit.ImageOptions.Image")));
            this.btnNotifExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotifExit.ImageOptions.LargeImage")));
            this.btnNotifExit.Name = "btnNotifExit";
            this.btnNotifExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotifExit_ItemClick);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNotifLogout,
            this.btnNotifExit});
            this.barManager.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1133, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 627);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1133, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 627);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1133, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 627);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 627);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmMain.IconOptions.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlAdminButtons)).EndInit();
            this.pnlAdminButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifyMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gcApps;
        private DevExpress.XtraGrid.Views.Tile.TileView gridApps;
        private DevExpress.XtraEditors.PanelControl panelDetails;
        private DevExpress.XtraGrid.Columns.TileViewColumn colImage;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAppName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAppAbbrev;
        private DevExpress.XtraEditors.PanelControl pnlAdminButtons;
        private DevExpress.XtraEditors.SimpleButton btnAppSettings;
        private DevExpress.XtraEditors.SimpleButton btnUserAccess;
        private DevExpress.XtraEditors.SimpleButton btnAddApp;
        private DevExpress.XtraEditors.SimpleButton btnDefaultApps;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
        private DevExpress.XtraGrid.Columns.TileViewColumn colInfo;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private DevExpress.XtraBars.PopupMenu notifyMenu;
        private DevExpress.XtraBars.BarButtonItem btnNotifLogout;
        private DevExpress.XtraBars.BarButtonItem btnNotifExit;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnOfficeAccess;
    }
}

