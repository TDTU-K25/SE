using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuKien
    {
        public SuKien()
        {
        }

        public SuKien(string drl_id, string tensk, string loaidiem, int diem, DateTime ngaytochuc, TimeSpan tgtochuc)
        {
            DRL_id = drl_id;
            TenSK = tensk;
            this.loaiDRL = loaidiem;
            Diem = diem;
            this.ngaytochuc = ngaytochuc;
            this.thoigiantochuc = tgtochuc;
        }

        public String DRL_id { get; set; }
        public String loaiDRL { get; set; }
        public String TenSK { get; set; }
        public int Diem { get; set; }
        public DateTime ngaytochuc { get; set; }
        public TimeSpan thoigiantochuc { get; set; }


    }
}
