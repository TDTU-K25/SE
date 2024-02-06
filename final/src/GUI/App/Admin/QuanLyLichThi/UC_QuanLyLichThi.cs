using BLL;
using DTO;
using FinalProject.App.Admin.QuanLySinhVien;
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

namespace FinalProject.App.Admin.QuanLyLichThi
{
    public partial class UC_QuanLyLichThi : UserControl
    {
        bool checkAction = false;
        LichThiBLL lichthiBLL = new LichThiBLL();
        List<string> selectedRowsId;
        private int num = 0;

        public UC_QuanLyLichThi()
        {
            InitializeComponent();
            //DataTable dt = lichthiBLL.GetLichThiGKCuaSV("us5");
            selectedRowsId = new List<string>();
            DataTable dt = lichthiBLL.GetAllLichThi();
            dgv_lichthi.DataSource = dt;


            setDisableButton();
            setEnableEdit(false);
            //cbb_phongthi.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbb_phongthi.SelectedIndex = -1;
            cbb_hinhthucthi.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbb_khoa.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbb_khoa.SelectedIndex = -1;
        }

        void loadDataGirdView()
        {
            dgv_lichthi.DataSource = lichthiBLL.GetAllLichThi();
        }
        // SETTING UI
        public void clearInput()
        {
            checkAction = false;
            txt_id.Clear();
            txt_idmh.Clear();
            txt_phong.Clear();
            txt_tg.Clear();
            //cbb_khoa.Refresh();
            //cbb_phongthi.Refresh();
            cbb_hinhthucthi.Refresh();
            dtp_ngaythi.ResetValue();
        }

        public void setEnableEdit(bool enable)
        {
            txt_id.Enabled = enable;
            txt_phong.Enabled = enable;
            //cbb_phongthi.Enabled = enable;
            txt_tg.Enabled = enable;
            cbb_hinhthucthi.Enabled = enable;
            //cbb_khoa.Enabled = enable;
            dtp_ngaythi.Enabled = enable;
            txt_idmh.Enabled = enable;
        }

        public void setDisableButton()
        {
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;

        }

        

        // SETTING BUTTON
        private void btn_them_Click(object sender, EventArgs e)
        {
            setEnableEdit(true);
            clearInput();
            txt_id.Text = lichthiBLL.GenerateLichThiID();
            txt_id.Enabled = false;
            txt_idmh.Focus();
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            checkAction = false;
        }

        

        private void btn_sua_Click(object sender, EventArgs e)
        {
            setEnableEdit(true);
            btn_luu.Enabled = true;
            checkAction = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //Check field
            // . . . .

            if (checkAction)
            {

                string timePattern = @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$";
                if (string.IsNullOrEmpty(txt_phong.Text))
                {
                    MessageBox.Show(" Vui lòng nhập phòng thi");
                    txt_phong.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_idmh.Text))
                {
                    MessageBox.Show(" Vui lòng nhập mã môn học");
                    txt_idmh.Focus();
                    return;
                }
                else if (dtp_ngaythi.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show(" Ngày thi không hợp lệ");
                    dtp_ngaythi.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(cbb_hinhthucthi.Text))
                {
                    MessageBox.Show(" Vui lòng nhập hình thức thi");
                    cbb_hinhthucthi.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_tg.Text))
                {
                    MessageBox.Show(" Vui lòng nhập thời gian");
                    txt_tg.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_tg.Text, timePattern))
                {
                    MessageBox.Show(" Thời gian không hợp lệ vui lòng nhập lại");
                    txt_tg.Focus();
                    return;
                }
                LichThi lichthi = new LichThi();
                lichthi.lt_id = txt_id.Text;
                lichthi.monhoc_id = txt_idmh.Text;
                lichthi.diaDiemThi = txt_phong.Text;
                lichthi.ngayThi = dtp_ngaythi.Value;
                lichthi.thoiGianThi = handle_TimeSpan(txt_tg.Text); // Xử lý time
                lichthi.hinhThucThi = cbb_hinhthucthi.Text;
                lichthi.user_id = "US0015";



                LichThiBLL.UpdateLichThi(lichthi);

