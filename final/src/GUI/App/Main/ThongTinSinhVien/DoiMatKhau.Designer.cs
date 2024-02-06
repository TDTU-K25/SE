namespace FinalProject.App.Main.ThongTinSinhVien
{
    partial class DoiMatKhau
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mkcu = new System.Windows.Forms.TextBox();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.txt_xacnhanmkmoi = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu mới:";
            // 
            // txt_mkcu
            // 
            this.txt_mkcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkcu.Location = new System.Drawing.Point(205, 32);
            this.txt_mkcu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mkcu.Name = "txt_mkcu";
            this.txt_mkcu.PasswordChar = '*';
            this.txt_mkcu.Size = new System.Drawing.Size(256, 26);
            this.txt_mkcu.TabIndex = 3;
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkmoi.Location = new System.Drawing.Point(205, 76);
            this.txt_mkmoi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.PasswordChar = '*';
            this.txt_mkmoi.Size = new System.Drawing.Size(256, 26);
            this.txt_mkmoi.TabIndex = 4;
            // 
            // txt_xacnhanmkmoi
            // 
            this.txt_xacnhanmkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xacnhanmkmoi.Location = new System.Drawing.Point(205, 119);
            this.txt_xacnhanmkmoi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_xacnhanmkmoi.Name = "txt_xacnhanmkmoi";
            this.txt_xacnhanmkmoi.PasswordChar = '*';
            this.txt_xacnhanmkmoi.Size = new System.Drawing.Size(256, 26);
            this.txt_xacnhanmkmoi.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(284, 176);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(69, 33);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_xacnhan.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btn_xacnhan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacnhan.Location = new System.Drawing.Point(373, 176);
            this.btn_xacnhan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(87, 33);
            this.btn_xacnhan.TabIndex = 7;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 230);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_xacnhanmkmoi);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.txt_mkcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mkcu;
        private System.Windows.Forms.TextBox txt_mkmoi;
        private System.Windows.Forms.TextBox txt_xacnhanmkmoi;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_xacnhan;
    }
}