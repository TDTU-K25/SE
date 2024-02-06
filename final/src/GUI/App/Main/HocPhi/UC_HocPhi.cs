using BLL;
using DTO;
using FinalProject.App.Main.ThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.HocPhi
{
    public partial class UC_HocPhi : UserControl
    {
        HocPhiBLL hocPhiBLL = new HocPhiBLL();
        public UC_HocPhi()
        {
            InitializeComponent();

            if (txt_trangthai.Text.Equals("Đã thanh toán"))
            {
                btn_thanhtoan.Visible = false;
            }
            else btn_thanhtoan.Visible = true;
            
        }
        private void dgv_hocphi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            int countRow = dgv_hocphi.RowCount;
            if (countRow <= 2)
            {
                dgv_hocphi.Height = dgv_hocphi.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_hocphi.Height = dgv_hocphi.RowTemplate.Height * countRow + 44;
            }
        }

        private void UC_HocPhi_Load(object sender, EventArgs e)
        {
            Home parentForm = this.ParentForm as Home;
            if (parentForm != null)
            {
                DataTable cthd = hocPhiBLL.GetCacChiTietHoaDon(parentForm.sv.Hoadon_id);
                dgv_hocphi.DataSource = cthd;

                long tongTien = 0;
                foreach (DataRow row in cthd.Rows)
                {
                    tongTien += Convert.ToInt64(row["hocPhiMon"]);
                }

                string trangThai = "";
                DataTable hoaDon = hocPhiBLL.GetHocPhiCuaSV(parentForm.sv.user_id);
                foreach (DataRow row in hoaDon.Rows)
                {
                    trangThai = row["trangthai"].ToString();
                }

                txt_chiphi.Text = tongTien.ToString();
                txt_mahoadon.Text = parentForm.sv.Hoadon_id;


                if (trangThai.Equals("Đã thanh toán"))
                {
                    btn_thanhtoan.Visible = false;
                    txt_trangthai.Text = "Đã thanh toán";
                }
                else if (trangThai.Equals("Chưa thanh toán"))
                {
                    btn_thanhtoan.Visible = true;
                    txt_trangthai.Text = "Chưa thanh toán";
                }
            }
            
        }

        private void dgv_hocphi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            ThanhToanHocPhi inputForm = new ThanhToanHocPhi(txt_mahoadon.Text, txt_chiphi.Text, "sv01");

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                bool enteredValue = inputForm.EnteredValue;

                if (enteredValue)
                {
                    pn_hocphi.Controls.Clear();
                    UC_HocPhi uc = new UC_HocPhi();
                    pn_hocphi.Controls.Add(uc);
                }
            }

        }
    }
}
