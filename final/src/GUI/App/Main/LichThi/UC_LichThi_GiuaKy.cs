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

namespace FinalProject.App.Main.LichThi
{
    public partial class UC_LichThi_GiuaKy : UserControl
    {
        LichThiBLL lichThiBLL = new LichThiBLL();

        public UC_LichThi_GiuaKy()
        {
            InitializeComponent();
           
        }

        private void BindDataGridView(DataGridView dgv, DataTable dt, Panel panel)
        {
            dgv.DataSource = dt;

            int countRow = dgv.RowCount;
            if (countRow <= 2)
            {
                dgv.Height = dgv.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv.Height = dgv.RowTemplate.Height * countRow + 44;
            }
        }

        private void UC_LichThi_GiuaKy_Load(object sender, EventArgs e)
        {
            Home parentForm = this.ParentForm as Home;
            if (parentForm != null)
            {
                BindDataGridView(dgv_lichthi_giuaky, lichThiBLL.GetLichThiGKCuaSV(parentForm.sv.user_id), pn_lichthi);
            }
            
        }
    }
}
