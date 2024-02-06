namespace FinalProject.App.Main
{
    partial class UC_DangKyMonHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DangKyMonHoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_dkmh = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.pn_dkmh = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_notification = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xacnhandk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.monHocTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.monhocidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dkmh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.pn_dkmh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dkmh
            // 
            this.dgv_dkmh.AllowUserToAddRows = false;
            this.dgv_dkmh.AllowUserToDeleteRows = false;
            this.dgv_dkmh.AllowUserToResizeColumns = false;
            this.dgv_dkmh.AllowUserToResizeRows = false;
            this.dgv_dkmh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dkmh.AutoGenerateColumns = false;
            this.dgv_dkmh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dkmh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_dkmh.ColumnHeadersHeight = 44;
            this.dgv_dkmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_dkmh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.monhocidDataGridViewTextBoxColumn,
            this.tenMonhocDataGridViewTextBoxColumn,
            this.tinChiDataGridViewTextBoxColumn,
            this.LichHoc});
            this.dgv_dkmh.DataSource = this.monHocBindingSource;
            this.dgv_dkmh.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_dkmh.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_dkmh.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_dkmh.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_dkmh.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_dkmh.HideOuterBorders = true;
            this.dgv_dkmh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_dkmh.Location = new System.Drawing.Point(51, 401);
            this.dgv_dkmh.MultiSelect = false;
            this.dgv_dkmh.Name = "dgv_dkmh";
            this.dgv_dkmh.RowHeadersVisible = false;
            this.dgv_dkmh.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.dgv_dkmh.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_dkmh.RowTemplate.Height = 40;
            this.dgv_dkmh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dkmh.Size = new System.Drawing.Size(1102, 76);
            this.dgv_dkmh.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_dkmh.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgv_dkmh.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_dkmh.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_dkmh.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_dkmh.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_dkmh.TabIndex = 0;
            this.dgv_dkmh.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_dkmh_DataBindingComplete);
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pn_dkmh
            // 
            this.pn_dkmh.AutoScroll = true;
            this.pn_dkmh.AutoSize = true;
            this.pn_dkmh.BackColor = System.Drawing.Color.White;
            this.pn_dkmh.Controls.Add(this.panel2);
            this.pn_dkmh.Controls.Add(this.label3);
            this.pn_dkmh.Controls.Add(this.dgv_dkmh);
            this.pn_dkmh.Controls.Add(this.panel1);
            this.pn_dkmh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_dkmh.Location = new System.Drawing.Point(0, 0);
            this.pn_dkmh.Name = "pn_dkmh";
            this.pn_dkmh.Size = new System.Drawing.Size(1218, 1200);
            this.pn_dkmh.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Controls.Add(this.txt_notification);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 194);
            this.panel2.TabIndex = 6;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AllowDrop = true;
            this.kryptonLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonLabel3.Location = new System.Drawing.Point(51, 123);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(1909, 44);
            this.kryptonLabel3.TabIndex = 9;
            this.kryptonLabel3.Values.Text = resources.GetString("kryptonLabel3.Values.Text");
            this.kryptonLabel3.Visible = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AllowDrop = true;
            this.kryptonLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonLabel2.Location = new System.Drawing.Point(51, 81);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(5016, 24);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = resources.GetString("kryptonLabel2.Values.Text");
            this.kryptonLabel2.Visible = false;
            this.kryptonLabel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel2_Paint);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AllowDrop = true;
            this.kryptonLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonLabel1.Location = new System.Drawing.Point(51, 33);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(1479, 24);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = resources.GetString("kryptonLabel1.Values.Text");
            this.kryptonLabel1.Visible = false;
            // 
            // txt_notification
            // 
            this.txt_notification.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.txt_notification.Location = new System.Drawing.Point(51, 3);
            this.txt_notification.Name = "txt_notification";
            this.txt_notification.Size = new System.Drawing.Size(1117, 24);
            this.txt_notification.TabIndex = 6;
            this.txt_notification.Values.Text = "NHỮNG ĐIỀU SINH VIÊN CẦN LƯU Ý KHI ĐĂNG KÝ MÔN HỌC - REMARKABLE TERMS AND CONDITI" +
    "ONS WHEN CONFIRMING COURSES REGISTRATION";
            this.txt_notification.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Môn học sẽ mở";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_xacnhandk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 141);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đăng ký môn học";
            // 
            // btn_xacnhandk
            // 
            this.btn_xacnhandk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xacnhandk.Location = new System.Drawing.Point(962, 75);
            this.btn_xacnhandk.Name = "btn_xacnhandk";
            this.btn_xacnhandk.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xacnhandk.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xacnhandk.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xacnhandk.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xacnhandk.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xacnhandk.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_xacnhandk.OverrideDefault.Border.Rounding = 16;
            this.btn_xacnhandk.OverrideDefault.Border.Width = 1;
            this.btn_xacnhandk.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_xacnhandk.Size = new System.Drawing.Size(191, 39);
            this.btn_xacnhandk.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xacnhandk.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xacnhandk.StateCommon.Back.ColorAngle = 45F;
            this.btn_xacnhandk.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xacnhandk.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_xacnhandk.StateCommon.Border.ColorAngle = 45F;
            this.btn_xacnhandk.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xacnhandk.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_xacnhandk.StateCommon.Border.Rounding = 16;
            this.btn_xacnhandk.StateCommon.Border.Width = 1;
            this.btn_xacnhandk.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_xacnhandk.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_xacnhandk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhandk.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xacnhandk.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xacnhandk.StatePressed.Back.ColorAngle = 45F;
            this.btn_xacnhandk.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xacnhandk.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_xacnhandk.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xacnhandk.StatePressed.Border.Rounding = 16;
            this.btn_xacnhandk.StatePressed.Border.Width = 1;
            this.btn_xacnhandk.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xacnhandk.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xacnhandk.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xacnhandk.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_xacnhandk.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_xacnhandk.StateTracking.Border.Rounding = 16;
            this.btn_xacnhandk.TabIndex = 1;
            this.btn_xacnhandk.Values.Text = "Xác nhận đăng ký";
            this.btn_xacnhandk.Click += new System.EventHandler(this.btn_xacnhandk_Click);
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // Chon
            // 
            this.Chon.FillWeight = 50F;
            this.Chon.HeaderText = "Chọn";
            this.Chon.MinimumWidth = 6;
            this.Chon.Name = "Chon";
            // 
            // monhocidDataGridViewTextBoxColumn
            // 
            this.monhocidDataGridViewTextBoxColumn.DataPropertyName = "Mã môn";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.monhocidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.monhocidDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.monhocidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monhocidDataGridViewTextBoxColumn.Name = "monhocidDataGridViewTextBoxColumn";
            this.monhocidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenMonhocDataGridViewTextBoxColumn
            // 
            this.tenMonhocDataGridViewTextBoxColumn.DataPropertyName = "Tên môn";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tenMonhocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tenMonhocDataGridViewTextBoxColumn.HeaderText = "Tên môn học";
            this.tenMonhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonhocDataGridViewTextBoxColumn.Name = "tenMonhocDataGridViewTextBoxColumn";
            this.tenMonhocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinChiDataGridViewTextBoxColumn
            // 
            this.tinChiDataGridViewTextBoxColumn.DataPropertyName = "Số tín chỉ";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tinChiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tinChiDataGridViewTextBoxColumn.HeaderText = "Số tính chỉ";
            this.tinChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinChiDataGridViewTextBoxColumn.Name = "tinChiDataGridViewTextBoxColumn";
            this.tinChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LichHoc
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.LichHoc.DefaultCellStyle = dataGridViewCellStyle4;
            this.LichHoc.HeaderText = "Lịch học";
            this.LichHoc.MinimumWidth = 6;
            this.LichHoc.Name = "LichHoc";
            this.LichHoc.ReadOnly = true;
            // 
            // UC_DangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pn_dkmh);
            this.Name = "UC_DangKyMonHoc";
            this.Size = new System.Drawing.Size(1218, 1200);
            this.Load += new System.EventHandler(this.UC_DangKyMonHoc_Load);
            this.Resize += new System.EventHandler(this.UC_DangKyMonHoc_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dkmh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.pn_dkmh.ResumeLayout(false);
            this.pn_dkmh.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_dkmh;
        private System.Windows.Forms.Panel pn_dkmh;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xacnhandk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel txt_notification;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhocidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LichHoc;
    }
}
