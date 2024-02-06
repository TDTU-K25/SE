namespace FinalProject.App.Main
{
    partial class UC_Diem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_diem = new System.Windows.Forms.Panel();
            this.dgv_diemthi = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.monhocidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemQT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemQT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemGiuaKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCuoiKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_diemtrungbinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_hocky = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.qLHTTTSV_TDTDataSet = new FinalProject.QLHTTTSV_TDTDataSet();
            this.qLHTTTSVTDTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonTableAdapter = new FinalProject.QLHTTTSV_TDTDataSetTableAdapters.ChiTietHoaDonTableAdapter();
            this.diemThiTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.DiemThiTableAdapter();
            this.pn_diem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_hocky)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSVTDTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_diem
            // 
            this.pn_diem.AutoScroll = true;
            this.pn_diem.BackColor = System.Drawing.Color.White;
            this.pn_diem.Controls.Add(this.dgv_diemthi);
            this.pn_diem.Controls.Add(this.panel5);
            this.pn_diem.Controls.Add(this.panel4);
            this.pn_diem.Controls.Add(this.label6);
            this.pn_diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_diem.Location = new System.Drawing.Point(0, 0);
            this.pn_diem.Name = "pn_diem";
            this.pn_diem.Size = new System.Drawing.Size(1185, 828);
            this.pn_diem.TabIndex = 17;
            // 
            // dgv_diemthi
            // 
            this.dgv_diemthi.AllowUserToAddRows = false;
            this.dgv_diemthi.AllowUserToDeleteRows = false;
            this.dgv_diemthi.AllowUserToResizeColumns = false;
            this.dgv_diemthi.AllowUserToResizeRows = false;
            this.dgv_diemthi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_diemthi.AutoGenerateColumns = false;
            this.dgv_diemthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_diemthi.ColumnHeadersHeight = 44;
            this.dgv_diemthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_diemthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monhocidDataGridViewTextBoxColumn,
            this.tenMonhoc,
            this.tinChi,
            this.diemTbDataGridViewTextBoxColumn,
            this.diemQT1DataGridViewTextBoxColumn,
            this.diemQT2DataGridViewTextBoxColumn,
            this.diemGiuaKiDataGridViewTextBoxColumn,
            this.diemCuoiKiDataGridViewTextBoxColumn});
            this.dgv_diemthi.DataSource = this.diemThiBindingSource;
            this.dgv_diemthi.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_diemthi.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_diemthi.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_diemthi.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_diemthi.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_diemthi.HideOuterBorders = true;
            this.dgv_diemthi.Location = new System.Drawing.Point(50, 202);
            this.dgv_diemthi.MultiSelect = false;
            this.dgv_diemthi.Name = "dgv_diemthi";
            this.dgv_diemthi.ReadOnly = true;
            this.dgv_diemthi.RowHeadersVisible = false;
            this.dgv_diemthi.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.dgv_diemthi.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_diemthi.RowTemplate.Height = 40;
            this.dgv_diemthi.RowTemplate.ReadOnly = true;
            this.dgv_diemthi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_diemthi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_diemthi.Size = new System.Drawing.Size(1080, 83);
            this.dgv_diemthi.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_diemthi.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgv_diemthi.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_diemthi.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgv_diemthi.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgv_diemthi.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.dgv_diemthi.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.dgv_diemthi.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_diemthi.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_diemthi.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_diemthi.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_diemthi.TabIndex = 17;
            this.dgv_diemthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diemthi_CellContentClick);
            this.dgv_diemthi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_diemthi_DataBindingComplete);
            // 
            // monhocidDataGridViewTextBoxColumn
            // 
            this.monhocidDataGridViewTextBoxColumn.DataPropertyName = "monhoc_id";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.monhocidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.monhocidDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.monhocidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monhocidDataGridViewTextBoxColumn.Name = "monhocidDataGridViewTextBoxColumn";
            this.monhocidDataGridViewTextBoxColumn.ReadOnly = true;
            this.monhocidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenMonhoc
            // 
            this.tenMonhoc.DataPropertyName = "tenMonhoc";
            this.tenMonhoc.HeaderText = "Tên môn học";
            this.tenMonhoc.MinimumWidth = 6;
            this.tenMonhoc.Name = "tenMonhoc";
            this.tenMonhoc.ReadOnly = true;
            // 
            // tinChi
            // 
            this.tinChi.DataPropertyName = "tinChi";
            this.tinChi.HeaderText = "Tín chỉ";
            this.tinChi.MinimumWidth = 6;
            this.tinChi.Name = "tinChi";
            this.tinChi.ReadOnly = true;
            // 
            // diemTbDataGridViewTextBoxColumn
            // 
            this.diemTbDataGridViewTextBoxColumn.DataPropertyName = "diemTb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.diemTbDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.diemTbDataGridViewTextBoxColumn.HeaderText = "Điểm trung bình";
            this.diemTbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemTbDataGridViewTextBoxColumn.Name = "diemTbDataGridViewTextBoxColumn";
            this.diemTbDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemTbDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // diemQT1DataGridViewTextBoxColumn
            // 
            this.diemQT1DataGridViewTextBoxColumn.DataPropertyName = "diemQT1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.diemQT1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.diemQT1DataGridViewTextBoxColumn.HeaderText = "Điểm quá trình 1";
            this.diemQT1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemQT1DataGridViewTextBoxColumn.Name = "diemQT1DataGridViewTextBoxColumn";
            this.diemQT1DataGridViewTextBoxColumn.ReadOnly = true;
            this.diemQT1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // diemQT2DataGridViewTextBoxColumn
            // 
            this.diemQT2DataGridViewTextBoxColumn.DataPropertyName = "diemQT2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.diemQT2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.diemQT2DataGridViewTextBoxColumn.HeaderText = "Điểm quá trình 2";
            this.diemQT2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemQT2DataGridViewTextBoxColumn.Name = "diemQT2DataGridViewTextBoxColumn";
            this.diemQT2DataGridViewTextBoxColumn.ReadOnly = true;
            this.diemQT2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // diemGiuaKiDataGridViewTextBoxColumn
            // 
            this.diemGiuaKiDataGridViewTextBoxColumn.DataPropertyName = "diemGiuaKi";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.diemGiuaKiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.diemGiuaKiDataGridViewTextBoxColumn.HeaderText = "Điểm giữa kỳ";
            this.diemGiuaKiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemGiuaKiDataGridViewTextBoxColumn.Name = "diemGiuaKiDataGridViewTextBoxColumn";
            this.diemGiuaKiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemGiuaKiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // diemCuoiKiDataGridViewTextBoxColumn
            // 
            this.diemCuoiKiDataGridViewTextBoxColumn.DataPropertyName = "diemCuoiKi";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.diemCuoiKiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.diemCuoiKiDataGridViewTextBoxColumn.HeaderText = "Điểm cuối kỳ";
            this.diemCuoiKiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemCuoiKiDataGridViewTextBoxColumn.Name = "diemCuoiKiDataGridViewTextBoxColumn";
            this.diemCuoiKiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemCuoiKiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // diemThiBindingSource
            // 
            this.diemThiBindingSource.DataMember = "DiemThi";
            this.diemThiBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_diemtrungbinh);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cbb_hocky);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1185, 87);
            this.panel5.TabIndex = 15;
            // 
            // txt_diemtrungbinh
            // 
            this.txt_diemtrungbinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_diemtrungbinh.AutoSize = true;
            this.txt_diemtrungbinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diemtrungbinh.ForeColor = System.Drawing.Color.Red;
            this.txt_diemtrungbinh.Location = new System.Drawing.Point(803, 37);
            this.txt_diemtrungbinh.Name = "txt_diemtrungbinh";
            this.txt_diemtrungbinh.Size = new System.Drawing.Size(39, 25);
            this.txt_diemtrungbinh.TabIndex = 16;
            this.txt_diemtrungbinh.Text = "8.7";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Điểm trung bình học kỳ:";
            // 
            // cbb_hocky
            // 
            this.cbb_hocky.DropDownWidth = 214;
            this.cbb_hocky.Items.AddRange(new object[] {
            "HK1 / 2022-2023",
            "HK2 / 2022-2023",
            "HK1 / 2023-2024",
            "HK2 / 2023-2024"});
            this.cbb_hocky.Location = new System.Drawing.Point(208, 37);
            this.cbb_hocky.Name = "cbb_hocky";
            this.cbb_hocky.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbb_hocky.Size = new System.Drawing.Size(214, 25);
            this.cbb_hocky.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hocky.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hocky.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chọn học kỳ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1185, 93);
            this.panel4.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm học kỳ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Học kỳ:";
            // 
            // qLHTTTSV_TDTDataSet
            // 
            this.qLHTTTSV_TDTDataSet.DataSetName = "QLHTTTSV_TDTDataSet";
            this.qLHTTTSV_TDTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLHTTTSVTDTDataSetBindingSource
            // 
            this.qLHTTTSVTDTDataSetBindingSource.DataSource = this.qLHTTTSV_TDTDataSet;
            this.qLHTTTSVTDTDataSetBindingSource.Position = 0;
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.chiTietHoaDonBindingSource.DataSource = this.qLHTTTSVTDTDataSetBindingSource;
            // 
            // chiTietHoaDonTableAdapter
            // 
            this.chiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // diemThiTableAdapter
            // 
            this.diemThiTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_diem);
            this.Name = "UC_Diem";
            this.Size = new System.Drawing.Size(1185, 828);
            this.Load += new System.EventHandler(this.UC_Diem_Load);
            this.pn_diem.ResumeLayout(false);
            this.pn_diem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_hocky)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSVTDTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_diem;
        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_hocky;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private System.Windows.Forms.BindingSource qLHTTTSVTDTDataSetBindingSource;
        private QLHTTTSV_TDTDataSet qLHTTTSV_TDTDataSet;
        private QLHTTTSV_TDTDataSetTableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource diemThiBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.DiemThiTableAdapter diemThiTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_diemthi;
        private System.Windows.Forms.Label txt_diemtrungbinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhocidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemQT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemQT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemGiuaKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCuoiKiDataGridViewTextBoxColumn;
    }
}
