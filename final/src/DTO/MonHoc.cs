using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class MonHoc
    {
        public String monhoc_id { get; set; }
       public String tenMonhoc { get; set; }
       public int tinChi { get; set; }
       public int hocPhiMon { get; set; }
       public String phonghoc { get; set; }
       public int cahoc { get; set; }
       public String thu { get; set; }
       public DateTime ngaybatdau { get; set; }
       public DateTime ngayketthuc { get; set; }
       
      

        public MonHoc(string tenMonhoc, int tinChi, int hocPhiMon, string phonghoc, int cahoc, string thu, DateTime ngaybatdau, DateTime ngayketthuc )
        {
            this.tenMonhoc = tenMonhoc;
            this.tinChi = tinChi;
            this.hocPhiMon = hocPhiMon;
            this.phonghoc = phonghoc;
            this.cahoc = cahoc;
            this.thu = thu;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
        }

        public MonHoc()
        {
        }
    }
}
