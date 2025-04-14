namespace PGISLauncher.ToolForms
{
    partial class FrmAddEditOfficeAccess
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ccbApps = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lueOffice = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbApps.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOffice.Properties)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(427, 40);
            this.panelControl1.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(187, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Add/Edit Office Access";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 49;
            this.labelControl6.Text = "Select Apps";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 48;
            this.labelControl4.Text = "Office";
            // 
            // ccbApps
            // 
            this.ccbApps.EditValue = "";
            this.ccbApps.Location = new System.Drawing.Point(115, 78);
            this.ccbApps.Name = "ccbApps";
            this.ccbApps.Properties.AllowMultiSelect = true;
            this.ccbApps.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbApps.Properties.DisplayMember = "AcrName";
            this.ccbApps.Properties.DropDownRows = 10;
            this.ccbApps.Properties.ValueMember = "Id";
            this.ccbApps.Size = new System.Drawing.Size(278, 20);
            this.ccbApps.TabIndex = 47;
            // 
            // lueOffice
            // 
            this.lueOffice.Location = new System.Drawing.Point(115, 56);
            this.lueOffice.Name = "lueOffice";
            this.lueOffice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOffice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficeName", "Role")});
            this.lueOffice.Properties.DisplayMember = "OfficeName";
            this.lueOffice.Properties.NullText = "";
            this.lueOffice.Properties.ValueMember = "OfficeId";
            this.lueOffice.Size = new System.Drawing.Size(278, 20);
            this.lueOffice.TabIndex = 46;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.ImageOptions.Image = global::PGISLauncher.Properties.Resources.save_16x16;
            this.btnSave.Location = new System.Drawing.Point(167, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 28);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.ImageOptions.Image = global::PGISLauncher.Properties.Resources.close_16x16;
            this.btnCancel.Location = new System.Drawing.Point(283, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 28);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddEditOfficeAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 152);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ccbApps);
            this.Controls.Add(this.lueOffice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmAddEditOfficeAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbApps.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOffice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbApps;
        private DevExpress.XtraEditors.LookUpEdit lueOffice;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}