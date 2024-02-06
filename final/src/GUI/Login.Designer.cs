using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pn_login = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_loginfail = new System.Windows.Forms.Label();
            this.lb_login_title = new System.Windows.Forms.Label();
            this.img_username = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.img_password = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.pn_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_username)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_password)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(541, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "CỔNG THÔNG TIN SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pn_login);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1284, 639);
            this.panel6.TabIndex = 15;
            // 
            // pn_login
            // 
            this.pn_login.Controls.Add(this.btn_exit);
            this.pn_login.Controls.Add(this.txt_loginfail);
            this.pn_login.Controls.Add(this.lb_login_title);
            this.pn_login.Controls.Add(this.img_username);
            this.pn_login.Controls.Add(this.btn_login);
            this.pn_login.Controls.Add(this.panel4);
            this.pn_login.Controls.Add(this.panel3);
            this.pn_login.Controls.Add(this.img_password);
            this.pn_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_login.Location = new System.Drawing.Point(604, 0);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(680, 639);
            this.pn_login.TabIndex = 19;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(499, 560);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(150, 61);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_loginfail
            // 
            this.txt_loginfail.AutoSize = true;
            this.txt_loginfail.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_loginfail.Location = new System.Drawing.Point(255, 308);
            this.txt_loginfail.Name = "txt_loginfail";
            this.txt_loginfail.Size = new System.Drawing.Size(146, 16);
            this.txt_loginfail.TabIndex = 14;
            this.txt_loginfail.Text = "Sai thông tin đăng nhập";
            this.txt_loginfail.Visible = false;
            // 
            // lb_login_title
            // 
            this.lb_login_title.AutoSize = true;
            this.lb_login_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lb_login_title.Location = new System.Drawing.Point(305, 6);
            this.lb_login_title.Name = "lb_login_title";
            this.lb_login_title.Size = new System.Drawing.Size(148, 58);
            this.lb_login_title.TabIndex = 1;
            this.lb_login_title.Text = "Login";
            this.lb_login_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // img_username
            // 
            this.img_username.BackColor = System.Drawing.Color.Transparent;
            this.img_username.Image = global::FinalProject.Properties.Resources.user32;
            this.img_username.Location = new System.Drawing.Point(198, 163);
            this.img_username.Name = "img_username";
            this.img_username.Size = new System.Drawing.Size(32, 32);
            this.img_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_username.TabIndex = 9;
            this.img_username.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_login.Location = new System.Drawing.Point(255, 337);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(251, 54);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txt_password);
            this.panel4.Location = new System.Drawing.Point(255, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 50);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 1);
            this.panel5.TabIndex = 9;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_password.Location = new System.Drawing.Point(3, 7);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(243, 27);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "buithong19950101";
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Location = new System.Drawing.Point(255, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 57);
            this.panel3.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(3, 47);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(243, 1);
            this.panel8.TabIndex = 9;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_username.Location = new System.Drawing.Point(3, 16);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(243, 25);
            this.txt_username.TabIndex = 2;
            this.txt_username.Text = "buithong@gmail.com";
            this.txt_username.Click += new System.EventHandler(this.txt_username_Click);
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // img_password
            // 
            this.img_password.BackColor = System.Drawing.Color.Transparent;
            this.img_password.Image = global::FinalProject.Properties.Resources.key1;
            this.img_password.Location = new System.Drawing.Point(200, 245);
            this.img_password.Name = "img_password";
            this.img_password.Size = new System.Drawing.Size(30, 30);
            this.img_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_password.TabIndex = 12;
            this.img_password.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 639);
            this.panel2.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(163, 95);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(381, 372);
            this.panel7.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.MASCOT;
            this.pictureBox1.Location = new System.Drawing.Point(-318, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::FinalProject.Properties.Resources.LogoTDTBgWhite;
            this.pictureBox2.Location = new System.Drawing.Point(1103, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1284, 110);
            this.panel1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel6.ResumeLayout(false);
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_username)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_password)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Panel panel6;
        private Panel panel2;
        private Panel panel7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel pn_login;
        private Label txt_loginfail;
        private Label lb_login_title;
        private PictureBox img_username;
        private Button btn_login;
        private Panel panel4;
        private Panel panel5;
        private TextBox txt_password;
        private Panel panel3;
        private Panel panel8;
        private TextBox txt_username;
        private PictureBox img_password;
        private Button btn_exit;
    }
}