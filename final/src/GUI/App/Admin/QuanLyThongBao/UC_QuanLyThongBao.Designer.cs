namespace FinalProject.App.Admin.QuanLyThongBao
{
    partial class UC_QuanLyThongBao
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
            this.pn_quanlymonhoc = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_thongbao = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapNhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiThongBaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doiTuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongBaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_luu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_huy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_them = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_xoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_khoa = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txt_noidung = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbb_doituong = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbb_loaithongbao = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_ngayhethan = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txt_id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.thongBaoTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.ThongBaoTableAdapter();
            this.pn_quanlymonhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongbao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongBaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_doituong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_loaithongbao)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_quanlymonhoc
            // 
            this.pn_quanlymonhoc.AutoScroll = true;
            this.pn_quanlymonhoc.BackColor = System.Drawing.Color.White;
            this.pn_quanlymonhoc.Controls.Add(this.panel4);
            this.pn_quanlymonhoc.Controls.Add(this.dgv_thongbao);
            this.pn_quanlymonhoc.Controls.Add(this.panel3);
            this.pn_quanlymonhoc.Controls.Add(this.panel2);
            this.pn_quanlymonhoc.Controls.Add(this.panel1);
            this.pn_quanlymonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlymonhoc.Location = new System.Drawing.Point(0, 0);
            this.pn_quanlymonhoc.Name = "pn_quanlymonhoc";
            this.pn_quanlymonhoc.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlymonhoc.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 974);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1218, 38);
            this.panel4.TabIndex = 21;
            // 
            // dgv_thongbao
            // 
            this.dgv_thongbao.AllowUserToAddRows = false;
            this.dgv_thongbao.AllowUserToDeleteRows = false;
            this.dgv_thongbao.AllowUserToOrderColumns = true;
            this.dgv_thongbao.AllowUserToResizeColumns = false;
            this.dgv_thongbao.AllowUserToResizeRows = false;
            this.dgv_thongbao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_thongbao.AutoGenerateColumns = false;
            this.dgv_thongbao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongbao.ColumnHeadersHeight = 44;
            this.dgv_thongbao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_thongbao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.tbidDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.ngayCapNhatDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn,
            this.loaiThongBaoDataGridViewTextBoxColumn,
            this.doiTuongDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn,
            this.khoaidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn});
            this.dgv_thongbao.DataSource = this.thongBaoBindingSource;
            this.dgv_thongbao.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_thongbao.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_thongbao.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_thongbao.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_thongbao.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_thongbao.HideOuterBorders = true;
            this.dgv_thongbao.Location = new System.Drawing.Point(51, 482);
            this.dgv_thongbao.MultiSelect = false;
            this.dgv_thongbao.Name = "dgv_thongbao";
            this.dgv_thongbao.RowHeadersVisible = false;
            this.dgv_thongbao.RowHeadersWidth = 51;
            this.dgv_thongbao.RowTemplate.Height = 36;
            this.dgv_thongbao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_thongbao.Size = new System.Drawing.Size(1083, 150);
            this.dgv_thongbao.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_thongbao.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_thongbao.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_thongbao.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_thongbao.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_thongbao.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dgv_thongbao.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_thongbao.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_thongbao.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgv_thongbao.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_thongbao.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgv_thongbao.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgv_thongbao.TabIndex = 20;
            this.dgv_thongbao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongbao_CellContentClick);
            this.dgv_thongbao.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_thongbao_DataBindingComplete);
            // 
            // select
            // 
            this.select.HeaderText = "Chọn";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            // 
            // tbidDataGridViewTextBoxColumn
            // 
            this.tbidDataGridViewTextBoxColumn.DataPropertyName = "tb_id";
            this.tbidDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.tbidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbidDataGridViewTextBoxColumn.Name = "tbidDataGridViewTextBoxColumn";
            this.tbidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "ngayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            this.ngayTaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayCapNhatDataGridViewTextBoxColumn
            // 
            this.ngayCapNhatDataGridViewTextBoxColumn.DataPropertyName = "ngayCapNhat";
            this.ngayCapNhatDataGridViewTextBoxColumn.HeaderText = "Ngày cập nhật";
            this.ngayCapNhatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCapNhatDataGridViewTextBoxColumn.Name = "ngayCapNhatDataGridViewTextBoxColumn";
            this.ngayCapNhatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "noiDung";
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.noiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            this.noiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiThongBaoDataGridViewTextBoxColumn
            // 
            this.loaiThongBaoDataGridViewTextBoxColumn.DataPropertyName = "loaiThongBao";
            this.loaiThongBaoDataGridViewTextBoxColumn.HeaderText = "Loại";
            this.loaiThongBaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiThongBaoDataGridViewTextBoxColumn.Name = "loaiThongBaoDataGridViewTextBoxColumn";
            this.loaiThongBaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doiTuongDataGridViewTextBoxColumn
            // 
            this.doiTuongDataGridViewTextBoxColumn.DataPropertyName = "doiTuong";
            this.doiTuongDataGridViewTextBoxColumn.HeaderText = "Đối tượng";
            this.doiTuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doiTuongDataGridViewTextBoxColumn.Name = "doiTuongDataGridViewTextBoxColumn";
            this.doiTuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "ngayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "ngayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // khoaidDataGridViewTextBoxColumn
            // 
            this.khoaidDataGridViewTextBoxColumn.DataPropertyName = "khoa_id";
            this.khoaidDataGridViewTextBoxColumn.HeaderText = "Mã khoa";
            this.khoaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khoaidDataGridViewTextBoxColumn.Name = "khoaidDataGridViewTextBoxColumn";
            this.khoaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thongBaoBindingSource
            // 
            this.thongBaoBindingSource.DataMember = "ThongBao";
            this.thongBaoBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_luu);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_huy);
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1218, 76);
            this.panel3.TabIndex = 18;
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_luu.Location = new System.Drawing.Point(820, 17);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(95)))));
            this.btn_luu.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(95)))));
            this.btn_luu.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(95)))));
            this.btn_luu.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(95)))));
            this.btn_luu.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_luu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_luu.Size = new System.Drawing.Size(133, 39);
            this.btn_luu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(95)))));
            this.btn_luu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(95)))));
            this.btn_luu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(95)))));
            this.btn_luu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(141)))), ((int)(((byte)(95)))));
            this.btn_luu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_luu.StateCommon.Border.Rounding = 8;
            this.btn_luu.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_luu.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_luu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_luu.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_luu.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.btn_luu.StateDisabled.Border.Color2 = System.Drawing.Color.Silver;
            this.btn_luu.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_luu.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.btn_luu.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.btn_luu.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.btn_luu.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.btn_luu.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_luu.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(78)))));
            this.btn_luu.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(78)))));
            this.btn_luu.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(78)))));
            this.btn_luu.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(116)))), ((int)(((byte)(78)))));
            this.btn_luu.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_luu.TabIndex = 23;
            this.btn_luu.Values.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sua.Location = new System.Drawing.Point(461, 17);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.btn_sua.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.btn_sua.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.btn_sua.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.btn_sua.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_sua.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_sua.Size = new System.Drawing.Size(133, 39);
            this.btn_sua.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.btn_sua.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.btn_sua.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.btn_sua.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(188)))), ((int)(((byte)(106)))));
            this.btn_sua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_sua.StateCommon.Border.Rounding = 8;
            this.btn_sua.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_sua.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_sua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_sua.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_sua.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.btn_sua.StateDisabled.Border.Color2 = System.Drawing.Color.Silver;
            this.btn_sua.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_sua.StateDisabled.Border.Rounding = 8;
            this.btn_sua.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(80)))));
            this.btn_sua.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(80)))));
            this.btn_sua.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(80)))));
            this.btn_sua.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(139)))), ((int)(((byte)(80)))));
            this.btn_sua.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_sua.StatePressed.Border.Rounding = 8;
            this.btn_sua.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(163)))), ((int)(((byte)(93)))));
            this.btn_sua.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(163)))), ((int)(((byte)(93)))));
            this.btn_sua.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(163)))), ((int)(((byte)(93)))));
            this.btn_sua.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(163)))), ((int)(((byte)(93)))));
            this.btn_sua.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_sua.StateTracking.Border.Rounding = 8;
            this.btn_sua.StateTracking.Border.Width = 1;
            this.btn_sua.TabIndex = 24;
            this.btn_sua.Values.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_huy.Location = new System.Drawing.Point(1004, 17);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btn_huy.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btn_huy.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btn_huy.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btn_huy.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_huy.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_huy.Size = new System.Drawing.Size(133, 39);
            this.btn_huy.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btn_huy.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btn_huy.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btn_huy.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btn_huy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_huy.StateCommon.Border.Rounding = 8;
            this.btn_huy.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_huy.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_huy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btn_huy.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btn_huy.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btn_huy.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btn_huy.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_huy.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_huy.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_huy.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_huy.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_huy.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_huy.TabIndex = 22;
            this.btn_huy.Values.Text = "Huỷ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them.Location = new System.Drawing.Point(281, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_them.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_them.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_them.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_them.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_them.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_them.Size = new System.Drawing.Size(133, 39);
            this.btn_them.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_them.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_them.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_them.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_them.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_them.StateCommon.Border.Rounding = 8;
            this.btn_them.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_them.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_them.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_them.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_them.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.btn_them.StateDisabled.Border.Color2 = System.Drawing.Color.Silver;
            this.btn_them.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_them.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.btn_them.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.btn_them.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.btn_them.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.btn_them.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_them.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.btn_them.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.btn_them.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.btn_them.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.btn_them.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_them.TabIndex = 19;
            this.btn_them.Values.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoa.Location = new System.Drawing.Point(641, 17);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_xoa.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_xoa.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_xoa.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_xoa.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xoa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_xoa.Size = new System.Drawing.Size(133, 39);
            this.btn_xoa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_xoa.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_xoa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_xoa.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_xoa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xoa.StateCommon.Border.Rounding = 8;
            this.btn_xoa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_xoa.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_xoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_xoa.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_xoa.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.btn_xoa.StateDisabled.Border.Color2 = System.Drawing.Color.Silver;
            this.btn_xoa.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xoa.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(53)))), ((int)(((byte)(35)))));
            this.btn_xoa.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(53)))), ((int)(((byte)(35)))));
            this.btn_xoa.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(53)))), ((int)(((byte)(35)))));
            this.btn_xoa.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(53)))), ((int)(((byte)(35)))));
            this.btn_xoa.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xoa.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(70)))), ((int)(((byte)(49)))));
            this.btn_xoa.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(70)))), ((int)(((byte)(49)))));
            this.btn_xoa.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(70)))), ((int)(((byte)(49)))));
            this.btn_xoa.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(70)))), ((int)(((byte)(49)))));
            this.btn_xoa.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xoa.TabIndex = 20;
            this.btn_xoa.Values.Text = "Xoá";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbb_khoa);
            this.panel2.Controls.Add(this.txt_noidung);
            this.panel2.Controls.Add(this.cbb_doituong);
            this.panel2.Controls.Add(this.cbb_loaithongbao);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtp_ngayhethan);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 279);
            this.panel2.TabIndex = 9;
            // 
            // cbb_khoa
            // 
            this.cbb_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_khoa.DropDownWidth = 279;
            this.cbb_khoa.Enabled = false;
            this.cbb_khoa.Location = new System.Drawing.Point(189, 199);
            this.cbb_khoa.Name = "cbb_khoa";
            this.cbb_khoa.Size = new System.Drawing.Size(335, 25);
            this.cbb_khoa.TabIndex = 31;
            // 
            // txt_noidung
            // 
            this.txt_noidung.Enabled = false;
            this.txt_noidung.Location = new System.Drawing.Point(741, 45);
            this.txt_noidung.MaximumSize = new System.Drawing.Size(335, 68);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_noidung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_noidung.Size = new System.Drawing.Size(335, 68);
            this.txt_noidung.TabIndex = 30;
            // 
            // cbb_doituong
            // 
            this.cbb_doituong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_doituong.DropDownWidth = 279;
            this.cbb_doituong.Enabled = false;
            this.cbb_doituong.Items.AddRange(new object[] {
            "Sinh Viên",
            "Giảng Viên"});
            this.cbb_doituong.Location = new System.Drawing.Point(189, 147);
            this.cbb_doituong.Name = "cbb_doituong";
            this.cbb_doituong.Size = new System.Drawing.Size(335, 25);
            this.cbb_doituong.TabIndex = 29;
            // 
            // cbb_loaithongbao
            // 
            this.cbb_loaithongbao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaithongbao.DropDownWidth = 279;
            this.cbb_loaithongbao.Enabled = false;
            this.cbb_loaithongbao.Items.AddRange(new object[] {
            "Thông báo quan trọng",
            "Thông báo chung",
            "Cảnh báo"});
            this.cbb_loaithongbao.Location = new System.Drawing.Point(741, 199);
            this.cbb_loaithongbao.Name = "cbb_loaithongbao";
            this.cbb_loaithongbao.Size = new System.Drawing.Size(335, 25);
            this.cbb_loaithongbao.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(599, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 22);
            this.label13.TabIndex = 27;
            this.label13.Text = "Loại thông báo";
            // 
            // dtp_ngayhethan
            // 
            this.dtp_ngayhethan.CalendarTodayDate = new System.DateTime(2023, 11, 8, 0, 0, 0, 0);
            this.dtp_ngayhethan.Enabled = false;
            this.dtp_ngayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayhethan.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.dtp_ngayhethan.Location = new System.Drawing.Point(741, 144);
            this.dtp_ngayhethan.Name = "dtp_ngayhethan";
            this.dtp_ngayhethan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dtp_ngayhethan.Size = new System.Drawing.Size(335, 25);
            this.dtp_ngayhethan.TabIndex = 22;
            this.dtp_ngayhethan.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(189, 90);
            this.txt_id.Name = "txt_id";
            this.txt_id.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_id.Size = new System.Drawing.Size(335, 27);
            this.txt_id.TabIndex = 17;
            this.txt_id.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(599, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ngày hết hạn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(599, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nội dung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đối tượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID thông báo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thông tin";
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
            this.label2.Size = new System.Drawing.Size(300, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản lý thông báo";
            // 
            // thongBaoTableAdapter
            // 
            this.thongBaoTableAdapter.ClearBeforeFill = true;
            // 
            // UC_QuanLyThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_quanlymonhoc);
            this.Name = "UC_QuanLyThongBao";
            this.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlymonhoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongbao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongBaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_doituong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_loaithongbao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_quanlymonhoc;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_thongbao;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_luu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_sua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_huy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_them;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xoa;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_loaithongbao;
        private System.Windows.Forms.Label label13;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_ngayhethan;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource thongBaoBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.ThongBaoTableAdapter thongBaoTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_doituong;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_khoa;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_noidung;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapNhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiThongBaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doiTuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
    }
}
