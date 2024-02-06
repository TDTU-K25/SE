using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HocPhiBLL
    {
        HocPhiAccess hocPhiAccess = new HocPhiAccess();
        public DataTable GetHocPhiCuaSV(String userId)
        {
            return hocPhiAccess.GetHocPhiCuaSV(userId);
        }

        public void CreateOrder(String userId, int tongTienCacMon)
        {
            hocPhiAccess.CreateOrder(userId, tongTienCacMon);
        }

        public void CreateDetailOrder(String hd_id, String mh_id)
        {
            hocPhiAccess.CreateDetailOrder(hd_id, mh_id);
        }

        public DataTable GetCacChiTietHoaDon(String hd_id)
        {
            return hocPhiAccess.GetCacChiTietHoaDon(hd_id);
        }

        public void ThanhToanHocPhi(String hd_id, int tongSoTienThanhToan)
        {
           hocPhiAccess.ThanhToanHocPhi(hd_id, tongSoTienThanhToan);
        }
    }
}
