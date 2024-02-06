namespace FinalProject.App.GiangVien.DiemDanh
{
    partial class UC_DiemDanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_diemdanh = new System.Windows.Forms.Panel();
            this.btn_luu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_vang = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_tongsv = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgv_diemdanh = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sVMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.SinhVienTableAdapter();
            this.sV_MHTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.SV_MHTableAdapter();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.pn_diemdanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemdanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_diemdanh
            // 
            this.pn_diemdanh.BackColor = System.Drawing.Color.White;
            this.pn_diemdanh.Controls.Add(this.cbb_lop);
            this.pn_diemdanh.Controls.Add(this.btn_luu);
            this.pn_diemdanh.Controls.Add(this.txt_vang);
            this.pn_diemdanh.Controls.Add(this.txt_tongsv);
            this.pn_diemdanh.Controls.Add(this.dgv_diemdanh);
            this.pn_diemdanh.Controls.Add(this.kryptonLabel4);
            this.pn_diemdanh.Controls.Add(this.kryptonLabel3);
            this.pn_diemdanh.Controls.Add(this.kryptonLabel2);
            this.pn_diemdanh.Controls.Add(this.kryptonLabel1);
            this.pn_diemdanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_diemdanh.Location = new System.Drawing.Point(0, 0);
            this.pn_diemdanh.Name = "pn_diemdanh";
            this.pn_diemdanh.Size = new System.Drawing.Size(1335, 739);
            this.pn_diemdanh.TabIndex = 0;
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_luu.Location = new System.Drawing.Point(1086, 126);
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
            this.btn_luu.TabIndex = 25;
            this.btn_luu.Values.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_vang
            // 
            this.txt_vang.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.txt_vang.Location = new System.Drawing.Point(528, 220);
            this.txt_vang.Name = "txt_vang";
            this.txt_vang.Size = new System.Drawing.Size(27, 35);
            this.txt_vang.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.txt_vang.TabIndex = 24;
            this.txt_vang.Values.Text = "0";
            // 
            // txt_tongsv
            // 
            this.txt_tongsv.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.txt_tongsv.Location = new System.Drawing.Point(155, 220);
            this.txt_tongsv.Name = "txt_tongsv";
            this.txt_tongsv.Size = new System.Drawing.Size(171, 35);
            this.txt_tongsv.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.txt_tongsv.TabIndex = 23;
            this.txt_tongsv.Values.Text = "kryptonLabel6";
            // 
            // dgv_diemdanh
            // 
            this.dgv_diemdanh.AllowUserToAddRows = false;
            this.dgv_diemdanh.AllowUserToDeleteRows = false;
            this.dgv_diemdanh.AllowUserToOrderColumns = true;
            this.dgv_diemdanh.AllowUserToResizeColumns = false;
            this.dgv_diemdanh.AllowUserToResizeRows = false;
            this.dgv_diemdanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_diemdanh.AutoGenerateColumns = false;
            this.dgv_diemdanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_diemdanh.ColumnHeadersHeight = 44;
            this.dgv_diemdanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_diemdanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.name,
            this.select});
            this.dgv_diemdanh.DataSource = this.sVMHBindingSource;
            this.dgv_diemdanh.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_diemdanh.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_diemdanh.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_diemdanh.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_diemdanh.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_diemdanh.HideOuterBorders = true;
            this.dgv_diemdanh.Location = new System.Drawing.Point(42, 284);
            this.dgv_diemdanh.MultiSelect = false;
            this.dgv_diemdanh.Name = "dgv_diemdanh";
            this.dgv_diemdanh.RowHeadersVisible = false;
            this.dgv_diemdanh.RowHeadersWidth = 51;
            this.dgv_diemdanh.RowTemplate.Height = 36;
            this.dgv_diemdanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_diemdanh.Size = new System.Drawing.Size(1177, 150);
            this.dgv_diemdanh.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_diemdanh.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_diemdanh.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_diemdanh.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_diemdanh.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_diemdanh.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dgv_diemdanh.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_diemdanh.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_diemdanh.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgv_diemdanh.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_diemdanh.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgv_diemdanh.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgv_diemdanh.TabIndex = 21;
            this.dgv_diemdanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diemdanh_CellValueChanged);
            this.dgv_diemdanh.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_diemdanh_CurrentCellDirtyStateChanged);
            this.dgv_diemdanh.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_diemdanh_DataBindingComplete);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.useridDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.useridDataGridViewTextBoxColumn.HeaderText = "Mã số sinh viên";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "hovaten";
            this.name.HeaderText = "Tên sinh viên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // select
            // 
            this.select.HeaderText = "Vắng";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            // 
            // sVMHBindingSource
            // 
            this.sVMHBindingSource.DataMember = "SV_MH";
            this.sVMHBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            this.sVMHBindingSource.CurrentChanged += new System.EventHandler(this.sVMHBindingSource_CurrentChanged);
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(445, 220);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(77, 35);
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "Vắng:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(42, 220);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(107, 35);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Tổng số:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(42, 119);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(119, 35);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Chọn lớp:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(42, 32);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(306, 40);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Điểm danh sinh viên";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            this.sinhVienBindingSource.CurrentChanged += new System.EventHandler(this.sinhVienBindingSource_CurrentChanged);
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // sV_MHTableAdapter
            // 
            this.sV_MHTableAdapter.ClearBeforeFill = true;
            // 
            // cbb_lop
            // 
            this.cbb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(167, 126);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(328, 28);
            this.cbb_lop.TabIndex = 29;
            this.cbb_lop.SelectedValueChanged += new System.EventHandler(this.cbb_lop_SelectedValueChanged);
            // 
            // UC_DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_diemdanh);
            this.Name = "UC_DiemDanh";
            this.Size = new System.Drawing.Size(1335, 739);
            this.pn_diemdanh.ResumeLayout(false);
            this.pn_diemdanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemdanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_diemdanh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLHTTTSV_TDT_DataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_diemdanh;
        private System.Windows.Forms.BindingSource sVMHBindingSource;
        private QLHTTTSV_TDT_DataSetTableAdapters.SV_MHTableAdapter sV_MHTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_tongsv;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_vang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.ComboBox cbb_lop;
    }
}
