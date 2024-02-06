using BLL;
using DTO;
using FinalProject.App.Main.DangKyMonHoc;
using FinalProject.App.Main.ThongTinSinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Main
{
    public partial class UC_InfoUser : UserControl 
    {
        UserBLL userBLL = new UserBLL();
        public UC_InfoUser()
        {
            InitializeComponent();

            // Set disable edit info user
            disableEditUserInfo();

        }

        private void disableEditUserInfo()
        {
            txt_mssv.Enabled = false;
            txt_lop.Enabled = false;
            txt_khoa.Enabled = false;
            txt_hoten.Enabled = false;
            txt_gioitinh.Enabled = false;
            txt_diachi.Enabled = false;
            txt_email.Enabled = false;
            dtp_ngaysinh.Enabled = false;
            txt_namvaotruong.Enabled = false;
            txt_sdt.Enabled = false;
            btn_savechange.Enabled = false;
        }
       

        private void UC_InfoUser_Load(object sender, EventArgs e)
        {
            /*if(this.ParentForm != null)
            {
                Home home = (Home ) this.ParentForm;
            }*/

            Home parentForm = this.ParentForm as Home;

            if (parentForm != null)
            {
                txt_mssv.Text = parentForm.sv.Sv_id;
                txt_khoa.Text = parentForm.sv.Khoa_id;
                txt_hoten.Text = parentForm.sv.hovaten;
                txt_gioitinh.Text = parentForm.sv.gioitinh;
                txt_diachi.Text = parentForm.sv.diachi;
                txt_email.Text = parentForm.sv.email;
                dtp_ngaysinh.Value = parentForm.sv.Ngaysinh;
                txt_sdt.Text = parentForm.sv.numberPhone;
            }
        }


        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau inputForm = new DoiMatKhau();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string mk_moi = inputForm.MatKhauMoi;
                string mk_cu = inputForm.MatKhauMoi;
                string mk_xacnhan = inputForm.MatKhauXacNhan;

                Home parentForm = this.ParentForm as Home;

                if (parentForm != null)
                {
                    // need to check the old password in db
                    if (!mk_moi.Equals(mk_xacnhan))
                    {
                        MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        userBLL.ChangePasswordSV(mk_moi, parentForm.sv.account_id);
                        MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo");
                    }
                }
            }
        }

        private void btn_savechange_Click(object sender, EventArgs e)
        {
            Home parentForm = this.ParentForm as Home;
            if (parentForm != null)
            {
                SinhVien sv = parentForm.sv;
                sv.hovaten = txt_hoten.Text;
                sv.diachi = txt_diachi.Text;
                sv.numberPhone = txt_sdt.Text;
                sv.gioitinh = txt_gioitinh.Text;
                sv.Ngaysinh = dtp_ngaysinh.Value;
                sv.email = txt_email.Text;
                userBLL.UpadteProfileSV(sv);
                disableEditUserInfo();
                MessageBox.Show("Cập nhật thông tin cá nhân thành công.", "Thông báo");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_hoten.Enabled = true;
            txt_diachi.Enabled = true;
            txt_email.Enabled = true;
            dtp_ngaysinh.Enabled = true;
            txt_sdt.Enabled = true;
            btn_savechange.Enabled = true;
        }
    }
}
