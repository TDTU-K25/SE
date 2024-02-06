using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public String account_id {  get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public Account(string username, string password)
        {
            this.account_id = account_id;
            this.username = username;
            this.password = password;
        }

        public Account()
        {

        }
    }
}
