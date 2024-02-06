namespace FinalProject.Main
{
    partial class UC_DiemRenLuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_drl = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dRLidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTochucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGiantochucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKDRLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sKDRLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDTDataSet = new FinalProject.QLHTTTSV_TDTDataSet();
            this.qLHTTTSVTDTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKDRLTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.SKDRLTableAdapter();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDRLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDRLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSVTDTDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dgv_drl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 1022);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 71);
            this.panel4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(230, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng điểm rèn luyện:";
            // 
            // dgv_drl
            // 
            this.dgv_drl.AllowUserToAddRows = false;
            this.dgv_drl.AllowUserToDeleteRows = false;
            this.dgv_drl.AllowUserToResizeColumns = false;
            this.dgv_drl.AllowUserToResizeRows = false;
            this.dgv_drl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_drl.AutoGenerateColumns = false;
            this.dgv_drl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_drl.ColumnHeadersHeight = 44;
            this.dgv_drl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_drl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dRLidDataGridViewTextBoxColumn,
            this.loaiDRLDataGridViewTextBoxColumn,
            this.tenSKDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.ngayTochucDataGridViewTextBoxColumn,
            this.thoiGiantochucDataGridViewTextBoxColumn});
            this.dgv_drl.DataSource = this.sKDRLBindingSource1;
            this.dgv_drl.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgv_drl.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_drl.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_drl.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_drl.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dgv_drl.HideOuterBorders = true;
            this.dgv_drl.Location = new System.Drawing.Point(38, 165);
            this.dgv_drl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_drl.Name = "dgv_drl";
            this.dgv_drl.ReadOnly = true;
            this.dgv_drl.RowHeadersVisible = false;
            this.dgv_drl.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_drl.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_drl.RowTemplate.Height = 40;
            this.dgv_drl.RowTemplate.ReadOnly = true;
            this.dgv_drl.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_drl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_drl.Size = new System.Drawing.Size(828, 67);
            this.dgv_drl.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgv_drl.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgv_drl.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgv_drl.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgv_drl.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgv_drl.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.dgv_drl.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.LightSteelBlue;
            this.dgv_drl.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_drl.TabIndex = 18;
            this.dgv_drl.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_drl_DataBindingComplete);
            // 
            // dRLidDataGridViewTextBoxColumn
            // 
            this.dRLidDataGridViewTextBoxColumn.DataPropertyName = "DRL_id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dRLidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dRLidDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dRLidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.dRLidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dRLidDataGridViewTextBoxColumn.Name = "dRLidDataGridViewTextBoxColumn";
            this.dRLidDataGridViewTextBoxColumn.ReadOnly = true;
            this.dRLidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // loaiDRLDataGridViewTextBoxColumn
            // 
            this.loaiDRLDataGridViewTextBoxColumn.DataPropertyName = "loaiDRL";
            this.loaiDRLDataGridViewTextBoxColumn.HeaderText = "Loại điểm";
            this.loaiDRLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiDRLDataGridViewTextBoxColumn.Name = "loaiDRLDataGridViewTextBoxColumn";
            this.loaiDRLDataGridViewTextBoxColumn.ReadOnly = true;
            this.loaiDRLDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenSKDataGridViewTextBoxColumn
            // 
            this.tenSKDataGridViewTextBoxColumn.DataPropertyName = "tenSK";
            this.tenSKDataGridViewTextBoxColumn.HeaderText = "Tên hoạt động";
            this.tenSKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSKDataGridViewTextBoxColumn.Name = "tenSKDataGridViewTextBoxColumn";
            this.tenSKDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.diemDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.ReadOnly = true;
            this.diemDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ngayTochucDataGridViewTextBoxColumn
            // 
            this.ngayTochucDataGridViewTextBoxColumn.DataPropertyName = "ngayTochuc";
            this.ngayTochucDataGridViewTextBoxColumn.HeaderText = "Ngày tổ chức";
            this.ngayTochucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTochucDataGridViewTextBoxColumn.Name = "ngayTochucDataGridViewTextBoxColumn";
            this.ngayTochucDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayTochucDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // thoiGiantochucDataGridViewTextBoxColumn
            // 
            this.thoiGiantochucDataGridViewTextBoxColumn.DataPropertyName = "thoiGiantochuc";
            this.thoiGiantochucDataGridViewTextBoxColumn.HeaderText = "Thời gian tổ chức";
            this.thoiGiantochucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGiantochucDataGridViewTextBoxColumn.Name = "thoiGiantochucDataGridViewTextBoxColumn";
            this.thoiGiantochucDataGridViewTextBoxColumn.ReadOnly = true;
            this.thoiGiantochucDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sKDRLBindingSource1
            // 
            this.sKDRLBindingSource1.DataMember = "SKDRL";
            this.sKDRLBindingSource1.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonComboBox1);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 71);
            this.panel2.TabIndex = 13;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 214;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "HK1 / 2022-2023",
            "HK2 / 2022-2023",
            "HK1 / 2023-2024",
            "HK2 / 2023-2024"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(119, 22);
            this.kryptonComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonComboBox1.Size = new System.Drawing.Size(160, 21);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(33, 19);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 26);
            this.label22.TabIndex = 6;
            this.label22.Text = "Học kỳ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học kỳ:";
            // 
            // sKDRLBindingSource
            // 
            this.sKDRLBindingSource.DataMember = "SKDRL";
            this.sKDRLBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDTDataSet
            // 
            this.qLHTTTSV_TDTDataSet.DataSetName = "QLHTTTSV_TDTDataSet";
            this.qLHTTTSV_TDTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLHTTTSVTDTDataSetBindingSource
            // 
            this.qLHTTTSVTDTDataSetBindingSource.DataSource = this.qLHTTTSV_TDTDataSet;
            this.qLHTTTSVTDTDataSetBindingSource.Position = 0;
            // 
            // sKDRLTableAdapter
            // 
            this.sKDRLTableAdapter.ClearBeforeFill = true;
            // 
            // UC_DiemRenLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_DiemRenLuyen";
            this.Size = new System.Drawing.Size(914, 1022);
            this.Load += new System.EventHandler(this.UC_DiemRenLuyen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDRLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKDRLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSVTDTDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private System.Windows.Forms.Label label22;
        private QLHTTTSV_TDTDataSet qLHTTTSV_TDTDataSet;
        private System.Windows.Forms.BindingSource qLHTTTSVTDTDataSetBindingSource;
        private System.Windows.Forms.BindingSource sKDRLBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.SKDRLTableAdapter sKDRLTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_drl;
        private System.Windows.Forms.BindingSource sKDRLBindingSource1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRLidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDRLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTochucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGiantochucDataGridViewTextBoxColumn;
    }
}
