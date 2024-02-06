namespace FinalProject.App.Main
{
    partial class UC_ThongBao
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
            this.pn_thongbao = new System.Windows.Forms.Panel();
            this.dgv_thongbao = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tb_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiThongBaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xemChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.thongBaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbb_doituong = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_loaithongbao = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbb_khoa = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.thongBaoTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.ThongBaoTableAdapter();
            this.pn_thongbao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongbao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongBaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_doituong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_loaithongbao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_khoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_thongbao
            // 
            this.pn_thongbao.AutoScroll = true;
            this.pn_thongbao.BackColor = System.Drawing.Color.White;
            this.pn_thongbao.Controls.Add(this.dgv_thongbao);
            this.pn_thongbao.Controls.Add(this.panel2);
            this.pn_thongbao.Controls.Add(this.panel1);
            this.pn_thongbao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_thongbao.Location = new System.Drawing.Point(0, 0);
            this.pn_thongbao.Name = "pn_thongbao";
            this.pn_thongbao.Size = new System.Drawing.Size(1218, 1200);
            this.pn_thongbao.TabIndex = 0;
            // 
            // dgv_thongbao
            // 
            this.dgv_thongbao.AllowUserToAddRows = false;
            this.dgv_thongbao.AllowUserToDeleteRows = false;
            this.dgv_thongbao.AllowUserToResizeColumns = false;
            this.dgv_thongbao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_thongbao.AutoGenerateColumns = false;
            this.dgv_thongbao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongbao.ColumnHeadersHeight = 44;
            this.dgv_thongbao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_thongbao.ColumnHeadersVisible = false;
            this.dgv_thongbao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tb_id,
            this.loaiThongBaoDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.xemChiTiet});
            this.dgv_thongbao.DataSource = this.thongBaoBindingSource;
            this.dgv_thongbao.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_thongbao.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_thongbao.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_thongbao.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_thongbao.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_thongbao.HideOuterBorders = true;
            this.dgv_thongbao.Location = new System.Drawing.Point(103, 359);
            this.dgv_thongbao.MultiSelect = false;
            this.dgv_thongbao.Name = "dgv_thongbao";
            this.dgv_thongbao.ReadOnly = true;
            this.dgv_thongbao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_thongbao.RowHeadersVisible = false;
            this.dgv_thongbao.RowHeadersWidth = 51;
            this.dgv_thongbao.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.dgv_thongbao.RowTemplate.Height = 44;
            this.dgv_thongbao.RowTemplate.ReadOnly = true;
            this.dgv_thongbao.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_thongbao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_thongbao.Size = new System.Drawing.Size(1021, 75);
            this.dgv_thongbao.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_thongbao.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgv_thongbao.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_thongbao.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_thongbao.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_thongbao.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.dgv_thongbao.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_thongbao.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgv_thongbao.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgv_thongbao.TabIndex = 16;
            this.dgv_thongbao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongbao_CellContentClick);
            this.dgv_thongbao.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_thongbao_DataBindingComplete);
            // 
            // tb_id
            // 
            this.tb_id.DataPropertyName = "tb_id";
            this.tb_id.FillWeight = 20F;
            this.tb_id.HeaderText = "ID";
            this.tb_id.MinimumWidth = 6;
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            // 
            // loaiThongBaoDataGridViewTextBoxColumn
            // 
            this.loaiThongBaoDataGridViewTextBoxColumn.DataPropertyName = "loaiThongBao";
            this.loaiThongBaoDataGridViewTextBoxColumn.FillWeight = 67.04546F;
            this.loaiThongBaoDataGridViewTextBoxColumn.HeaderText = "loaiThongBao";
            this.loaiThongBaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiThongBaoDataGridViewTextBoxColumn.Name = "loaiThongBaoDataGridViewTextBoxColumn";
            this.loaiThongBaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.loaiThongBaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "noiDung";
            this.noiDungDataGridViewTextBoxColumn.FillWeight = 134.0909F;
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "noiDung";
            this.noiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            this.noiDungDataGridViewTextBoxColumn.ReadOnly = true;
            this.noiDungDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "ngayTao";
            this.ngayTaoDataGridViewTextBoxColumn.FillWeight = 80.45454F;
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "ngayTao";
            this.ngayTaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayTaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // xemChiTiet
            // 
            this.xemChiTiet.FillWeight = 40.22727F;
            this.xemChiTiet.HeaderText = "Xem chi tiết";
            this.xemChiTiet.MinimumWidth = 6;
            this.xemChiTiet.Name = "xemChiTiet";
            this.xemChiTiet.ReadOnly = true;
            this.xemChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xemChiTiet.Text = "Xem chi tiết";
            this.xemChiTiet.UseColumnTextForButtonValue = true;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cbb_doituong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbb_loaithongbao);
            this.panel2.Controls.Add(this.cbb_khoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 203);
            this.panel2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(834, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Đối tượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Loại thông báo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Khoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Từ ngày:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(172, 166);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // cbb_doituong
            // 
            this.cbb_doituong.AllowButtonSpecToolTips = true;
            this.cbb_doituong.AlwaysActive = false;
            this.cbb_doituong.DropDownWidth = 121;
            this.cbb_doituong.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Dược",
            "Ngoại ngữ",
            "Quản trị kinh doanh"});
            this.cbb_doituong.Location = new System.Drawing.Point(941, 69);
            this.cbb_doituong.Name = "cbb_doituong";
            this.cbb_doituong.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.cbb_doituong.Size = new System.Drawing.Size(150, 26);
            this.cbb_doituong.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.Silver;
            this.cbb_doituong.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.Silver;
            this.cbb_doituong.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbb_doituong.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_doituong.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Silver;
            this.cbb_doituong.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Silver;
            this.cbb_doituong.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbb_doituong.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_doituong.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_doituong.TabIndex = 11;
            this.cbb_doituong.Text = "Đối tượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm:";
            // 
            // cbb_loaithongbao
            // 
            this.cbb_loaithongbao.AllowButtonSpecToolTips = true;
            this.cbb_loaithongbao.AlwaysActive = false;
            this.cbb_loaithongbao.DropDownWidth = 121;
            this.cbb_loaithongbao.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Dược",
            "Ngoại ngữ",
            "Quản trị kinh doanh"});
            this.cbb_loaithongbao.Location = new System.Drawing.Point(579, 69);
            this.cbb_loaithongbao.Name = "cbb_loaithongbao";
            this.cbb_loaithongbao.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.cbb_loaithongbao.Size = new System.Drawing.Size(173, 26);
            this.cbb_loaithongbao.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.Silver;
            this.cbb_loaithongbao.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.Silver;
            this.cbb_loaithongbao.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbb_loaithongbao.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loaithongbao.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Silver;
            this.cbb_loaithongbao.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Silver;
            this.cbb_loaithongbao.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbb_loaithongbao.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loaithongbao.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loaithongbao.TabIndex = 10;
            this.cbb_loaithongbao.Text = "Loại thông báo";
            // 
            // cbb_khoa
            // 
            this.cbb_khoa.AllowButtonSpecToolTips = true;
            this.cbb_khoa.AlwaysActive = false;
            this.cbb_khoa.DropDownWidth = 121;
            this.cbb_khoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Dược",
            "Ngoại ngữ",
            "Quản trị kinh doanh"});
            this.cbb_khoa.Location = new System.Drawing.Point(172, 69);
            this.cbb_khoa.Name = "cbb_khoa";
            this.cbb_khoa.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cbb_khoa.Size = new System.Drawing.Size(150, 26);
            this.cbb_khoa.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.Silver;
            this.cbb_khoa.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.Silver;
            this.cbb_khoa.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbb_khoa.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_khoa.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Silver;
            this.cbb_khoa.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Silver;
            this.cbb_khoa.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbb_khoa.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_khoa.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_khoa.TabIndex = 9;
            this.cbb_khoa.Text = "Khoa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 115);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thông báo";
            // 
            // thongBaoTableAdapter
            // 
            this.thongBaoTableAdapter.ClearBeforeFill = true;
            // 
            // UC_ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_thongbao);
            this.Name = "UC_ThongBao";
            this.Size = new System.Drawing.Size(1218, 1200);
            this.pn_thongbao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongbao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongBaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_doituong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_loaithongbao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_khoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_thongbao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_doituong;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_loaithongbao;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_khoa;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_thongbao;
        private System.Windows.Forms.BindingSource thongBaoBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.ThongBaoTableAdapter thongBaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tb_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiThongBaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn xemChiTiet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
