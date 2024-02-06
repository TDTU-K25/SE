using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        AccountAccess accountAccess =  new AccountAccess();
        public String CheckLogin(Account account)
        {
            if (account.username == "")
            {
                return "empty_username";
            } else if (account.password == "")
            {
                return "empty_password";
            }
            return accountAccess.CheckLogin(account);
        }

        public string GetLastAccountId()
        {
            return accountAccess.GetLastAccountId();
        }

        public bool InsertAccount(Account account)
        {
            return accountAccess.InsertAccount(account);
        }
    }
}
