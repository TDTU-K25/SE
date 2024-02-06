using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichThiAccess
    {
        public DataTable GetLichThiGKCuaSV(String userId)
        {
            return DatabaseAccess.GetLichThiGKCuaSV(userId);
        }

        public DataTable GetLichThiCKCuaSV(String userId)
        {
            return DatabaseAccess.GetLichThiCKCuaSV(userId);
        }

        public string GenerateLichThiID()
        {
            return DatabaseAccess.GenerateLichThiID();
        }

        public DataTable GetAllLichThi()
        {
            return DatabaseAccess.GetAllLichThi();
        }
    }
}
