using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using FinalProject.App.Admin;
using FinalProject.App.GiangVien;

namespace FinalProject
{
    public partial class Login : Form
    {
        Account account = new Account();
        AccountBLL accountBLL = new AccountBLL();
        UserBLL userBLL = new UserBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_username.ForeColor = Color.White;
            }
            catch { }
        }


        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_password.ForeColor = Color.White;
            }
            catch { }
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            txt_username.SelectAll();
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.SelectAll();
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Student ID";
                txt_username.ForeColor = Color.DarkGray;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.DarkGray;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            account.username = txt_username.Text;
            account.password = txt_password.Text;
            String result = accountBLL.CheckLogin(account);

            // Get accountId
            switch(result)
            {
                case "empty_username": 
                case "empty_password":
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "login_fail":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            // Get role based on accountId
            String role = userBLL.GetRole(result);

            switch(role)
            {
                case "QTV":
                    //account: buithong@gmail.com
                    //password: buithong19950101
                    AdminHome adminForm = new AdminHome(txt_username.Text, userBLL.GetAdminIdByAccId(result));
                    adminForm.Show();
                    this.Hide();

                    break;

                case "Giảng Viên":
                    // account: phamhuy@gmail.com
                    // password: phamhuy19990215
                    HomeGiangVien form = new HomeGiangVien(userBLL.GetAdminIdByAccId(result));
                    
                    form.Show();
                    this.Hide();
                    break;

                case "Sinh Viên":
                    // account: buinhi@gmail.com
                    // password: buinhi20051203
                    SinhVien sv = userBLL.GetSVByUserId(result);
                    sv.account_id = result;
                    Home svForm = new Home(sv);
                    svForm.Show();
                    this.Hide();
                    break;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
