using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khoa
    {
        public string khoaId { get; set; }
        public string tenKhoa { get; set; }

        public Khoa(string khoaId, string tenKhoa)
        {
            this.khoaId = khoaId;
            this.tenKhoa = tenKhoa;
        }

        public Khoa()
        {

        }
    }
}
