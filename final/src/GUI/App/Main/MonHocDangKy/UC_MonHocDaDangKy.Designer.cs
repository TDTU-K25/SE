namespace FinalProject.App.Main.MonHocDangKy
{
    partial class UC_MonHocDaDangKy
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_mhdk = new System.Windows.Forms.Panel();
            this.dgv_mhdk = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.monhocidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatdauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xemhocphi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.monHocTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter();
            this.pn_mhdk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mhdk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_mhdk
            // 
            this.pn_mhdk.AutoScroll = true;
            this.pn_mhdk.BackColor = System.Drawing.Color.White;
            this.pn_mhdk.Controls.Add(this.dgv_mhdk);
            this.pn_mhdk.Controls.Add(this.panel1);
            this.pn_mhdk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_mhdk.Location = new System.Drawing.Point(0, 0);
            this.pn_mhdk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_mhdk.Name = "pn_mhdk";
            this.pn_mhdk.Size = new System.Drawing.Size(914, 975);
            this.pn_mhdk.TabIndex = 0;
            // 
            // dgv_mhdk
            // 
            this.dgv_mhdk.AllowUserToAddRows = false;
            this.dgv_mhdk.AllowUserToDeleteRows = false;
            this.dgv_mhdk.AllowUserToResizeColumns = false;
            this.dgv_mhdk.AllowUserToResizeRows = false;
            this.dgv_mhdk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_mhdk.AutoGenerateColumns = false;
            this.dgv_mhdk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mhdk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_mhdk.ColumnHeadersHeight = 44;
            this.dgv_mhdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_mhdk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monhocidDataGridViewTextBoxColumn,
            this.tenMonhocDataGridViewTextBoxColumn,
            this.tinChiDataGridViewTextBoxColumn,
            this.caHocDataGridViewTextBoxColumn,
            this.ngayBatdauDataGridViewTextBoxColumn,
            this.ngayKetthuc});
            this.dgv_mhdk.DataSource = this.monHocBindingSource;
            this.dgv_mhdk.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_mhdk.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_mhdk.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_mhdk.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_mhdk.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_mhdk.HideOuterBorders = true;
            this.dgv_mhdk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_mhdk.Location = new System.Drawing.Point(38, 162);
            this.dgv_mhdk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_mhdk.MultiSelect = false;
            this.dgv_mhdk.Name = "dgv_mhdk";
            this.dgv_mhdk.ReadOnly = true;
            this.dgv_mhdk.RowHeadersVisible = false;
            this.dgv_mhdk.RowHeadersWidth = 30;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.dgv_mhdk.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_mhdk.RowTemplate.Height = 40;
            this.dgv_mhdk.RowTemplate.ReadOnly = true;
            this.dgv_mhdk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mhdk.Size = new System.Drawing.Size(826, 62);
            this.dgv_mhdk.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_mhdk.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgv_mhdk.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_mhdk.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.LightGreen;
            this.dgv_mhdk.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.LightGreen;
            this.dgv_mhdk.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_mhdk.TabIndex = 7;
            this.dgv_mhdk.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_mhdk_DataBindingComplete);
            // 
            // monhocidDataGridViewTextBoxColumn
            // 
            this.monhocidDataGridViewTextBoxColumn.DataPropertyName = "monhoc_id";
            this.monhocidDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.monhocidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monhocidDataGridViewTextBoxColumn.Name = "monhocidDataGridViewTextBoxColumn";
            this.monhocidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenMonhocDataGridViewTextBoxColumn
            // 
            this.tenMonhocDataGridViewTextBoxColumn.DataPropertyName = "tenMonhoc";
            this.tenMonhocDataGridViewTextBoxColumn.HeaderText = "Tên môn học";
            this.tenMonhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonhocDataGridViewTextBoxColumn.Name = "tenMonhocDataGridViewTextBoxColumn";
            this.tenMonhocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinChiDataGridViewTextBoxColumn
            // 
            this.tinChiDataGridViewTextBoxColumn.DataPropertyName = "tinChi";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tinChiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.tinChiDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ";
            this.tinChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinChiDataGridViewTextBoxColumn.Name = "tinChiDataGridViewTextBoxColumn";
            this.tinChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caHocDataGridViewTextBoxColumn
            // 
            this.caHocDataGridViewTextBoxColumn.DataPropertyName = "caHoc";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.caHocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.caHocDataGridViewTextBoxColumn.HeaderText = "Ca học";
            this.caHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caHocDataGridViewTextBoxColumn.Name = "caHocDataGridViewTextBoxColumn";
            this.caHocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayBatdauDataGridViewTextBoxColumn
            // 
            this.ngayBatdauDataGridViewTextBoxColumn.DataPropertyName = "ngayBatdau";
            this.ngayBatdauDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu học";
            this.ngayBatdauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayBatdauDataGridViewTextBoxColumn.Name = "ngayBatdauDataGridViewTextBoxColumn";
            this.ngayBatdauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayKetthuc
            // 
            this.ngayKetthuc.DataPropertyName = "ngayKetthuc";
            this.ngayKetthuc.HeaderText = "Ngày kết thúc";
            this.ngayKetthuc.MinimumWidth = 6;
            this.ngayKetthuc.Name = "ngayKetthuc";
            this.ngayKetthuc.ReadOnly = true;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_xemhocphi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 156);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn học đã đăng ký";
            // 
            // btn_xemhocphi
            // 
            this.btn_xemhocphi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xemhocphi.Location = new System.Drawing.Point(722, 95);
            this.btn_xemhocphi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xemhocphi.Name = "btn_xemhocphi";
            this.btn_xemhocphi.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xemhocphi.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xemhocphi.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xemhocphi.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xemhocphi.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xemhocphi.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_xemhocphi.OverrideDefault.Border.Rounding = 16;
            this.btn_xemhocphi.OverrideDefault.Border.Width = 1;
            this.btn_xemhocphi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_xemhocphi.Size = new System.Drawing.Size(143, 32);
            this.btn_xemhocphi.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xemhocphi.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xemhocphi.StateCommon.Back.ColorAngle = 45F;
            this.btn_xemhocphi.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xemhocphi.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xemhocphi.StateCommon.Border.ColorAngle = 45F;
            this.btn_xemhocphi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xemhocphi.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_xemhocphi.StateCommon.Border.Rounding = 16;
            this.btn_xemhocphi.StateCommon.Border.Width = 1;
            this.btn_xemhocphi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_xemhocphi.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_xemhocphi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemhocphi.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xemhocphi.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xemhocphi.StatePressed.Back.ColorAngle = 45F;
            this.btn_xemhocphi.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xemhocphi.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xemhocphi.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xemhocphi.StatePressed.Border.Rounding = 16;
            this.btn_xemhocphi.StatePressed.Border.Width = 1;
            this.btn_xemhocphi.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xemhocphi.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xemhocphi.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xemhocphi.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xemhocphi.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xemhocphi.StateTracking.Border.Rounding = 16;
            this.btn_xemhocphi.TabIndex = 1;
            this.btn_xemhocphi.Values.Text = "Xem học phí";
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // UC_MonHocDaDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_mhdk);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_MonHocDaDangKy";
            this.Size = new System.Drawing.Size(914, 975);
            this.Load += new System.EventHandler(this.UC_MonHocDaDangKy_Load);
            this.pn_mhdk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mhdk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_mhdk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xemhocphi;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_mhdk;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhocidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatdauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetthuc;
    }
}
