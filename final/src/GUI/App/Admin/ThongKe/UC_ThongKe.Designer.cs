namespace FinalProject.App.Admin.ThongKe
{
    partial class UC_ThongKe
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
            this.pn_quanlylichthi = new System.Windows.Forms.Panel();
            this.dgv_sinhvien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_diemhoctap = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_drl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbb_hoctap = new System.Windows.Forms.ComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbb_hocphi = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sVMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sV_MHTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.SV_MHTableAdapter();
            this.diemThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemThiTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.DiemThiTableAdapter();
            this.sinhVienTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.SinhVienTableAdapter();
            this.btnExportExcel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoadon_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_quanlylichthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemThiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_quanlylichthi
            // 
            this.pn_quanlylichthi.AutoScroll = true;
            this.pn_quanlylichthi.BackColor = System.Drawing.Color.White;
            this.pn_quanlylichthi.Controls.Add(this.dgv_sinhvien);
            this.pn_quanlylichthi.Controls.Add(this.panel4);
            this.pn_quanlylichthi.Controls.Add(this.panel3);
            this.pn_quanlylichthi.Controls.Add(this.panel1);
            this.pn_quanlylichthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlylichthi.Location = new System.Drawing.Point(0, 0);
            this.pn_quanlylichthi.Name = "pn_quanlylichthi";
            this.pn_quanlylichthi.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlylichthi.TabIndex = 5;
            // 
            // dgv_sinhvien
            // 
            this.dgv_sinhvien.AllowUserToAddRows = false;
            this.dgv_sinhvien.AllowUserToDeleteRows = false;
            this.dgv_sinhvien.AllowUserToOrderColumns = true;
            this.dgv_sinhvien.AllowUserToResizeColumns = false;
            this.dgv_sinhvien.AllowUserToResizeRows = false;
            this.dgv_sinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sinhvien.AutoGenerateColumns = false;
            this.dgv_sinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sinhvien.ColumnHeadersHeight = 44;
            this.dgv_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_sinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.hovaten,
            this.loaiSv,
            this.khoa_id,
            this.Lop_id,
            this.hoadon_id,
            this.diemTb});
            this.dgv_sinhvien.DataSource = this.sinhVienBindingSource;
            this.dgv_sinhvien.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_sinhvien.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_sinhvien.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_sinhvien.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_sinhvien.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_sinhvien.HideOuterBorders = true;
            this.dgv_sinhvien.Location = new System.Drawing.Point(51, 364);
            this.dgv_sinhvien.MultiSelect = false;
            this.dgv_sinhvien.Name = "dgv_sinhvien";
            this.dgv_sinhvien.ReadOnly = true;
            this.dgv_sinhvien.RowHeadersVisible = false;
            this.dgv_sinhvien.RowHeadersWidth = 51;
            this.dgv_sinhvien.RowTemplate.Height = 36;
            this.dgv_sinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sinhvien.Size = new System.Drawing.Size(1106, 150);
            this.dgv_sinhvien.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_sinhvien.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_sinhvien.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_sinhvien.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_sinhvien.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_sinhvien.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dgv_sinhvien.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_sinhvien.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_sinhvien.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgv_sinhvien.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_sinhvien.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_sinhvien.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_sinhvien.TabIndex = 22;
            this.dgv_sinhvien.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_sinhvien_DataBindingComplete);
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 974);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1218, 38);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExportExcel);
            this.panel3.Controls.Add(this.txt_diemhoctap);
            this.panel3.Controls.Add(this.txt_drl);
            this.panel3.Controls.Add(this.kryptonLabel4);
            this.panel3.Controls.Add(this.kryptonLabel3);
            this.panel3.Controls.Add(this.kryptonLabel2);
            this.panel3.Controls.Add(this.cbb_hoctap);
            this.panel3.Controls.Add(this.kryptonLabel1);
            this.panel3.Controls.Add(this.cbb_hocphi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1218, 236);
            this.panel3.TabIndex = 18;
            // 
            // txt_diemhoctap
            // 
            this.txt_diemhoctap.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.txt_diemhoctap.Location = new System.Drawing.Point(347, 84);
            this.txt_diemhoctap.Name = "txt_diemhoctap";
            this.txt_diemhoctap.Size = new System.Drawing.Size(47, 35);
            this.txt_diemhoctap.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.txt_diemhoctap.TabIndex = 31;
            this.txt_diemhoctap.Values.Text = "8.6";
            // 
            // txt_drl
            // 
            this.txt_drl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.txt_drl.Location = new System.Drawing.Point(347, 26);
            this.txt_drl.Name = "txt_drl";
            this.txt_drl.Size = new System.Drawing.Size(41, 35);
            this.txt_drl.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.txt_drl.TabIndex = 30;
            this.txt_drl.Values.Text = "86";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(51, 84);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(290, 35);
            this.kryptonLabel4.TabIndex = 29;
            this.kryptonLabel4.Values.Text = "Trung bình điểm học tập:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(51, 26);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(310, 35);
            this.kryptonLabel3.TabIndex = 28;
            this.kryptonLabel3.Values.Text = "Trung bình điểm rèn luyện:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(619, 143);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(99, 35);
            this.kryptonLabel2.TabIndex = 27;
            this.kryptonLabel2.Values.Text = "Học tập";
            // 
            // cbb_hoctap
            // 
            this.cbb_hoctap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hoctap.FormattingEnabled = true;
            this.cbb_hoctap.Items.AddRange(new object[] {
            "Danh sách sinh viên bị cảnh cáo học vụ",
            "Danh sách sinh viên nhận học bổng"});
            this.cbb_hoctap.Location = new System.Drawing.Point(724, 145);
            this.cbb_hoctap.Name = "cbb_hoctap";
            this.cbb_hoctap.Size = new System.Drawing.Size(433, 33);
            this.cbb_hoctap.TabIndex = 26;
            this.cbb_hoctap.SelectedIndexChanged += new System.EventHandler(this.cbb_hoctap_SelectedIndexChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(51, 143);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 35);
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "Học phí";
            // 
            // cbb_hocphi
            // 
            this.cbb_hocphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hocphi.FormattingEnabled = true;
            this.cbb_hocphi.Items.AddRange(new object[] {
            "Chưa đóng học phí",
            "Đã đóng học phí"});
            this.cbb_hocphi.Location = new System.Drawing.Point(155, 145);
            this.cbb_hocphi.Name = "cbb_hocphi";
            this.cbb_hocphi.Size = new System.Drawing.Size(342, 33);
            this.cbb_hocphi.TabIndex = 23;
            this.cbb_hocphi.SelectedIndexChanged += new System.EventHandler(this.cbb_hocphi_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 94);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thống kê";
            // 
            // sVMHBindingSource
            // 
            this.sVMHBindingSource.DataMember = "SV_MH";
            this.sVMHBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // sV_MHTableAdapter
            // 
            this.sV_MHTableAdapter.ClearBeforeFill = true;
            // 
            // diemThiBindingSource
            // 
            this.diemThiBindingSource.DataMember = "DiemThi";
            this.diemThiBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // diemThiTableAdapter
            // 
            this.diemThiTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(895, 26);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(110, 56);
            this.btnExportExcel.TabIndex = 32;
            this.btnExportExcel.Values.Text = "Export";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "user_id";
            this.Column1.HeaderText = "Mã sinh viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // hovaten
            // 
            this.hovaten.DataPropertyName = "hovaten";
            this.hovaten.HeaderText = "Họ và tên";
            this.hovaten.MinimumWidth = 6;
            this.hovaten.Name = "hovaten";
            this.hovaten.ReadOnly = true;
            // 
            // loaiSv
            // 
            this.loaiSv.DataPropertyName = "loaiSv";
            this.loaiSv.HeaderText = "Loại sinh viên";
            this.loaiSv.MinimumWidth = 6;
            this.loaiSv.Name = "loaiSv";
            this.loaiSv.ReadOnly = true;
            // 
            // khoa_id
            // 
            this.khoa_id.DataPropertyName = "khoa_id";
            this.khoa_id.HeaderText = "Mã khoa";
            this.khoa_id.MinimumWidth = 6;
            this.khoa_id.Name = "khoa_id";
            this.khoa_id.ReadOnly = true;
            // 
            // Lop_id
            // 
            this.Lop_id.DataPropertyName = "Lop_id";
            this.Lop_id.HeaderText = "Mã lớp";
            this.Lop_id.MinimumWidth = 6;
            this.Lop_id.Name = "Lop_id";
            this.Lop_id.ReadOnly = true;
            // 
            // hoadon_id
            // 
            this.hoadon_id.DataPropertyName = "hoadon_id";
            this.hoadon_id.HeaderText = "Mã hoá đơn";
            this.hoadon_id.MinimumWidth = 6;
            this.hoadon_id.Name = "hoadon_id";
            this.hoadon_id.ReadOnly = true;
            // 
            // diemTb
            // 
            this.diemTb.DataPropertyName = "diemTb";
            this.diemTb.HeaderText = "Điểm trung bình";
            this.diemTb.MinimumWidth = 6;
            this.diemTb.Name = "diemTb";
            this.diemTb.ReadOnly = true;
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_quanlylichthi);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlylichthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemThiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_quanlylichthi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ComboBox cbb_hocphi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.ComboBox cbb_hoctap;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_diemhoctap;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_drl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_sinhvien;
        private System.Windows.Forms.BindingSource diemThiBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private System.Windows.Forms.BindingSource sVMHBindingSource;
        private QLHTTTSV_TDT_DataSetTableAdapters.SV_MHTableAdapter sV_MHTableAdapter;
        private QLHTTTSV_TDT_DataSetTableAdapters.DiemThiTableAdapter diemThiTableAdapter;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLHTTTSV_TDT_DataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoadon_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTb;
    }
}
