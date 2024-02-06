using DTO;
using FinalProject.App.GiangVien.DiemDanh;
using FinalProject.App.GiangVien.NhapDiem;
using FinalProject.App.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.GiangVien
{
    public partial class HomeGiangVien : Form
    {
        private string id;
        public HomeGiangVien(string id)
        {
            InitializeComponent();
            this.id = id;

            txt_name.Text = id;
        }

        private void btn_diemdanh_Click(object sender, EventArgs e)
        {
            UC_DiemDanh uc = new UC_DiemDanh(id);
            uc.Dock = DockStyle.Fill;
            pn_content.Controls.Clear();
            pn_content.Controls.Add(uc);
        }

        private void HomeGiangVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_nhapdiem_Click(object sender, EventArgs e)
        {
            UC_NhapDiem uc = new UC_NhapDiem(id);
            uc.Dock = DockStyle.Fill;
            pn_content.Controls.Clear();
            pn_content.Controls.Add(uc);
        }

        private void pn_content_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DangXuat dangXuat = new DangXuat();
            dangXuat.ShowDialog();
        }
    }
}
