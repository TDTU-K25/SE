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

namespace FinalProject.App.Main
{
    public partial class UC_ThongBao : UserControl
    {
        ThongBaoBLL thongBaoBLL = new ThongBaoBLL();
        
        public UC_ThongBao()
        {
            InitializeComponent();


            dgv_thongbao.DataSource = thongBaoBLL.GetAllThongBao();

            cbb_khoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_loaithongbao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_doituong.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void dgv_thongbao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int countRow = dgv_thongbao.RowCount;
            dgv_thongbao.Height = 50 * countRow;
        }

        private void dgv_thongbao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Note:
            // 1.Truyền full dữ liệu của thông báo qua
            //    a. Làm cách nào để truyền được dữ liệu ko liệt kê trong DataGridView ?
            // 2. Truyền ID qua sau đó truy vấn data rồi load form

            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                DataGridViewRow selectRow = dgv_thongbao.Rows[e.RowIndex];
                string idThongBao = selectRow.Cells["tb_id"].Value.ToString();
                string ngayDang = selectRow.Cells["ngayTaoDataGridViewTextBoxColumn"].Value.ToString();
                string noidung = selectRow.Cells["noiDungDataGridViewTextBoxColumn"].Value.ToString();
                //string doituong = selectRow.Cells[]
                noidung = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquet quam ac ultricies feugiat. Nulla facilisi. Morbi at cursus libero. Sed vehicula facilisis elit in tristique. Donec ut cursus purus. Fusce gravida justo vitae velit cursus, eget malesuada turpis mattis. Sed pharetra quam at odio fermentum, vel facilisis nunc auctor. Proin tincidunt, ligula eu sollicitudin sagittis, odio tellus condimentum risus, in posuere risus lectus in odio. Etiam venenatis mauris vitae cursus facilisis. Sed vel turpis eu libero tristique sodales. Nulla vulputate ante eu velit tincidunt, id bibendum lorem fermentum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Ut quis velit vitae massa vestibulum dapibus sit amet at mauris. Sed aliquam, velit non auctor cursus, justo urna interdum tortor, eu feugiat dui nunc a lorem. Nullam efficitur justo nec urna vestibulum, eget varius quam suscipit. In nec nunc a purus luctus tincidunt. Vivamus gravida congue turpis, in feugiat justo efficitur ut.\r\n\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur id metus tincidunt, laoreet nulla id, fringilla augue. Nunc bibendum, ligula nec facilisis suscipit, quam quam lacinia purus, eu sodales libero orci in metus. Nunc in ligula eu felis egestas blandit ac at libero. Sed dapibus est ut tincidunt tempus. Vestibulum ac suscipit sapien. Praesent in dictum orci, id tempor libero. Nulla facilisi. Sed auctor, libero eu vulputate posuere, nisl risus bibendum erat, sit amet iaculis justo elit eu quam. Integer at odio eu elit tincidunt dapibus. Curabitur ut justo vel turpis blandit hendrerit. Etiam bibendum urna at ligula eleifend, in vehicula neque finibus. Sed scelerisque orci quis metus vestibulum lacinia.";

                ChiTietThongBao formChiTiet = new ChiTietThongBao();
                formChiTiet.SetData(idThongBao, ngayDang, noidung);

                formChiTiet.Show();
            }
        }
    }
}
