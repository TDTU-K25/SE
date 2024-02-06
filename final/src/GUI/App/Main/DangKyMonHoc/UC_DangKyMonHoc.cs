using BLL;
using DTO;
using FinalProject.App.Admin.QuanLySinhVien;
using FinalProject.App.Main.DangKyMonHoc;
using System;
using System.Collections;
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
    public partial class UC_DangKyMonHoc : UserControl
    {
        MonHocBLL monHocBLL = new MonHocBLL();
        UserBLL userBLL = new UserBLL();
        HocPhiBLL hocPhiBLL = new HocPhiBLL();
        private int num = 0;
        SinhVien sv;

        public UC_DangKyMonHoc()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            dgv_dkmh.BorderStyle = BorderStyle.None;
            dgv_dkmh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_dkmh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_dkmh.BackgroundColor = Color.White;

            dgv_dkmh.EnableHeadersVisualStyles = false;


            // Tạo và cấu hình label
              txt_notification.AutoSize = true; // Cho phép tự động điều chỉnh kích thước theo nội dung
            txt_notification.Text = GetNotificationText(); // Gán giá trị văn bản cho label

            // Đặt sự kiện thay đổi kích thước form
            this.Resize += UC_DangKyMonHoc_Resize;
        }   

        

        private void UC_DangKyMonHoc_Load(object sender, EventArgs e)
        {
            Home parentForm = this.ParentForm as Home;
            if (parentForm != null)
            {
                sv = parentForm.sv;
                DataTable dtMonHocDK = monHocBLL.GetAllMonHocDKCuaSV(parentForm.sv.user_id);
                
                string[] results = new string[dtMonHocDK.Rows.Count];
                for (int index = 0; index < dtMonHocDK.Rows.Count; index++)
                {
                    results[index] = dtMonHocDK.Rows[index][0].ToString();
                }

                // check all the checkbox for register subject before
                // debug correct but do not know why it not display on UI
                DataTable dt = monHocBLL.GetAllMonHoc();
                dgv_dkmh.DataSource = dt;

                foreach (DataGridViewColumn column in dgv_dkmh.Columns)
                {
                    if (column.Name == "Chon") // Thay "ColumnName" bằng tên cột chứa ô kiểm
                    {
                        if (column is DataGridViewCheckBoxColumn)
                        {
                            // Đây là cột kiểu checkbox, kiểm tra kiểu dữ liệu và đặt giá trị
                            foreach (DataGridViewRow row in dgv_dkmh.Rows)
                            {
                                string cellValue = row.Cells[1].Value.ToString();
                                if (results.Contains(cellValue))
                                {
                                    row.Cells["Chon"].Value = true;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cột không phải kiểu CheckBoxColumn");
                        }
                    }
                }

            }
        }

        private void dgv_dkmh_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = dgv_dkmh.RowCount;
            if (countRow <= 2)
            {
                dgv_dkmh.Height = dgv_dkmh.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_dkmh.Height = dgv_dkmh.RowTemplate.Height * countRow + 44;
            }
        }

        private void btn_xacnhandk_Click(object sender, EventArgs e)
        {
            var idOfAllMonHocDk = new ArrayList();
            foreach (DataGridViewRow row in dgv_dkmh.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    row.Cells[0].Value = false;
                }
                
                if ((bool) row.Cells[0].Value == true)
                {
                    idOfAllMonHocDk.Add(row.Cells[1].Value);
                }
            }

            XacNhanDangKy inputForm = new XacNhanDangKy();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string enteredValue = inputForm.EnteredValue;

                bool isValid = true;
                // Check mật khẩu xem có đúng không
                // . . .
                if(enteredValue.Length == 0)
                {
                    isValid = false;
                }
                // -> isValid

                if(isValid)
                {
                    // Delete all register subject before
                    monHocBLL.DeleteAllMonHocDKCuaSV(sv.user_id);


                    List<MonHoc> cacMonHoc = new List<MonHoc>();
                    foreach (var idMonHoc in idOfAllMonHocDk)
                    {
                        monHocBLL.RegisterSubject(sv.user_id, (string) idMonHoc);
                        MonHoc monHoc = monHocBLL.GetMonHocById((string) idMonHoc);
                        cacMonHoc.Add(monHoc);
                    }

                    int tongTienHoc = 0;
                    for (int i = 0; i < cacMonHoc.Count; i++)
                    {
                        tongTienHoc += cacMonHoc[i].hocPhiMon;
                    }

                    hocPhiBLL.CreateOrder(sv.user_id, tongTienHoc);

                    // When create new order the hd_id will be update to table sv
                    sv.Hoadon_id = userBLL.GetSVByUserId(sv.account_id).Hoadon_id;

                    foreach (var idMonHoc in idOfAllMonHocDk)
                    {
                        hocPhiBLL.CreateDetailOrder(sv.Hoadon_id, (string) idMonHoc);
                    }


                    MessageBox.Show("Đăng ký môn học thành công.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!\nVui lòng kiểm tra lại mật khẩu.", "Thông báo");
                }
            }
        }

        private void UC_DangKyMonHoc_Resize(object sender, EventArgs e)
        {
            txt_notification.Text = GetNotificationText();
        }

        private string GetNotificationText()
        {
            // Trả về văn bản thông báo, bạn có thể thay đổi nó theo nhu cầu của mình
            return "NHỮNG ĐIỀU SINH VIÊN CẦN LƯU Ý KHI ĐĂNG KÝ MÔN HỌC - REMARKABLE TERMS AND CONDITIONS WHEN CONFIRMING COURSES REGISTRATION\r\n1. \"Các môn học đang chọn\": là danh sách môn học bạn lựa chọn để học chính thức trong học kỳ.\\nSau khi xác nhận mật khẩu thì danh sách này chính là danh sách môn học mà bạn đăng ký thành công trong học kỳ.\r\n\"List of courses successfully registered\": is the list of courses you select to study officially during the semester. After confirming by entering your password of your portal, this is the list of courses that you successfully registered in the semester.\r\n\r\n2. \"Danh sách môn học có nguyện vọng đăng ký vào nhóm đầy sĩ số\": là danh sách nhóm môn học đã đủ số lượng sinh viên đăng ký, nhưng sinh viên có nguyện vọng muốn đăng ký thêm vào.\\nLưu ý Hiện nay nhóm môn học sinh viên có nguyện vọng đăng ký đã đầy sĩ số, phòng Đại học tạm mở cho sinh viên đăng ký vào nhóm môn học đầy. Sau khi kết thúc thời gian đăng ký đợt bổ sung, phòng Đại học sẽ thống kê số lượng sinh viên và gửi về Khoa để xem xét về việc mở thêm nhóm hoặc cho sinh viên chính thức vào nhóm đầy. Trong trường hợp Khoa không mở thêm nhóm hoặc không đồng ý cho SV vào nhóm đầy thì kết quả đăng ký môn học trên sẽ bị hủy. Sinh viên kiểm tra email và sẽ đăng ký lại vào các học kỳ tiếp theo.\r\n\"List of courses that students wish to enroll in a group full of students\": is a list of course groups that have had enough registered students, but students wish to register in additionally. Note that the course group students want to register is full, the department of Undergraduate Studies open for students to register in the full course group temporarily. After the end of the registration period for the additional phase, the Department of Undergraduate Studies will make a statistics of the number of students and send it to the Faculty for consideration on opening more groups or allowing students to officially join the full group. In case the Faculty does not open more groups or does not agree to allow students to enter the full group, the results of the above course registration will be cancelled. Students check your email and will re-register in the following semesters.\r\n\r\nNếu sinh viên còn vấn đề gì chưa rõ, sinh viên vui lòng liên hệ Thầy/Cô Văn phòng Tư vấn & hỗ trợ - Phòng E0001 theo địa chỉ email: tuvanhocduong@tdtu.edu.vn hoặc liên hệ số điện thoại: 090 9670 911 / (028)-22477215 (trong giờ hành chính) để được thầy/cô giải đáp thắc mắc.\r\nIf students still have unclear problems, please contact the Student Services Office - Room E0001 at email address: tuvanhocduong@tdtu.edu.vn or contact phone number: 090 9670 911 / (028)-22477215 (during administrative hours) to be answered your questions.\r\n";
        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
