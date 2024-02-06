namespace FinalProject.App.Main.LichThi
{
    partial class UC_LichThi_GiuaKy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_lichthi = new System.Windows.Forms.Panel();
            this.dgv_lichthi_giuaky = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lichthiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhoc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemThiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhthucthiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lichThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.qLHTTTSVTDTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lichThiTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.LichThiTableAdapter();
            this.pn_lichthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichthi_giuaky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSVTDTDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_lichthi
            // 
            this.pn_lichthi.AutoScroll = true;
            this.pn_lichthi.BackColor = System.Drawing.Color.White;
            this.pn_lichthi.Controls.Add(this.dgv_lichthi_giuaky);
            this.pn_lichthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_lichthi.Location = new System.Drawing.Point(0, 0);
            this.pn_lichthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_lichthi.Name = "pn_lichthi";
            this.pn_lichthi.Size = new System.Drawing.Size(1219, 614);
            this.pn_lichthi.TabIndex = 1;
            // 
            // dgv_lichthi_giuaky
            // 
            this.dgv_lichthi_giuaky.AllowUserToAddRows = false;
            this.dgv_lichthi_giuaky.AllowUserToDeleteRows = false;
            this.dgv_lichthi_giuaky.AllowUserToResizeColumns = false;
            this.dgv_lichthi_giuaky.AllowUserToResizeRows = false;
            this.dgv_lichthi_giuaky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_lichthi_giuaky.AutoGenerateColumns = false;
            this.dgv_lichthi_giuaky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lichthi_giuaky.ColumnHeadersHeight = 44;
            this.dgv_lichthi_giuaky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_lichthi_giuaky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lichthiidDataGridViewTextBoxColumn,
            this.monhoc_id,
            this.ngayThiDataGridViewTextBoxColumn,
            this.thoiGianThiDataGridViewTextBoxColumn,
            this.diaDiemThiDataGridViewTextBoxColumn,
            this.hinhthucthiDataGridViewTextBoxColumn});
            this.dgv_lichthi_giuaky.DataSource = this.lichThiBindingSource;
            this.dgv_lichthi_giuaky.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_lichthi_giuaky.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_lichthi_giuaky.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_lichthi_giuaky.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_lichthi_giuaky.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_lichthi_giuaky.HideOuterBorders = true;
            this.dgv_lichthi_giuaky.Location = new System.Drawing.Point(92, 91);
            this.dgv_lichthi_giuaky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_lichthi_giuaky.Name = "dgv_lichthi_giuaky";
            this.dgv_lichthi_giuaky.ReadOnly = true;
            this.dgv_lichthi_giuaky.RowHeadersVisible = false;
            this.dgv_lichthi_giuaky.RowHeadersWidth = 51;
            this.dgv_lichthi_giuaky.RowTemplate.Height = 40;
            this.dgv_lichthi_giuaky.RowTemplate.ReadOnly = true;
            this.dgv_lichthi_giuaky.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lichthi_giuaky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lichthi_giuaky.Size = new System.Drawing.Size(1109, 87);
            this.dgv_lichthi_giuaky.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_lichthi_giuaky.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_lichthi_giuaky.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.dgv_lichthi_giuaky.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.dgv_lichthi_giuaky.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_lichthi_giuaky.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dgv_lichthi_giuaky.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_lichthi_giuaky.StateCommon.HeaderColumn.Border.Width = 2;
            this.dgv_lichthi_giuaky.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_lichthi_giuaky.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_lichthi_giuaky.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgv_lichthi_giuaky.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgv_lichthi_giuaky.TabIndex = 1;
            // 
            // lichthiidDataGridViewTextBoxColumn
            // 
            this.lichthiidDataGridViewTextBoxColumn.DataPropertyName = "lichthi_id";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lichthiidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.lichthiidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.lichthiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lichthiidDataGridViewTextBoxColumn.Name = "lichthiidDataGridViewTextBoxColumn";
            this.lichthiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monhoc_id
            // 
            this.monhoc_id.DataPropertyName = "monhoc_id";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.monhoc_id.DefaultCellStyle = dataGridViewCellStyle10;
            this.monhoc_id.HeaderText = "Mã môn học";
            this.monhoc_id.MinimumWidth = 6;
            this.monhoc_id.Name = "monhoc_id";
            this.monhoc_id.ReadOnly = true;
            // 
            // ngayThiDataGridViewTextBoxColumn
            // 
            this.ngayThiDataGridViewTextBoxColumn.DataPropertyName = "ngayThi";
            this.ngayThiDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.ngayThiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayThiDataGridViewTextBoxColumn.Name = "ngayThiDataGridViewTextBoxColumn";
            this.ngayThiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianThiDataGridViewTextBoxColumn
            // 
            this.thoiGianThiDataGridViewTextBoxColumn.DataPropertyName = "thoiGianThi";
            this.thoiGianThiDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.thoiGianThiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianThiDataGridViewTextBoxColumn.Name = "thoiGianThiDataGridViewTextBoxColumn";
            this.thoiGianThiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDiemThiDataGridViewTextBoxColumn
            // 
            this.diaDiemThiDataGridViewTextBoxColumn.DataPropertyName = "diaDiemThi";
            this.diaDiemThiDataGridViewTextBoxColumn.HeaderText = "Phòng";
            this.diaDiemThiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaDiemThiDataGridViewTextBoxColumn.Name = "diaDiemThiDataGridViewTextBoxColumn";
            this.diaDiemThiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hinhthucthiDataGridViewTextBoxColumn
            // 
            this.hinhthucthiDataGridViewTextBoxColumn.DataPropertyName = "hinhthucthi";
            this.hinhthucthiDataGridViewTextBoxColumn.HeaderText = "Hình thức thi";
            this.hinhthucthiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hinhthucthiDataGridViewTextBoxColumn.Name = "hinhthucthiDataGridViewTextBoxColumn";
            this.hinhthucthiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lichThiBindingSource
            // 
            this.lichThiBindingSource.DataMember = "LichThi";
            this.lichThiBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLHTTTSVTDTDataSetBindingSource
            // 
            this.qLHTTTSVTDTDataSetBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            this.qLHTTTSVTDTDataSetBindingSource.Position = 0;
            // 
            // lichThiTableAdapter
            // 
            this.lichThiTableAdapter.ClearBeforeFill = true;
            // 
            // UC_LichThi_GiuaKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_lichthi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_LichThi_GiuaKy";
            this.Size = new System.Drawing.Size(1219, 614);
            this.Load += new System.EventHandler(this.UC_LichThi_GiuaKy_Load);
            this.pn_lichthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichthi_giuaky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSVTDTDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_lichthi;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_lichthi_giuaky;
        private System.Windows.Forms.BindingSource lichThiBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private System.Windows.Forms.BindingSource qLHTTTSVTDTDataSetBindingSource;
        private QLHTTTSV_TDT_DataSetTableAdapters.LichThiTableAdapter lichThiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lichthiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhoc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDiemThiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhthucthiDataGridViewTextBoxColumn;
    }
}
