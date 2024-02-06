namespace FinalProject.App.Admin.QuanLyKhaoSat
{
    partial class UC_KhaoSat
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
            this.dgv_khaosat = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksmhidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanXetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhocidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khaoSatMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_quaylai = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_tenMH = new System.Windows.Forms.Label();
            this.khaoSatMonHocTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.KhaoSatMonHocTableAdapter();
            this.pn_quanlylichthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khaosat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khaoSatMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_quanlylichthi
            // 
            this.pn_quanlylichthi.AutoScroll = true;
            this.pn_quanlylichthi.BackColor = System.Drawing.Color.White;
            this.pn_quanlylichthi.Controls.Add(this.dgv_khaosat);
            this.pn_quanlylichthi.Controls.Add(this.panel4);
            this.pn_quanlylichthi.Controls.Add(this.panel1);
            this.pn_quanlylichthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlylichthi.Location = new System.Drawing.Point(0, 0);
            this.pn_quanlylichthi.Name = "pn_quanlylichthi";
            this.pn_quanlylichthi.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlylichthi.TabIndex = 6;
            // 
            // dgv_khaosat
            // 
            this.dgv_khaosat.AllowUserToAddRows = false;
            this.dgv_khaosat.AllowUserToDeleteRows = false;
            this.dgv_khaosat.AllowUserToOrderColumns = true;
            this.dgv_khaosat.AllowUserToResizeColumns = false;
            this.dgv_khaosat.AllowUserToResizeRows = false;
            this.dgv_khaosat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_khaosat.AutoGenerateColumns = false;
            this.dgv_khaosat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khaosat.ColumnHeadersHeight = 44;
            this.dgv_khaosat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_khaosat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.ksmhidDataGridViewTextBoxColumn,
            this.nhanXetDataGridViewTextBoxColumn,
            this.monhocidDataGridViewTextBoxColumn});
            this.dgv_khaosat.DataSource = this.khaoSatMonHocBindingSource;
            this.dgv_khaosat.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_khaosat.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_khaosat.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_khaosat.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_khaosat.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_khaosat.HideOuterBorders = true;
            this.dgv_khaosat.Location = new System.Drawing.Point(51, 165);
            this.dgv_khaosat.MultiSelect = false;
            this.dgv_khaosat.Name = "dgv_khaosat";
            this.dgv_khaosat.ReadOnly = true;
            this.dgv_khaosat.RowHeadersVisible = false;
            this.dgv_khaosat.RowHeadersWidth = 51;
            this.dgv_khaosat.RowTemplate.Height = 36;
            this.dgv_khaosat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_khaosat.Size = new System.Drawing.Size(1083, 150);
            this.dgv_khaosat.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_khaosat.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_khaosat.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.dgv_khaosat.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.dgv_khaosat.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_khaosat.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_khaosat.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgv_khaosat.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dgv_khaosat.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgv_khaosat.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgv_khaosat.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dgv_khaosat.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_khaosat.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgv_khaosat.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgv_khaosat.TabIndex = 22;
            this.dgv_khaosat.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_khaosat_DataBindingComplete);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "Mã người gửi";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // ksmhidDataGridViewTextBoxColumn
            // 
            this.ksmhidDataGridViewTextBoxColumn.DataPropertyName = "ksmh_id";
            this.ksmhidDataGridViewTextBoxColumn.HeaderText = "Mã khảo sát";
            this.ksmhidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ksmhidDataGridViewTextBoxColumn.Name = "ksmhidDataGridViewTextBoxColumn";
            // 
            // nhanXetDataGridViewTextBoxColumn
            // 
            this.nhanXetDataGridViewTextBoxColumn.DataPropertyName = "nhanXet";
            this.nhanXetDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.nhanXetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhanXetDataGridViewTextBoxColumn.Name = "nhanXetDataGridViewTextBoxColumn";
            // 
            // monhocidDataGridViewTextBoxColumn
            // 
            this.monhocidDataGridViewTextBoxColumn.DataPropertyName = "monhoc_id";
            this.monhocidDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.monhocidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monhocidDataGridViewTextBoxColumn.Name = "monhocidDataGridViewTextBoxColumn";
            // 
            // khaoSatMonHocBindingSource
            // 
            this.khaoSatMonHocBindingSource.DataMember = "KhaoSatMonHoc";
            this.khaoSatMonHocBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_quaylai);
            this.panel1.Controls.Add(this.txt_tenMH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 94);
            this.panel1.TabIndex = 6;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quaylai.Location = new System.Drawing.Point(1001, 22);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_quaylai.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_quaylai.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_quaylai.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_quaylai.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_quaylai.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_quaylai.Size = new System.Drawing.Size(133, 39);
            this.btn_quaylai.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_quaylai.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_quaylai.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_quaylai.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(69)))));
            this.btn_quaylai.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_quaylai.StateCommon.Border.Rounding = 8;
            this.btn_quaylai.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_quaylai.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_quaylai.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_quaylai.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_quaylai.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.btn_quaylai.StateDisabled.Border.Color2 = System.Drawing.Color.Silver;
            this.btn_quaylai.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_quaylai.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(53)))), ((int)(((byte)(35)))));
            this.btn_quaylai.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(53)))), ((int)(((byte)(35)))));
            this.btn_quaylai.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(53)))), ((int)(((byte)(35)))));
            this.btn_quaylai.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(53)))), ((int)(((byte)(35)))));
            this.btn_quaylai.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_quaylai.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(70)))), ((int)(((byte)(49)))));
            this.btn_quaylai.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(70)))), ((int)(((byte)(49)))));
            this.btn_quaylai.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(70)))), ((int)(((byte)(49)))));
            this.btn_quaylai.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(70)))), ((int)(((byte)(49)))));
            this.btn_quaylai.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_quaylai.TabIndex = 21;
            this.btn_quaylai.Values.Text = "Quay lại";
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // txt_tenMH
            // 
            this.txt_tenMH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenMH.AutoSize = true;
            this.txt_tenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenMH.Location = new System.Drawing.Point(44, 23);
            this.txt_tenMH.Name = "txt_tenMH";
            this.txt_tenMH.Size = new System.Drawing.Size(184, 38);
            this.txt_tenMH.TabIndex = 5;
            this.txt_tenMH.Text = "Giải Tích 2";
            // 
            // khaoSatMonHocTableAdapter
            // 
            this.khaoSatMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // UC_KhaoSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_quanlylichthi);
            this.Name = "UC_KhaoSat";
            this.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlylichthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khaosat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khaoSatMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_quanlylichthi;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_khaosat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_tenMH;
        private System.Windows.Forms.BindingSource khaoSatMonHocBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_quaylai;
        private QLHTTTSV_TDT_DataSetTableAdapters.KhaoSatMonHocTableAdapter khaoSatMonHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksmhidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanXetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhocidDataGridViewTextBoxColumn;
    }
}
