using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.LichThi
{
    public partial class UC_LichThi : UserControl
    {
        public UC_LichThi()
        {
            InitializeComponent();

            // Get time now
            DateTime currentDate = DateTime.Now;
            lb_ngayhientai.Text = currentDate.ToString("dd/MM/yyyy");
        }

        private void btn_giuaky_Click(object sender, EventArgs e)
        {
            UC_LichThi_GiuaKy uc = new UC_LichThi_GiuaKy();
            setUserControl( uc );
        }

        private void btn_cuoiky_Click(object sender, EventArgs e)
        {
            UC_LichThi_CuoiKy uc = new UC_LichThi_CuoiKy();
            setUserControl( uc );
        }

        private void setUserControl(System.Windows.Forms.UserControl userControl)
        {
            pn_lichthi_content.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pn_lichthi_content.Controls.Add(userControl);
        }
    }
}
