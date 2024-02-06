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
    public class LichThiBLL
    {
        LichThiAccess lichThiAccess = new LichThiAccess();
        public DataTable GetLichThiGKCuaSV(String userId)
        {
            return lichThiAccess.GetLichThiGKCuaSV(userId);
        }

        public DataTable GetLichThiCKCuaSV(String userId)
        {
            return lichThiAccess.GetLichThiCKCuaSV(userId);
        }

        public DataTable GetAllLichThi()
        {
            return lichThiAccess.GetAllLichThi();
        }

        public string GenerateLichThiID()
        {
            return lichThiAccess.GenerateLichThiID();
        }

        public static void InsertLichThi(LichThi lt)
        {
            DatabaseAccess.InsertLichThi(lt);
        }

        public static void UpdateLichThi(LichThi lt)
        {
            DatabaseAccess.UpdateLichThi(lt);
        }

        public static void DeleteLichThi(String lt_id)
        {
            DatabaseAccess.DeleteLichThi(lt_id);
        }
    }
}
