using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        protected User(string user_id, string hovaten, string diachi, string numberPhone, string gioitinh, DateTime ngaysinh, string email, string role, string account_id)
        {
            this.user_id = user_id;
            this.hovaten = hovaten;
            this.diachi = diachi;
            this.numberPhone = numberPhone;
            this.gioitinh = gioitinh;
            Ngaysinh = ngaysinh;
            this.email = email;
            this.role = role;
            this.account_id = account_id;
        }
        public String user_id { get; set; }
        public String hovaten {  get; set; }
        public String diachi { get; set; }
        public String numberPhone { get; set; }
        public String gioitinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public String account_id { get; set; }

        public User(string hovaten, string diachi, string numberPhone, string gioitinh, DateTime ngaysinh, string email, string role, string account_id)
        {
            this.user_id = user_id;
            this.hovaten = hovaten;
            this.diachi = diachi;
            this.numberPhone = numberPhone;
            this.gioitinh = gioitinh;
            Ngaysinh = ngaysinh;
            this.email = email;
            this.role = role;
            this.account_id = account_id;
        }

        public User()
        {
        }
    }
}
