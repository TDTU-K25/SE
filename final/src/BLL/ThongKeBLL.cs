using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        ThongKeAccess thongKeAccess = new ThongKeAccess();
        public double GetDiemTrungBinhCaTruong()
        {
            return thongKeAccess.GetDiemTrungBinhCaTruong();
        }

        public int GetDRLTrungBinhCaTruong()
        {
            return thongKeAccess.GetDRLTrungBinhCaTruong();
        }

        public DataTable GetDanhSachSinhVienTheoDtbVaDRL(int drl, float dtb)
        {
            return thongKeAccess.GetDanhSachSinhVienTheoDtbVaDRL(drl, dtb);
        }

        public DataTable GetDanhSachSinhVienTheoTrangThaiHD(string trangThai)
        {
            return thongKeAccess.GetDanhSachSinhVienTheoTrangThaiHD(trangThai);
        }
    }
}
