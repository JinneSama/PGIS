namespace PGISLauncher.ToolForms
{
    partial class FrmDefaultApps
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
            this.gcDefaultApps = new DevExpress.XtraGrid.GridControl();
            this.gridDefaultApps = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDefaultApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDefaultApps)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(432, 40);
            this.panelControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Default Apps";
            // 
            // gcDefaultApps
            // 
            this.gcDefaultApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDefaultApps.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDefaultApps.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDefaultApps.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDefaultApps.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDefaultApps.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDefaultApps.Location = new System.Drawing.Point(0, 38);
            this.gcDefaultApps.MainView = this.gridDefaultApps;
            this.gcDefaultApps.Name = "gcDefaultApps";
            this.gcDefaultApps.Size = new System.Drawing.Size(432, 369);
            this.gcDefaultApps.TabIndex = 6;
            this.gcDefaultApps.UseEmbeddedNavigator = true;
            this.gcDefaultApps.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDefaultApps});
            // 
            // gridDefaultApps
            // 
            this.gridDefaultApps.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridDefaultApps.GridControl = this.gcDefaultApps;
            this.gridDefaultApps.Name = "gridDefaultApps";
            this.gridDefaultApps.OptionsView.ShowGroupPanel = false;
            this.gridDefaultApps.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridDefaultApps_RowUpdated);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "App Name";
            this.gridColumn1.FieldName = "AcrName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 316;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Default?";
            this.gridColumn2.FieldName = "IsDefaultApp";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 91;
            // 
            // FrmDefaultApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 406);
            this.Controls.Add(this.gcDefaultApps);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmDefaultApps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDefaultApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDefaultApps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDefaultApps;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDefaultApps;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}