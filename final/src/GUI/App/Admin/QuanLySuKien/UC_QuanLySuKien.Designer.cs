namespace FinalProject.App.Admin.QuanLySuKien
{
    partial class UC_QuanLySuKien
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
            this.pn_quanlysukien = new System.Windows.Forms.Panel();
            this.pn_quanlymonhoc = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_drl = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.sKDRLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_luu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_huy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_them = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_xoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_tg = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbb_loaidiem = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_ngaytochuc = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txt_sodiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_tensk = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.monHocTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sKDRLTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.SKDRLTableAdapter();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dRLidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTochucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGiantochucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_quanlysukien.SuspendLayout();
            this.pn_quanlymonhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDRLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_loaidiem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_quanlysukien
            // 
            this.pn_quanlysukien.AutoScroll = true;
            this.pn_quanlysukien.BackColor = System.Drawing.Color.White;
            this.pn_quanlysukien.Controls.Add(this.pn_quanlymonhoc);
            this.pn_quanlysukien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlysukien.Location = new System.Drawing.Point(0, 0);
            this.pn_quanlysukien.Name = "pn_quanlysukien";
            this.pn_quanlysukien.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlysukien.TabIndex = 0;
            // 
            // pn_quanlymonhoc
            // 
            this.pn_quanlymonhoc.AutoScroll = true;
            this.pn_quanlymonhoc.BackColor = System.Drawing.Color.White;
            this.pn_quanlymonhoc.Controls.Add(this.panel4);
            this.pn_quanlymonhoc.Controls.Add(this.dgv_drl);
            this.pn_quanlymonhoc.Controls.Add(this.panel3);
            this.pn_quanlymonhoc.Controls.Add(this.panel2);
            this.pn_quanlymonhoc.Controls.Add(this.panel1);
            this.pn_quanlymonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlymonhoc.Location = new System.Drawing.Point(0, 0);
            this.pn_quanlymonhoc.Name = "pn_quanlymonhoc";
            this.pn_quanlymonhoc.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlymonhoc.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 974);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1218, 38);
            this.panel4.TabIndex = 21;
            // 
            // dgv_drl
            // 
            this.dgv_drl.AllowUserToAddRows = false;
            this.dgv_drl.AllowUserToDeleteRows = false;
            this.dgv_drl.AllowUserToOrderColumns = true;
            this.dgv_drl.AllowUserToResizeColumns = false;
            this.dgv_drl.AllowUserToResizeRows = false;
            this.dgv_drl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_drl.AutoGenerateColumns = false;
            this.dgv_drl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_drl.ColumnHeadersHeight = 44;
            this.dgv_drl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_drl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.dRLidDataGridViewTextBoxColumn,
            this.tenSKDataGridViewTextBoxColumn,
            this.loaiDRLDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.ngayTochucDataGridViewTextBoxColumn,
            this.thoiGiantochucDataGridViewTextBoxColumn});
            this.dgv_drl.DataSource = this.sKDRLBindingSource;
            this.dgv_drl.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_drl.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_drl.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_drl.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_drl.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_drl.HideOuterBorders = true;
            this.dgv_drl.Location = new System.Drawing.Point(51, 482);
            this.dgv_drl.MultiSelect = false;
            this.dgv_drl.Name = "dgv_drl";
            this.dgv_drl.RowHeadersVisible = false;
            this.dgv_drl.RowHeadersWidth = 51;
            this.dgv_drl.RowTemplate.Height = 36;
            this.dgv_drl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_drl.Size = new System.Drawing.Size(1083, 150);
            this.dgv_drl.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_drl.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_drl.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_drl.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_drl.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_drl.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dgv_drl.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_drl.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_drl.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgv_drl.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_drl.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgv_drl.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgv_drl.TabIndex = 20;
            this.dgv_drl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_drl_CellContentClick);
            this.dgv_drl.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_drl_CellValueChanged);
            this.dgv_drl.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_drl_DataBindingComplete);
            // 
            // sKDRLBindingSource
            // 
            this.sKDRLBindingSource.DataMember = "SKDRL";
            this.sKDRLBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
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
            this.panel2.Controls.Add(this.txt_tg);
            this.panel2.Controls.Add(this.cbb_loaidiem);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtp_ngaytochuc);
            this.panel2.Controls.Add(this.txt_sodiem);
            this.panel2.Controls.Add(this.txt_tensk);
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
            // txt_tg
            // 
            this.txt_tg.Location = new System.Drawing.Point(741, 142);
            this.txt_tg.Name = "txt_tg";
            this.txt_tg.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_tg.Size = new System.Drawing.Size(335, 27);
            this.txt_tg.TabIndex = 29;
            this.txt_tg.WordWrap = false;
            // 
            // cbb_loaidiem
            // 
            this.cbb_loaidiem.DropDownWidth = 279;
            this.cbb_loaidiem.Location = new System.Drawing.Point(741, 199);
            this.cbb_loaidiem.Name = "cbb_loaidiem";
            this.cbb_loaidiem.Size = new System.Drawing.Size(335, 25);
            this.cbb_loaidiem.TabIndex = 28;
            this.cbb_loaidiem.Text = "kryptonComboBox1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(599, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 22);
            this.label13.TabIndex = 27;
            this.label13.Text = "Loại điểm";
            // 
            // dtp_ngaytochuc
            // 
            this.dtp_ngaytochuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaytochuc.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.dtp_ngaytochuc.Location = new System.Drawing.Point(741, 88);
            this.dtp_ngaytochuc.Name = "dtp_ngaytochuc";
            this.dtp_ngaytochuc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dtp_ngaytochuc.Size = new System.Drawing.Size(335, 25);
            this.dtp_ngaytochuc.TabIndex = 21;
            this.dtp_ngaytochuc.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            // 
            // txt_sodiem
            // 
            this.txt_sodiem.Location = new System.Drawing.Point(189, 199);
            this.txt_sodiem.Name = "txt_sodiem";
            this.txt_sodiem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_sodiem.Size = new System.Drawing.Size(335, 27);
            this.txt_sodiem.TabIndex = 19;
            this.txt_sodiem.WordWrap = false;
            // 
            // txt_tensk
            // 
            this.txt_tensk.Location = new System.Drawing.Point(189, 142);
            this.txt_tensk.Name = "txt_tensk";
            this.txt_tensk.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_tensk.Size = new System.Drawing.Size(335, 27);
            this.txt_tensk.TabIndex = 18;
            this.txt_tensk.WordWrap = false;
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
            this.label11.Size = new System.Drawing.Size(85, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Thời gian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(599, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày tổ chức";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên sự kiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID sự kiện";
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
            this.label2.Size = new System.Drawing.Size(495, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản lý sư kiện điểm rèn luyện";
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // monHocBindingSource1
            // 
            this.monHocBindingSource1.DataMember = "MonHoc";
            this.monHocBindingSource1.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // sKDRLTableAdapter
            // 
            this.sKDRLTableAdapter.ClearBeforeFill = true;
            // 
            // select
            // 
            this.select.HeaderText = "Chọn";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dRLidDataGridViewTextBoxColumn
            // 
            this.dRLidDataGridViewTextBoxColumn.DataPropertyName = "DRL_id";
            this.dRLidDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.dRLidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dRLidDataGridViewTextBoxColumn.Name = "dRLidDataGridViewTextBoxColumn";
            this.dRLidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSKDataGridViewTextBoxColumn
            // 
            this.tenSKDataGridViewTextBoxColumn.DataPropertyName = "tenSK";
            this.tenSKDataGridViewTextBoxColumn.HeaderText = "Tên sự kiện";
            this.tenSKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSKDataGridViewTextBoxColumn.Name = "tenSKDataGridViewTextBoxColumn";
            this.tenSKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiDRLDataGridViewTextBoxColumn
            // 
            this.loaiDRLDataGridViewTextBoxColumn.DataPropertyName = "loaiDRL";
            this.loaiDRLDataGridViewTextBoxColumn.HeaderText = "Loại điểm";
            this.loaiDRLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiDRLDataGridViewTextBoxColumn.Name = "loaiDRLDataGridViewTextBoxColumn";
            this.loaiDRLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayTochucDataGridViewTextBoxColumn
            // 
            this.ngayTochucDataGridViewTextBoxColumn.DataPropertyName = "ngayTochuc";
            this.ngayTochucDataGridViewTextBoxColumn.HeaderText = "Ngày tổ chức";
            this.ngayTochucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTochucDataGridViewTextBoxColumn.Name = "ngayTochucDataGridViewTextBoxColumn";
            this.ngayTochucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGiantochucDataGridViewTextBoxColumn
            // 
            this.thoiGiantochucDataGridViewTextBoxColumn.DataPropertyName = "thoiGiantochuc";
            this.thoiGiantochucDataGridViewTextBoxColumn.HeaderText = "Thời gian tổ chức";
            this.thoiGiantochucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGiantochucDataGridViewTextBoxColumn.Name = "thoiGiantochucDataGridViewTextBoxColumn";
            this.thoiGiantochucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UC_QuanLySuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_quanlysukien);
            this.Name = "UC_QuanLySuKien";
            this.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlysukien.ResumeLayout(false);
            this.pn_quanlymonhoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDRLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_loaidiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_quanlysukien;
        private System.Windows.Forms.Panel pn_quanlymonhoc;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_drl;
        private System.Windows.Forms.BindingSource sKDRLBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_luu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_sua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_huy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_them;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xoa;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_loaidiem;
        private System.Windows.Forms.Label label13;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtp_ngaytochuc;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_sodiem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_tensk;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private System.Windows.Forms.BindingSource monHocBindingSource1;
        private QLHTTTSV_TDT_DataSetTableAdapters.SKDRLTableAdapter sKDRLTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_tg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRLidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDRLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTochucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGiantochucDataGridViewTextBoxColumn;
    }
}
