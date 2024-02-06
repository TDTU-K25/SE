using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhaoSat
    {
        public String khaosat_id { get; set; }
        public String noidung { get; set; }
        public String monhoc_id { get; set; }
        public String user_id { get; set; }

        public KhaoSat(string khaosat_id, string noidung, string monhoc_id, string user_id)
        {
            this.khaosat_id = khaosat_id;
            this.noidung = noidung;
            this.monhoc_id = monhoc_id;
            this.user_id = user_id;
        }

        public KhaoSat()
        {

        }
    }
}
