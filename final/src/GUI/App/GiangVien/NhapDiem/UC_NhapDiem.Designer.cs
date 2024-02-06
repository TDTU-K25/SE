namespace FinalProject.App.GiangVien.NhapDiem
{
    partial class UC_NhapDiem
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
            this.pn_nhapdiem = new System.Windows.Forms.Panel();
            this.btn_sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_luu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_diemdanh = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.diemThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.sV_MHTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.SV_MHTableAdapter();
            this.sinhVienTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.SinhVienTableAdapter();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVMHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diemThiTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.DiemThiTableAdapter();
            this.pn_nhapdiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemdanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_nhapdiem
            // 
            this.pn_nhapdiem.BackColor = System.Drawing.Color.White;
            this.pn_nhapdiem.Controls.Add(this.btn_sua);
            this.pn_nhapdiem.Controls.Add(this.btn_luu);
            this.pn_nhapdiem.Controls.Add(this.dgv_diemdanh);
            this.pn_nhapdiem.Controls.Add(this.cbbMon);
            this.pn_nhapdiem.Controls.Add(this.kryptonLabel1);
            this.pn_nhapdiem.Controls.Add(this.kryptonLabel2);
            this.pn_nhapdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_nhapdiem.Location = new System.Drawing.Point(0, 0);
            this.pn_nhapdiem.Name = "pn_nhapdiem";
            this.pn_nhapdiem.Size = new System.Drawing.Size(1335, 739);
            this.pn_nhapdiem.TabIndex = 0;
            // 
            
            // 
           
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
            this.dgv_diemdanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_diemdanh.ColumnHeadersHeight = 44;
            this.dgv_diemdanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_diemdanh.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_diemdanh.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_diemdanh.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_diemdanh.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_diemdanh.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_diemdanh.HideOuterBorders = true;
            this.dgv_diemdanh.Location = new System.Drawing.Point(42, 224);
            this.dgv_diemdanh.MultiSelect = false;
            this.dgv_diemdanh.Name = "dgv_diemdanh";
            this.dgv_diemdanh.RowHeadersVisible = false;
            this.dgv_diemdanh.RowHeadersWidth = 51;
            this.dgv_diemdanh.RowTemplate.Height = 36;
            this.dgv_diemdanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_diemdanh.Size = new System.Drawing.Size(1177, 308);
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
            this.dgv_diemdanh.TabIndex = 31;
            this.dgv_diemdanh.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diemdanh_CellEndEdit);
            this.dgv_diemdanh.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_diemdanh_EditingControlShowing);
            // 
            // cbbMon
            // 
            this.cbbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(155, 126);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(328, 28);
            this.cbbMon.TabIndex = 28;
            this.cbbMon.SelectedValueChanged += new System.EventHandler(this.cbbMon_SelectedValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(42, 32);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(304, 40);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 26;
            this.kryptonLabel1.Values.Text = "Bảng điểm sinh viên";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(42, 119);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(119, 35);
            this.kryptonLabel2.TabIndex = 27;
            this.kryptonLabel2.Values.Text = "Chọn lớp:";
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
            // sV_MHTableAdapter
            // 
            this.sV_MHTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // sVMHBindingSource
            // 
            this.sVMHBindingSource.DataMember = "SV_MH";
            this.sVMHBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // sVMHBindingSource1
            // 
            this.sVMHBindingSource1.DataMember = "SV_MH";
            this.sVMHBindingSource1.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // diemThiTableAdapter
            // 
            this.diemThiTableAdapter.ClearBeforeFill = true;
            // 
            // UC_NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_nhapdiem);
            this.Name = "UC_NhapDiem";
            this.Size = new System.Drawing.Size(1335, 739);
            this.pn_nhapdiem.ResumeLayout(false);
            this.pn_nhapdiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diemdanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVMHBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_nhapdiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_luu;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_diemdanh;
        private System.Windows.Forms.BindingSource sVMHBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private System.Windows.Forms.ComboBox cbbMon;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private QLHTTTSV_TDT_DataSetTableAdapters.SV_MHTableAdapter sV_MHTableAdapter;
        private QLHTTTSV_TDT_DataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.BindingSource diemThiBindingSource;
        private System.Windows.Forms.BindingSource sVMHBindingSource1;
        private QLHTTTSV_TDT_DataSetTableAdapters.DiemThiTableAdapter diemThiTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_sua;
    }
}
