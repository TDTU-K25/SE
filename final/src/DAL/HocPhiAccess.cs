using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocPhiAccess
    {
        public DataTable GetHocPhiCuaSV(String userId) // need to get of each student not all
        {
            return DatabaseAccess.GetHocPhiCuaSV(userId);
        }

        public void CreateOrder(String userId, int tongTienCacMon)
        {
            DatabaseAccess.CreateOrder(userId, tongTienCacMon);
        }

        public void CreateDetailOrder(String hd_id, String mh_id)
        {
            DatabaseAccess.CreateDetailOrder(hd_id, mh_id);
        }

        public DataTable GetCacChiTietHoaDon(String hd_id)
        {
            return DatabaseAccess.GetCacChiTietHoaDon(hd_id);
        }

        public void ThanhToanHocPhi(String hd_id, int tongSoTienThanhToan)
        {
            DatabaseAccess.ThanhToanHocPhi(hd_id, tongSoTienThanhToan);
        }
    }
}
