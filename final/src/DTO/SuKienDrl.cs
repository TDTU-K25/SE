using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuKienDrl
    {
        public String DRL_id { get; set; }
        public String loaiDRL { get; set; }
        public String tenSK { get; set; }
        public int Diem { get; set; }
        public DateTime ngaytochuc { get; set; }
        public DateTime thoigiantochuc { get; set; }
    }
}
