using FinalProject.App.Main.ThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.KhaoSatMonHoc
{
    public partial class ChiTietKhaoSat : Form
    {
        public void SetData(string idMonHoc, string tenMonHoc)
        {
            txt_monhoc.Text = tenMonHoc;
            txt_idmonhoc.Text = idMonHoc;
        }

        public ChiTietKhaoSat()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_xacnhangui_Click(object sender, EventArgs e)
        {
            // Xử lý: gửi nội dung
            // . . .

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
