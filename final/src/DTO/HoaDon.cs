using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public string hoadon_id { get; set; }
        public int Tongtiencacmon { get; set; }
        public DateTime ngaytao { get; set; }
        public string trangThai { get; set; }
        public int Sotiendathanhtoan { get; set; }
        public DateTime Ngaythanhtoan { get; set; }
    }
}
