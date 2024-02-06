using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject.App.Admin.QuanLyThongBao
{
    public partial class UC_QuanLyThongBao : UserControl
    {
        ThongBaoBLL thongBaoBLL= new ThongBaoBLL();
        KhoaBLL khoaBLL = new KhoaBLL();
        
        string id;
        // true: Thêm 
        // false: Sửa 
        bool checkAction = false;
        List<string> selectedRowsId;
        public UC_QuanLyThongBao(string id)
        {
            InitializeComponent();
            loadThongBao();
            loadCbbKhoa();
            setDisableButton();
            this.id = id;
            cbb_doituong.SelectedIndex = 0;
            selectedRowsId = new List<string>();
            cbb_loaithongbao.SelectedIndex = 0;
            
            cbb_khoa.SelectedIndex = 0;
        }

        private void loadThongBao()
        {
            DataTable dt = thongBaoBLL.GetAllThongBao();
            dgv_thongbao.DataSource = dt;
        }

        private void loadCbbKhoa()
        {
            DataTable dt = khoaBLL.GetAllKhoa(); 
            cbb_khoa.DataSource = dt;
            
            cbb_khoa.DisplayMember = "tenKhoa"; 
            cbb_khoa.ValueMember = "khoa_id"; 
        }

        private void dgv_thongbao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //int countRow = dgv_drl.RowCount;
            int countRow = 10;
            if (countRow <= 2)
            {
                dgv_thongbao.Height = dgv_thongbao.RowTemplate.Height * countRow + 70;
            }
            else
            {
                dgv_thongbao.Height = dgv_thongbao.RowTemplate.Height * countRow + 44;
            }
        }

        public void setEnableEdit(bool enable)
        {
            txt_id.Enabled = enable;
            cbb_doituong.Enabled = enable;
            cbb_loaithongbao.Enabled = enable;
            cbb_khoa.Enabled = enable;
            dtp_ngayhethan.Enabled = enable;
            txt_noidung.Enabled = enable;
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
                if (txt_noidung.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập nội dung thông báo");
                    txt_noidung.Focus();
                }
                if (dtp_ngayhethan.Value < DateTime.Now)
                {
                    MessageBox.Show("Ngày hết hạn không phù hợp");
                    dtp_ngayhethan.Focus();
                }

                ThongBao tb = new ThongBao(txt_noidung.Text, cbb_loaithongbao.SelectedItem.ToString(), cbb_doituong.SelectedItem.ToString(), dtp_ngayhethan.Value, cbb_khoa.SelectedValue.ToString(), this.id);
                tb.tb_id = txt_id.Text;
                thongBaoBLL.UpdateThongBao(tb);
                loadThongBao();
                MessageBox.Show("Cập nhật thông báo thành công", "Thông báo");
                setDisableButton();
                setEnableEdit(false);


            }
            else
            {
                if (txt_noidung.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập nội dung thông báo");
                    txt_noidung.Focus();
                    return;
                }
                else if (dtp_ngayhethan.Value<=DateTime.Now)
                {
                    MessageBox.Show("Ngày hết hạn không phù hợp");
                    dtp_ngayhethan.Focus();
                    return;
                }
                
                ThongBao tb = new ThongBao(txt_noidung.Text,  cbb_loaithongbao.SelectedItem.ToString(), cbb_doituong.SelectedItem.ToString(), dtp_ngayhethan.Value, cbb_khoa.SelectedValue.ToString(), this.id);
                
                if (thongBaoBLL.AddThongBao(tb))
                {
                    loadThongBao();
                    MessageBox.Show("Thêm thông báo thành công.", "Thông báo");
                    setDisableButton();
                    setEnableEdit(false);
                }
                else
                {
                    MessageBox.Show("Thêm thông báo thất bại.", "Thông báo");
                }
                
            }
            setDisableButton();
            setEnableEdit(false);
            clearInput();
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
            txt_noidung.Clear();

            cbb_khoa.Refresh();
            cbb_doituong.Refresh();
            cbb_loaithongbao.Refresh();
            
            dtp_ngayhethan.ResetValue();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            setEnableEdit(true);
            clearInput();
            txt_id.Text = thongBaoBLL.GenerateMonHocID();
            txt_id.Enabled = false;
            cbb_doituong.Focus();
            btn_luu.Enabled = true;
            checkAction = false;

        }
        private void loadDataGirdView()
        {
            DataTable dt = thongBaoBLL.GetAllThongBao();
            dgv_thongbao.DataSource = dt;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (selectedRowsId.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông báo  muốn xóa");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (string id in selectedRowsId)
                    {
                        thongBaoBLL.DeleteThongBao(id);
                        loadDataGirdView();
                    }
                    MessageBox.Show("Xóa thông báo thành công");
                }

            }
            setDisableButton();
            setEnableEdit(false);
            clearInput();
            
        }

        private void dgv_thongbao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgv_thongbao.CurrentRow != null)
            {
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;

                if (dgv_thongbao.CurrentRow.Cells[0].Value == null)
                {
                    selectedRowsId.Add(dgv_thongbao.CurrentRow.Cells[1].Value.ToString());
                    dgv_thongbao.CurrentRow.Cells[0].Value = true;
                }
                else
                {
                    selectedRowsId.Remove(dgv_thongbao.CurrentRow.Cells[1].Value.ToString());
                    dgv_thongbao.CurrentRow.Cells[0].Value = null;
                }

                txt_id.Text = dgv_thongbao.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_noidung.Text = dgv_thongbao.Rows[e.RowIndex].Cells[4].Value.ToString();

                cbb_loaithongbao.SelectedItem = dgv_thongbao.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbb_doituong.SelectedItem = dgv_thongbao.Rows[e.RowIndex].Cells[6].Value.ToString();

                dtp_ngayhethan.Value = (DateTime)dgv_thongbao.Rows[e.RowIndex].Cells[7].Value;
                cbb_khoa.SelectedValue = dgv_thongbao.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
            setEnableEdit(false);
           

        }
    }
}
