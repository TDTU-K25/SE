using BLL;
using DTO;
using FinalProject.App.Admin.QuanLyGiangVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProject.App.Admin.ThemNguoiDung
{
    public partial class EditGiangVien : Form
    {
        private String noti = "";
        private TeacherBLL teacherBLL = new TeacherBLL();
        private AccountBLL accountBLL = new AccountBLL();
        private UserBLL userBLL = new UserBLL();
        private bool code;
        private KhoaBLL khoaBLL = new KhoaBLL();
        public EditGiangVien(bool code)
        {
            InitializeComponent();
            this.code = code;
            cbbLoai.SelectedIndex = 0;
            rdb_gioitinh1.Checked = true;

            loadCbbKhoa();
            cbbKhoa.SelectedIndex = 0;
            if (code)
            {
                txt_title.Text = "THÔNG TIN GIẢNG VIÊN";
                btn_savechange.Text = "Cập nhật";
                noti = "Cập nhật giảng viên thành công.";
            }
            else 
            {
                txt_title.Text = "THÊM GIẢNG VIÊN";
                btn_savechange.Text = "Thêm";
                noti = "Thêm giảng viên thành công.";
            }
        }
        private void loadCbbKhoa()
        {
            DataTable dt = khoaBLL.GetAllKhoa();
            cbbKhoa.DataSource = dt;

            cbbKhoa.DisplayMember = "tenKhoa";
            cbbKhoa.ValueMember = "khoa_id";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } // r do load le ndi
        
        private void btn_savechange_Click(object sender, EventArgs e)
        {
            try
            {
                if (code)
                {
                    if (string.IsNullOrWhiteSpace(txt_hoten.Text))
                    {
                        MessageBox.Show(" vui lòng nhập tên");
                        txt_hoten.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(txt_email.Text))
                    {
                        MessageBox.Show(" vui lòng nhập email");
                        txt_email.Focus();
                        return;
                    }
                    else if (!Regex.IsMatch(txt_email.Text, @"^[a-za-z0-9+_.-]+@[a-za-z0-9.-]+$"))
                    {
                        MessageBox.Show("email không hợp lệ");
                        txt_email.Focus();
                        return;
                    }
                    else if (((int)(DateTime.Now - dtp_ngaysinh.Value).TotalDays / 365.25) < 18)
                    {
                        MessageBox.Show("ngày sinh không hợp lệ");
                        txt_email.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(txt_sdt.Text))
                    {
                        MessageBox.Show(" vui lòng nhập số điện thoại");
                        txt_sdt.Focus();
                        return;
                    }
                    else if (!Regex.IsMatch(txt_sdt.Text, @"^\d{10}$"))
                    {
                        MessageBox.Show("số điện thoại không hợp lệ");
                        txt_sdt.Focus();
                        return;
                    }
                    else if (string.IsNullOrEmpty(txt_diachi.Text))
                    {
                        MessageBox.Show(" vui lòng nhập địa chỉ ");
                        txt_diachi.Focus();
                        return;
                    }
                    Teacher teacher = new Teacher();
                    teacher.gv_id = txt_gvId.Text;
                    teacher.hovaten = txt_hoten.Text;
                    if (rdb_gioitinh1.Checked)
                    {
                        teacher.gioitinh = rdb_gioitinh1.Text;
                    } else
                    {
                        teacher.gioitinh = rdb_gioitinh2.Text;
                    }
                    
                    teacher.email = txt_email.Text;
                    teacher.diachi = txt_diachi.Text;
                    teacher.khoa_id = cbbKhoa.SelectedValue.ToString();
                    teacher.Ngaysinh = dtp_ngaysinh.Value;
                    teacher.role = "Giảng Viên";
                    
                    teacher.numberPhone = txt_sdt.Text;
                    teacher.type = cbbLoai.SelectedItem.ToString();  
                    
                    if(teacherBLL.UpdateGiangvien(teacher))
                    {
                        if (successUpdate != null)
                        {
                            successUpdate(this, new EventArgs());
                        }
                        MessageBox.Show("Cập nhật giảng viên thành công");
                    }
                    
                    
                    
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txt_hoten.Text))
                    {
                        MessageBox.Show(" vui lòng nhập tên");
                        txt_hoten.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(txt_email.Text))
                    {
                        MessageBox.Show(" vui lòng nhập email");
                        txt_email.Focus();
                        return;
                    }
                    else if (!Regex.IsMatch(txt_email.Text, @"^[a-za-z0-9+_.-]+@[a-za-z0-9.-]+$"))
                    {
                        MessageBox.Show("email không hợp lệ");
                        txt_email.Focus();
                        return;
                    }
                    else if (((int)(DateTime.Now - dtp_ngaysinh.Value).TotalDays / 365.25) < 18)
                    {
                        MessageBox.Show("ngày sinh không hợp lệ");
                        dtp_ngaysinh.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(txt_sdt.Text))
                    {
                        MessageBox.Show(" vui lòng nhập số điện thoại");
                        txt_sdt.Focus();
                        return;
                    }
                    else if (!Regex.IsMatch(txt_sdt.Text, @"^\d{10}$"))
                    {
                        MessageBox.Show("số điện thoại không hợp lệ");
                        txt_sdt.Focus();
                        return;
                    }
                    else if (string.IsNullOrEmpty(txt_diachi.Text))
                    {
                        MessageBox.Show(" vui lòng nhập địa chỉ ");
                        txt_diachi.Focus();
                        return;
                    }

                    string gioitinh = "";
                    if (rdb_gioitinh1.Checked)
                    {
                        gioitinh = rdb_gioitinh1.Text;
                    }
                    else
                    {
                        gioitinh = rdb_gioitinh2.Text;
                    }
                    Account account = new Account(txt_email.Text, txt_sdt.Text);
                    accountBLL.InsertAccount(account);
                    User user = new User(txt_hoten.Text, txt_diachi.Text, txt_sdt.Text, gioitinh,
                        dtp_ngaysinh.Value, txt_email.Text, cbbLoai.SelectedItem.ToString(), accountBLL.GetLastAccountId());
                    userBLL.InsertUser(user);
                    Teacher teacher = new Teacher(cbbLoai.SelectedItem.ToString(), userBLL.GetLastUserId(),cbbKhoa.SelectedValue.ToString());
                    if (teacherBLL.InsertTeacher(teacher))
                    {
                        if (successInsert != null)
                        {
                            successInsert(this, new EventArgs());
                            MessageBox.Show("Thêm giảng viên thành công");
                            
                        }
                    }
                }
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private event EventHandler successInsert;
        public event EventHandler SuccessInsert
        {
            add { successInsert += value; }
            remove { successInsert -= value; }
        }

        private event EventHandler successUpdate;
        public event EventHandler SuccessUpdate
        {
            add { successUpdate += value; }
            remove { successUpdate -= value; }
        }

        private void txt_mssv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_khoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gioitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_namvaotruong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lop_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_ngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pn_editsinhvien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
