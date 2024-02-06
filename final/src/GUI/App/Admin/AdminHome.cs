using FinalProject.App.Main.HocPhi;
using FinalProject.App.Main.HocVu;
using FinalProject.App.Main.KhaoSatMonHoc;
using FinalProject.App.Main.LichThi;
using FinalProject.App.Main.MonHocDangKy;
using FinalProject.App.Main.ThoiKhoaBieu;
using FinalProject.App.Main;
using FinalProject.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.App.Admin.QuanLySinhVien;
using FinalProject.App.Admin.QuanLyGiangVien;
using FinalProject.App.Admin.QuanLyMonHoc;
using FinalProject.App.Admin.QuanLySuKien;
using FinalProject.App.Admin.QuanLyThongBao;
using FinalProject.App.Admin.QuanLyLichThi;
using FinalProject.App.Admin.QuanLyKhaoSat;
using FinalProject.App.Admin.ThongKe;

namespace FinalProject.App.Admin
{
    public partial class AdminHome : Form
    {
        public string name;
        private string idSV;
        bool showPannelDaotao = false;

        public AdminHome(string name, string id)
        {
            InitializeComponent();
            cbb_language.SelectedIndex = 0;
            tooglePannels();

            this.idSV = id;

            txt_name.Text = name;

            cbb_language.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_language.SelectedIndex = 0;
        }

        private void setUserControl(System.Windows.Forms.UserControl userControl)
        {
            pn_content.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pn_content.Controls.Add(userControl);
        }

        private void tooglePannels()
        {
            if (showPannelDaotao)
            {
                pn_daotao.Height = 50;
            }
            else
            {
                pn_daotao.Height = 0;
            }
        }

        private void btn_quanlysinhvien_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = true;
            tooglePannels();

            // Set color Selected
            btn_quanlysinhvien.BackColor = Color.FromArgb(83, 83, 73);
            btn_quanlysinhvien.ForeColor = Color.White;

            // Set color for other btn
            btn_diemrenluyen.BackColor = Color.FromArgb(30, 39, 30);
            btn_quanlygiangvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlymonhoc.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_lichthi.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlykhaosat.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongke.BackColor = Color.FromArgb(30, 30, 30);

            // Set User Control
            UC_QuanLySinhVien uc = new UC_QuanLySinhVien();
            setUserControl(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DangXuat dangXuat = new DangXuat();
            dangXuat.ShowDialog();
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_nhapdrl_Click(object sender, EventArgs e)
        {
            UC_NhapDiemRenLuyen uc = new UC_NhapDiemRenLuyen();
            setUserControl(uc);

            // Xử lý lấy tham số và trả về kết quả
        }

        private void btn_quanlygiangvien_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = true;
            tooglePannels();

            // Set color Selected
            btn_quanlygiangvien.BackColor = Color.FromArgb(83, 83, 73);
            btn_quanlygiangvien.ForeColor = Color.White;

            // Set color for other btn
            btn_diemrenluyen.BackColor = Color.FromArgb(30, 39, 30);
            btn_quanlysinhvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlymonhoc.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_lichthi.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlykhaosat.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongke.BackColor = Color.FromArgb(30, 30, 30);

            UC_QuanLyGiangVien uc = new UC_QuanLyGiangVien();
            setUserControl(uc);
        }

        private void btn_quanlymonhoc_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = true;
            tooglePannels();

            // Set color Selected
            btn_quanlymonhoc.BackColor = Color.FromArgb(83, 83, 73);
            btn_quanlymonhoc.ForeColor = Color.White;

            // Set color for other btn
            btn_diemrenluyen.BackColor = Color.FromArgb(30, 39, 30);
            btn_quanlygiangvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlysinhvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_lichthi.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlykhaosat.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongke.BackColor = Color.FromArgb(30, 30, 30);

            UC_QuanLyMonHoc uc = new UC_QuanLyMonHoc();
            setUserControl(uc);
        }

        private void btn_diemrenluyen_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = true;
            tooglePannels();

            // Set color Selected
            btn_diemrenluyen.BackColor = Color.FromArgb(83, 83, 73);
            btn_diemrenluyen.ForeColor = Color.White;

            // Set color for other btn
            btn_quanlymonhoc.BackColor = Color.FromArgb(30, 39, 30);
            btn_quanlygiangvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlysinhvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_lichthi.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlykhaosat.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongke.BackColor = Color.FromArgb(30, 30, 30);

            UC_QuanLySuKien uc = new UC_QuanLySuKien();
            setUserControl(uc);
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = true;
            tooglePannels();

            // Set color Selected
            btn_thongbao.BackColor = Color.FromArgb(83, 83, 73);
            btn_thongbao.ForeColor = Color.White;

            // Set color for other btn
            btn_diemrenluyen.BackColor = Color.FromArgb(30, 39, 30);
            btn_quanlygiangvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlysinhvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlymonhoc.BackColor = Color.FromArgb(30, 30, 30);
            btn_lichthi.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlykhaosat.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongke.BackColor = Color.FromArgb(30, 30, 30);

            UC_QuanLyThongBao uc = new UC_QuanLyThongBao(idSV);
            setUserControl(uc);
        }

        private void btn_lichthi_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = true;
            tooglePannels();

            // Set color Selected
            btn_lichthi.BackColor = Color.FromArgb(83, 83, 73);
            btn_lichthi.ForeColor = Color.White;

            // Set color for other btn
            btn_diemrenluyen.BackColor = Color.FromArgb(30, 39, 30);
            btn_quanlygiangvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlysinhvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlymonhoc.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlykhaosat.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongke.BackColor = Color.FromArgb(30, 30, 30);

            UC_QuanLyLichThi uc = new UC_QuanLyLichThi();
            setUserControl(uc);
        }

        private void btn_quanlykhaosat_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = true;
            tooglePannels();

            // Set color Selected
            btn_quanlykhaosat.BackColor = Color.FromArgb(83, 83, 73);
            btn_quanlykhaosat.ForeColor = Color.White;

            // Set color for other btn
            btn_diemrenluyen.BackColor = Color.FromArgb(30, 39, 30);
            btn_quanlygiangvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlysinhvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_lichthi.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlymonhoc.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongke.BackColor = Color.FromArgb(30, 30, 30);

            UC_QuanLyKhaoSat uc = new UC_QuanLyKhaoSat();
            setUserControl(uc);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = true;
            tooglePannels();

            // Set color Selected
            btn_thongke.BackColor = Color.FromArgb(83, 83, 73);
            btn_thongke.ForeColor = Color.White;

            // Set color for other btn
            btn_diemrenluyen.BackColor = Color.FromArgb(30, 39, 30);
            btn_quanlygiangvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlysinhvien.BackColor = Color.FromArgb(30, 30, 30);
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_lichthi.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlykhaosat.BackColor = Color.FromArgb(30, 30, 30);
            btn_quanlymonhoc.BackColor = Color.FromArgb(30, 30, 30);

            UC_ThongKe uc = new UC_ThongKe();
            setUserControl( uc );

        }
    }
}

