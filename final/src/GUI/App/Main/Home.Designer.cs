using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    partial class Home
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pn_header = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbb_language = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_content = new System.Windows.Forms.Panel();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.btn_hocphi = new System.Windows.Forms.Button();
            this.btn_khaosat = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pn_congtacsinhvien = new System.Windows.Forms.Panel();
            this.btn_hocvu = new System.Windows.Forms.Button();
            this.btn_hocbong = new System.Windows.Forms.Button();
            this.btn_drl = new System.Windows.Forms.Button();
            this.btn_thongtinsv = new System.Windows.Forms.Button();
            this.btn_ctsv = new System.Windows.Forms.Button();
            this.pn_daotao = new System.Windows.Forms.Panel();
            this.btn_mhdk = new System.Windows.Forms.Button();
            this.btn_dkmh = new System.Windows.Forms.Button();
            this.btn_lichthi = new System.Windows.Forms.Button();
            this.btn_tkb = new System.Windows.Forms.Button();
            this.btn_ketquahoctap = new System.Windows.Forms.Button();
            this.btn_daotao = new System.Windows.Forms.Button();
            this.btn_thongbao = new System.Windows.Forms.Button();
            this.pn_header.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn_menu.SuspendLayout();
            this.pn_congtacsinhvien.SuspendLayout();
            this.pn_daotao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pn_header.Controls.Add(this.panel6);
            this.pn_header.Controls.Add(this.panel3);
            this.pn_header.Controls.Add(this.pictureBox1);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(1582, 49);
            this.pn_header.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbb_language);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1197, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(146, 49);
            this.panel6.TabIndex = 5;
            // 
            // cbb_language
            // 
            this.cbb_language.BackColor = System.Drawing.Color.White;
            this.cbb_language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_language.FormattingEnabled = true;
            this.cbb_language.Items.AddRange(new object[] {
            "VIE",
            "ENG"});
            this.cbb_language.Location = new System.Drawing.Point(58, 14);
            this.cbb_language.Name = "cbb_language";
            this.cbb_language.Size = new System.Drawing.Size(63, 28);
            this.cbb_language.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1343, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 49);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FinalProject.Properties.Resources.user32;
            this.pictureBox2.Location = new System.Drawing.Point(6, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(44, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 28);
            this.txt_name.TabIndex = 3;
            this.txt_name.Text = "Trần Phước Sang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.LogoTDTBgWhite;
            this.pictureBox1.Location = new System.Drawing.Point(85, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pn_content);
            this.panel1.Controls.Add(this.pn_menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 904);
            this.panel1.TabIndex = 2;
            // 
            // pn_content
            // 
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(293, 0);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(1289, 904);
            this.pn_content.TabIndex = 10;
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pn_menu.Controls.Add(this.btn_hocphi);
            this.pn_menu.Controls.Add(this.btn_khaosat);
            this.pn_menu.Controls.Add(this.button5);
            this.pn_menu.Controls.Add(this.pn_congtacsinhvien);
            this.pn_menu.Controls.Add(this.btn_ctsv);
            this.pn_menu.Controls.Add(this.pn_daotao);
            this.pn_menu.Controls.Add(this.btn_daotao);
            this.pn_menu.Controls.Add(this.btn_thongbao);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(293, 904);
            this.pn_menu.TabIndex = 8;
            // 
            // btn_hocphi
            // 
            this.btn_hocphi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hocphi.FlatAppearance.BorderSize = 0;
            this.btn_hocphi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hocphi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hocphi.ForeColor = System.Drawing.Color.White;
            this.btn_hocphi.Image = global::FinalProject.Properties.Resources.coins;
            this.btn_hocphi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hocphi.Location = new System.Drawing.Point(0, 676);
            this.btn_hocphi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hocphi.Name = "btn_hocphi";
            this.btn_hocphi.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_hocphi.Size = new System.Drawing.Size(293, 50);
            this.btn_hocphi.TabIndex = 41;
            this.btn_hocphi.Text = "              Học phí - Dịch vụ";
            this.btn_hocphi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hocphi.UseVisualStyleBackColor = true;
            this.btn_hocphi.Click += new System.EventHandler(this.btn_hocphi_Click);
            // 
            // btn_khaosat
            // 
            this.btn_khaosat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_khaosat.FlatAppearance.BorderSize = 0;
            this.btn_khaosat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_khaosat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khaosat.ForeColor = System.Drawing.Color.White;
            this.btn_khaosat.Image = global::FinalProject.Properties.Resources.bell_ring;
            this.btn_khaosat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khaosat.Location = new System.Drawing.Point(0, 626);
            this.btn_khaosat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_khaosat.Name = "btn_khaosat";
            this.btn_khaosat.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_khaosat.Size = new System.Drawing.Size(293, 50);
            this.btn_khaosat.TabIndex = 39;
            this.btn_khaosat.Text = "              Khảo sát môn học";
            this.btn_khaosat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khaosat.UseVisualStyleBackColor = true;
            this.btn_khaosat.Click += new System.EventHandler(this.btn_khaosat_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::FinalProject.Properties.Resources.logout;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 854);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(293, 50);
            this.button5.TabIndex = 36;
            this.button5.Text = "              Đăng xuất";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // pn_congtacsinhvien
            // 
            this.pn_congtacsinhvien.BackColor = System.Drawing.Color.Silver;
            this.pn_congtacsinhvien.Controls.Add(this.btn_hocvu);
            this.pn_congtacsinhvien.Controls.Add(this.btn_hocbong);
            this.pn_congtacsinhvien.Controls.Add(this.btn_drl);
            this.pn_congtacsinhvien.Controls.Add(this.btn_thongtinsv);
            this.pn_congtacsinhvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_congtacsinhvien.Location = new System.Drawing.Point(0, 410);
            this.pn_congtacsinhvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_congtacsinhvien.Name = "pn_congtacsinhvien";
            this.pn_congtacsinhvien.Size = new System.Drawing.Size(293, 216);
            this.pn_congtacsinhvien.TabIndex = 33;
            // 
            // btn_hocvu
            // 
            this.btn_hocvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_hocvu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hocvu.FlatAppearance.BorderSize = 0;
            this.btn_hocvu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hocvu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hocvu.ForeColor = System.Drawing.Color.White;
            this.btn_hocvu.Image = global::FinalProject.Properties.Resources.exclamation;
            this.btn_hocvu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hocvu.Location = new System.Drawing.Point(0, 150);
            this.btn_hocvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hocvu.Name = "btn_hocvu";
            this.btn_hocvu.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btn_hocvu.Size = new System.Drawing.Size(293, 50);
            this.btn_hocvu.TabIndex = 16;
            this.btn_hocvu.Text = "              Học vụ";
            this.btn_hocvu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hocvu.UseVisualStyleBackColor = false;
            this.btn_hocvu.Click += new System.EventHandler(this.btn_hocvu_Click);
            // 
            // btn_hocbong
            // 
            this.btn_hocbong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_hocbong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hocbong.FlatAppearance.BorderSize = 0;
            this.btn_hocbong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hocbong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hocbong.ForeColor = System.Drawing.Color.White;
            this.btn_hocbong.Image = global::FinalProject.Properties.Resources.mortarboard;
            this.btn_hocbong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hocbong.Location = new System.Drawing.Point(0, 100);
            this.btn_hocbong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hocbong.Name = "btn_hocbong";
            this.btn_hocbong.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btn_hocbong.Size = new System.Drawing.Size(293, 50);
            this.btn_hocbong.TabIndex = 15;
            this.btn_hocbong.Text = "              Học bổng";
            this.btn_hocbong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hocbong.UseVisualStyleBackColor = false;
            this.btn_hocbong.Click += new System.EventHandler(this.btn_hocbong_Click);
            // 
            // btn_drl
            // 
            this.btn_drl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_drl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_drl.FlatAppearance.BorderSize = 0;
            this.btn_drl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_drl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_drl.ForeColor = System.Drawing.Color.White;
            this.btn_drl.Image = global::FinalProject.Properties.Resources.trophy;
            this.btn_drl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_drl.Location = new System.Drawing.Point(0, 50);
            this.btn_drl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_drl.Name = "btn_drl";
            this.btn_drl.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btn_drl.Size = new System.Drawing.Size(293, 50);
            this.btn_drl.TabIndex = 14;
            this.btn_drl.Text = "              Điểm rèn luyện";
            this.btn_drl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_drl.UseVisualStyleBackColor = false;
            this.btn_drl.Click += new System.EventHandler(this.btn_drl_Click);
            // 
            // btn_thongtinsv
            // 
            this.btn_thongtinsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_thongtinsv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongtinsv.FlatAppearance.BorderSize = 0;
            this.btn_thongtinsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_thongtinsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongtinsv.ForeColor = System.Drawing.Color.White;
            this.btn_thongtinsv.Image = global::FinalProject.Properties.Resources.id_card1;
            this.btn_thongtinsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongtinsv.Location = new System.Drawing.Point(0, 0);
            this.btn_thongtinsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thongtinsv.Name = "btn_thongtinsv";
            this.btn_thongtinsv.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btn_thongtinsv.Size = new System.Drawing.Size(293, 50);
            this.btn_thongtinsv.TabIndex = 13;
            this.btn_thongtinsv.Text = "              Thông tin sinh viên";
            this.btn_thongtinsv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongtinsv.UseVisualStyleBackColor = false;
            this.btn_thongtinsv.Click += new System.EventHandler(this.btn_thongtinsv_Click);
            // 
            // btn_ctsv
            // 
            this.btn_ctsv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ctsv.FlatAppearance.BorderSize = 0;
            this.btn_ctsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ctsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ctsv.ForeColor = System.Drawing.Color.White;
            this.btn_ctsv.Image = global::FinalProject.Properties.Resources.user;
            this.btn_ctsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ctsv.Location = new System.Drawing.Point(0, 360);
            this.btn_ctsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ctsv.Name = "btn_ctsv";
            this.btn_ctsv.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_ctsv.Size = new System.Drawing.Size(293, 50);
            this.btn_ctsv.TabIndex = 32;
            this.btn_ctsv.Text = "              Công tác sinh viên";
            this.btn_ctsv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ctsv.UseVisualStyleBackColor = true;
            this.btn_ctsv.Click += new System.EventHandler(this.btn_ctsv_Click);
            // 
            // pn_daotao
            // 
            this.pn_daotao.BackColor = System.Drawing.Color.Silver;
            this.pn_daotao.Controls.Add(this.btn_mhdk);
            this.pn_daotao.Controls.Add(this.btn_dkmh);
            this.pn_daotao.Controls.Add(this.btn_lichthi);
            this.pn_daotao.Controls.Add(this.btn_tkb);
            this.pn_daotao.Controls.Add(this.btn_ketquahoctap);
            this.pn_daotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_daotao.Location = new System.Drawing.Point(0, 100);
            this.pn_daotao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_daotao.Name = "pn_daotao";
            this.pn_daotao.Size = new System.Drawing.Size(293, 260);
            this.pn_daotao.TabIndex = 30;
            // 
            // btn_mhdk
            // 
            this.btn_mhdk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_mhdk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mhdk.FlatAppearance.BorderSize = 0;
            this.btn_mhdk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_mhdk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mhdk.ForeColor = System.Drawing.Color.White;
            this.btn_mhdk.Image = global::FinalProject.Properties.Resources.calendar_done;
            this.btn_mhdk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mhdk.Location = new System.Drawing.Point(0, 200);
            this.btn_mhdk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mhdk.Name = "btn_mhdk";
            this.btn_mhdk.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btn_mhdk.Size = new System.Drawing.Size(293, 50);
            this.btn_mhdk.TabIndex = 17;
            this.btn_mhdk.Text = "              Môn học đã đăng ký";
            this.btn_mhdk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mhdk.UseVisualStyleBackColor = false;
            this.btn_mhdk.Click += new System.EventHandler(this.btn_mhdk_Click);
            // 
            // btn_dkmh
            // 
            this.btn_dkmh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_dkmh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dkmh.FlatAppearance.BorderSize = 0;
            this.btn_dkmh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dkmh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dkmh.ForeColor = System.Drawing.Color.White;
            this.btn_dkmh.Image = global::FinalProject.Properties.Resources.time;
            this.btn_dkmh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dkmh.Location = new System.Drawing.Point(0, 150);
            this.btn_dkmh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dkmh.Name = "btn_dkmh";
            this.btn_dkmh.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btn_dkmh.Size = new System.Drawing.Size(293, 50);
            this.btn_dkmh.TabIndex = 16;
            this.btn_dkmh.Text = "              Đăng ký môn học";
            this.btn_dkmh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dkmh.UseVisualStyleBackColor = false;
            this.btn_dkmh.Click += new System.EventHandler(this.btn_dkmh_Click);
            // 
            // btn_lichthi
            // 
            this.btn_lichthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_lichthi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lichthi.FlatAppearance.BorderSize = 0;
            this.btn_lichthi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_lichthi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lichthi.ForeColor = System.Drawing.Color.White;
            this.btn_lichthi.Image = global::FinalProject.Properties.Resources.exam;
            this.btn_lichthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lichthi.Location = new System.Drawing.Point(0, 100);
            this.btn_lichthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lichthi.Name = "btn_lichthi";
            this.btn_lichthi.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btn_lichthi.Size = new System.Drawing.Size(293, 50);
            this.btn_lichthi.TabIndex = 15;
            this.btn_lichthi.Text = "              Lịch thi";
            this.btn_lichthi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lichthi.UseVisualStyleBackColor = false;
            this.btn_lichthi.Click += new System.EventHandler(this.btn_lichthi_Click);
            // 
            // btn_tkb
            // 
            this.btn_tkb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_tkb.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tkb.FlatAppearance.BorderSize = 0;
            this.btn_tkb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_tkb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tkb.ForeColor = System.Drawing.Color.White;
            this.btn_tkb.Image = global::FinalProject.Properties.Resources.calendar;
            this.btn_tkb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tkb.Location = new System.Drawing.Point(0, 50);
            this.btn_tkb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tkb.Name = "btn_tkb";
            this.btn_tkb.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btn_tkb.Size = new System.Drawing.Size(293, 50);
            this.btn_tkb.TabIndex = 14;
            this.btn_tkb.Text = "              Thời khoá biểu";
            this.btn_tkb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tkb.UseVisualStyleBackColor = false;
            this.btn_tkb.Click += new System.EventHandler(this.btn_tkb_Click);
            // 
            // btn_ketquahoctap
            // 
            this.btn_ketquahoctap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_ketquahoctap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ketquahoctap.FlatAppearance.BorderSize = 0;
            this.btn_ketquahoctap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ketquahoctap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ketquahoctap.ForeColor = System.Drawing.Color.White;
            this.btn_ketquahoctap.Image = global::FinalProject.Properties.Resources.scoreboard;
            this.btn_ketquahoctap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ketquahoctap.Location = new System.Drawing.Point(0, 0);
            this.btn_ketquahoctap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ketquahoctap.Name = "btn_ketquahoctap";
            this.btn_ketquahoctap.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btn_ketquahoctap.Size = new System.Drawing.Size(293, 50);
            this.btn_ketquahoctap.TabIndex = 13;
            this.btn_ketquahoctap.Text = "              Kết quả học tập";
            this.btn_ketquahoctap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ketquahoctap.UseVisualStyleBackColor = false;
            this.btn_ketquahoctap.Click += new System.EventHandler(this.btn_ketquahoctap_Click);
            // 
            // btn_daotao
            // 
            this.btn_daotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_daotao.FlatAppearance.BorderSize = 0;
            this.btn_daotao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_daotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daotao.ForeColor = System.Drawing.Color.White;
            this.btn_daotao.Image = global::FinalProject.Properties.Resources.agenda1;
            this.btn_daotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_daotao.Location = new System.Drawing.Point(0, 50);
            this.btn_daotao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_daotao.Name = "btn_daotao";
            this.btn_daotao.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_daotao.Size = new System.Drawing.Size(293, 50);
            this.btn_daotao.TabIndex = 29;
            this.btn_daotao.Text = "              Đào tạo";
            this.btn_daotao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_daotao.UseVisualStyleBackColor = true;
            this.btn_daotao.Click += new System.EventHandler(this.btn_daotao_Click);
            // 
            // btn_thongbao
            // 
            this.btn_thongbao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongbao.FlatAppearance.BorderSize = 0;
            this.btn_thongbao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_thongbao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongbao.ForeColor = System.Drawing.Color.White;
            this.btn_thongbao.Image = global::FinalProject.Properties.Resources.bell_ring;
            this.btn_thongbao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongbao.Location = new System.Drawing.Point(0, 0);
            this.btn_thongbao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thongbao.Name = "btn_thongbao";
            this.btn_thongbao.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_thongbao.Size = new System.Drawing.Size(293, 50);
            this.btn_thongbao.TabIndex = 8;
            this.btn_thongbao.Text = "              Thông báo";
            this.btn_thongbao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongbao.UseVisualStyleBackColor = true;
            this.btn_thongbao.Click += new System.EventHandler(this.btn_thongbao_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.pn_header.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pn_menu.ResumeLayout(false);
            this.pn_congtacsinhvien.ResumeLayout(false);
            this.pn_daotao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel pn_header;
        private Panel panel6;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label txt_name;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel pn_menu;
        private Button button5;
        private Panel pn_congtacsinhvien;
        private Button btn_hocvu;
        private Button btn_hocbong;
        private Button btn_drl;
        private Button btn_thongtinsv;
        private Button btn_ctsv;
        private Panel pn_daotao;
        private Button btn_ketquahoctap;
        private Button btn_daotao;
        private Button btn_thongbao;
        private Panel pn_content;
        private Button btn_mhdk;
        private Button btn_dkmh;
        private Button btn_lichthi;
        private Button btn_tkb;
        private ComboBox cbb_language;
        private Button btn_hocphi;
        private Button btn_khaosat;
    }
}