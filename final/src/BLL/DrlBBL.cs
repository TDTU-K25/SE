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
    public class DrlBBL
    {
        DrlAccess drlAccess = new DrlAccess();
        public DataTable GetAllSKDrlSVJoin(String userId)
        {
            return drlAccess.GetAllSKDrlSVJoin(userId);
        }

        public void CreateSuKienDrl(SuKienDrl suKienDrl)
        {
            drlAccess.CreateSuKienDrl(suKienDrl);
        }

        public string GenerateSKDRLID()
        {
            return drlAccess.GenerateSKDRLID();
        }

        public String GetLastIdSuKienDrl()
        {
            return drlAccess.GetLastIdSuKienDrl();
        }

        public void ThemSvJoinSuKienDrl(String user_id, string drl_id)
        {
            drlAccess.ThemSvJoinSuKienDrl(user_id, drl_id);
        }

        public DataTable GetAllSKDRL()
        {
            return drlAccess.GetAllSKDRL();
        }
        public DataTable GetAllLoaiDRL()
        {
            return drlAccess.GetAllLoaiDRL();
        }


        public static void InsertSuKien(SuKien sk)
        {
            DatabaseAccess.InsertSuKien(sk);
        }

        public static void UpdateSuKien(SuKien sk)
        {
            DatabaseAccess.UpdateSuKien(sk);
        }

        public static void DeleteSuKien(String drl_id)
        {
            DatabaseAccess.DeleteSuKien(drl_id);
        }
    }
}
