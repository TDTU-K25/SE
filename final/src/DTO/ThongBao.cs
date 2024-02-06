using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongBao
    {
        public String tb_id {  get; set; }
        public DateTime ngayTao { get; set; }
        public DateTime ngayCapNhat { get; set; }
        public String noiDung { get; set; }
        public String loaiThongBao { get; set; }
        public String doiTuong { get; set; }
        public DateTime ngayHetHan { get; set; }
        public String khoa_id { get; set; }
        public String user_id { get; set; }
        
        public ThongBao( string noiDung, string loaiThongBao, string doiTuong, DateTime ngayHetHan, string khoa_id, string user_id)
        { 
            this.noiDung = noiDung;
            this.loaiThongBao = loaiThongBao;
            this.doiTuong = doiTuong;
            this.ngayHetHan = ngayHetHan;
            this.khoa_id = khoa_id;
            this.user_id = user_id;
        }
    }
}
