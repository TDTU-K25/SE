using BLL;
using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DTO;
using FinalProject.App.Main.ThongBao;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace FinalProject.App.Admin.QuanLySinhVien
{
    public partial class UC_QuanLySinhVien : UserControl
    {
        UserBLL userBLL = new UserBLL();
        SinhVienBLL svBLL = new SinhVienBLL();

        private int num = 0;

        public UC_QuanLySinhVien()
        {
            InitializeComponent();


            loadDataGirdView();

            btn_search.Enabled = false;

        }

        void loadDataGirdView()
        {
            dgv_listsinhvien.DataSource = userBLL.GetAllSv();
        }

        private void dgv_listsinhvien_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                dgv_listsinhvien[e.ColumnIndex, e.RowIndex].ToolTipText = string.Empty;

                e.Graphics.DrawImage(Properties.Resources.pencil_edit_24, new Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }

        private void dgv_listsinhvien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = 10;
            if (countRow <= 2)
            {
                dgv_listsinhvien.Height = dgv_listsinhvien.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_listsinhvien.Height = dgv_listsinhvien.RowTemplate.Height * countRow + 44;
            }
        }

        private void dgv_listsinhvien_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                dgv_listsinhvien.Cursor = Cursors.Hand;
            }
            else
            {
                dgv_listsinhvien.Cursor = Cursors.Default;
            }
        }

        private void dgv_listsinhvien_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_listsinhvien.Cursor = Cursors.Default;
            }
        }

        private void dgv_listsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                DataGridViewRow selectRow = dgv_listsinhvien.Rows[e.RowIndex];
                //string idThongBao = selectRow.Cells["tb_id"].Value.ToString();
                //string ngayDang = selectRow.Cells["ngayTaoDataGridViewTextBoxColumn"].Value.ToString();

                string _id, _hoten, _xeploai, _khoa, _user_id, _lop;

                _id = selectRow.Cells[1].Value.ToString();
                _hoten = selectRow.Cells[2].Value.ToString();
                _xeploai = selectRow.Cells[3].Value.ToString();
                _khoa = selectRow.Cells[4].Value.ToString();
                _user_id = selectRow.Cells[5].Value.ToString();
                //_lop = selectRow.Cells[5].Value.ToString();

                User user = userBLL.GetSvByUserId_LoadInputSV(_user_id);
                

                EditSinhVien formedit = new EditSinhVien(true);

                formedit.txt_mssv.Text = _id;
                formedit.txt_hoten.Text = _hoten;
                formedit.txt_khoa.Text = _khoa;
                formedit.txt_gioitinh.Text = user.gioitinh;
                //formedit.txt_lop.Text = _lop;
                formedit.txt_email.Text = user.email;
                formedit.cbbLoaiSv.SelectedItem = _xeploai;
                formedit.txt_sdt.Text = user.numberPhone;
                formedit.dtp_ngaysinh.Value = user.Ngaysinh;
                formedit.txt_diachi.Text = user.diachi;

                formedit.ShowDialog();
                loadDataGirdView();
            }
        }
        private void FormEdit_SuccessUpdate(object sender, EventArgs e)
        {
            loadDataGirdView();
        }

        private void dgv_listsinhvien_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_listsinhvien.IsCurrentCellDirty)
            {
                dgv_listsinhvien.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_listsinhvien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            bool isChecked = (bool)dgv_listsinhvien.Rows[e.RowIndex].Cells[0].Value;

            if (isChecked)
            {
                num += 1;
            }
            else
            {
                num -= 1;
            }

            txt_slchon.Text = num.ToString();
        }

        private void btn_addsinhvien_Click(object sender, EventArgs e)
        {
            EditSinhVien editSinhVien = new EditSinhVien(false);
            editSinhVien.txt_mssv.Text = svBLL.GenerateSinhVienID();
            editSinhVien.ShowDialog();
            loadDataGirdView();
        }
        private void btn_deletesinhvien_Click(object sender, EventArgs e)
        {
            //Tạo Dialong để confirm xoá
            foreach (DataGridViewRow item in this.dgv_listsinhvien.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    SinhVienBLL.DeleteSinhVien(item.Cells[1].Value.ToString());
                }
            }
            if (num != 0)
            {
                MessageBox.Show("Xóa sinh viên thành công.", "Thông báo");
                loadDataGirdView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xoá.", "Thông báo");
            }
            num = 0;
            txt_slchon.Text = "0";
        }

        private void txt_searchsv_TextChanged(object sender, EventArgs e)
        {
            if(txt_searchsv.Text.Length == 0)
            {
                btn_search.Enabled= false;
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




        // Call this method to export the data to Excel
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
                    p.Workbook.Properties.Title = "Báo cáo tổng hợp sinh viên";

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
                                        "Mã SV",
                                        "Họ và tên",
                                        "Xếp loại",
                                        "Khoa",
                                        "User_id",

                    };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Thống kê thông tin Sinh Viên TDT";
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
                    DataTable dataTable = (DataTable)dgv_listsinhvien.DataSource;

                    // Convert DataTable to List<SinhVien>
                    List<SinhVien> svList = dataTable.AsEnumerable()
                        .Select(row => new SinhVien
                        {
                            Sv_id = row.Field<string>("Sv_id"),
                            hovaten = row.Field<string>("hovaten"),
                            LoaiSv = row.Field<string>("LoaiSv"),
                            Khoa_id = row.Field<string>("Khoa_id"),
                            user_id = row.Field<string>("user_id"),
                            // Add other properties as needed
                        })
                        .ToList();

                    //MessageBox.Show("" + userList);
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in svList)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.Sv_id;
                        ws.Cells[rowIndex, colIndex++].Value = item.hovaten;
                        ws.Cells[rowIndex, colIndex++].Value = item.LoaiSv;
                        ws.Cells[rowIndex, colIndex++].Value = item.Khoa_id;
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
