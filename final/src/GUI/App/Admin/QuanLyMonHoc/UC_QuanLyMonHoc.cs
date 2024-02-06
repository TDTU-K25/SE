using BLL;
using DTO;
using FinalProject.App.Admin.ThemNguoiDung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FinalProject.App.Admin.QuanLyMonHoc
{

    public partial class UC_QuanLyMonHoc : UserControl
    {
        private MonHocBLL monHocBLL;
        List<string> selectedRowsId;
        // true: Thêm môn học
        // false: Sửa môn học
        bool checkAction = false;
        TeacherBLL teacher = new TeacherBLL();
        public UC_QuanLyMonHoc()
        {
            InitializeComponent();
            monHocBLL = new MonHocBLL();
            DataTable dt = monHocBLL.GetAllMonHoc();
            loadCbbgiangvien();
            selectedRowsId = new List<string>();
            dgv_monhoc.DataSource = dt;
            cbbThu.SelectedIndex = 0;
            
            cbb_giangvien.SelectedItem = 0;
            setDisableButton();
            setEnable(false);
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
        private void loadDataGirdView()
        {
            DataTable dt = monHocBLL.GetAllMonHoc();
            dgv_monhoc.DataSource = dt;
        }
        private void loadCbbgiangvien()
        {
            DataTable dt = teacher.GetAllTeachers();
            cbb_giangvien.DataSource = dt;

            cbb_giangvien.DisplayMember = "hovaten";
            cbb_giangvien.ValueMember = "user_id";
        }
        public void setDisableButton()
        {
            //btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;
                
            clearInput();
        }

        public void setEnable(bool enable)
        {
            txt_ca.Enabled = enable;
            txt_hocphi.Enabled = enable;
            txt_phong.Enabled = enable;
            txt_sotinchi.Enabled = enable;
            txt_tenmh.Enabled = enable;
            dtp_ngaybatdau.Enabled = enable;
            dtp_ngayketthuc.Enabled = enable;
            cbbThu.Enabled = enable;
            cbb_giangvien.Enabled = enable;
        }

        public void clearInput()
        {
            checkAction = false;
            txt_ca.Clear();
            txt_hocphi.Clear();
            txt_id.Clear();
            txt_phong.Clear();
            txt_sotinchi.Clear();
            txt_tenmh.Clear();
            dtp_ngaybatdau.ResetValue();
            dtp_ngayketthuc.ResetValue();
            cbbThu.Refresh();
            cbb_giangvien.Refresh();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            clearInput();
            setEnable(true);
            txt_id.Text = monHocBLL.GenerateMonHocID();
            txt_tenmh.Focus();
            btn_luu.Enabled = true;
            checkAction = false;

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            setDisableButton();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //Check field
            // . . . . 
            int sotinchi;
           
            if (checkAction)
            {
                if (string.IsNullOrWhiteSpace(txt_tenmh.Text))
                {
                    MessageBox.Show(" Vui lòng nhập tên môn học");
                    txt_tenmh.Focus();
                    return;
                }
                else if (txt_tenmh.Text.All(char.IsLetter))
                {
                    MessageBox.Show("Tên môn hoc không hợp lệ. Vui lòng nhập lại");
                    txt_tenmh.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txt_sotinchi.Text))
                {
                    MessageBox.Show(" Vui lòng nhập số tín chỉ");
                    txt_sotinchi.Focus();
                    return;
                }
                else if (!int.TryParse(txt_sotinchi.Text, out sotinchi) || sotinchi < 0 || sotinchi > 4)
                {
                    MessageBox.Show("Số tín chỉ không hợp lệ");
                    txt_sotinchi.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_hocphi.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("Học phí không hợp lệ");
                    txt_hocphi.Focus();
                    return;
                }
                else if (dtp_ngaybatdau.Value<DateTime.Now)
                {
                    MessageBox.Show("Ngày bắt đầu  không hợp lệ");
                    dtp_ngaybatdau.Focus();
                    return;
                }
                else if (dtp_ngayketthuc.Value <= dtp_ngaybatdau.Value )
                {
                    MessageBox.Show("Ngày kết thúc không hợp lệ");
                    dtp_ngayketthuc.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_phong.Text))
                {
                    MessageBox.Show(" Vui lòng nhập phòng học");
                    txt_phong.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_phong.Text, @"^[A-E][0-9]0[0-9]$"))
                {
                    MessageBox.Show("Phòng học không hợp lệ ");
                    txt_phong.Focus();
                    return;
                }
                
                else if (string.IsNullOrWhiteSpace(txt_ca.Text))
                {
                    MessageBox.Show(" Vui lòng nhập ca học");
                    txt_ca.Focus();
                    return;
                }
                else if (!int.TryParse(txt_sotinchi.Text, out sotinchi) || sotinchi < 0 || sotinchi > 4)
                {
                    MessageBox.Show(" Ca học không hợp lệ");
                    txt_sotinchi.Focus();
                    return;
                }
                MonHoc mh = new MonHoc(txt_tenmh.Text, int.Parse(txt_sotinchi.Text), int.Parse(txt_hocphi.Text), txt_phong.Text,
                        int.Parse(txt_ca.Text), cbbThu.SelectedItem.ToString(), dtp_ngaybatdau.Value, dtp_ngayketthuc.Value);
                mh.monhoc_id = txt_id.Text;
                
               
                if (monHocBLL.UpdateMonHoc(mh, dgv_monhoc.CurrentRow.Cells[7].Value.ToString(), cbb_giangvien.SelectedValue.ToString()))
                {
                    loadDataGirdView();
                    MessageBox.Show("Cập nhật môn học thành công.", "Thông báo");
                }

                setEnable(false);
                setDisableButton();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txt_tenmh.Text))
                {
                    MessageBox.Show(" Vui lòng nhập tên môn học");
                    txt_tenmh.Focus();
                    return;
                }
                else if (!txt_tenmh.Text.All(char.IsLetter))
                {
                    MessageBox.Show("Tên môn hoc không hợp lệ. Vui lòng nhập lại");
                    txt_tenmh.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_sotinchi.Text))
                {
                    MessageBox.Show(" Vui lòng nhập số tín chỉ");
                    txt_sotinchi.Focus();
                    return;
                }
                else if (!int.TryParse(txt_sotinchi.Text, out sotinchi) || sotinchi < 0 || sotinchi > 4)
                {
                    MessageBox.Show("Số tín chỉ không hợp lệ");
                    txt_sotinchi.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_hocphi.Text))
                {
                    MessageBox.Show(" Vui lòng nhập học phí môn");
                    txt_hocphi.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_hocphi.Text, @"^\d{1,10}$"))
                {
                    MessageBox.Show("Học phí không hợp lệ");
                    txt_hocphi.Focus();
                    return;
                }
                else if (dtp_ngaybatdau.Value < DateTime.Now)
                {
                    MessageBox.Show("Ngày bắt đầu  không hợp lệ");
                    dtp_ngaybatdau.Focus();
                    return;
                }
                else if (dtp_ngayketthuc.Value <= dtp_ngaybatdau.Value)
                {
                    MessageBox.Show("Ngày kết thúc không hợp lệ");
                    dtp_ngayketthuc.Focus();
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txt_phong.Text))
                {
                    MessageBox.Show(" Vui lòng nhập phòng học");
                    txt_phong.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_phong.Text, @"^[A-E][0-9]0[0-9]$"))
                {
                    MessageBox.Show("Phòng học không hợp lệ ");
                    txt_phong.Focus();
                    return;
                }

                else if (string.IsNullOrWhiteSpace(txt_ca.Text))
                {
                    MessageBox.Show(" Vui lòng nhập ca học");
                    txt_ca.Focus();
                    return;
                }
                else if (!int.TryParse(txt_sotinchi.Text, out sotinchi) || sotinchi < 0 || sotinchi > 4)
                {
                    MessageBox.Show(" Ca học không hợp lệ");
                    txt_sotinchi.Focus();
                    return;
                }
                MonHoc mh = new MonHoc(txt_tenmh.Text, int.Parse(txt_sotinchi.Text), int.Parse(txt_hocphi.Text), txt_phong.Text,
                        int.Parse(txt_ca.Text), cbbThu.SelectedItem.ToString(), dtp_ngaybatdau.Value, dtp_ngayketthuc.Value);
                if(monHocBLL.AddMonhoc(mh ,cbb_giangvien.SelectedValue.ToString()))
                {
                    loadDataGirdView();
                    MessageBox.Show("Thêm môn học thành công.", "Thông báo");
                    
                }
                else
                {
                    MessageBox.Show("Lỗi.", "Thông báo");
                }
                setEnable(false);
                setDisableButton();
            }
            clearInput();
        }

        private void dgv_monhoc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_monhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_monhoc.CurrentRow != null)
            {
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;

                if (dgv_monhoc.CurrentRow.Cells[0].Value == null)
                {
                    selectedRowsId.Add(dgv_monhoc.CurrentRow.Cells[1].Value.ToString());
                    dgv_monhoc.CurrentRow.Cells[0].Value = true;
                }
                else
                {
                    selectedRowsId.Remove(dgv_monhoc.CurrentRow.Cells[1].Value.ToString());
                    dgv_monhoc.CurrentRow.Cells[0].Value = null;
                }

                txt_id.Text = dgv_monhoc.CurrentRow.Cells[1].Value.ToString();
                txt_tenmh.Text = dgv_monhoc.CurrentRow.Cells[2].Value.ToString();
                txt_sotinchi.Text = dgv_monhoc.CurrentRow.Cells[3].Value.ToString();
                txt_hocphi.Text = dgv_monhoc.CurrentRow.Cells[4].Value.ToString();
                dtp_ngaybatdau.Value = (DateTime)dgv_monhoc.CurrentRow.Cells[5].Value;
                dtp_ngayketthuc.Value = (DateTime)dgv_monhoc.CurrentRow.Cells[6].Value;
                txt_ca.Text = dgv_monhoc.CurrentRow.Cells[8].Value.ToString();
                txt_phong.Text = dgv_monhoc.CurrentRow.Cells[9].Value.ToString();
                cbbThu.SelectedItem = dgv_monhoc.CurrentRow.Cells[10].Value.ToString();
                cbb_giangvien.SelectedValue = dgv_monhoc.CurrentRow.Cells[11].Value.ToString();
            }
        }
        
        private void btn_sua_Click(object sender, EventArgs e)
        {
            setEnable(true);
            txt_tenmh.Select();
            btn_luu.Enabled = true;
            checkAction = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (selectedRowsId.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học muốn xóa");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (string id in selectedRowsId)
                    {
                        monHocBLL.DeleteMonHoc(id);
                        loadDataGirdView();
                    }
                    MessageBox.Show("Xóa môn học thành công");
                }
               
            }
        }
    }
}
