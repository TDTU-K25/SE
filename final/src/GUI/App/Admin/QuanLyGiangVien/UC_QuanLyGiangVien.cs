using BLL;
using DTO;
using FinalProject.App.Admin.QuanLySinhVien;
using FinalProject.App.Admin.ThemNguoiDung;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Admin.QuanLyGiangVien
{
    public partial class UC_QuanLyGiangVien : UserControl
    {

        TeacherBLL teacherBLL = new TeacherBLL();
        UserBLL userBLL = new UserBLL();
        private int num = 0;
        List<string> selectedRowsId;

        public UC_QuanLyGiangVien()
        {
            InitializeComponent();

            loadDataGirdView();
            btn_search.Enabled = false;
            selectedRowsId = new List<string>();
        } 

        private void loadDataGirdView()
        {
            DataTable dt = teacherBLL.GetAllTeachers();
            dgv_listgiangvien.DataSource = dt;
        }

        private void dgv_listgiangvien_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Index col btn edit
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.pencil_edit_24.Width;
                var h = Properties.Resources.pencil_edit_24.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                // Set bg color btn edit
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
                dgv_listgiangvien[e.ColumnIndex, e.RowIndex].ToolTipText = string.Empty;

                e.Graphics.DrawImage(Properties.Resources.pencil_edit_24, new Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }

        private void dgv_listgiangvien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = dgv_listgiangvien.RowCount;
            if (countRow <= 2)
            {
                dgv_listgiangvien.Height = dgv_listgiangvien.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_listgiangvien.Height = dgv_listgiangvien.RowTemplate.Height * countRow + 44;
            }

        }

        private void dgv_listgiangvien_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_listgiangvien.Cursor = Cursors.Default;
            }
        }

        private void dgv_listgiangvien_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                dgv_listgiangvien.Cursor = Cursors.Hand;
            }
            else
            {
                dgv_listgiangvien.Cursor = Cursors.Default;
            }
        }

        private void dgv_listgiangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                DataGridViewRow selectRow = dgv_listgiangvien.Rows[e.RowIndex];

                string _id, _hoten, _loai, _makhoa, _user_id;
                _id = selectRow.Cells[1].Value.ToString();
                _hoten = selectRow.Cells[2].Value.ToString();
                _loai = selectRow.Cells[3].Value.ToString();
                _makhoa = selectRow.Cells[4].Value.ToString();
                _user_id = selectRow.Cells[5].Value.ToString();

                User user = userBLL.GetGvByUserId(_user_id);

                EditGiangVien formEdit = new EditGiangVien(true);
                formEdit.SuccessUpdate += FormEdit_SuccessUpdate;
                formEdit.txt_gvId.Text = _id;
                formEdit.txt_hoten.Text = _hoten;
                formEdit.cbbKhoa.SelectedValue = _makhoa;
                formEdit.txt_diachi.Text = user.diachi;
                formEdit.txt_email.Text = user.email;
                if( formEdit.rdb_gioitinh1.Checked== true)
                {
                    formEdit.rdb_gioitinh1.Text = user.gioitinh;
                }
                else
                {
                    formEdit.rdb_gioitinh2.Text = user.gioitinh;
                }    

                formEdit.txt_sdt.Text = user.numberPhone;
                formEdit.cbbLoai.SelectedItem = _loai;
                formEdit.dtp_ngaysinh.Value = user.Ngaysinh;
               
                formEdit.ShowDialog();
                
            }
        }

        private void FormEdit_SuccessUpdate(object sender, EventArgs e)
        {
            loadDataGirdView();
            num = 0;
            txt_slchon.Text = "0";
        }

        private void dgv_listgiangvien_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_listgiangvien.IsCurrentCellDirty)
            {
                dgv_listgiangvien.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_listgiangvien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            bool isChecked = (bool)dgv_listgiangvien.Rows[e.RowIndex].Cells[0].Value;

            if (isChecked)
            {
                num += 1;
                selectedRowsId.Add((string)dgv_listgiangvien.Rows[e.RowIndex].Cells[1].Value);
            }
            else
            {
                num -= 1;
                selectedRowsId.Remove((string)dgv_listgiangvien.Rows[e.RowIndex].Cells[1].Value);
            }

            txt_slchon.Text = num.ToString();
        }
        
        private void txt_searchsv_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchsv.Text.Length == 0)
            {
                btn_search.Enabled = false;
            }
            else
            {
                btn_search.Enabled = true;
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không tìm thấy thông tin người dùng trong hệ thống", "Thông báo");
        }
        
        private void btn_addgiangvien_Click(object sender, EventArgs e)
        {

            EditGiangVien form = new EditGiangVien(false);
            form.txt_gvId.Text = teacherBLL.GenerateGiangVienID();
            form.SuccessInsert += Form_SuccessInsert;
            form.ShowDialog();

        }

        private void Form_SuccessInsert(object sender, EventArgs e)
        {
            loadDataGirdView();
        }

        private void btn_xoagiangvien_Click(object sender, EventArgs e)
        {
            
            if (selectedRowsId.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giảng viên muốn xóa");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (string id in selectedRowsId)
                    {
                        teacherBLL.DeleteTeacher(id);
                        loadDataGirdView();
                        
                    }
                    MessageBox.Show("Xóa giảng  viên thành công");
                }
                txt_slchon.Text = "0";
                num = 0;
            }
            
        }

        private void txt_slchon_Click(object sender, EventArgs e)
        {

        }
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }



            try
            {
                using (var p = new ExcelPackage(new FileInfo("MyWorkbook.xlsx")))
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "Admin";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Báo cáo tổng hợp giảng viên";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("sheet");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets["sheet"];

                    // đặt tên cho sheet
                    ws.Name = "sheet";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                        "Mã GV",
                                        "Họ và tên",
                                        "Loại GV",
                                        "Khoa",
                                        "User_id",

                    };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Thống kê thông tin Giảng Viên TDT";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;

                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }

                    // lấy ra danh sách SinhVien từ ItemSource của DataGrid
                    DataTable dataTable = (DataTable)dgv_listgiangvien.DataSource;

                    // Convert DataTable to List<SinhVien>
                    List<Teacher> gvList = dataTable.AsEnumerable()
                        .Select(row => new Teacher
                        {
                            gv_id = row.Field<string>("GV_id"),
                            hovaten = row.Field<string>("hovaten"),
                            type= row.Field<string>("LoaiGv"),
                            khoa_id = row.Field<string>("Khoa_id"),
                            user_id = row.Field<string>("user_id"),
                            // Add other properties as needed
                        })
                        .ToList();

                    //MessageBox.Show("" + userList);
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in gvList)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.gv_id;
                        ws.Cells[rowIndex, colIndex++].Value = item.hovaten;
                        ws.Cells[rowIndex, colIndex++].Value = item.type;
                        ws.Cells[rowIndex, colIndex++].Value = item.khoa_id;
                        ws.Cells[rowIndex, colIndex++].Value = item.user_id;


                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}\n\nStackTrace: {ex.StackTrace}", "Export to Excel Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
