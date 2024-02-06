using BLL;
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

namespace FinalProject.App.Main.MonHocDangKy
{
    public partial class UC_MonHocDaDangKy : UserControl
    {
        MonHocBLL monHocBLL = new MonHocBLL();
        public UC_MonHocDaDangKy()
        {
            InitializeComponent();
        }

        private void loadDataGirdView()
        {
            Home parentForm = this.ParentForm as Home;
            if (parentForm != null )
            {
                dgv_mhdk.DataSource = monHocBLL.GetAllMonHocDKCuaSV(parentForm.sv.user_id);
            }
            
        }

        private void dgv_mhdk_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = dgv_mhdk.RowCount;
            if (countRow <= 2)
            {
                dgv_mhdk.Height = dgv_mhdk.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_mhdk.Height = dgv_mhdk.RowTemplate.Height * countRow + 44;
            }
        }

        private void UC_MonHocDaDangKy_Load(object sender, EventArgs e)
        {
            loadDataGirdView();
        }
    }
}
