using FinalProject.App.Main;
using FinalProject.App.Main.HocPhi;
using FinalProject.App.Main.HocVu;
using FinalProject.App.Main.KhaoSatMonHoc;
using FinalProject.App.Main.LichThi;
using FinalProject.App.Main.MonHocDangKy;
using FinalProject.App.Main.ThoiKhoaBieu;
using FinalProject.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using DTO;

namespace FinalProject
{
    public partial class Home : Form
    {
        public SinhVien sv;
        bool showPannelDaotao = false;
        bool showPannelCongtacsinhvien = false;

        public Home(SinhVien sv) 
        {
            InitializeComponent();
            cbb_language.SelectedIndex = 0;
            tooglePannels();

            cbb_language.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_language.SelectedIndex = 0;

            this.sv = sv;
            txt_name.Text = sv.hovaten;

            // Set color Selected
            btn_thongbao.BackColor = Color.FromArgb(50, 50, 50);
            btn_thongbao.ForeColor = Color.White;

            // Set color for other btn
            btn_ctsv.BackColor = Color.FromArgb(30, 30, 30);
            btn_daotao.BackColor = Color.FromArgb(30, 30, 30);
            btn_hocphi.BackColor = Color.FromArgb(30, 30, 30);
            btn_khaosat.BackColor = Color.FromArgb(30, 30, 30);

            // Set User Control
            UC_ThongBao uc = new UC_ThongBao();
            setUserControl(uc);
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
                pn_daotao.Height = 250;
            }
            else
            {
                pn_daotao.Height = 0;
            }

            if (showPannelCongtacsinhvien)
            {
                pn_congtacsinhvien.Height = 200;
            }
            else
            {
                pn_congtacsinhvien.Height = 0;
            }
        }

        private void btn_daotao_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = !showPannelDaotao;
            showPannelCongtacsinhvien = false;
            tooglePannels();

            // Set color Selected
            btn_daotao.BackColor = Color.FromArgb(50,50,50);
            btn_daotao.ForeColor = Color.White;

            // Set color for other btn
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_ctsv.BackColor = Color.FromArgb(30, 30, 30);
            btn_khaosat.BackColor = Color.FromArgb(30, 30, 30);
            btn_hocphi.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void btn_ctsv_Click(object sender, EventArgs e)
        {
            // Show pannel
            showPannelCongtacsinhvien = !showPannelCongtacsinhvien;
            showPannelDaotao = false;
            tooglePannels();

            // Set color Selected
            btn_ctsv.BackColor = Color.FromArgb(50,50,50);
            btn_ctsv.ForeColor = Color.White;

            // Set color for other btn
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_daotao.BackColor = Color.FromArgb(30, 30, 30);
            btn_khaosat.BackColor = Color.FromArgb(30, 30, 30);
            btn_hocphi.BackColor = Color.FromArgb(30, 30, 30);

        }

        private void btn_thongtinsv_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_thongtinsv.BackColor = Color.FromArgb(75, 75, 75);

            // Set color for other btn
            btn_drl.BackColor = Color.FromArgb(40, 40, 40);
            btn_hocbong.BackColor = Color.FromArgb(40, 40, 40);
            btn_hocvu.BackColor = Color.FromArgb(40, 40, 40);

