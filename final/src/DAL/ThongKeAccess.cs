using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeAccess
    {
        public double GetDiemTrungBinhCaTruong()
        {
            return DatabaseAccess.GetDiemTrungBinhCaTruong();
        }

        public int GetDRLTrungBinhCaTruong()
        {
            return DatabaseAccess.GetDRLTrungBinhCaTruong();
        }

        public DataTable GetDanhSachSinhVienTheoDtbVaDRL(int drl, float dtb)
        {
            return DatabaseAccess.GetDanhSachSinhVienTheoDtbVaDRL(drl, dtb);
        }

        public DataTable GetDanhSachSinhVienTheoTrangThaiHD(string trangThai)
        {
            return DatabaseAccess.GetDanhSachSinhVienTheoTrangThaiHD(trangThai);
        }
    }
}
