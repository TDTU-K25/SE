using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAccess
    {
        public String GetRole(String accountId)
        {
            return DatabaseAccess.GetRole(accountId);
        }

        public SinhVien GetSVByUserId(String userId)
        {
            return DatabaseAccess.GetSVByUserId(userId);
        }

        public User GetSvByUserId_LoadInputSV(String userId)
        {
            return DatabaseAccess.GetSvByUserId_LoadInputSV(userId);
        }


        public User GetGvByUserId(string userId)
        {
            return DatabaseAccess.GetGvByUserId(userId);
        }

        public DataTable GetAllSv()
        {
            return DatabaseAccess.GetAllSv();
        }

        public void ChangePasswordSV(String newPassword, String accountId)
        {
            DatabaseAccess.ChangePasswordSV(newPassword, accountId);
        }

        public void UpadteProfileSV(SinhVien sv)
        {
            DatabaseAccess.UpadteProfileSV(sv);
        }

        public bool InsertUser(User user)
        {
            try
            {
                DatabaseAccess.InsertUser(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public string GetLastUserId()
        {
            return DatabaseAccess.GetLastIdByTableName("user_id", "User_sub");
        }

        public string GetAdminIdByAccId(string acc)
        {
            return DatabaseAccess.GetAdminIdByAccId(acc);
        }
    }
}
