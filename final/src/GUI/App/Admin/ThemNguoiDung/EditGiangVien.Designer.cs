namespace FinalProject.App.Admin.ThemNguoiDung
{
    partial class EditGiangVien
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
            this.pn_editsinhvien = new System.Windows.Forms.Panel();
            this.rdb_gioitinh2 = new System.Windows.Forms.RadioButton();
            this.rdb_gioitinh1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_savechange = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_title = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gvId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.pn_editsinhvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_editsinhvien
            // 
            this.pn_editsinhvien.BackColor = System.Drawing.Color.White;
            this.pn_editsinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_editsinhvien.Controls.Add(this.cbbKhoa);
            this.pn_editsinhvien.Controls.Add(this.rdb_gioitinh2);
            this.pn_editsinhvien.Controls.Add(this.rdb_gioitinh1);
            this.pn_editsinhvien.Controls.Add(this.label1);
            this.pn_editsinhvien.Controls.Add(this.cbbLoai);
            this.pn_editsinhvien.Controls.Add(this.btn_cancel);
            this.pn_editsinhvien.Controls.Add(this.btn_savechange);
            this.pn_editsinhvien.Controls.Add(this.txt_title);
            this.pn_editsinhvien.Controls.Add(this.dtp_ngaysinh);
            this.pn_editsinhvien.Controls.Add(this.label12);
            this.pn_editsinhvien.Controls.Add(this.txt_diachi);
            this.pn_editsinhvien.Controls.Add(this.label13);
            this.pn_editsinhvien.Controls.Add(this.txt_sdt);
            this.pn_editsinhvien.Controls.Add(this.label6);
            this.pn_editsinhvien.Controls.Add(this.txt_email);
            this.pn_editsinhvien.Controls.Add(this.label7);
            this.pn_editsinhvien.Controls.Add(this.txt_hoten);
            this.pn_editsinhvien.Controls.Add(this.label9);
            this.pn_editsinhvien.Controls.Add(this.label5);
            this.pn_editsinhvien.Controls.Add(this.label3);
            this.pn_editsinhvien.Controls.Add(this.txt_gvId);
            this.pn_editsinhvien.Controls.Add(this.label2);
            this.pn_editsinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_editsinhvien.Location = new System.Drawing.Point(0, 0);
            this.pn_editsinhvien.Name = "pn_editsinhvien";
            this.pn_editsinhvien.Size = new System.Drawing.Size(929, 655);
            this.pn_editsinhvien.TabIndex = 2;
            this.pn_editsinhvien.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_editsinhvien_Paint);
            // 
            // rdb_gioitinh2
            // 
            this.rdb_gioitinh2.AutoSize = true;
            this.rdb_gioitinh2.Location = new System.Drawing.Point(626, 220);
            this.rdb_gioitinh2.Name = "rdb_gioitinh2";
            this.rdb_gioitinh2.Size = new System.Drawing.Size(45, 20);
            this.rdb_gioitinh2.TabIndex = 55;
            this.rdb_gioitinh2.TabStop = true;
            this.rdb_gioitinh2.Text = "Nữ";
            this.rdb_gioitinh2.UseVisualStyleBackColor = true;
            this.rdb_gioitinh2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdb_gioitinh1
            // 
            this.rdb_gioitinh1.AutoSize = true;
            this.rdb_gioitinh1.Location = new System.Drawing.Point(552, 221);
            this.rdb_gioitinh1.Name = "rdb_gioitinh1";
            this.rdb_gioitinh1.Size = new System.Drawing.Size(57, 20);
            this.rdb_gioitinh1.TabIndex = 54;
            this.rdb_gioitinh1.TabStop = true;
            this.rdb_gioitinh1.Text = "Nam";
            this.rdb_gioitinh1.UseVisualStyleBackColor = true;
            this.rdb_gioitinh1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Khoa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbLoai
            // 
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Thỉnh Giảng",
            "Cơ Hữu"});
            this.cbbLoai.Location = new System.Drawing.Point(143, 295);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(244, 24);
            this.cbbLoai.TabIndex = 52;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(552, 582);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btn_cancel.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btn_cancel.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_cancel.OverrideDefault.Border.Color1 = System.Drawing.Color.Silver;
            this.btn_cancel.OverrideDefault.Border.Color2 = System.Drawing.Color.Silver;
            this.btn_cancel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_cancel.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_cancel.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_cancel.OverrideDefault.Border.Rounding = 16;
            this.btn_cancel.OverrideDefault.Border.Width = 1;
            this.btn_cancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_cancel.Size = new System.Drawing.Size(108, 46);
            this.btn_cancel.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_cancel.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_cancel.StateCommon.Back.ColorAngle = 45F;
            this.btn_cancel.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_cancel.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.btn_cancel.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.btn_cancel.StateCommon.Border.ColorAngle = 45F;
            this.btn_cancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_cancel.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_cancel.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_cancel.StateCommon.Border.Rounding = 16;
            this.btn_cancel.StateCommon.Border.Width = 1;
            this.btn_cancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_cancel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_cancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_cancel.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_cancel.StatePressed.Back.Color1 = System.Drawing.Color.LightGray;
            this.btn_cancel.StatePressed.Back.Color2 = System.Drawing.Color.LightGray;
            this.btn_cancel.StatePressed.Back.ColorAngle = 45F;
            this.btn_cancel.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_cancel.StatePressed.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.btn_cancel.StatePressed.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btn_cancel.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_cancel.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_cancel.StatePressed.Border.Rounding = 16;
            this.btn_cancel.StatePressed.Border.Width = 1;
            this.btn_cancel.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_cancel.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancel.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancel.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_cancel.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_cancel.StateTracking.Border.Rounding = 16;
            this.btn_cancel.TabIndex = 49;
            this.btn_cancel.Values.Text = "Huỷ";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_savechange
            // 
            this.btn_savechange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_savechange.Location = new System.Drawing.Point(687, 582);
            this.btn_savechange.Name = "btn_savechange";
            this.btn_savechange.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_savechange.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_savechange.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_savechange.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_savechange.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_savechange.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_savechange.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_savechange.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_savechange.OverrideDefault.Border.Rounding = 16;
            this.btn_savechange.OverrideDefault.Border.Width = 1;
            this.btn_savechange.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_savechange.Size = new System.Drawing.Size(156, 46);
            this.btn_savechange.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_savechange.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_savechange.StateCommon.Back.ColorAngle = 45F;
            this.btn_savechange.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_savechange.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_savechange.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_savechange.StateCommon.Border.ColorAngle = 45F;
            this.btn_savechange.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_savechange.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_savechange.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_savechange.StateCommon.Border.Rounding = 16;
            this.btn_savechange.StateCommon.Border.Width = 1;
            this.btn_savechange.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_savechange.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_savechange.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savechange.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_savechange.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_savechange.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.btn_savechange.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.btn_savechange.StatePressed.Back.ColorAngle = 45F;
            this.btn_savechange.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_savechange.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.btn_savechange.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(4)))));
            this.btn_savechange.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_savechange.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_savechange.StatePressed.Border.Rounding = 16;
            this.btn_savechange.StatePressed.Border.Width = 1;
            this.btn_savechange.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(5)))));
            this.btn_savechange.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(5)))));
            this.btn_savechange.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_savechange.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(5)))));
            this.btn_savechange.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(5)))));
            this.btn_savechange.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_savechange.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_savechange.StateTracking.Border.Rounding = 16;
            this.btn_savechange.TabIndex = 48;
            this.btn_savechange.Values.Text = "Cập nhật";
            this.btn_savechange.Click += new System.EventHandler(this.btn_savechange_Click);
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(291, 26);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(330, 32);
            this.txt_title.TabIndex = 47;
            this.txt_title.Text = "THÔNG TIN SINH VIÊN";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.CustomFormat = "";
            this.dtp_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(170, 368);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(217, 27);
            this.dtp_ngaysinh.TabIndex = 46;
            this.dtp_ngaysinh.Value = new System.DateTime(2023, 10, 22, 0, 0, 0, 0);
            this.dtp_ngaysinh.ValueChanged += new System.EventHandler(this.dtp_ngaysinh_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Ngày sinh";
            // 
            // txt_diachi
            // 
            this.txt_diachi.BackColor = System.Drawing.Color.White;
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(158, 448);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(326, 27);
            this.txt_diachi.TabIndex = 44;
            this.txt_diachi.TextChanged += new System.EventHandler(this.txt_diachi_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(81, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Địa chỉ";
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.Color.White;
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(552, 366);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(291, 27);
            this.txt_sdt.TabIndex = 42;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Số điện thoại";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(517, 292);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(326, 27);
            this.txt_email.TabIndex = 40;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Email";
            // 
            // txt_hoten
            // 
            this.txt_hoten.BackColor = System.Drawing.Color.White;
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(517, 142);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(326, 27);
            this.txt_hoten.TabIndex = 36;
            this.txt_hoten.TextChanged += new System.EventHandler(this.txt_hoten_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Giới tính";
            // 
            // txt_gvId
            // 
            this.txt_gvId.BackColor = System.Drawing.Color.White;
            this.txt_gvId.Enabled = false;
            this.txt_gvId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gvId.Location = new System.Drawing.Point(143, 142);
            this.txt_gvId.Name = "txt_gvId";
            this.txt_gvId.ReadOnly = true;
            this.txt_gvId.Size = new System.Drawing.Size(244, 27);
            this.txt_gvId.TabIndex = 28;
            this.txt_gvId.TextChanged += new System.EventHandler(this.txt_mssv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID ";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(143, 226);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(244, 24);
            this.cbbKhoa.TabIndex = 56;
            this.label1.AutoSize = true;


            this.label1.Location = new System.Drawing.Point(85, 226);
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.Click += new System.EventHandler(this.label1_Click);

            // 
            // EditGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 655);
            this.Controls.Add(this.pn_editsinhvien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditGiangVien";
            this.pn_editsinhvien.ResumeLayout(false);
            this.pn_editsinhvien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_editsinhvien;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_savechange;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        public System.Windows.Forms.TextBox txt_diachi;
        public System.Windows.Forms.TextBox txt_sdt;
        public System.Windows.Forms.TextBox txt_email;
        public System.Windows.Forms.TextBox txt_hoten;
        public System.Windows.Forms.TextBox txt_gvId;
        public System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton rdb_gioitinh2;
        public System.Windows.Forms.RadioButton rdb_gioitinh1;
        public System.Windows.Forms.ComboBox cbbKhoa;
    }
}