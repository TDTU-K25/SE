namespace FinalProject.App.GiangVien
{
    partial class HomeGiangVien
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_content = new System.Windows.Forms.Panel();
            this.pn_header = new System.Windows.Forms.Panel();
            this.btn_nhapdiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_diemdanh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbb_language = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.Label();
            this.btn_dangxuat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.LogoTDTBgWhite;
            this.pictureBox1.Location = new System.Drawing.Point(47, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pn_content);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 891);
            this.panel1.TabIndex = 10;
            // 
            // pn_content
            // 
            this.pn_content.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 0);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(1582, 891);
            this.pn_content.TabIndex = 10;
            this.pn_content.Click += new System.EventHandler(this.pn_content_Click);
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pn_header.Controls.Add(this.btn_dangxuat);
            this.pn_header.Controls.Add(this.btn_nhapdiem);
            this.pn_header.Controls.Add(this.btn_diemdanh);
            this.pn_header.Controls.Add(this.panel2);
            this.pn_header.Controls.Add(this.panel6);
            this.pn_header.Controls.Add(this.panel3);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(1582, 62);
            this.pn_header.TabIndex = 9;
            // 
            // btn_nhapdiem
            // 
            this.btn_nhapdiem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.btn_nhapdiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_nhapdiem.Location = new System.Drawing.Point(396, 0);
            this.btn_nhapdiem.Name = "btn_nhapdiem";
            this.btn_nhapdiem.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_nhapdiem.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_nhapdiem.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_nhapdiem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_nhapdiem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.btn_nhapdiem.Size = new System.Drawing.Size(209, 62);
            this.btn_nhapdiem.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_nhapdiem.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_nhapdiem.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_nhapdiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_nhapdiem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_nhapdiem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_nhapdiem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapdiem.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_nhapdiem.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_nhapdiem.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_nhapdiem.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_nhapdiem.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_nhapdiem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_nhapdiem.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_nhapdiem.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_nhapdiem.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_nhapdiem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_nhapdiem.TabIndex = 6;
            this.btn_nhapdiem.Values.Text = "Nhập điểm";
            this.btn_nhapdiem.Click += new System.EventHandler(this.btn_nhapdiem_Click);
            // 
            // btn_diemdanh
            // 
            this.btn_diemdanh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.btn_diemdanh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_diemdanh.Location = new System.Drawing.Point(187, 0);
            this.btn_diemdanh.Name = "btn_diemdanh";
            this.btn_diemdanh.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_diemdanh.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_diemdanh.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_diemdanh.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_diemdanh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.btn_diemdanh.Size = new System.Drawing.Size(209, 62);
            this.btn_diemdanh.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_diemdanh.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_diemdanh.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_diemdanh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_diemdanh.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_diemdanh.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_diemdanh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diemdanh.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_diemdanh.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_diemdanh.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_diemdanh.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_diemdanh.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_diemdanh.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_diemdanh.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_diemdanh.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_diemdanh.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_diemdanh.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_diemdanh.TabIndex = 0;
            this.btn_diemdanh.Values.Text = "Điểm danh";
            this.btn_diemdanh.Click += new System.EventHandler(this.btn_diemdanh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 62);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbb_language);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1204, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(139, 62);
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
            this.panel3.Size = new System.Drawing.Size(239, 62);
            this.panel3.TabIndex = 4;
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
            // btn_dangxuat
            // 
            this.btn_dangxuat.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.btn_dangxuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_dangxuat.Location = new System.Drawing.Point(995, 0);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_dangxuat.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_dangxuat.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_dangxuat.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_dangxuat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.btn_dangxuat.Size = new System.Drawing.Size(209, 62);
            this.btn_dangxuat.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_dangxuat.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_dangxuat.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_dangxuat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_dangxuat.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_dangxuat.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_dangxuat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_dangxuat.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_dangxuat.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_dangxuat.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_dangxuat.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_dangxuat.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_dangxuat.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_dangxuat.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_dangxuat.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btn_dangxuat.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_dangxuat.TabIndex = 7;
            this.btn_dangxuat.Values.Text = "Đăng xuất";
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // HomeGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_header);
            this.Name = "HomeGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeGiangVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeGiangVien_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pn_header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbb_language;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_diemdanh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_nhapdiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_dangxuat;
    }
}