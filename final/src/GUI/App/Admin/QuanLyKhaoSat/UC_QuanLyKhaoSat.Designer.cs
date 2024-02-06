namespace FinalProject.App.Admin.QuanLyKhaoSat
{
    partial class UC_QuanLyKhaoSat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_quanlylichthi = new System.Windows.Forms.Panel();
            this.dgv_monhoc = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.monHocTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter();
            this.txt_id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_idmh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.monhocidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xemkhaosat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pn_quanlylichthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_quanlylichthi
            // 
            this.pn_quanlylichthi.AutoScroll = true;
            this.pn_quanlylichthi.BackColor = System.Drawing.Color.White;
            this.pn_quanlylichthi.Controls.Add(this.dgv_monhoc);
            this.pn_quanlylichthi.Controls.Add(this.panel4);
            this.pn_quanlylichthi.Controls.Add(this.panel1);
            this.pn_quanlylichthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_quanlylichthi.Location = new System.Drawing.Point(0, 0);
            this.pn_quanlylichthi.Name = "pn_quanlylichthi";
            this.pn_quanlylichthi.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlylichthi.TabIndex = 5;
            // 
            // dgv_monhoc
            // 
            this.dgv_monhoc.AllowUserToAddRows = false;
            this.dgv_monhoc.AllowUserToDeleteRows = false;
            this.dgv_monhoc.AllowUserToOrderColumns = true;
            this.dgv_monhoc.AllowUserToResizeColumns = false;
            this.dgv_monhoc.AllowUserToResizeRows = false;
            this.dgv_monhoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_monhoc.AutoGenerateColumns = false;
            this.dgv_monhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_monhoc.ColumnHeadersHeight = 44;
            this.dgv_monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_monhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monhocidDataGridViewTextBoxColumn,
            this.tenMonhocDataGridViewTextBoxColumn,
            this.xemkhaosat});
            this.dgv_monhoc.DataSource = this.monHocBindingSource;
            this.dgv_monhoc.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_monhoc.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_monhoc.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_monhoc.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_monhoc.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_monhoc.HideOuterBorders = true;
            this.dgv_monhoc.Location = new System.Drawing.Point(51, 165);
            this.dgv_monhoc.MultiSelect = false;
            this.dgv_monhoc.Name = "dgv_monhoc";
            this.dgv_monhoc.RowHeadersVisible = false;
            this.dgv_monhoc.RowHeadersWidth = 51;
            this.dgv_monhoc.RowTemplate.Height = 36;
            this.dgv_monhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_monhoc.Size = new System.Drawing.Size(1083, 150);
            this.dgv_monhoc.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_monhoc.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_monhoc.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.dgv_monhoc.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
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
            this.dgv_monhoc.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgv_monhoc.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgv_monhoc.TabIndex = 22;
            this.dgv_monhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_monhoc_CellContentClick);
            this.dgv_monhoc.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_monhoc_CellPainting);
            this.dgv_monhoc.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_monhoc_DataBindingComplete);
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 94);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản lý Khảo sát";
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
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
            // txt_idmh
            // 
            this.txt_idmh.Location = new System.Drawing.Point(189, 142);
            this.txt_idmh.Name = "txt_idmh";
            this.txt_idmh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.txt_idmh.Size = new System.Drawing.Size(335, 27);
            this.txt_idmh.TabIndex = 30;
            this.txt_idmh.WordWrap = false;
            // 
            // monhocidDataGridViewTextBoxColumn
            // 
            this.monhocidDataGridViewTextBoxColumn.DataPropertyName = "Mã môn";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.monhocidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.monhocidDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.monhocidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monhocidDataGridViewTextBoxColumn.Name = "monhocidDataGridViewTextBoxColumn";
            this.monhocidDataGridViewTextBoxColumn.ReadOnly = true;
            this.monhocidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tenMonhocDataGridViewTextBoxColumn
            // 
            this.tenMonhocDataGridViewTextBoxColumn.DataPropertyName = "Tên môn";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tenMonhocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tenMonhocDataGridViewTextBoxColumn.HeaderText = "Tên môn học";
            this.tenMonhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonhocDataGridViewTextBoxColumn.Name = "tenMonhocDataGridViewTextBoxColumn";
            this.tenMonhocDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenMonhocDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // xemkhaosat
            // 
            this.xemkhaosat.FillWeight = 50F;
            this.xemkhaosat.HeaderText = "Xem khảo sát";
            this.xemkhaosat.MinimumWidth = 3;
            this.xemkhaosat.Name = "xemkhaosat";
            this.xemkhaosat.Text = "Xem khảo sát";
            this.xemkhaosat.UseColumnTextForButtonValue = true;
            // 
            // UC_QuanLyKhaoSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_quanlylichthi);
            this.Name = "UC_QuanLyKhaoSat";
            this.Size = new System.Drawing.Size(1218, 1012);
            this.pn_quanlylichthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_quanlylichthi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_monhoc;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_id;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_idmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhocidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn xemkhaosat;
    }
}
