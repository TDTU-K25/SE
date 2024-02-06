using BLL;
using DocumentFormat.OpenXml.Wordprocessing;
using DTO;
using FinalProject.App.Admin.ThemNguoiDung;
using FinalProject.QLHTTTSV_TDTDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.GiangVien.NhapDiem
{
    public partial class UC_NhapDiem : UserControl
    {
        private int num = 0;
        private MonHocBLL monHocBLL = new MonHocBLL();
        private DiemBLL diemBLL = new DiemBLL();
        private string gvId;

        private object oldValue = null;


        List<string> selectedRowsId;
        public UC_NhapDiem(string id)
        {
            InitializeComponent();
            this.gvId = id;
            loadCbbMon();
            cbbMon.SelectedIndex = 0;
            loadAllDiemSinhVienOfMonHoc(cbbMon.SelectedValue.ToString());
        }
        
        private void loadCbbMon()
        {
            DataTable dt = monHocBLL.GetAllMonHocByGvId(gvId);
            cbbMon.DataSource = dt;
            dt.Columns.Add("Mon");
            foreach (DataRow item in dt.Rows)
            {
                // h load sv học môn đó ca đó hạ ừ đúng rmaf môn này chuaw có điểm nên ko có j hết đổi gv đi
                item["Mon"] = item["Tên môn"].ToString() + " Ca " + item["Ca học"].ToString() + " " + item["Thứ"].ToString();
            }
            cbbMon.DisplayMember = "Mon";
            cbbMon.ValueMember = "Mã môn";
        }

     
        private void loadAllDiemSinhVienOfMonHoc(string monHocId)
        {
            DataTable dt = diemBLL.GetAllDiemSvByMonHocId(monHocId);
            dgv_diemdanh.DataSource = dt; 
        }
        
      

        private double? ValidateAndParseDouble(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                Regex regex = new Regex(@"^(10(\.0{1,2})?|[0-9](\.[0-9]{1,2})?)$");
                if (regex.IsMatch(input))
                {
                    return double.Parse(input);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số thập phân từ 0 đến 10.");
                    return -1;
                }
            }
            return null;
        }

       
        private void cbbMon_SelectedValueChanged(object sender, EventArgs e)
        {
            loadAllDiemSinhVienOfMonHoc(cbbMon.SelectedValue.ToString());
        }

        private void dgv_diemdanh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string diemId = dgv_diemdanh.CurrentRow.Cells[0].Value.ToString();
                double? diemQT1 = ValidateAndParseDouble(dgv_diemdanh.CurrentRow.Cells[3].Value?.ToString());
                double? diemQT2 = ValidateAndParseDouble(dgv_diemdanh.CurrentRow.Cells[4].Value?.ToString());
                double? diemGiuaKi = ValidateAndParseDouble(dgv_diemdanh.CurrentRow.Cells[5].Value?.ToString());
                double? diemCuoiKi = ValidateAndParseDouble(dgv_diemdanh.CurrentRow.Cells[6].Value?.ToString());
                double? diemTb = ValidateAndParseDouble(dgv_diemdanh.CurrentRow.Cells[7].Value?.ToString());
                string monhocId = cbbMon.SelectedValue.ToString();

                DiemThi dt = new DiemThi(diemQT1, diemQT2, diemCuoiKi, diemGiuaKi, diemTb, diemId, monhocId);


                diemBLL.UpdateDiemThi(dt);
            }
            catch (Exception ex)
            {
                dgv_diemdanh.CurrentCell.Value = oldValue;

                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void dgv_diemdanh_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue = dgv_diemdanh.CurrentCell.Value;
        }


        private void dgv_diemdanh_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if (dgv_diemdanh.CurrentCell.ColumnIndex == 3 || dgv_diemdanh.CurrentCell.ColumnIndex == 4 ||
                dgv_diemdanh.CurrentCell.ColumnIndex == 5 || dgv_diemdanh.CurrentCell.ColumnIndex == 6 ||
                dgv_diemdanh.CurrentCell.ColumnIndex == 7) // Kiểm tra cột cần áp dụng
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và các điều khiển như backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu chấm thập phân
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgv_diemdanh_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = dgv_diemdanh.RowCount;
            if (countRow <= 2)
            {
                dgv_diemdanh.Height = dgv_diemdanh.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_diemdanh.Height = dgv_diemdanh.RowTemplate.Height * countRow + 44;
            }
        }
    }
}
