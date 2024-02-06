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

namespace FinalProject.Main
{
    public partial class UC_DiemRenLuyen : UserControl
    {
        DrlBBL drlBBL = new DrlBBL();
        public UC_DiemRenLuyen()
        {
            InitializeComponent();
            
        }

        private void dgv_drl_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = dgv_drl.RowCount;
            if (countRow <= 2)
            {
                dgv_drl.Height = dgv_drl.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_drl.Height = dgv_drl.RowTemplate.Height * countRow + 44;
            }
        }

        private void UC_DiemRenLuyen_Load(object sender, EventArgs e)
        {
            Home parentForm = this.ParentForm as Home;
            if (parentForm != null)
            {
                dgv_drl.DataSource = drlBBL.GetAllSKDrlSVJoin(parentForm.sv.user_id);
            }
        }
    }
}
