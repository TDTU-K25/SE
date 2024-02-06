using BLL;
using FinalProject.App.Main.ThongBao;
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

namespace FinalProject.App.Main.KhaoSatMonHoc
{
    public partial class UC_KhaoSatMonHoc : UserControl
    {
        MonHocBLL monHocBLL = new MonHocBLL();
        public UC_KhaoSatMonHoc()
        {
            InitializeComponent();

            

            txt_desc.Text = "Anh/Chị sinh viên thân mến,\r\nDear students,\r\n\r\n     " +
                "Nhằm mục đích đảm bảo đội ngũ giảng viên của Trường có chuyên môn và phương pháp giảng dạy tốt, từ góp phần nâng cao chất lượng giảng dạy và uy tín của Nhà trường đối với xã hội, Trường đề nghị Anh/Chị dành chút thời gian để thực hiện Bảng khảo sát này.\r\n\n     " +
                "Kết quả khảo sát được giữ kín nên Anh/Chị vui lòng đưa ra ý kiến khách quan của bản thân bằng cách điền vào chỗ trống hoặc đánh dấu vào lựa chọn mà Anh/Chị thấy phù hợp nhất.\r\n\n     " +
                "Lưu ý rằng các ý kiến của Anh/Chị sẽ được xem xét và có hành động khắc phục tương thích, vì thế Anh/Chị cần trả lời một cách thận trọng và có trách nhiệm. Đây cũng là quyền lợi và nghĩa vụ của Anh/Chị.\r\n     ";
            txt_desc.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Height, 0);
            txt_desc.AutoSize = true;
        }


        private void loadDataGirdView()
        {
            Home parentForm = this.ParentForm as Home;
            if (parentForm != null)
            {
                dgv_khaosatmonhoc.DataSource = monHocBLL.GetAllMonHocDKCuaSV(parentForm.sv.user_id);
            }
           
        }

        private void dgv_khaosatmonhoc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = dgv_khaosatmonhoc.RowCount;
            dgv_khaosatmonhoc.Height = 50 * countRow;
        }

        private void dgv_khaosatmonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                DataGridViewRow selectRow = dgv_khaosatmonhoc.Rows[e.RowIndex];
                string idMonhoc = selectRow.Cells["monhocidDataGridViewTextBoxColumn"].Value.ToString();
                string tenMonhoc = selectRow.Cells["tenMonHocDataGridViewTextBoxColumn"].Value.ToString();

                ChiTietKhaoSat formChiTiet = new ChiTietKhaoSat();
                formChiTiet.SetData(idMonhoc, tenMonhoc);

                formChiTiet.ShowDialog();
            }
        }

        private void UC_KhaoSatMonHoc_Load(object sender, EventArgs e)
        {
            
            loadDataGirdView();
        }
    }
}
