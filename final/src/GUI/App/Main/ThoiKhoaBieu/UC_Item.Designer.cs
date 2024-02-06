namespace FinalProject.App.Main.ThoiKhoaBieu
{
    partial class UC_Item
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
            this.txt_tenmonhoc = new System.Windows.Forms.Label();
            this.txt_phonghoc = new System.Windows.Forms.Label();
            this.txt_ngaubatdau = new System.Windows.Forms.Label();
            this.txt_ngayketthuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_tenmonhoc
            // 
            this.txt_tenmonhoc.AutoSize = true;
            this.txt_tenmonhoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_tenmonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenmonhoc.Location = new System.Drawing.Point(0, 0);
            this.txt_tenmonhoc.MaximumSize = new System.Drawing.Size(142, 0);
            this.txt_tenmonhoc.Name = "txt_tenmonhoc";
            this.txt_tenmonhoc.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.txt_tenmonhoc.Size = new System.Drawing.Size(69, 30);
            this.txt_tenmonhoc.TabIndex = 0;
            this.txt_tenmonhoc.Text = "label1";
            // 
            // txt_phonghoc
            // 
            this.txt_phonghoc.AutoSize = true;
            this.txt_phonghoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_phonghoc.Location = new System.Drawing.Point(0, 30);
            this.txt_phonghoc.Name = "txt_phonghoc";
            this.txt_phonghoc.Padding = new System.Windows.Forms.Padding(10, 4, 0, 0);
            this.txt_phonghoc.Size = new System.Drawing.Size(54, 20);
            this.txt_phonghoc.TabIndex = 1;
            this.txt_phonghoc.Text = "label1";
            // 
            // txt_ngaubatdau
            // 
            this.txt_ngaubatdau.AutoSize = true;
            this.txt_ngaubatdau.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_ngaubatdau.Location = new System.Drawing.Point(0, 50);
            this.txt_ngaubatdau.Name = "txt_ngaubatdau";
            this.txt_ngaubatdau.Padding = new System.Windows.Forms.Padding(10, 4, 0, 0);
            this.txt_ngaubatdau.Size = new System.Drawing.Size(54, 20);
            this.txt_ngaubatdau.TabIndex = 2;
            this.txt_ngaubatdau.Text = "label1";
            // 
            // txt_ngayketthuc
            // 
            this.txt_ngayketthuc.AutoSize = true;
            this.txt_ngayketthuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_ngayketthuc.Location = new System.Drawing.Point(0, 70);
            this.txt_ngayketthuc.Name = "txt_ngayketthuc";
            this.txt_ngayketthuc.Padding = new System.Windows.Forms.Padding(10, 4, 0, 0);
            this.txt_ngayketthuc.Size = new System.Drawing.Size(54, 20);
            this.txt_ngayketthuc.TabIndex = 3;
            this.txt_ngayketthuc.Text = "label2";
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_ngayketthuc);
            this.Controls.Add(this.txt_ngaubatdau);
            this.Controls.Add(this.txt_phonghoc);
            this.Controls.Add(this.txt_tenmonhoc);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(152, 133);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_tenmonhoc;
        private System.Windows.Forms.Label txt_phonghoc;
        private System.Windows.Forms.Label txt_ngaubatdau;
        private System.Windows.Forms.Label txt_ngayketthuc;
    }
}
