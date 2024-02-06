using BLL;
using DTO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace FinalProject.App.Admin.QuanLySinhVien
{
    public partial class UC_NhapDiemRenLuyen : UserControl
    {
        DrlBBL drlBBL = new DrlBBL();
        public UC_NhapDiemRenLuyen()
        {
            InitializeComponent();
          
        }

        private void btn_choose_file_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    string[] Lines = File.ReadAllLines(file, Encoding.UTF8);
                    string[] Fields_SKRDL;
                    string[] Fields_SV_DRL;
                    Fields_SKRDL = Lines[0].Split(new char[] { ',' });
                    Fields_SV_DRL = Lines[1].Split(new char[] { ',' });
                    int Cols_SKDRL = Fields_SKRDL.GetLength(0);

                    //1st row information of event DRL
                    
                        SuKienDrl suKienDrl = new SuKienDrl();
                        suKienDrl.loaiDRL = Fields_SKRDL[0];
                        suKienDrl.tenSK = Fields_SKRDL[1];
                        suKienDrl.Diem = Convert.ToInt32(Fields_SKRDL[2]);
                        suKienDrl.ngaytochuc = Convert.ToDateTime(Fields_SKRDL[3]);
                        suKienDrl.thoigiantochuc = Convert.ToDateTime(Fields_SKRDL[4]);
                    
                    drlBBL.CreateSuKienDrl(suKienDrl);
                    
                    String DRL_id = drlBBL.GetLastIdSuKienDrl();


                    //from 2nd row information of id sv join event DRL
                    for (int i = 1; i < Lines.GetLength(0); i++)
                    {
                        Fields_SV_DRL = Lines[i].Split(new char[] { ',' });
                        String idSV = Fields_SV_DRL[0];
                        // function that insert into db
                        drlBBL.ThemSvJoinSuKienDrl(idSV, DRL_id);
                    }

                    System.Windows.Forms.MessageBox.Show("Cập nhật dữ liệu điểm rèn luyện thành công.", "Thông báo");
                }
                catch (IOException err)
                {
                    Console.WriteLine(err.ToString());
                }
            }
        }
    }
}