            // Set User Control
            UC_InfoUser uc = new UC_InfoUser();
            setUserControl( uc ); 
        }



        private void btn_ketquahoctap_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_ketquahoctap.BackColor = Color.FromArgb(75,75,75);

            // Set color for other btn
            btn_tkb.BackColor = Color.FromArgb(40,40,40);
            btn_lichthi.BackColor = Color.FromArgb(40,40,40);
            btn_dkmh.BackColor = Color.FromArgb(40,40,40);
            btn_mhdk.BackColor = Color.FromArgb(40,40,40);

            // Set User Control
            UC_Diem uc = new UC_Diem();
            setUserControl(uc);
        }

        private void btn_tkb_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_tkb.BackColor = Color.FromArgb(75,75,75);

            // Set color for other btn
            btn_ketquahoctap.BackColor = Color.FromArgb(40,40,40);
            btn_lichthi.BackColor = Color.FromArgb(40,40,40);
            btn_dkmh.BackColor = Color.FromArgb(40,40,40);
            btn_mhdk.BackColor = Color.FromArgb(40,40,40);

            // Set User Control
            UC_ThoiKhoaBieu uc = new UC_ThoiKhoaBieu(sv.user_id);
            setUserControl(uc);
        }

        private void btn_lichthi_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_lichthi.BackColor = Color.FromArgb(75,75,75);

            // Set color for other 
            btn_ketquahoctap.BackColor = Color.FromArgb(40,40,40);
            btn_tkb.BackColor = Color.FromArgb(40,40,40);
            btn_dkmh.BackColor = Color.FromArgb(40,40,40);
            btn_mhdk.BackColor = Color.FromArgb(40,40,40);

            // Set User Control
            UC_LichThi uc = new UC_LichThi();
            setUserControl(uc);
        }

        private void btn_dkmh_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_dkmh.BackColor = Color.FromArgb(75,75,75);

            // Set color for other 
            btn_ketquahoctap.BackColor = Color.FromArgb(40,40,40);
            btn_tkb.BackColor = Color.FromArgb(40,40,40);
            btn_lichthi.BackColor = Color.FromArgb(40,40,40);
            btn_mhdk.BackColor = Color.FromArgb(40,40,40);

            // Set User Control
            UC_DangKyMonHoc uc = new UC_DangKyMonHoc();
            setUserControl(uc);
        }

        private void btn_mhdk_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_mhdk.BackColor = Color.FromArgb(75,75,75);

            // Set color for other btn
            btn_ketquahoctap.BackColor = Color.FromArgb(40,40,40);
            btn_tkb.BackColor = Color.FromArgb(40,40,40);
            btn_lichthi.BackColor = Color.FromArgb(40,40,40);
            btn_dkmh.BackColor = Color.FromArgb(40,40,40);

            //Set User Control
            UC_MonHocDaDangKy uc = new UC_MonHocDaDangKy();
            setUserControl(uc);
        }

        private void btn_drl_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_drl.BackColor = Color.FromArgb(75, 75, 75);

            // Set color for other btn
            btn_hocbong.BackColor = Color.FromArgb(40, 40, 40);
            btn_thongtinsv.BackColor = Color.FromArgb(40, 40, 40);
            btn_hocphi.BackColor = Color.FromArgb(40, 40, 40);
            btn_hocvu.BackColor = Color.FromArgb(40, 40, 40);

            // Set User Control
            UC_DiemRenLuyen uc = new UC_DiemRenLuyen();
            setUserControl(uc);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DangXuat dangxuat = new DangXuat();
            dangxuat.ShowDialog();
        }

        private void btn_hocbong_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_hocbong.BackColor = Color.FromArgb(75, 75, 75);

            // Set color for other btn
            btn_drl.BackColor = Color.FromArgb(40, 40, 40);
            btn_thongtinsv.BackColor = Color.FromArgb(40, 40, 40);
            btn_hocvu.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btn_hocvu_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_hocvu.BackColor = Color.FromArgb(75, 75, 75);

            // Set color for other btn
            btn_drl.BackColor = Color.FromArgb(40, 40, 40);
            btn_hocbong.BackColor = Color.FromArgb(40, 40, 40);
            btn_hocphi.BackColor = Color.FromArgb(40, 40, 40);

            UC_HocVu uc = new UC_HocVu();
            setUserControl((uc));
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            // Set color Selected
            btn_thongbao.BackColor = Color.FromArgb(50, 50, 50);
            btn_thongbao.ForeColor = Color.White;

            // Set color for other btn
            btn_ctsv.BackColor = Color.FromArgb(30, 30, 30);
            btn_daotao.BackColor = Color.FromArgb(30, 30, 30);
            btn_hocphi.BackColor = Color.FromArgb(30, 30, 30);
            btn_khaosat.BackColor = Color.FromArgb(30, 30, 30);

            // Set User Control
            UC_ThongBao uc = new UC_ThongBao();
            setUserControl(uc);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_khaosat_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = false;
            showPannelCongtacsinhvien = false;
            tooglePannels();

            // Set color Selected
            btn_khaosat.BackColor = Color.FromArgb(50, 50, 50);
            btn_khaosat.ForeColor = Color.White;

            // Set color for other btn
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_ctsv.BackColor = Color.FromArgb(30, 30, 30);
            btn_daotao.BackColor = Color.FromArgb(30, 30, 30);
            btn_hocphi.BackColor = Color.FromArgb(30, 30, 30);

            // Set User Control
            UC_KhaoSatMonHoc uc = new UC_KhaoSatMonHoc();
            setUserControl(uc);
        }

        private void btn_hocphi_Click(object sender, EventArgs e)
        {
            // Show pannel 
            showPannelDaotao = false;
            showPannelCongtacsinhvien = false;
            tooglePannels();

            // Set color Selected
            btn_hocphi.BackColor = Color.FromArgb(50, 50, 50);
            btn_hocphi.ForeColor = Color.White;

            // Set color for other btn
            btn_thongbao.BackColor = Color.FromArgb(30, 30, 30);
            btn_ctsv.BackColor = Color.FromArgb(30, 30, 30);
            btn_daotao.BackColor = Color.FromArgb(30, 30, 30);
            btn_khaosat.BackColor = Color.FromArgb(30, 30, 30);

            // Set User Control
            UC_HocPhi uc = new UC_HocPhi();
            setUserControl(uc);
        }
    }
}
