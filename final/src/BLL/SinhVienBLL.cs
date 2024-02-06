using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SinhVienBLL
    {
        DatabaseAccess svdal = new DatabaseAccess();
        public static DataTable GetAllSinhVien()
        {
            return DatabaseAccess.GetAllSv();
        }
        public static DataTable GetAllSVStudyMonHoc(String mh_id)
        {
            return DatabaseAccess.GetAllSVStudyMonHoc(mh_id);
        }
        public string GenerateSinhVienID() => DatabaseAccess.GenerateSinhVienID();
        public static void InsertSinhVien(SinhVien sv)
        {
            DatabaseAccess.InsertSinhVien(sv);
        }

        public static void UpdateSinhVien(SinhVien sv)
        {
            DatabaseAccess.UpdateSinhvien(sv);
        }

        public static void DeleteSinhVien(string sv_id)
        {
            DatabaseAccess.DeleteSinhvien(sv_id);
        }
    }
}
