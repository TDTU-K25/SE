namespace FinalProject.App.Admin.QuanLyMonHoc
{
    partial class UC_QuanLyMonHoc
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
            this.dgv_monhoc = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_luu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_huy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_them = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_xoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbThu = new System.Windows.Forms.ComboBox();
            this.txt_ca = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_phong = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dtp_ngayketthuc = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtp_ngaybatdau = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txt_hocphi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_sotinchi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_tenmh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.monHocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter();
            this.cbb_giangvien = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pn_quanlymonhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_quanlymonhoc
            // 
            this.pn_quanlymonhoc.AutoScroll = true;
            this.pn_quanlymonhoc.BackColor = System.Drawing.Color.White;
            this.pn_quanlymonhoc.Controls.Add(this.dgv_monhoc);
            this.pn_quanlymonhoc.Controls.Add(this.panel3);
            this.pn_quanlymonhoc.Controls.Add(this.panel2);
            this.pn_quanlymonhoc.Controls.Add(this.panel1);
            this.pn_quanlymonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlymonhoc.Location = new System.Drawing.Point(0, 0);
            this.pn_quanlymonhoc.Name = "pn_quanlymonhoc";
            this.pn_quanlymonhoc.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlymonhoc.TabIndex = 0;
            // 
            // dgv_monhoc
            // 
            this.dgv_monhoc.AllowUserToAddRows = false;
            this.dgv_monhoc.AllowUserToDeleteRows = false;
            this.dgv_monhoc.AllowUserToOrderColumns = true;
            this.dgv_monhoc.AllowUserToResizeColumns = false;
            this.dgv_monhoc.AllowUserToResizeRows = false;
            this.dgv_monhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_monhoc.ColumnHeadersHeight = 44;
            this.dgv_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_monhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            this.dgv_monhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_monhoc.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_monhoc.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_monhoc.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_monhoc.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_monhoc.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_monhoc.HideOuterBorders = true;
            this.dgv_monhoc.Location = new System.Drawing.Point(0, 621);
            this.dgv_monhoc.MultiSelect = false;
            this.dgv_monhoc.Name = "dgv_monhoc";
            this.dgv_monhoc.ReadOnly = true;
            this.dgv_monhoc.RowHeadersVisible = false;
            this.dgv_monhoc.RowHeadersWidth = 51;
            this.dgv_monhoc.RowTemplate.Height = 36;
            this.dgv_monhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_monhoc.Size = new System.Drawing.Size(1218, 391);
            this.dgv_monhoc.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_monhoc.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_monhoc.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_monhoc.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_monhoc.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_monhoc.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dgv_monhoc.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_monhoc.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_monhoc.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgv_monhoc.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_monhoc.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgv_monhoc.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgv_monhoc.TabIndex = 20;
            this.dgv_monhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_monhoc_CellContentClick);
            this.dgv_monhoc.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_monhoc_DataBindingComplete);
            // 
            // select
            // 
            this.select.HeaderText = "Chọn";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            this.select.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_luu);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_huy);
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1218, 118);
            this.panel3.TabIndex = 18;
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_luu.Location = new System.Drawing.Point(820, 50);
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
            this.btn_sua.Location = new System.Drawing.Point(461, 50);
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
            this.btn_huy.Location = new System.Drawing.Point(1004, 50);
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
            this.btn_them.Location = new System.Drawing.Point(281, 50);
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
            this.btn_xoa.Location = new System.Drawing.Point(641, 50);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 32);
            this.label12.TabIndex = 17;
            this.label12.Text = "Chức năng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbb_giangvien);
            this.panel2.Controls.Add(this.cbbThu);
            this.panel2.Controls.Add(this.txt_ca);
            this.panel2.Controls.Add(this.txt_phong);
            this.panel2.Controls.Add(this.dtp_ngayketthuc);
            this.panel2.Controls.Add(this.dtp_ngaybatdau);
            this.panel2.Controls.Add(this.txt_hocphi);
            this.panel2.Controls.Add(this.txt_sotinchi);
            this.panel2.Controls.Add(this.txt_tenmh);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 409);
            this.panel2.TabIndex = 9;
            // 
            // cbbThu
            // 
            this.cbbThu.FormattingEnabled = true;
            this.cbbThu.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7",
            "Chủ nhật"});
            this.cbbThu.Location = new System.Drawing.Point(732, 189);
            this.cbbThu.Name = "cbbThu";
            this.cbbThu.Size = new System.Drawing.Size(335, 24);
            this.cbbThu.TabIndex = 25;
            // 
            // txt_ca
            // 
            this.txt_ca.Location = new System.Drawing.Point(732, 128);
            this.txt_ca.Name = "txt_ca";
            this.txt_ca.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_ca.Size = new System.Drawing.Size(335, 27);
            this.txt_ca.TabIndex = 24;
            this.txt_ca.WordWrap = false;
            // 
            // txt_phong
            // 
            this.txt_phong.Location = new System.Drawing.Point(732, 71);
            this.txt_phong.Name = "txt_phong";
            this.txt_phong.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_phong.Size = new System.Drawing.Size(335, 27);
            this.txt_phong.TabIndex = 23;
            this.txt_phong.WordWrap = false;
            // 
            // dtp_ngayketthuc
            // 
            this.dtp_ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayketthuc.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.dtp_ngayketthuc.Location = new System.Drawing.Point(189, 356);
            this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
            this.dtp_ngayketthuc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dtp_ngayketthuc.Size = new System.Drawing.Size(335, 25);
            this.dtp_ngayketthuc.TabIndex = 22;
            this.dtp_ngayketthuc.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            // 
            // dtp_ngaybatdau
            // 
            this.dtp_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaybatdau.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.dtp_ngaybatdau.Location = new System.Drawing.Point(189, 303);
            this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
            this.dtp_ngaybatdau.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dtp_ngaybatdau.Size = new System.Drawing.Size(335, 25);
            this.dtp_ngaybatdau.TabIndex = 21;
            this.dtp_ngaybatdau.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            // 
            // txt_hocphi
            // 
            this.txt_hocphi.Location = new System.Drawing.Point(189, 241);
            this.txt_hocphi.Name = "txt_hocphi";
            this.txt_hocphi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_hocphi.Size = new System.Drawing.Size(335, 27);
            this.txt_hocphi.TabIndex = 20;
            this.txt_hocphi.WordWrap = false;
            // 
            // txt_sotinchi
            // 
            this.txt_sotinchi.Location = new System.Drawing.Point(189, 184);
            this.txt_sotinchi.Name = "txt_sotinchi";
            this.txt_sotinchi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_sotinchi.Size = new System.Drawing.Size(335, 27);
            this.txt_sotinchi.TabIndex = 19;
            this.txt_sotinchi.WordWrap = false;
            // 
            // txt_tenmh
            // 
            this.txt_tenmh.Location = new System.Drawing.Point(189, 123);
            this.txt_tenmh.Name = "txt_tenmh";
            this.txt_tenmh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_tenmh.Size = new System.Drawing.Size(335, 27);
            this.txt_tenmh.TabIndex = 18;
            this.txt_tenmh.WordWrap = false;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(189, 71);
            this.txt_id.Name = "txt_id";
            this.txt_id.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(335, 27);
            this.txt_id.TabIndex = 17;
            this.txt_id.WordWrap = false;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(579, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày trong tuần";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(579, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ca học";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(579, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phòng học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Học phí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số tín chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thông tin môn học";
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
            this.label2.Size = new System.Drawing.Size(279, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản lý môn học";
            // 
            // monHocBindingSource1
            // 
            this.monHocBindingSource1.DataMember = "MonHoc";
            this.monHocBindingSource1.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // cbb_giangvien
            // 
            this.cbb_giangvien.FormattingEnabled = true;
            this.cbb_giangvien.Location = new System.Drawing.Point(732, 241);
            this.cbb_giangvien.Name = "cbb_giangvien";
            this.cbb_giangvien.Size = new System.Drawing.Size(335, 24);
            this.cbb_giangvien.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(583, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Giảng viên";
            // 
            // UC_QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pn_quanlymonhoc);
            this.Name = "UC_QuanLyMonHoc";
            this.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlymonhoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_quanlymonhoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_them;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_luu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_sua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_huy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xoa;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_monhoc;
        private System.Windows.Forms.BindingSource monHocBindingSource1;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_ngaybatdau;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_hocphi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_sotinchi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_tenmh;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_id;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_ca;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_phong;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_ngayketthuc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.ComboBox cbbThu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbb_giangvien;
    }
}
