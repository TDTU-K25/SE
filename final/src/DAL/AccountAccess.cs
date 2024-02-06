using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountAccess
    {
        public String CheckLogin(Account account)
        {
            return DatabaseAccess.CheckLogin(account);
        }

        public string GetLastAccountId()
        {
            return DatabaseAccess.GetLastIdByTableName("account_id", "Account");
        }

        public bool InsertAccount(Account account)
        {
            try
            {
                DatabaseAccess.InsertAccount(account);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
