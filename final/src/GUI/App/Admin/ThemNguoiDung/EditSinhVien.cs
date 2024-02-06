using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FinalProject.App.Admin.QuanLySinhVien
{
    public partial class EditSinhVien : Form
    {
        public EditSinhVien(bool code)
        {
            InitializeComponent();
            txt_mssv.Enabled = false;
            // EDIT
            if (code)
            {
                txt_title.Text = "THÔNG TIN SINH VIÊN";
                btn_savechange.Text = "Cập nhật";
            }
            // Add
            else
            {
                txt_title.Text = "THÊM SINH VIÊN";
                btn_savechange.Text = "Thêm";


            }
        }

        void load()
        {
            UC_QuanLySinhVien sv = new UC_QuanLySinhVien();
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_savechange_Click(object sender, EventArgs e)
        {
            if (btn_savechange.Text == "Thêm")
            {
                if (string.IsNullOrEmpty(txt_hoten.Text))
                {
                    MessageBox.Show(" Vui lòng nhập họ và tên");
                    txt_hoten.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_khoa.Text))
                {
                    MessageBox.Show(" Vui lòng nhập khoa");
                    txt_khoa.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_gioitinh.Text))
                {
                    MessageBox.Show(" Vui lòng nhập giới tính");
                    txt_gioitinh.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_lop.Text))
                {
                    MessageBox.Show(" Vui lòng nhập lớp");
                    txt_lop.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_email.Text))
                {
                    MessageBox.Show(" Vui lòng nhập email");
                    txt_email.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                {
                    MessageBox.Show("Địa chỉ email không hợp lệ");
                    txt_email.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(cbbLoaiSv.Text))
                {
                    MessageBox.Show(" Vui lòng nhập Loại Sinh Viên");
                    cbbLoaiSv.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_sdt.Text))
                {
                    MessageBox.Show(" Vui lòng nhập số điện thoại");
                    txt_sdt.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_sdt.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    txt_sdt.Focus();
                    return;
                }
                else if (((int)(DateTime.Now - dtp_ngaysinh.Value).TotalDays / 365.25) < 18)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                    dtp_ngaysinh.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_diachi.Text))
                {
                    MessageBox.Show(" Vui lòng nhập địa chỉ ");
                    txt_diachi.Focus();
                    return;
                }


                string sv_id = txt_mssv.Text;
                string hoten = txt_hoten.Text;
                string khoa = txt_khoa.Text;
                string gt = txt_gioitinh.Text;
                string lop = txt_lop.Text;
                string email = txt_email.Text;
                string loaiSv = cbbLoaiSv.Text;
                string sdt = txt_sdt.Text;
                DateTime ngaysinh = dtp_ngaysinh.Value;
                string diachi = txt_diachi.Text;

                string user_id = txt_mssv.Text;
                string role = "SinhVien";
                string account = txt_mssv.Text;
                string hd = "";


                SinhVien sinhvien = new SinhVien(user_id, hoten, diachi, sdt, gt, ngaysinh, email, role, account, sv_id, loaiSv, khoa, hd);
                SinhVienBLL.InsertSinhVien(sinhvien);

                //dgv.DataSource = SinhVienBLL.GetAllSinhVien();
                MessageBox.Show("Thêm sinh viên thành công.", "Thông báo");

            }
            else
            {
                if (string.IsNullOrEmpty(txt_hoten.Text))
                {
                    MessageBox.Show(" Vui lòng nhập họ và tên");
                    txt_hoten.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_khoa.Text))
                {
                    MessageBox.Show(" Vui lòng nhập khoa");
                    txt_khoa.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_gioitinh.Text))
                {
                    MessageBox.Show(" Vui lòng nhập giới tính");
                    txt_gioitinh.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_lop.Text))
                {
                    MessageBox.Show(" Vui lòng nhập lớp");
                    txt_lop.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_email.Text))
                {
                    MessageBox.Show(" Vui lòng nhập email");
                    txt_email.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                {
                    MessageBox.Show("Địa chỉ email không hợp lệ");
                    txt_email.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(cbbLoaiSv.Text))
                {
                    MessageBox.Show(" Vui lòng nhập Loại Sinh Viên");
                    cbbLoaiSv.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_sdt.Text))
                {
                    MessageBox.Show(" Vui lòng nhập số điện thoại");
                    txt_sdt.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_sdt.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    txt_sdt.Focus();
                    return;
                }
                else if (((int)(DateTime.Now - dtp_ngaysinh.Value).TotalDays / 365.25) < 18)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                    dtp_ngaysinh.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_diachi.Text))
                {
                    MessageBox.Show(" Vui lòng nhập địa chỉ ");
                    txt_diachi.Focus();
                    return;
                }
                string sv_id = txt_mssv.Text;
                string hoten = txt_hoten.Text;
                string khoa = txt_khoa.Text;
                string gt = txt_gioitinh.Text;
                string lop = txt_lop.Text;
                string email = txt_email.Text;
                string loaiSv = cbbLoaiSv.Text;
                string sdt = txt_sdt.Text;
                DateTime ngaysinh = dtp_ngaysinh.Value;
                string diachi = txt_diachi.Text;

                string user_id = "";
                string role = "SinhVien";
                string account = "";
                string hd = "";


                SinhVien sinhvien = new SinhVien(user_id, hoten, diachi, sdt, gt, ngaysinh, email, role, account, sv_id, loaiSv, khoa, hd);
                SinhVienBLL.UpdateSinhVien(sinhvien);

                //dgv.DataSource = SinhVienBLL.GetAllSinhVien();
                MessageBox.Show("Cập nhật sinh viên thành công.", "Thông báo");

                
            }
            this.Close();
        }

    }
}
