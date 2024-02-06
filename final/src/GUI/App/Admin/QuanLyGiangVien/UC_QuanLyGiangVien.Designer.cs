namespace FinalProject.App.Admin.QuanLyGiangVien
{
    partial class UC_QuanLyGiangVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_quanlysinhvien = new System.Windows.Forms.Panel();
            this.pn_quanlysinhvien_content = new System.Windows.Forms.Panel();
            this.txt_slchon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_listgiangvien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiGvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editSinhVien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_searchsv = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_xoagiangvien = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_addgiangvien = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.giangVienTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.GiangVienTableAdapter();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pn_quanlysinhvien.SuspendLayout();
            this.pn_quanlysinhvien_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listgiangvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_quanlysinhvien
            // 
            this.pn_quanlysinhvien.AutoScroll = true;
            this.pn_quanlysinhvien.BackColor = System.Drawing.Color.White;
            this.pn_quanlysinhvien.Controls.Add(this.pn_quanlysinhvien_content);
            this.pn_quanlysinhvien.Controls.Add(this.panel1);
            this.pn_quanlysinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlysinhvien.Location = new System.Drawing.Point(0, 0);
            this.pn_quanlysinhvien.Name = "pn_quanlysinhvien";
            this.pn_quanlysinhvien.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlysinhvien.TabIndex = 1;
            // 
            // pn_quanlysinhvien_content
            // 
            this.pn_quanlysinhvien_content.Controls.Add(this.kryptonButton1);
            this.pn_quanlysinhvien_content.Controls.Add(this.txt_slchon);
            this.pn_quanlysinhvien_content.Controls.Add(this.label2);
            this.pn_quanlysinhvien_content.Controls.Add(this.dgv_listgiangvien);
            this.pn_quanlysinhvien_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlysinhvien_content.Location = new System.Drawing.Point(0, 188);
            this.pn_quanlysinhvien_content.Name = "pn_quanlysinhvien_content";
            this.pn_quanlysinhvien_content.Size = new System.Drawing.Size(1218, 824);
            this.pn_quanlysinhvien_content.TabIndex = 1;
            // 
            // txt_slchon
            // 
            this.txt_slchon.AutoSize = true;
            this.txt_slchon.BackColor = System.Drawing.Color.White;
            this.txt_slchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slchon.ForeColor = System.Drawing.Color.Red;
            this.txt_slchon.Location = new System.Drawing.Point(167, 45);
            this.txt_slchon.Name = "txt_slchon";
            this.txt_slchon.Size = new System.Drawing.Size(23, 25);
            this.txt_slchon.TabIndex = 2;
            this.txt_slchon.Text = "0";
            this.txt_slchon.Click += new System.EventHandler(this.txt_slchon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn:";
            // 
            // dgv_listgiangvien
            // 
            this.dgv_listgiangvien.AllowUserToAddRows = false;
            this.dgv_listgiangvien.AllowUserToDeleteRows = false;
            this.dgv_listgiangvien.AllowUserToResizeColumns = false;
            this.dgv_listgiangvien.AllowUserToResizeRows = false;
            this.dgv_listgiangvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listgiangvien.AutoGenerateColumns = false;
            this.dgv_listgiangvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listgiangvien.ColumnHeadersHeight = 44;
            this.dgv_listgiangvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_listgiangvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.gvidDataGridViewTextBoxColumn,
            this.tenSinhVien,
            this.loaiGvDataGridViewTextBoxColumn,
            this.khoaidDataGridViewTextBoxColumn,
            this.user_id,
            this.editSinhVien});
            this.dgv_listgiangvien.DataSource = this.giangVienBindingSource;
            this.dgv_listgiangvien.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_listgiangvien.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_listgiangvien.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_listgiangvien.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_listgiangvien.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_listgiangvien.HideOuterBorders = true;
            this.dgv_listgiangvien.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgv_listgiangvien.Location = new System.Drawing.Point(98, 94);
            this.dgv_listgiangvien.MultiSelect = false;
            this.dgv_listgiangvien.Name = "dgv_listgiangvien";
            this.dgv_listgiangvien.RowHeadersVisible = false;
            this.dgv_listgiangvien.RowHeadersWidth = 51;
            this.dgv_listgiangvien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_listgiangvien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_listgiangvien.RowTemplate.Height = 40;
            this.dgv_listgiangvien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listgiangvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listgiangvien.Size = new System.Drawing.Size(1007, 150);
            this.dgv_listgiangvien.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_listgiangvien.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_listgiangvien.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.LightGray;
            this.dgv_listgiangvien.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.LightGray;
            this.dgv_listgiangvien.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.dgv_listgiangvien.StateCommon.DataCell.Border.Width = 1;
            this.dgv_listgiangvien.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Tan;
            this.dgv_listgiangvien.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Tan;
            this.dgv_listgiangvien.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Tan;
            this.dgv_listgiangvien.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Tan;
            this.dgv_listgiangvien.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_listgiangvien.StateCommon.HeaderColumn.Border.Rounding = 0;
            this.dgv_listgiangvien.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.dgv_listgiangvien.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_listgiangvien.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Gray;
            this.dgv_listgiangvien.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.Gray;
            this.dgv_listgiangvien.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_listgiangvien.StateCommon.HeaderRow.Border.Width = 1;
            this.dgv_listgiangvien.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.Tan;
            this.dgv_listgiangvien.StatePressed.HeaderColumn.Back.Color2 = System.Drawing.Color.Tan;
            this.dgv_listgiangvien.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgv_listgiangvien.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgv_listgiangvien.StateSelected.HeaderColumn.Back.Color1 = System.Drawing.Color.Tan;
            this.dgv_listgiangvien.StateSelected.HeaderColumn.Back.Color2 = System.Drawing.Color.Tan;
            this.dgv_listgiangvien.TabIndex = 0;
            this.dgv_listgiangvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listgiangvien_CellContentClick);
            this.dgv_listgiangvien.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listgiangvien_CellMouseEnter);
            this.dgv_listgiangvien.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listgiangvien_CellMouseLeave);
            this.dgv_listgiangvien.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_listgiangvien_CellPainting);
            this.dgv_listgiangvien.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listgiangvien_CellValueChanged);
            this.dgv_listgiangvien.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_listgiangvien_CurrentCellDirtyStateChanged);
            this.dgv_listgiangvien.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_listgiangvien_DataBindingComplete);
            // 
            // check
            // 
            this.check.HeaderText = "Chọn";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            // 
            // gvidDataGridViewTextBoxColumn
            // 
            this.gvidDataGridViewTextBoxColumn.DataPropertyName = "gv_id";
            this.gvidDataGridViewTextBoxColumn.HeaderText = "Mã số";
            this.gvidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gvidDataGridViewTextBoxColumn.Name = "gvidDataGridViewTextBoxColumn";
            this.gvidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSinhVien
            // 
            this.tenSinhVien.DataPropertyName = "hovaten";
            this.tenSinhVien.HeaderText = "Họ tên";
            this.tenSinhVien.MinimumWidth = 6;
            this.tenSinhVien.Name = "tenSinhVien";
            this.tenSinhVien.ReadOnly = true;
            this.tenSinhVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tenSinhVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // loaiGvDataGridViewTextBoxColumn
            // 
            this.loaiGvDataGridViewTextBoxColumn.DataPropertyName = "loaiGv";
            this.loaiGvDataGridViewTextBoxColumn.HeaderText = "Loại ";
            this.loaiGvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiGvDataGridViewTextBoxColumn.Name = "loaiGvDataGridViewTextBoxColumn";
            this.loaiGvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // khoaidDataGridViewTextBoxColumn
            // 
            this.khoaidDataGridViewTextBoxColumn.DataPropertyName = "khoa_id";
            this.khoaidDataGridViewTextBoxColumn.HeaderText = "Mã khoa";
            this.khoaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khoaidDataGridViewTextBoxColumn.Name = "khoaidDataGridViewTextBoxColumn";
            this.khoaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            // 
            // editSinhVien
            // 
            this.editSinhVien.FillWeight = 20F;
            this.editSinhVien.HeaderText = "";
            this.editSinhVien.MinimumWidth = 3;
            this.editSinhVien.Name = "editSinhVien";
            this.editSinhVien.ToolTipText = "Edit";
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_searchsv);
            this.panel1.Controls.Add(this.btn_xoagiangvien);
            this.panel1.Controls.Add(this.btn_addgiangvien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 188);
            this.panel1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(1000, 130);
            this.btn_search.Name = "btn_search";
            this.btn_search.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_search.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_search.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_search.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_search.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_search.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_search.OverrideDefault.Border.Rounding = 16;
            this.btn_search.OverrideDefault.Border.Width = 1;
            this.btn_search.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_search.Size = new System.Drawing.Size(115, 39);
            this.btn_search.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_search.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_search.StateCommon.Back.ColorAngle = 45F;
            this.btn_search.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_search.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_search.StateCommon.Border.ColorAngle = 45F;
            this.btn_search.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_search.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_search.StateCommon.Border.Rounding = 16;
            this.btn_search.StateCommon.Border.Width = 1;
            this.btn_search.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_search.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_search.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_search.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_search.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_search.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btn_search.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btn_search.StatePressed.Back.ColorAngle = 45F;
            this.btn_search.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btn_search.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btn_search.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_search.StatePressed.Border.Rounding = 16;
            this.btn_search.StatePressed.Border.Width = 1;
            this.btn_search.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.btn_search.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.btn_search.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.btn_search.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.btn_search.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_search.StateTracking.Border.Rounding = 16;
            this.btn_search.TabIndex = 7;
            this.btn_search.Values.Text = "Tìm kiếm";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_searchsv
            // 
            this.txt_searchsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchsv.Location = new System.Drawing.Point(732, 129);
            this.txt_searchsv.Name = "txt_searchsv";
            this.txt_searchsv.Size = new System.Drawing.Size(262, 42);
            this.txt_searchsv.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_searchsv.StateCommon.Border.Rounding = 12;
            this.txt_searchsv.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchsv.TabIndex = 6;
            this.txt_searchsv.TextChanged += new System.EventHandler(this.txt_searchsv_TextChanged);
            // 
            // btn_xoagiangvien
            // 
            this.btn_xoagiangvien.Location = new System.Drawing.Point(337, 130);
            this.btn_xoagiangvien.Name = "btn_xoagiangvien";
            this.btn_xoagiangvien.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xoagiangvien.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xoagiangvien.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xoagiangvien.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xoagiangvien.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xoagiangvien.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_xoagiangvien.OverrideDefault.Border.Rounding = 16;
            this.btn_xoagiangvien.OverrideDefault.Border.Width = 1;
            this.btn_xoagiangvien.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_xoagiangvien.Size = new System.Drawing.Size(213, 39);
            this.btn_xoagiangvien.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xoagiangvien.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xoagiangvien.StateCommon.Back.ColorAngle = 45F;
            this.btn_xoagiangvien.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xoagiangvien.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xoagiangvien.StateCommon.Border.ColorAngle = 45F;
            this.btn_xoagiangvien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xoagiangvien.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_xoagiangvien.StateCommon.Border.Rounding = 16;
            this.btn_xoagiangvien.StateCommon.Border.Width = 1;
            this.btn_xoagiangvien.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_xoagiangvien.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_xoagiangvien.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoagiangvien.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xoagiangvien.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xoagiangvien.StatePressed.Back.ColorAngle = 45F;
            this.btn_xoagiangvien.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xoagiangvien.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xoagiangvien.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xoagiangvien.StatePressed.Border.Rounding = 16;
            this.btn_xoagiangvien.StatePressed.Border.Width = 1;
            this.btn_xoagiangvien.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xoagiangvien.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xoagiangvien.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xoagiangvien.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xoagiangvien.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xoagiangvien.StateTracking.Border.Rounding = 16;
            this.btn_xoagiangvien.TabIndex = 5;
            this.btn_xoagiangvien.Values.Text = "Xoá giảng viên";
            this.btn_xoagiangvien.Click += new System.EventHandler(this.btn_xoagiangvien_Click);
            // 
            // btn_addgiangvien
            // 
            this.btn_addgiangvien.Location = new System.Drawing.Point(98, 130);
            this.btn_addgiangvien.Name = "btn_addgiangvien";
            this.btn_addgiangvien.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_addgiangvien.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_addgiangvien.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_addgiangvien.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_addgiangvien.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addgiangvien.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_addgiangvien.OverrideDefault.Border.Rounding = 16;
            this.btn_addgiangvien.OverrideDefault.Border.Width = 1;
            this.btn_addgiangvien.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_addgiangvien.Size = new System.Drawing.Size(213, 39);
            this.btn_addgiangvien.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_addgiangvien.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_addgiangvien.StateCommon.Back.ColorAngle = 45F;
            this.btn_addgiangvien.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_addgiangvien.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.btn_addgiangvien.StateCommon.Border.ColorAngle = 45F;
            this.btn_addgiangvien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addgiangvien.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_addgiangvien.StateCommon.Border.Rounding = 16;
            this.btn_addgiangvien.StateCommon.Border.Width = 1;
            this.btn_addgiangvien.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_addgiangvien.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_addgiangvien.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addgiangvien.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btn_addgiangvien.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btn_addgiangvien.StatePressed.Back.ColorAngle = 45F;
            this.btn_addgiangvien.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btn_addgiangvien.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btn_addgiangvien.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addgiangvien.StatePressed.Border.Rounding = 16;
            this.btn_addgiangvien.StatePressed.Border.Width = 1;
            this.btn_addgiangvien.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.btn_addgiangvien.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.btn_addgiangvien.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.btn_addgiangvien.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.btn_addgiangvien.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addgiangvien.StateTracking.Border.Rounding = 16;
            this.btn_addgiangvien.TabIndex = 4;
            this.btn_addgiangvien.Values.Text = "Thêm giảng viên";
            this.btn_addgiangvien.Click += new System.EventHandler(this.btn_addgiangvien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý giảng viên";
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(892, 31);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideDefault.Border.Rounding = 16;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(213, 39);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 16;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.kryptonButton1.StatePressed.Back.ColorAngle = 45F;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 16;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(77)))));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 16;
            this.kryptonButton1.TabIndex = 5;
            this.kryptonButton1.Values.Text = "Export";
            this.kryptonButton1.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // UC_QuanLyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_quanlysinhvien);
            this.Name = "UC_QuanLyGiangVien";
            this.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlysinhvien.ResumeLayout(false);
            this.pn_quanlysinhvien_content.ResumeLayout(false);
            this.pn_quanlysinhvien_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listgiangvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_quanlysinhvien;
        private System.Windows.Forms.Panel pn_quanlysinhvien_content;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_listgiangvien;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_search;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_searchsv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xoagiangvien;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_addgiangvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiGvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn editSinhVien;
        public System.Windows.Forms.Label txt_slchon;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
