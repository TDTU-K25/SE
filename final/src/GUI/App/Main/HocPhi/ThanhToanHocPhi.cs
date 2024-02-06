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

namespace FinalProject.App.Main.HocPhi
{
    public partial class ThanhToanHocPhi : Form
    {
        HocPhiBLL hocPhiBLL = new HocPhiBLL();
        private String tongchiphi;
        private String mahoadon;

        public bool EnteredValue { get; private set; }

        public ThanhToanHocPhi(String maHoaDon, String soTien, string maSV)
        {
            InitializeComponent();
            btn_xacnhandk.Enabled = false;
            txt_magiaodich.Text = maHoaDon + " " + maSV;
            txt_sotienthanhtoan.Text = soTien;
            tongchiphi = soTien;
            mahoadon = maHoaDon;
        }

        private void btn_xacnhandk_Click(object sender, EventArgs e)
        {
            hocPhiBLL.ThanhToanHocPhi(mahoadon, Convert.ToInt32(tongchiphi));
            MessageBox.Show("Thanh toán học phí thành công", "Thông báo");
            EnteredValue = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_sotienthanhtoan_TextChanged(object sender, EventArgs e)
        {
            if (!txt_sotienthanhtoan.Text.Equals(""))
                if(Convert.ToInt64(txt_sotienthanhtoan.Text) < Convert.ToInt64(tongchiphi))
                {
                    txt_err.Visible = true;
                    btn_xacnhandk.Enabled = false;
                }
                else 
                {
                    txt_err.Visible = false;
                    btn_xacnhandk.Enabled = true;

                }
        }

        private void txt_sotienthanhtoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
