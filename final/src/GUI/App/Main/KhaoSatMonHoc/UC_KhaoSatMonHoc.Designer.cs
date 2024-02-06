namespace FinalProject.App.Main.KhaoSatMonHoc
{
    partial class UC_KhaoSatMonHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_khaosatmonhoc = new System.Windows.Forms.Panel();
            this.dgv_khaosatmonhoc = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.monhocidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_desc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.khaoSatMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khaoSatMonHocTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.KhaoSatMonHocTableAdapter();
            this.monHocTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter();
            this.pn_khaosatmonhoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khaosatmonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khaoSatMonHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_khaosatmonhoc
            // 
            this.pn_khaosatmonhoc.AutoScroll = true;
            this.pn_khaosatmonhoc.BackColor = System.Drawing.Color.White;
            this.pn_khaosatmonhoc.Controls.Add(this.dgv_khaosatmonhoc);
            this.pn_khaosatmonhoc.Controls.Add(this.panel1);
            this.pn_khaosatmonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_khaosatmonhoc.Location = new System.Drawing.Point(0, 0);
            this.pn_khaosatmonhoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_khaosatmonhoc.Name = "pn_khaosatmonhoc";
            this.pn_khaosatmonhoc.Size = new System.Drawing.Size(914, 608);
            this.pn_khaosatmonhoc.TabIndex = 0;
            // 
            // dgv_khaosatmonhoc
            // 
            this.dgv_khaosatmonhoc.AllowUserToAddRows = false;
            this.dgv_khaosatmonhoc.AllowUserToDeleteRows = false;
            this.dgv_khaosatmonhoc.AllowUserToResizeColumns = false;
            this.dgv_khaosatmonhoc.AllowUserToResizeRows = false;
            this.dgv_khaosatmonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_khaosatmonhoc.AutoGenerateColumns = false;
            this.dgv_khaosatmonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khaosatmonhoc.ColumnHeadersHeight = 44;
            this.dgv_khaosatmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_khaosatmonhoc.ColumnHeadersVisible = false;
            this.dgv_khaosatmonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monhocidDataGridViewTextBoxColumn,
            this.tenMonhocDataGridViewTextBoxColumn,
            this.tinChiDataGridViewTextBoxColumn,
            this.Column1});
            this.dgv_khaosatmonhoc.DataSource = this.monHocBindingSource;
            this.dgv_khaosatmonhoc.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_khaosatmonhoc.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_khaosatmonhoc.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_khaosatmonhoc.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_khaosatmonhoc.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_khaosatmonhoc.HideOuterBorders = true;
            this.dgv_khaosatmonhoc.Location = new System.Drawing.Point(38, 298);
            this.dgv_khaosatmonhoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_khaosatmonhoc.MultiSelect = false;
            this.dgv_khaosatmonhoc.Name = "dgv_khaosatmonhoc";
            this.dgv_khaosatmonhoc.ReadOnly = true;
            this.dgv_khaosatmonhoc.RowHeadersVisible = false;
            this.dgv_khaosatmonhoc.RowHeadersWidth = 51;
            this.dgv_khaosatmonhoc.RowTemplate.Height = 40;
            this.dgv_khaosatmonhoc.RowTemplate.ReadOnly = true;
            this.dgv_khaosatmonhoc.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_khaosatmonhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_khaosatmonhoc.Size = new System.Drawing.Size(806, 67);
            this.dgv_khaosatmonhoc.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_khaosatmonhoc.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_khaosatmonhoc.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_khaosatmonhoc.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_khaosatmonhoc.TabIndex = 9;
            this.dgv_khaosatmonhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khaosatmonhoc_CellContentClick);
            this.dgv_khaosatmonhoc.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_khaosatmonhoc_DataBindingComplete);
            // 
            // monhocidDataGridViewTextBoxColumn
            // 
            this.monhocidDataGridViewTextBoxColumn.DataPropertyName = "monhoc_id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.monhocidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.monhocidDataGridViewTextBoxColumn.FillWeight = 103.5418F;
            this.monhocidDataGridViewTextBoxColumn.HeaderText = "Mã môn hoc";
            this.monhocidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monhocidDataGridViewTextBoxColumn.Name = "monhocidDataGridViewTextBoxColumn";
            this.monhocidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenMonhocDataGridViewTextBoxColumn
            // 
            this.tenMonhocDataGridViewTextBoxColumn.DataPropertyName = "tenMonhoc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tenMonhocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tenMonhocDataGridViewTextBoxColumn.FillWeight = 126.8387F;
            this.tenMonhocDataGridViewTextBoxColumn.HeaderText = "Tên môn học";
            this.tenMonhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonhocDataGridViewTextBoxColumn.Name = "tenMonhocDataGridViewTextBoxColumn";
            this.tenMonhocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinChiDataGridViewTextBoxColumn
            // 
            this.tinChiDataGridViewTextBoxColumn.DataPropertyName = "tinChi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tinChiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tinChiDataGridViewTextBoxColumn.FillWeight = 126.8387F;
            this.tinChiDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ";
            this.tinChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinChiDataGridViewTextBoxColumn.Name = "tinChiDataGridViewTextBoxColumn";
            this.tinChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 42.78075F;
            this.Column1.HeaderText = "Khảo sát";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Khảo sát";
            this.Column1.UseColumnTextForButtonValue = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_desc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 277);
            this.panel1.TabIndex = 8;
            // 
            // txt_desc
            // 
            this.txt_desc.AllowDrop = true;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(35, 83);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(75, 19);
            this.txt_desc.TabIndex = 6;
            this.txt_desc.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khảo sát";
            // 
            // khaoSatMonHocBindingSource
            // 
            this.khaoSatMonHocBindingSource.DataMember = "KhaoSatMonHoc";
            this.khaoSatMonHocBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // khaoSatMonHocTableAdapter
            // 
            this.khaoSatMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // UC_KhaoSatMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_khaosatmonhoc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_KhaoSatMonHoc";
            this.Size = new System.Drawing.Size(914, 608);
            this.Load += new System.EventHandler(this.UC_KhaoSatMonHoc_Load);
            this.pn_khaosatmonhoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khaosatmonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khaoSatMonHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_khaosatmonhoc;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_khaosatmonhoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource khaoSatMonHocBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.KhaoSatMonHocTableAdapter khaoSatMonHocTableAdapter;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLHTTTSV_TDT_DataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhocidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label txt_desc;
    }
}
