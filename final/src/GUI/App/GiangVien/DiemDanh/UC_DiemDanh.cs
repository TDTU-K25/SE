using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.GiangVien.DiemDanh
{
    public partial class UC_DiemDanh : UserControl
    {
        TeacherBLL teacherBll = new TeacherBLL();
        private int num = 0;
        private MonHocBLL monHocBLL = new MonHocBLL();
        SinhVienBLL sinhVienBLL = new SinhVienBLL();
        List<string> selectedRowsId;
        List<string> non_selectedRowsId;
        private string gvId;
        string monhoc_id;


        public UC_DiemDanh(string id)
        {
            InitializeComponent();
            this.gvId = id;
            selectedRowsId = new List<string>();
            non_selectedRowsId = new List<string>();
            loadCbbMon();
            cbb_lop.SelectedIndex = 0;


            //dgv_diemdanh.DataSource = dt;

            // không lấy được monhoc_id, chỉ lấy cái đầu tiên

            loadAllSinhVienOfMonHoc(cbb_lop.SelectedValue.ToString());
            monhoc_id = cbb_lop.SelectedValue.ToString();
            
            txt_tongsv.Text = dgv_diemdanh.RowCount.ToString();
        }

        private void loadCbbMon()
        {
            DataTable dt = monHocBLL.GetAllMonHocByGvId(gvId);
            cbb_lop.DataSource = dt;
            dt.Columns.Add("Mon");
            foreach (DataRow item in dt.Rows)
            {
                // h load sv học môn đó ca đó hạ ừ đúng rmaf môn này chuaw có điểm nên ko có j hết đổi gv đi
                item["Mon"] = item["Mã môn"].ToString() +" "+ item["Tên môn"].ToString() + " Ca " + item["Ca học"].ToString() + " " + item["Thứ"].ToString();
            }
            cbb_lop.DisplayMember = "Mon";
            cbb_lop.ValueMember = "Mã môn";
        }

        private void loadAllSinhVienOfMonHoc(string monhocId)
        {
            DataTable dt = SinhVienBLL.GetAllSVStudyMonHoc(monhocId);
            dgv_diemdanh.DataSource = dt;
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

        private void dgv_diemdanh_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            bool isChecked = (bool)dgv_diemdanh.Rows[e.RowIndex].Cells[2].Value;

            if (isChecked)
            {
                num += 1;
            }
            else
            {
                num -= 1;
            }

            txt_vang.Text = num.ToString();
        }

        private void dgv_diemdanh_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_diemdanh.IsCurrentCellDirty)
            {
                dgv_diemdanh.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void sVMHBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sinhVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            // Lấy monhoc_id trên value cbb_lop
            // Thêm DiemDanh trc
            teacherBll.InsertDiemDanh(monhoc_id);

            // Lấy DD_id trc rồi mới thêm (1)
            String id_dd = teacherBll.GetLastIdDiemDanh();


            // foreach và dk select ko đc chon
            foreach (DataGridViewRow row in dgv_diemdanh.Rows)
            {
                if (row.Cells["select"].Value == null || (bool)row.Cells["select"].Value == false)
                {
                    string userId = row.Cells[0].Value.ToString();

                    // Lấy Danh sách US không tích
                    non_selectedRowsId.Add(userId);
                }
            }

            // Lặp qua Danh sách US không tích va DD_id (1) để thêm vào SV_DD
            foreach (string element in non_selectedRowsId)
            {
                teacherBll.InsertSV_DD(element, id_dd);
            }


            // Lấy danh sách sinh viên đã được chọn (đã điểm danh)
            foreach (DataGridViewRow row in dgv_diemdanh.Rows)
            {
                // Kiểm tra nếu ô "select" được chọn
                if (row.Cells["select"].Value != null && (bool)row.Cells["select"].Value)
                {
                    // Lấy thông tin sinh viên (mã số sinh viên và tên)
                    string userId = row.Cells[0].Value.ToString();
                    //string name = row.Cells["name"].Value.ToString();

                    // Thực hiện các xử lý khác với thông tin sinh viên đã điểm danh ở đây

                    // Thêm userId vào danh sách đã chọn (nếu bạn cần)
                    selectedRowsId.Add(userId);
                }
            }

            // Hiển thị thông báo lưu thành công
            MessageBox.Show("Lưu thông tin điểm danh thành công");

            //int svshow = dgv_diemdanh.RowCount - selectedRowsId.Count;
            // Đặt lại số lượng sinh viên vắng và danh sách đã chọn (nếu cần)
            selectedRowsId.Clear();
            //txt_tongsv.Text = svshow.ToString();
            txt_vang.Text = "0";
        }

        private void cbb_lop_SelectedValueChanged(object sender, EventArgs e)
        {
            loadAllSinhVienOfMonHoc(cbb_lop.SelectedValue.ToString());
            monhoc_id = cbb_lop.SelectedValue.ToString();
            txt_tongsv.Text = dgv_diemdanh.RowCount.ToString();
        }
    }
}
