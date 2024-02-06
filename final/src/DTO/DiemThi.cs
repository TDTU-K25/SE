using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemThi
    {
        public double? diemQT1 { get; set; }
        public double? diemQT2 { get; set; }
        public double? diemCuoiKi { get; set; }
        public double? diemGiuaKi { get; set; }
        public double? diemTb { get; set; }
        public string user_id { get; set; }
        public string monhoc_id { get; set; }

        public DiemThi(double? diemQT1, double? diemQT2, double? diemCuoiKi, double? diemGiuaKi, double? diemTb, string user_id, string monhoc_id)
        {
            this.diemQT1 = diemQT1;
            this.diemQT2 = diemQT2;
            this.diemCuoiKi = diemCuoiKi;
            this.diemGiuaKi = diemGiuaKi;
            this.diemTb = diemTb;
            this.user_id = user_id;
            this.monhoc_id = monhoc_id;
        }
    }
}
