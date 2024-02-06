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

namespace FinalProject.App.Main
{
    public partial class UC_Diem : UserControl
    {
        DiemBLL diemBLL = new DiemBLL();
        public UC_Diem()
        {
            InitializeComponent();
            cbb_hocky.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_hocky.SelectedIndex = 0;
        }

        private void UC_Diem_Load(object sender, EventArgs e)
        {
            Home parentForm = this.ParentForm as Home;
            if (parentForm != null)
            {
                dgv_diemthi.DataSource = diemBLL.GetDiemCuaSV(parentForm.sv.user_id);
            } 
        }

        private void dgv_diemthi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            int countRow = dgv_diemthi.RowCount;
            if (countRow <= 2)
            {
                dgv_diemthi.Height = dgv_diemthi.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_diemthi.Height = dgv_diemthi.RowTemplate.Height * countRow + 44;
            }
        }

        private void dgv_diemthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
