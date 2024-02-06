namespace FinalProject.App.Main.HocPhi
{
    partial class UC_HocPhi
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
            this.pn_hocphi = new System.Windows.Forms.Panel();
            this.txt_trangthai = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_chiphi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_mahoadon = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgv_hocphi = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thanhtoan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.HoaDonTableAdapter();
            this.chiTietHoaDonTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.ChiTietHoaDonTableAdapter();
            this.monhoc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocPhiMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_hocphi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocphi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_hocphi
            // 
            this.pn_hocphi.AutoScroll = true;
            this.pn_hocphi.BackColor = System.Drawing.Color.White;
            this.pn_hocphi.Controls.Add(this.txt_trangthai);
            this.pn_hocphi.Controls.Add(this.txt_chiphi);
            this.pn_hocphi.Controls.Add(this.txt_mahoadon);
            this.pn_hocphi.Controls.Add(this.kryptonLabel3);
            this.pn_hocphi.Controls.Add(this.kryptonLabel2);
            this.pn_hocphi.Controls.Add(this.kryptonLabel1);
            this.pn_hocphi.Controls.Add(this.dgv_hocphi);
            this.pn_hocphi.Controls.Add(this.panel1);
            this.pn_hocphi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_hocphi.Location = new System.Drawing.Point(0, 0);
            this.pn_hocphi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_hocphi.Name = "pn_hocphi";
            this.pn_hocphi.Size = new System.Drawing.Size(1219, 748);
            this.pn_hocphi.TabIndex = 0;
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.txt_trangthai.Location = new System.Drawing.Point(962, 150);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(196, 35);
            this.txt_trangthai.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.txt_trangthai.TabIndex = 23;
            this.txt_trangthai.Values.Text = "Chưa thanh toán";
            // 
            // txt_chiphi
            // 
            this.txt_chiphi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.txt_chiphi.Location = new System.Drawing.Point(594, 150);
            this.txt_chiphi.Name = "txt_chiphi";
            this.txt_chiphi.Size = new System.Drawing.Size(121, 35);
            this.txt_chiphi.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.txt_chiphi.TabIndex = 22;
            this.txt_chiphi.Values.Text = "18000000";
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.txt_mahoadon.Location = new System.Drawing.Point(209, 150);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(121, 35);
            this.txt_mahoadon.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.txt_mahoadon.TabIndex = 21;
            this.txt_mahoadon.Values.Text = "00000000";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(824, 150);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(132, 35);
            this.kryptonLabel3.TabIndex = 20;
            this.kryptonLabel3.Values.Text = "Trạng thái:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(432, 150);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(156, 35);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "Tổng chi phí:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(51, 150);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(152, 35);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Mã hoá đơn:";
            // 
            // dgv_hocphi
            // 
            this.dgv_hocphi.AllowUserToAddRows = false;
            this.dgv_hocphi.AllowUserToDeleteRows = false;
            this.dgv_hocphi.AllowUserToResizeColumns = false;
            this.dgv_hocphi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_hocphi.AutoGenerateColumns = false;
            this.dgv_hocphi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hocphi.ColumnHeadersHeight = 44;
            this.dgv_hocphi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_hocphi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monhoc_id,
            this.tenMonhoc,
            this.hocPhiMon});
            this.dgv_hocphi.DataSource = this.chiTietHoaDonBindingSource;
            this.dgv_hocphi.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_hocphi.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_hocphi.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_hocphi.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_hocphi.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_hocphi.HideOuterBorders = true;
            this.dgv_hocphi.Location = new System.Drawing.Point(51, 254);
            this.dgv_hocphi.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_hocphi.MultiSelect = false;
            this.dgv_hocphi.Name = "dgv_hocphi";
            this.dgv_hocphi.ReadOnly = true;
            this.dgv_hocphi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_hocphi.RowHeadersVisible = false;
            this.dgv_hocphi.RowHeadersWidth = 51;
            this.dgv_hocphi.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.dgv_hocphi.RowTemplate.Height = 44;
            this.dgv_hocphi.RowTemplate.ReadOnly = true;
            this.dgv_hocphi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hocphi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hocphi.Size = new System.Drawing.Size(1107, 75);
            this.dgv_hocphi.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_hocphi.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgv_hocphi.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_hocphi.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.DarkKhaki;
            this.dgv_hocphi.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.DarkKhaki;
            this.dgv_hocphi.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_hocphi.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_hocphi.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_hocphi.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_hocphi.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgv_hocphi.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgv_hocphi.TabIndex = 17;
            this.dgv_hocphi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hocphi_CellContentClick);
            this.dgv_hocphi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_hocphi_DataBindingComplete);
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.chiTietHoaDonBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_thanhtoan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 112);
            this.panel1.TabIndex = 9;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thanhtoan.Location = new System.Drawing.Point(962, 44);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_thanhtoan.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_thanhtoan.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_thanhtoan.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_thanhtoan.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_thanhtoan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_thanhtoan.Size = new System.Drawing.Size(196, 49);
            this.btn_thanhtoan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_thanhtoan.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_thanhtoan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_thanhtoan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btn_thanhtoan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_thanhtoan.StateCommon.Border.Rounding = 8;
            this.btn_thanhtoan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_thanhtoan.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_thanhtoan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_thanhtoan.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_thanhtoan.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.btn_thanhtoan.StateDisabled.Border.Color2 = System.Drawing.Color.Silver;
            this.btn_thanhtoan.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_thanhtoan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.btn_thanhtoan.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.btn_thanhtoan.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.btn_thanhtoan.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.btn_thanhtoan.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_thanhtoan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.btn_thanhtoan.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.btn_thanhtoan.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.btn_thanhtoan.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.btn_thanhtoan.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_thanhtoan.TabIndex = 24;
            this.btn_thanhtoan.Values.Text = "Thanh toán học phí";
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Học phí";
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietHoaDonTableAdapter
            // 
            this.chiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // monhoc_id
            // 
            this.monhoc_id.DataPropertyName = "monhoc_id";
            this.monhoc_id.HeaderText = "Mã môn học";
            this.monhoc_id.MinimumWidth = 6;
            this.monhoc_id.Name = "monhoc_id";
            this.monhoc_id.ReadOnly = true;
            // 
            // tenMonhoc
            // 
            this.tenMonhoc.DataPropertyName = "tenMonhoc";
            this.tenMonhoc.HeaderText = "Tên môn học";
            this.tenMonhoc.MinimumWidth = 6;
            this.tenMonhoc.Name = "tenMonhoc";
            this.tenMonhoc.ReadOnly = true;
            // 
            // hocPhiMon
            // 
            this.hocPhiMon.DataPropertyName = "hocPhiMon";
            this.hocPhiMon.HeaderText = "Học phí";
            this.hocPhiMon.MinimumWidth = 6;
            this.hocPhiMon.Name = "hocPhiMon";
            this.hocPhiMon.ReadOnly = true;
            // 
            // UC_HocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_hocphi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_HocPhi";
            this.Size = new System.Drawing.Size(1219, 748);
            this.Load += new System.EventHandler(this.UC_HocPhi_Load);
            this.pn_hocphi.ResumeLayout(false);
            this.pn_hocphi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hocphi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_hocphi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_hocphi;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_mahoadon;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_trangthai;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_chiphi;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private QLHTTTSV_TDT_DataSetTableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_thanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhoc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocPhiMon;
    }
}
