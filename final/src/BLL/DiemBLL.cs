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
    public class DiemBLL
    {
        DiemAccess diemAccess = new DiemAccess();
        public DataTable GetDiemCuaSV(String userId)
        {
            return diemAccess.GetDiemCuaSV(userId);
        }

        public DataTable GetAllDiemSvByMonHocId(string monHocId)
        {
            return diemAccess.GetAllDiemSvByMonHocId(monHocId);
        }

        public void UpdateDiemThi(DiemThi diem)
        {
            diemAccess.UpdateDiemThi(diem);
        }
    }
}