                MessageBox.Show("Cập nhật thông báo thành công.", "Thông báo");
                loadDataGirdView();
                setDisableButton();
                setEnableEdit(false);
            }
            else
            {
                string timePattern = @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$";
                if (string.IsNullOrEmpty(txt_phong.Text))
                {
                    MessageBox.Show(" Vui lòng nhập phòng thi");
                    txt_phong.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_idmh.Text))
                {
                    MessageBox.Show(" Vui lòng nhập mã môn học");
                    txt_idmh.Focus();
                    return;
                }
                else if(dtp_ngaythi.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show(" Ngày thi không hợp lệ");
                    dtp_ngaythi.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(cbb_hinhthucthi.Text))
                {
                    MessageBox.Show(" Vui lòng nhập hình thức thi");
                    cbb_hinhthucthi.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_tg.Text))
                {
                    MessageBox.Show(" Vui lòng nhập thời gian");
                    txt_tg.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_tg.Text, timePattern))
                {
                    MessageBox.Show(" Thời gian không hợp lệ vui lòng nhập lại");
                    txt_tg.Focus();
                    return;
                }

                string lt_id = txt_id.Text;
                DateTime ngaythi = dtp_ngaythi.Value;

                //string khoa_id = cbb_khoa.Text;
                string phong = txt_phong.Text;
                string ht = cbb_hinhthucthi.Text;
                string mh_id = txt_idmh.Text;
                string user_id = "US0015";

                LichThi lt = new LichThi(lt_id, ngaythi, handle_TimeSpan(txt_tg.Text), phong, ht, user_id, mh_id);
                LichThiBLL.InsertLichThi(lt);
                MessageBox.Show("Thêm lịch thi thành công.", "Thông báo");
                loadDataGirdView();
                setDisableButton();
            }
        }

        public TimeSpan handle_TimeSpan(String tgStr)
        {
            tgStr = txt_tg.Text; // Lấy giá trị thời gian từ TextBox
            string[] timeParts = tgStr.Split(':'); // Tách chuỗi thành các phần giờ, phút và giây


            if (timeParts.Length == 3)
            {
                int hours, minutes, seconds;

                if (int.TryParse(timeParts[0], out hours) && int.TryParse(timeParts[1], out minutes) && int.TryParse(timeParts[2], out seconds))
                {
                    return new TimeSpan(hours, minutes, seconds); // Tạo đối tượng TimeSpan
                }
            }
            return TimeSpan.Zero;
        }
        
        private void btn_huy_Click(object sender, EventArgs e)
        {
            setDisableButton();
            clearInput();
            setEnableEdit(true);
        }

        // SETTING DataGridView
        private void dgv_licthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgv_lichthi.CurrentRow != null)
            //{
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                //MessageBox.Show("" + num + "");

                DataGridViewRow selectRow = dgv_lichthi.Rows[e.RowIndex];
                //string idThongBao = selectRow.Cells["tb_id"].Value.ToString();
                //string ngayDang = selectRow.Cells["ngayTaoDataGridViewTextBoxColumn"].Value.ToString();


                string _id, _tgthi, _phong, _hinhthuc, _mhid, _usid;
                DateTime _ngaythi;

                _id = selectRow.Cells[1].Value.ToString();
                _ngaythi = (DateTime)selectRow.Cells[2].Value;
                _tgthi = selectRow.Cells[3].Value.ToString();
                _phong = (String)selectRow.Cells[4].Value;
                _hinhthuc = (String)selectRow.Cells[5].Value;
                _mhid = selectRow.Cells[6].Value.ToString();


                txt_id.Text = _id;
                dtp_ngaythi.Value = _ngaythi;
                txt_tg.Text = _tgthi;
                txt_phong.Text = _phong;
                cbb_hinhthucthi.Text = _hinhthuc;
                txt_idmh.Text = _mhid;

                //cbb_khoa.Text = dgv_lichthi.Rows[e.RowIndex].Cells[4].Value.ToString();


                setEnableEdit(false);
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_them.Enabled = false;

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (selectedRowsId.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lịch thi!");
            }
            else
            {
                //MessageBox.Show("giá trị:"+ selectedRowsId.Count + "");
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (string id in selectedRowsId)
                    {
                        LichThiBLL.DeleteLichThi(id);
                    }
                    MessageBox.Show("Xóa lịch thi thành công");
                    loadDataGirdView();
                }
                else
                {
                    MessageBox.Show("Xóa lịch thi thất bại");
                    dgv_lichthi.CurrentRow.Cells[0].Value = false;
                }
            }

            setEnableEdit(false);
            selectedRowsId.Clear();
            clearInput();
            setDisableButton();

            
        }

        private void dgv_lichthi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            bool isChecked = (bool)dgv_lichthi.Rows[e.RowIndex].Cells[0].Value;

            if (isChecked)
            {
                num += 1;
                selectedRowsId.Add(dgv_lichthi.CurrentRow.Cells[1].Value.ToString());
            }
            else
            {
                num -= 1;
                selectedRowsId.Remove(dgv_lichthi.CurrentRow.Cells[1].Value.ToString());
            }
        }

        private void dgv_lichthi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //int countRow = dgv_lichthi.RowCount;

            int countRow = 10;
            if (countRow <= 2)
            {
                dgv_lichthi.Height = dgv_lichthi.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_lichthi.Height = dgv_lichthi.RowTemplate.Height * countRow + 44;
            }
        }
    }
}
