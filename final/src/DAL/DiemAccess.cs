using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiemAccess
    {
        public DataTable GetAllDiemSvByMonHocId(string monHocId)
        {
            return DatabaseAccess.GetAllDiemSvByMonHocId(monHocId);
        }

        public DataTable GetDiemCuaSV(String userId)
        {
            return DatabaseAccess.GetDiemCuaSV(userId);
        }

        public void UpdateDiemThi(DiemThi diem)
        {
            DatabaseAccess.UpdateDiemThi(diem);
        }
    }
}
