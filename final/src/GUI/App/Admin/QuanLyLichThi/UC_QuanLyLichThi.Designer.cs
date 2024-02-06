namespace FinalProject.App.Admin.QuanLyLichThi
{
    partial class UC_QuanLyLichThi
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
            this.thongBaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.thongBaoTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.ThongBaoTableAdapter();
            this.pn_quanlylichthi = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_lichthi = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lichthiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhthucthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhoc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lichThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_luu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_huy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_them = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_xoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_phong = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_tg = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idmh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbb_hinhthucthi = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_ngaythi = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txt_id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lichThiTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.LichThiTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.thongBaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.pn_quanlylichthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_hinhthucthi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // thongBaoTableAdapter
            // 
            this.thongBaoTableAdapter.ClearBeforeFill = true;
            // 
            // pn_quanlylichthi
            // 
            this.pn_quanlylichthi.AutoScroll = true;
            this.pn_quanlylichthi.BackColor = System.Drawing.Color.White;
            this.pn_quanlylichthi.Controls.Add(this.panel4);
            this.pn_quanlylichthi.Controls.Add(this.dgv_lichthi);
            this.pn_quanlylichthi.Controls.Add(this.panel3);
            this.pn_quanlylichthi.Controls.Add(this.panel2);
            this.pn_quanlylichthi.Controls.Add(this.panel1);
            this.pn_quanlylichthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlylichthi.Location = new System.Drawing.Point(0, 0);
            this.pn_quanlylichthi.Name = "pn_quanlylichthi";
            this.pn_quanlylichthi.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlylichthi.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 974);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1218, 38);
            this.panel4.TabIndex = 21;
            // 
            // dgv_lichthi
            // 
            this.dgv_lichthi.AllowUserToAddRows = false;
            this.dgv_lichthi.AllowUserToDeleteRows = false;
            this.dgv_lichthi.AllowUserToOrderColumns = true;
            this.dgv_lichthi.AllowUserToResizeColumns = false;
            this.dgv_lichthi.AllowUserToResizeRows = false;
            this.dgv_lichthi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_lichthi.AutoGenerateColumns = false;
            this.dgv_lichthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lichthi.ColumnHeadersHeight = 44;
            this.dgv_lichthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_lichthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.lichthiidDataGridViewTextBoxColumn,
            this.ngayThi,
            this.thoiGianThi,
            this.diaDiemThi,
            this.hinhthucthi,
            this.monhoc_id});
            this.dgv_lichthi.DataSource = this.lichThiBindingSource;
            this.dgv_lichthi.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_lichthi.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_lichthi.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_lichthi.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_lichthi.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_lichthi.HideOuterBorders = true;
            this.dgv_lichthi.Location = new System.Drawing.Point(51, 528);
            this.dgv_lichthi.MultiSelect = false;
            this.dgv_lichthi.Name = "dgv_lichthi";
            this.dgv_lichthi.RowHeadersVisible = false;
            this.dgv_lichthi.RowHeadersWidth = 51;
            this.dgv_lichthi.RowTemplate.Height = 36;
            this.dgv_lichthi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lichthi.Size = new System.Drawing.Size(1083, 150);
            this.dgv_lichthi.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_lichthi.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_lichthi.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_lichthi.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_lichthi.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_lichthi.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dgv_lichthi.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_lichthi.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_lichthi.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgv_lichthi.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_lichthi.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgv_lichthi.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgv_lichthi.TabIndex = 20;
            this.dgv_lichthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_licthi_CellContentClick);
            this.dgv_lichthi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lichthi_CellValueChanged);
            this.dgv_lichthi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_lichthi_DataBindingComplete);
            // 
            // select
            // 
            this.select.HeaderText = "Chọn";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            // 
            // lichthiidDataGridViewTextBoxColumn
            // 
            this.lichthiidDataGridViewTextBoxColumn.DataPropertyName = "lichthi_id";
            this.lichthiidDataGridViewTextBoxColumn.HeaderText = "lichthi_id";
            this.lichthiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lichthiidDataGridViewTextBoxColumn.Name = "lichthiidDataGridViewTextBoxColumn";
            this.lichthiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayThi
            // 
            this.ngayThi.DataPropertyName = "ngayThi";
            this.ngayThi.HeaderText = "Ngày thi";
            this.ngayThi.MinimumWidth = 6;
            this.ngayThi.Name = "ngayThi";
            this.ngayThi.ReadOnly = true;
            // 
            // thoiGianThi
            // 
            this.thoiGianThi.DataPropertyName = "thoiGianThi";
            this.thoiGianThi.HeaderText = "Thời gian thi";
            this.thoiGianThi.MinimumWidth = 6;
            this.thoiGianThi.Name = "thoiGianThi";
            this.thoiGianThi.ReadOnly = true;
            // 
            // diaDiemThi
            // 
            this.diaDiemThi.DataPropertyName = "diaDiemThi";
            this.diaDiemThi.HeaderText = "Phòng thi";
            this.diaDiemThi.MinimumWidth = 6;
            this.diaDiemThi.Name = "diaDiemThi";
            this.diaDiemThi.ReadOnly = true;
            // 
            // hinhthucthi
            // 
            this.hinhthucthi.DataPropertyName = "hinhthucthi";
            this.hinhthucthi.HeaderText = "Hình thức thi";
            this.hinhthucthi.MinimumWidth = 6;
            this.hinhthucthi.Name = "hinhthucthi";
            this.hinhthucthi.ReadOnly = true;
            // 
            // monhoc_id
            // 
            this.monhoc_id.DataPropertyName = "monhoc_id";
            this.monhoc_id.HeaderText = "Mã môn học";
            this.monhoc_id.MinimumWidth = 6;
            this.monhoc_id.Name = "monhoc_id";
            this.monhoc_id.ReadOnly = true;
            // 
            // lichThiBindingSource
            // 
            this.lichThiBindingSource.DataMember = "LichThi";
            this.lichThiBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_luu);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_huy);
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 446);
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
            this.panel2.Controls.Add(this.txt_phong);
            this.panel2.Controls.Add(this.txt_tg);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_idmh);
            this.panel2.Controls.Add(this.cbb_hinhthucthi);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtp_ngaythi);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 352);
            this.panel2.TabIndex = 9;
            // 
            // txt_phong
            // 
            this.txt_phong.Location = new System.Drawing.Point(741, 90);
            this.txt_phong.Name = "txt_phong";
            this.txt_phong.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_phong.Size = new System.Drawing.Size(335, 27);
            this.txt_phong.TabIndex = 35;
            this.txt_phong.WordWrap = false;
            // 
            // txt_tg
            // 
            this.txt_tg.Location = new System.Drawing.Point(741, 194);
            this.txt_tg.Name = "txt_tg";
            this.txt_tg.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_tg.Size = new System.Drawing.Size(335, 27);
            this.txt_tg.TabIndex = 34;
            this.txt_tg.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(599, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Thời gian thi";
            // 
            // txt_idmh
            // 
            this.txt_idmh.Location = new System.Drawing.Point(189, 142);
            this.txt_idmh.Name = "txt_idmh";
            this.txt_idmh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_idmh.Size = new System.Drawing.Size(335, 27);
            this.txt_idmh.TabIndex = 30;
            this.txt_idmh.WordWrap = false;
            // 
            // cbb_hinhthucthi
            // 
            this.cbb_hinhthucthi.DropDownWidth = 279;
            this.cbb_hinhthucthi.Items.AddRange(new object[] {
            "Thi Giữa Kỳ",
            "Thi Cuối Kỳ"});
            this.cbb_hinhthucthi.Location = new System.Drawing.Point(189, 196);
            this.cbb_hinhthucthi.Name = "cbb_hinhthucthi";
            this.cbb_hinhthucthi.Size = new System.Drawing.Size(335, 25);
            this.cbb_hinhthucthi.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 22);
            this.label13.TabIndex = 27;
            this.label13.Text = "Hình thức thi";
            // 
            // dtp_ngaythi
            // 
            this.dtp_ngaythi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaythi.Location = new System.Drawing.Point(741, 144);
            this.dtp_ngaythi.Name = "dtp_ngaythi";
            this.dtp_ngaythi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dtp_ngaythi.Size = new System.Drawing.Size(335, 25);
            this.dtp_ngaythi.TabIndex = 22;
            this.dtp_ngaythi.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            // 
            // txt_id
            // 
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
            this.label11.Size = new System.Drawing.Size(76, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ngày thi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mã môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(599, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phòng thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID lịch thi";
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
            this.label2.Size = new System.Drawing.Size(247, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản lý lịch thi";
            // 
            // lichThiTableAdapter
            // 
            this.lichThiTableAdapter.ClearBeforeFill = true;
            // 
            // UC_QuanLyLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_quanlylichthi);
            this.Name = "UC_QuanLyLichThi";
            this.Size = new System.Drawing.Size(1218, 1012);
            ((System.ComponentModel.ISupportInitialize)(this.thongBaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.pn_quanlylichthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_hinhthucthi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource thongBaoBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.ThongBaoTableAdapter thongBaoTableAdapter;
        private System.Windows.Forms.Panel pn_quanlylichthi;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_lichthi;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_luu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_sua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_huy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_them;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xoa;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_idmh;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_hinhthucthi;
        private System.Windows.Forms.Label label13;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_ngaythi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource lichThiBindingSource;
        private QLHTTTSV_TDT_DataSetTableAdapters.LichThiTableAdapter lichThiTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_tg;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_phong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn lichthiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhthucthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhoc_id;
    }
}
