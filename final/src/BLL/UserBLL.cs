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
    public class UserBLL
    {
        UserAccess userAccess = new UserAccess();
        public String GetRole(String accountId)
        {
            if (accountId == null)
            {
                return "empty_accountId";
            }
            return userAccess.GetRole(accountId);
        }

        public SinhVien GetSVByUserId(String userId)
        {
            return userAccess.GetSVByUserId(userId);
        }

        public DataTable GetAllSv()
        {
            return userAccess.GetAllSv();
        }

        public void ChangePasswordSV(String newPassword, String accountId)
        {
            userAccess.ChangePasswordSV(newPassword, accountId);
        }

        public void UpadteProfileSV(SinhVien sv)
        {
            userAccess.UpadteProfileSV(sv);
        }

        public bool InsertUser(User user)
        {
           return userAccess.InsertUser(user);
        }

        public string GetLastUserId()
        {
            return userAccess.GetLastUserId();
        }

        public User GetGvByUserId(string userId)
        {
            return userAccess.GetGvByUserId(userId);
        }

        public string GetAdminIdByAccId(string acc)
        {
            return userAccess.GetAdminIdByAccId(acc);
        }

        public User GetSvByUserId_LoadInputSV(string userId)
        {
            return userAccess.GetSvByUserId_LoadInputSV(userId);
        }
    }
}
