using FinalProject.App.Main.LichThi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.ThoiKhoaBieu
{
    public partial class UC_ThoiKhoaBieu : UserControl
    {
        private String user_id = "";
        public UC_ThoiKhoaBieu(string user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void btn_tkbtongquat_Click(object sender, EventArgs e)
        {


            UC_TKBTongQuat uc = new UC_TKBTongQuat(user_id);
            setUserControl(uc);
        }

        private void btn_tkbchitiet_Click(object sender, EventArgs e)
        {
            UC_TKBChiTiet uc = new UC_TKBChiTiet(user_id);
            setUserControl(uc);
        }

        private void setUserControl(System.Windows.Forms.UserControl userControl)
        {
            pn_tkb_content.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pn_tkb_content.Controls.Add(userControl);
        }
    }
}
