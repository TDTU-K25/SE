using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.DangKyMonHoc
{
    public partial class XacNhanDangKy : Form
    {
        public XacNhanDangKy()
        {
            InitializeComponent();
        }

        public string EnteredValue { get; private set; }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_xacnhandk_Click(object sender, EventArgs e)
        {
            EnteredValue = txt_mkxacnhan.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
