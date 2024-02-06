using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Admin.QuanLySuKien
{
    public partial class UC_QuanLySuKien : UserControl
    {
        DrlBBL sukienBBL = new DrlBBL();
        List<string> selectedRowsId;
        private int num = 0;
        // true: Thêm 
        // false: Sửa 
        bool checkAction = false;

        public UC_QuanLySuKien()
        {
            InitializeComponent();
            selectedRowsId = new List<string>();
            DataTable dt = sukienBBL.GetAllSKDRL();
            dgv_drl.DataSource = dt;

            dt = sukienBBL.GetAllLoaiDRL();

            setEnableEdit(false);

            // Đỗ dữ liệu vào cbb
            cbb_loaidiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_loaidiem.SelectedIndex = -1;
            cbb_loaidiem.DisplayMember = "loaiDRL";
            cbb_loaidiem.ValueMember = "DRL_id";
            cbb_loaidiem.DataSource = dt;
            setDisableButton();
        }

        void loadDataGirdView()
        {
            dgv_drl.DataSource = sukienBBL.GetAllSKDRL();
        }

        private void dgv_drl_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //int countRow = dgv_drl.RowCount;
            int countRow = 10;
            if (countRow <= 2)
            {
                dgv_drl.Height = dgv_drl.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_drl.Height = dgv_drl.RowTemplate.Height * countRow + 44;
            }
        }

        public void setEnableEdit(bool enable)
        {
            txt_id.Enabled = enable;
            txt_sodiem.Enabled = enable;
            txt_tensk.Enabled = enable;
            cbb_loaidiem.Enabled = enable;
            txt_tg.Enabled = enable;
            dtp_ngaytochuc.Enabled = enable;
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            setEnableEdit(true);
            btn_luu.Enabled = true;
            checkAction = true;
        }

        private void dgv_drl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectRow = dgv_drl.Rows[e.RowIndex];

            string _id, _tensk, _loaidrl, _tgtochuc, _diem;
            //int _diem;
            DateTime _ngaytochuc;

            _id = selectRow.Cells[1].Value.ToString();
            _tensk = selectRow.Cells[2].Value.ToString();
            _loaidrl = selectRow.Cells[3].Value.ToString();
            _diem = selectRow.Cells[4].Value.ToString();
            _ngaytochuc = (DateTime)selectRow.Cells[5].Value;
            _tgtochuc = selectRow.Cells[6].Value.ToString();


            txt_id.Text = _id;
            txt_tensk.Text = _tensk;
            cbb_loaidiem.Text = _loaidrl;
            txt_sodiem.Text = _diem;
            dtp_ngaytochuc.Value = _ngaytochuc;
            txt_tg.Text = _tgtochuc;

            setEnableEdit(false);
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //Check field
            // . . . .
            if (checkAction)
            {
                string timePattern = @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$";
                if (dtp_ngaytochuc.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show(" Ngày tổ chức không hợp lệ");
                    dtp_ngaytochuc.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_tensk.Text))
                {
                    MessageBox.Show(" Vui lòng nhập tên sự kiện");
                    txt_tensk.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_tg.Text))
                {
                    MessageBox.Show(" Vui lòng nhập thời gian sự kiện");
                    txt_tg.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_tg.Text, timePattern))
                {
                    MessageBox.Show(" Thời gian không hợp lệ vui lòng nhập lại");
                    txt_tg.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_sodiem.Text))
                {
                    MessageBox.Show(" Vui lòng nhập số điểm");
                    txt_sodiem.Focus();
                    return;
                }
                else if (!double.TryParse(txt_sodiem.Text, out _))
                {
                    MessageBox.Show("Số điểm không hợp lệ");
                    txt_sodiem.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(cbb_loaidiem.Text))
                {
                    MessageBox.Show(" Vui lòng nhập loại sự kiện");
                    cbb_loaidiem.Focus();
                    return;
                }

                SuKien sk = new SuKien();
                sk.DRL_id = txt_id.Text;
                sk.TenSK = txt_tensk.Text;
                sk.loaiDRL = cbb_loaidiem.Text;
                sk.Diem = int.Parse(txt_sodiem.Text);
                sk.ngaytochuc = dtp_ngaytochuc.Value; // Xử lý time
                sk.thoigiantochuc = handle_TimeSpan(txt_tg.Text);

                DrlBBL.UpdateSuKien(sk);
                MessageBox.Show("Cập nhật sự kiện thành công.", "Thông báo");
                loadDataGirdView();
                setDisableButton();
                setEnableEdit(false);
            }
            else
            {
                string timePattern = @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$";
                if (dtp_ngaytochuc.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show(" Ngày tổ chức không hợp lệ");
                    dtp_ngaytochuc.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_tensk.Text))
                {
                    MessageBox.Show(" Vui lòng nhập tên sự kiện");
                    txt_tensk.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_tg.Text))
                {
                    MessageBox.Show(" Vui lòng nhập thời gian sự kiện");
                    txt_tg.Focus();
                    return;
                }
                else if (!Regex.IsMatch(txt_tg.Text, timePattern))
                {
                    MessageBox.Show(" Thời gian không hợp lệ vui lòng nhập lại");
                    txt_tg.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txt_sodiem.Text))
                {
                    MessageBox.Show(" Vui lòng nhập số điểm");
                    txt_sodiem.Focus();
                    return;
                }
                else if (!double.TryParse(txt_sodiem.Text, out _))
                {
                    MessageBox.Show("Số điểm không hợp lệ");
                    txt_sodiem.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(cbb_loaidiem.Text))
                {
                    MessageBox.Show(" Vui lòng nhập loại sự kiện");
                    cbb_loaidiem.Focus();
                    return;
                }



                string drl_id = txt_id.Text;
                string tensk = txt_tensk.Text;
                string loaidiem = cbb_loaidiem.Text;

                string diem = txt_sodiem.Text;
                DateTime ngaytochuc = dtp_ngaytochuc.Value;
                string tgtochuc = txt_tg.Text;

                SuKien sk = new SuKien(drl_id, tensk, loaidiem, int.Parse(diem), ngaytochuc, handle_TimeSpan(tgtochuc));
                DrlBBL.InsertSuKien(sk);
                MessageBox.Show("Thêm sự kiện thành công.", "Thông báo");
                loadDataGirdView();
                setDisableButton();
            }
        }



        private void btn_huy_Click(object sender, EventArgs e)
        {
            setDisableButton();
            clearInput();
            setEnableEdit(true);
        }

        public void setDisableButton()
        {
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;
        }

        public void clearInput()
        {
            checkAction = false;
            txt_id.Clear();
            txt_sodiem.Clear();
            txt_tensk.Clear();
            cbb_loaidiem.Refresh();
            dtp_ngaytochuc.ResetValue();
            txt_tg.Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            clearInput();
            setEnableEdit(true);
            txt_id.Text = sukienBBL.GenerateSKDRLID();
            txt_id.Enabled = false;
            txt_tensk.Focus();
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            checkAction = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (selectedRowsId.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sự kiện!");
            }
            else
            {
                //MessageBox.Show("giá trị:"+ selectedRowsId.Count + "");
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (string id in selectedRowsId)
                    {
                        DrlBBL.DeleteSuKien(id);
                    }
                    MessageBox.Show("Xóa sự kiện thành công");
                    loadDataGirdView();
                }
                else
                {
                    MessageBox.Show("Xóa sự kiện thất bại");
                    dgv_drl.CurrentRow.Cells[0].Value = false;
                }
            }
            setEnableEdit(false);
            setDisableButton() ;
            selectedRowsId.Clear();
            clearInput();
        }

        private void dgv_drl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            bool isChecked = (bool)dgv_drl.Rows[e.RowIndex].Cells[0].Value;

            if (isChecked)
            {
                num += 1;
                selectedRowsId.Add(dgv_drl.CurrentRow.Cells[1].Value.ToString());
            }
            else
            {
                num -= 1;
                selectedRowsId.Remove(dgv_drl.CurrentRow.Cells[1].Value.ToString());
            }
        }
    }
}
