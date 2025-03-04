namespace PGISLauncher.DashboardForms
{
    partial class UCSystemDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSystemDetails));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnOpen = new DevExpress.XtraEditors.SimpleButton();
            this.btnInstall = new DevExpress.XtraEditors.SimpleButton();
            this.picImage = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblAppStatus = new DevExpress.XtraEditors.LabelControl();
            this.lblCreator = new DevExpress.XtraEditors.LabelControl();
            this.lblPublisherName = new DevExpress.XtraEditors.LabelControl();
            this.lblAcrName = new DevExpress.XtraEditors.LabelControl();
            this.lblAbbrevName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.progressPanel = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnUninstall = new DevExpress.XtraEditors.SimpleButton();
            this.btnDocs = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressPanel)).BeginInit();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(214, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "App Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(214, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "App Acronym";
            // 
            // btnOpen
            // 
            this.btnOpen.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnOpen.Appearance.Options.UseBackColor = true;
            this.btnOpen.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.btnOpen.AppearanceDisabled.BackColor2 = System.Drawing.Color.Gray;
            this.btnOpen.AppearanceDisabled.Options.UseBackColor = true;
            this.btnOpen.ImageOptions.Image = global::PGISLauncher.Properties.Resources.next_16x16;
            this.btnOpen.Location = new System.Drawing.Point(18, 160);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(151, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.btnInstall.Appearance.Options.UseBackColor = true;
            this.btnInstall.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.btnInstall.AppearanceDisabled.BackColor2 = System.Drawing.Color.Gray;
            this.btnInstall.AppearanceDisabled.Options.UseBackColor = true;
            this.btnInstall.ImageOptions.Image = global::PGISLauncher.Properties.Resources.download_16x16;
            this.btnInstall.Location = new System.Drawing.Point(18, 160);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(151, 23);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "INSTALL";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(18, 15);
            this.picImage.Name = "picImage";
            this.picImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picImage.Size = new System.Drawing.Size(151, 139);
            this.picImage.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(214, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Publisher";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(214, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Creator/Programmer";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(214, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "App Status";
            // 
            // lblAppStatus
            // 
            this.lblAppStatus.Location = new System.Drawing.Point(350, 53);
            this.lblAppStatus.Name = "lblAppStatus";
            this.lblAppStatus.Size = new System.Drawing.Size(53, 13);
            this.lblAppStatus.TabIndex = 16;
            this.lblAppStatus.Text = "App Status";
            // 
            // lblCreator
            // 
            this.lblCreator.Location = new System.Drawing.Point(350, 91);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(99, 13);
            this.lblCreator.TabIndex = 13;
            this.lblCreator.Text = "Creator/Programmer";
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.Location = new System.Drawing.Point(350, 72);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(43, 13);
            this.lblPublisherName.TabIndex = 12;
            this.lblPublisherName.Text = "Publisher";
            // 
            // lblAcrName
            // 
            this.lblAcrName.Location = new System.Drawing.Point(350, 34);
            this.lblAcrName.Name = "lblAcrName";
            this.lblAcrName.Size = new System.Drawing.Size(64, 13);
            this.lblAcrName.TabIndex = 11;
            this.lblAcrName.Text = "App Acronym";
            // 
            // lblAbbrevName
            // 
            this.lblAbbrevName.Location = new System.Drawing.Point(350, 15);
            this.lblAbbrevName.Name = "lblAbbrevName";
            this.lblAbbrevName.Size = new System.Drawing.Size(49, 13);
            this.lblAbbrevName.TabIndex = 10;
            this.lblAbbrevName.Text = "App Name";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(18, 218);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(53, 13);
            this.labelControl15.TabIndex = 18;
            this.labelControl15.Text = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Appearance.Options.UseTextOptions = true;
            this.lblDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblDescription.Location = new System.Drawing.Point(18, 237);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(831, 65);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // progressPanel
            // 
            this.progressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progressPanel.Controls.Add(this.labelControl8);
            this.progressPanel.Controls.Add(this.progressBarControl);
            this.progressPanel.Location = new System.Drawing.Point(214, 119);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(298, 35);
            this.progressPanel.TabIndex = 20;
            this.progressPanel.Visible = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(116, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(61, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Downloading";
            // 
            // progressBarControl
            // 
            this.progressBarControl.Location = new System.Drawing.Point(-1, 17);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.ShowTitle = true;
            this.progressBarControl.Size = new System.Drawing.Size(299, 18);
            this.progressBarControl.TabIndex = 0;
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.Appearance.BackColor = System.Drawing.Color.Tomato;
            this.btnUninstall.Appearance.Options.UseBackColor = true;
            this.btnUninstall.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.btnUninstall.AppearanceDisabled.BackColor2 = System.Drawing.Color.Gray;
            this.btnUninstall.AppearanceDisabled.Options.UseBackColor = true;
            this.btnUninstall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUninstall.ImageOptions.Image")));
            this.btnUninstall.Location = new System.Drawing.Point(769, 501);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(80, 23);
            this.btnUninstall.TabIndex = 21;
            this.btnUninstall.Text = "UNINSTALL";
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnDocs
            // 
            this.btnDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDocs.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnDocs.Appearance.Options.UseBackColor = true;
            this.btnDocs.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.btnDocs.AppearanceDisabled.BackColor2 = System.Drawing.Color.Gray;
            this.btnDocs.AppearanceDisabled.Options.UseBackColor = true;
            this.btnDocs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDocs.ImageOptions.Image")));
            this.btnDocs.Location = new System.Drawing.Point(683, 501);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Size = new System.Drawing.Size(80, 23);
            this.btnDocs.TabIndex = 22;
            this.btnDocs.Text = "DOCS";
            // 
            // UCSystemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDocs);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.lblAppStatus);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblPublisherName);
            this.Controls.Add(this.lblAcrName);
            this.Controls.Add(this.lblAbbrevName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnInstall);
            this.Name = "UCSystemDetails";
            this.Size = new System.Drawing.Size(869, 540);
            this.Load += new System.EventHandler(this.UCSystemDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressPanel)).EndInit();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picImage;
        private DevExpress.XtraEditors.SimpleButton btnInstall;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnOpen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblAppStatus;
        private DevExpress.XtraEditors.LabelControl lblCreator;
        private DevExpress.XtraEditors.LabelControl lblPublisherName;
        private DevExpress.XtraEditors.LabelControl lblAcrName;
        private DevExpress.XtraEditors.LabelControl lblAbbrevName;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.PanelControl progressPanel;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.SimpleButton btnUninstall;
        private DevExpress.XtraEditors.SimpleButton btnDocs;
    }
}
