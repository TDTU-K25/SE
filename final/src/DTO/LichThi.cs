using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichThi
    {
        public String lt_id { get; set; }
        public DateTime ngayThi { get; set; }
        public TimeSpan thoiGianThi { get; set; }
        public String diaDiemThi { get; set; }
        public String hinhThucThi { get; set; }
        public String user_id { get; set; }
        public String monhoc_id { get; set; }

        public LichThi(string lt_id, DateTime ngayThi, TimeSpan thoiGianThi, string diaDiemThi, string hinhThucThi, string user_id, string monhoc_id)
        {
            this.lt_id = lt_id;
            this.ngayThi = ngayThi;
            this.thoiGianThi = thoiGianThi;
            this.diaDiemThi = diaDiemThi;
            this.hinhThucThi = hinhThucThi;
            this.user_id = user_id;
            this.monhoc_id = monhoc_id;
        }

        public LichThi()
        {
        }
    }
}
