using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DrlAccess
    {
        public DataTable GetAllSKDrlSVJoin(String userId) 
        {
           return DatabaseAccess.GetAllSKDrlSVJoin(userId);
        }

        public void CreateSuKienDrl(SuKienDrl suKienDrl)
        {
            DatabaseAccess.CreateSuKienDrl(suKienDrl);
        }

        public String GetLastIdSuKienDrl()
        {
            return DatabaseAccess.GetLastIdSuKienDrl();
        }

        public void ThemSvJoinSuKienDrl(String user_id, string drl_id)
        {
            DatabaseAccess.ThemSvJoinSuKienDrl(user_id, drl_id);
        }

        public DataTable GetAllLoaiDRL()
        {
            return DatabaseAccess.GetAllLoaiDRL();
        }

        public DataTable GetAllSKDRL()
        {
            return DatabaseAccess.GetAllSKDRL();
        }

        public string GenerateSKDRLID()
        {
            return DatabaseAccess.GenerateSuKienID();
        }
    }
}
