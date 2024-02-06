using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.ThongBao
{
    public partial class ChiTietThongBao : Form
    {
        public ChiTietThongBao()
        {
            InitializeComponent();
            
            txt_title.MaximumSize = new System.Drawing.Size(this.Width, this.Height);
            txt_noidung.MaximumSize = new System.Drawing.Size(this.Width, this.Height);
        }

        public void SetData(string idThongBao, string ngayDang, string noidung)
        {
            txt_idthongbao.Text = idThongBao;
            txt_ngaydang.Text = ngayDang;
            txt_noidung.Text = noidung;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChiTietThongBao_SizeChanged(object sender, EventArgs e)
        {
            txt_title.MaximumSize = new System.Drawing.Size(this.Width, this.Height);
            txt_noidung.MaximumSize = new System.Drawing.Size(this.Width, this.Height);
        }
    }
}
