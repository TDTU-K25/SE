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

namespace FinalProject.App.Main.ThongTinSinhVien
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        public string MatKhauMoi { get; private set; }
        public string MatKhauCu { get; private set; }
        public string MatKhauXacNhan { get; private set; }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
                MatKhauMoi = txt_mkmoi.Text;
                MatKhauCu = txt_mkcu.Text;
                MatKhauXacNhan= txt_xacnhanmkmoi.Text; 
                DialogResult = DialogResult.OK;
                Close();
        }
    }
}
