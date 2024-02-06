using BLL;
using FinalProject.App.Admin.QuanLyLichThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Admin.QuanLyKhaoSat
{
    public partial class UC_KhaoSat : UserControl
    {

        KhaoSatBLL khaoSatBLL = new KhaoSatBLL();
        private String maMonHoc;
        private String tenMonHoc;

        public UC_KhaoSat(String maMH, String tenMH)
        {
            InitializeComponent();
            maMonHoc = maMH;
            txt_tenMH.Text = tenMH;
            DataTable dt = khaoSatBLL.GetAllKhaoSat(maMH);
            dgv_khaosat.DataSource = dt;
        }


        private void dgv_khaosat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = dgv_khaosat.RowCount;
            if (countRow <= 2)
            {
                dgv_khaosat.Height = dgv_khaosat.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_khaosat.Height = dgv_khaosat.RowTemplate.Height * countRow + 44;
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            UC_QuanLyKhaoSat uc = new UC_QuanLyKhaoSat();
            pn_quanlylichthi.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pn_quanlylichthi.Controls.Add(uc);
        }
    }
}
