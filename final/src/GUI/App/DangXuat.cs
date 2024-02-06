using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main
{
    public partial class DangXuat : Form
    {
        public DangXuat()
        {
            InitializeComponent();
        }

        private void btn_xacnhandk_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
