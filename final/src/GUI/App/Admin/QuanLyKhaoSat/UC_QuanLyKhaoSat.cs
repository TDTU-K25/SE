using BLL;
using FinalProject.App.Main.ThongBao;
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

namespace FinalProject.App.Admin.QuanLyKhaoSat
{
    public partial class UC_QuanLyKhaoSat : System.Windows.Forms.UserControl
    {
        MonHocBLL monHocBLL = new MonHocBLL();

        public UC_QuanLyKhaoSat()
        {
            InitializeComponent();
            DataTable dt = monHocBLL.GetAllMonHoc();
            dgv_monhoc.DataSource = dt;
            dgv_monhoc.Columns["xemkhaosat"].DefaultCellStyle.BackColor = System.Drawing.Color.White;

        }

        private void dgv_monhoc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = dgv_monhoc.RowCount;
            if (countRow <= 2)
            {
                dgv_monhoc.Height = dgv_monhoc.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_monhoc.Height = dgv_monhoc.RowTemplate.Height * countRow + 44;
            }
        }

        private void dgv_monhoc_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == 2) 
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All
                    & ~(DataGridViewPaintParts.ContentForeground));
                var r = e.CellBounds;
                r.Inflate(-4, -4);
                e.Graphics.FillRectangle(Brushes.White, r);
                e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);
                e.Handled = true;
            }
        }

        private void dgv_monhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                DataGridViewRow selectRow = dgv_monhoc.Rows[e.RowIndex];
                string idMonHoc = selectRow.Cells["monhocidDataGridViewTextBoxColumn"].Value.ToString();
                string tenMonHoc= selectRow.Cells["tenMonhocDataGridViewTextBoxColumn"].Value.ToString();

                UC_KhaoSat uc = new UC_KhaoSat(idMonHoc, tenMonHoc);

                pn_quanlylichthi.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                pn_quanlylichthi.Controls.Add(uc);
            }
        }
    }
}
