namespace PGISLauncher.ToolForms
{
    partial class FrmOfficeAccess
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOfficeAccess));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcOfficeAccess = new DevExpress.XtraGrid.GridControl();
            this.gridUserAccess = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnAddNewOffice = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcOfficeAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcOfficeAccess
            // 
            this.gcOfficeAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOfficeAccess.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcOfficeAccess.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcOfficeAccess.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcOfficeAccess.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcOfficeAccess.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcOfficeAccess.Location = new System.Drawing.Point(0, 87);
            this.gcOfficeAccess.MainView = this.gridUserAccess;
            this.gcOfficeAccess.Name = "gcOfficeAccess";
            this.gcOfficeAccess.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
            this.gcOfficeAccess.Size = new System.Drawing.Size(535, 488);
            this.gcOfficeAccess.TabIndex = 10;
            this.gcOfficeAccess.UseEmbeddedNavigator = true;
            this.gcOfficeAccess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUserAccess});
            // 
            // gridUserAccess
            // 
            this.gridUserAccess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridUserAccess.GridControl = this.gcOfficeAccess;
            this.gridUserAccess.Name = "gridUserAccess";
            this.gridUserAccess.OptionsFind.AlwaysVisible = true;
            this.gridUserAccess.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Office";
            this.gridColumn1.FieldName = "OfficeName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 170;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Username";
            this.gridColumn2.FieldName = "OFMISUser.Username";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Width = 166;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "User Role";
            this.gridColumn3.FieldName = "UserAccess.UserRole";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Width = 182;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.Width = 43;
            // 
            // gridColumn5
            // 
            this.gridColumn5.ColumnEdit = this.btnEdit;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.FixedWidth = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 41;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ContextImageOptions.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.btnAddNewOffice);
            this.panelControl4.Location = new System.Drawing.Point(0, 41);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(535, 40);
            this.panelControl4.TabIndex = 9;
            // 
            // btnAddNewOffice
            // 
            this.btnAddNewOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewOffice.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddNewOffice.Appearance.Options.UseBackColor = true;
            this.btnAddNewOffice.ImageOptions.Image = global::PGISLauncher.Properties.Resources.add_16x16;
            this.btnAddNewOffice.Location = new System.Drawing.Point(413, 5);
            this.btnAddNewOffice.Name = "btnAddNewOffice";
            this.btnAddNewOffice.Size = new System.Drawing.Size(110, 28);
            this.btnAddNewOffice.TabIndex = 3;
            this.btnAddNewOffice.Text = "Add New Office";
            this.btnAddNewOffice.Click += new System.EventHandler(this.btnAddNewOffice_Click);
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
            this.panelControl1.Size = new System.Drawing.Size(535, 40);
            this.panelControl1.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Office Access";
            // 
            // FrmOfficeAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 574);
            this.Controls.Add(this.gcOfficeAccess);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmOfficeAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmOfficeAccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcOfficeAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcOfficeAccess;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUserAccess;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAddNewOffice;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}