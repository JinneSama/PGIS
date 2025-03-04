namespace PGISLauncher.ToolForms
{
    partial class FrmAddEditUserAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditUserAccess));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ccbApps = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lueRole = new DevExpress.XtraEditors.LookUpEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.btnOFMIS = new DevExpress.XtraEditors.SimpleButton();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbApps.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(480, 40);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(176, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Add/Edit User Access";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Full Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Position";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Username";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "User Role";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 137);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 42;
            this.labelControl6.Text = "Select Apps";
            // 
            // ccbApps
            // 
            this.ccbApps.EditValue = "";
            this.ccbApps.Location = new System.Drawing.Point(113, 134);
            this.ccbApps.Name = "ccbApps";
            this.ccbApps.Properties.AllowMultiSelect = true;
            this.ccbApps.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbApps.Properties.DisplayMember = "AcrName";
            this.ccbApps.Properties.DropDownRows = 10;
            this.ccbApps.Properties.ValueMember = "Id";
            this.ccbApps.Size = new System.Drawing.Size(278, 20);
            this.ccbApps.TabIndex = 40;
            // 
            // lueRole
            // 
            this.lueRole.Location = new System.Drawing.Point(113, 112);
            this.lueRole.Name = "lueRole";
            this.lueRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Role")});
            this.lueRole.Properties.DisplayMember = "Value";
            this.lueRole.Properties.DropDownRows = 2;
            this.lueRole.Properties.NullText = "";
            this.lueRole.Properties.ValueMember = "Value";
            this.lueRole.Size = new System.Drawing.Size(278, 20);
            this.lueRole.TabIndex = 39;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(113, 90);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.ReadOnly = true;
            this.txtUsername.Properties.UseReadOnlyAppearance = false;
            this.txtUsername.Size = new System.Drawing.Size(278, 20);
            this.txtUsername.TabIndex = 38;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(113, 68);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Properties.ReadOnly = true;
            this.txtPosition.Properties.UseReadOnlyAppearance = false;
            this.txtPosition.Size = new System.Drawing.Size(278, 20);
            this.txtPosition.TabIndex = 36;
            // 
            // btnOFMIS
            // 
            this.btnOFMIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOFMIS.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.btnOFMIS.Appearance.Options.UseBackColor = true;
            this.btnOFMIS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOFMIS.ImageOptions.Image")));
            this.btnOFMIS.Location = new System.Drawing.Point(397, 46);
            this.btnOFMIS.Name = "btnOFMIS";
            this.btnOFMIS.Size = new System.Drawing.Size(77, 20);
            this.btnOFMIS.TabIndex = 34;
            this.btnOFMIS.Text = "OFMIS";
            this.btnOFMIS.Click += new System.EventHandler(this.btnOFMIS_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(113, 46);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.ReadOnly = true;
            this.txtFullName.Properties.UseReadOnlyAppearance = false;
            this.txtFullName.Size = new System.Drawing.Size(278, 20);
            this.txtFullName.TabIndex = 33;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.ImageOptions.Image = global::PGISLauncher.Properties.Resources.save_16x16;
            this.btnSave.Location = new System.Drawing.Point(165, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 28);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.ImageOptions.Image = global::PGISLauncher.Properties.Resources.close_16x16;
            this.btnCancel.Location = new System.Drawing.Point(281, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 28);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddEditUserAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 196);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ccbApps);
            this.Controls.Add(this.lueRole);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnOFMIS);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmAddEditUserAccess.IconOptions.Icon")));
            this.Name = "FrmAddEditUserAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbApps.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnOFMIS;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lueRole;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbApps;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}