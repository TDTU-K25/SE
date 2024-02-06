namespace FinalProject.App.Main.LichThi
{
    partial class UC_LichThi
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
            this.pn_lichthi = new System.Windows.Forms.Panel();
            this.pn_lichthi_content = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cuoiky = new System.Windows.Forms.Button();
            this.btn_giuaky = new System.Windows.Forms.Button();
            this.lb_ngayhientai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lichThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHTTTSV_TDT_DataSet = new FinalProject.QLHTTTSV_TDT_DataSet();
            this.lichThiTableAdapter = new FinalProject.QLHTTTSV_TDT_DataSetTableAdapters.LichThiTableAdapter();
            this.pn_lichthi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_lichthi
            // 
            this.pn_lichthi.AutoScroll = true;
            this.pn_lichthi.BackColor = System.Drawing.Color.White;
            this.pn_lichthi.Controls.Add(this.pn_lichthi_content);
            this.pn_lichthi.Controls.Add(this.panel2);
            this.pn_lichthi.Controls.Add(this.panel1);
            this.pn_lichthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_lichthi.Location = new System.Drawing.Point(0, 0);
            this.pn_lichthi.Name = "pn_lichthi";
            this.pn_lichthi.Size = new System.Drawing.Size(1218, 1258);
            this.pn_lichthi.TabIndex = 0;
            // 
            // pn_lichthi_content
            // 
            this.pn_lichthi_content.AutoScroll = true;
            this.pn_lichthi_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_lichthi_content.Location = new System.Drawing.Point(0, 235);
            this.pn_lichthi_content.Name = "pn_lichthi_content";
            this.pn_lichthi_content.Size = new System.Drawing.Size(1218, 1023);
            this.pn_lichthi_content.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cuoiky);
            this.panel2.Controls.Add(this.btn_giuaky);
            this.panel2.Controls.Add(this.lb_ngayhientai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 148);
            this.panel2.TabIndex = 9;
            // 
            // btn_cuoiky
            // 
            this.btn_cuoiky.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cuoiky.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_cuoiky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cuoiky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuoiky.Location = new System.Drawing.Point(238, 79);
            this.btn_cuoiky.Name = "btn_cuoiky";
            this.btn_cuoiky.Size = new System.Drawing.Size(155, 45);
            this.btn_cuoiky.TabIndex = 14;
            this.btn_cuoiky.Text = "Cuối kỳ";
            this.btn_cuoiky.UseVisualStyleBackColor = false;
            this.btn_cuoiky.Click += new System.EventHandler(this.btn_cuoiky_Click);
            // 
            // btn_giuaky
            // 
            this.btn_giuaky.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_giuaky.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_giuaky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giuaky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giuaky.Location = new System.Drawing.Point(51, 79);
            this.btn_giuaky.Name = "btn_giuaky";
            this.btn_giuaky.Size = new System.Drawing.Size(155, 45);
            this.btn_giuaky.TabIndex = 13;
            this.btn_giuaky.Text = "Giữa kỳ";
            this.btn_giuaky.UseVisualStyleBackColor = false;
            this.btn_giuaky.Click += new System.EventHandler(this.btn_giuaky_Click);
            // 
            // lb_ngayhientai
            // 
            this.lb_ngayhientai.AutoSize = true;
            this.lb_ngayhientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayhientai.ForeColor = System.Drawing.Color.MediumBlue;
            this.lb_ngayhientai.Location = new System.Drawing.Point(183, 30);
            this.lb_ngayhientai.Name = "lb_ngayhientai";
            this.lb_ngayhientai.Size = new System.Drawing.Size(23, 25);
            this.lb_ngayhientai.TabIndex = 1;
            this.lb_ngayhientai.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày hiện tại:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 87);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lịch thi";
            // 
            // lichThiBindingSource
            // 
            this.lichThiBindingSource.DataMember = "LichThi";
            this.lichThiBindingSource.DataSource = this.qLHTTTSV_TDT_DataSet;
            // 
            // qLHTTTSV_TDT_DataSet
            // 
            this.qLHTTTSV_TDT_DataSet.DataSetName = "QLHTTTSV_TDT_DataSet";
            this.qLHTTTSV_TDT_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lichThiTableAdapter
            // 
            this.lichThiTableAdapter.ClearBeforeFill = true;
            // 
            // UC_LichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_lichthi);
            this.Name = "UC_LichThi";
            this.Size = new System.Drawing.Size(1218, 1258);
            this.pn_lichthi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHTTTSV_TDT_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_lichthi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_ngayhientai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lichThiBindingSource;
        private QLHTTTSV_TDT_DataSet qLHTTTSV_TDT_DataSet;
        private QLHTTTSV_TDT_DataSetTableAdapters.LichThiTableAdapter lichThiTableAdapter;
        private System.Windows.Forms.Button btn_giuaky;
        private System.Windows.Forms.Button btn_cuoiky;
        private System.Windows.Forms.Panel pn_lichthi_content;
    }
}
