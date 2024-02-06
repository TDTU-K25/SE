using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teacher: User
    {
        public String gv_id { get; set; }
        public String type { get; set; }
        public String khoa_id { get; set; }

        public Teacher(string type, string userId, string khoa_id)
        {
            this.type = type;
            this.user_id = userId;
            this.khoa_id = khoa_id;
        }

        public Teacher()
        {
        }
    }
}
