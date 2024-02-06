using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien : User
    {
        private String sv_id;
        private String loaiSv;
        private String khoa_id;
        private String hoadon_id;

        public SinhVien()
        {
        }

        public SinhVien(string sv_id, string loaiSv, string user_id, string khoa_id, string hoadon_id)
        {
            this.sv_id = sv_id;
            this.loaiSv = loaiSv;
            this.user_id = user_id;
            this.khoa_id = khoa_id;
            this.hoadon_id = hoadon_id;
        }

        public SinhVien(string user_id, string hovaten, string diachi, string numberPhone, string gioitinh, DateTime ngaysinh, string email, string role, string account_id, string sv_id, string loaiSv, string khoa_id, string hoadon_id)
            : base(user_id, hovaten, diachi, numberPhone, gioitinh, ngaysinh, email, role, account_id)
        {

            this.sv_id = sv_id;
            this.loaiSv = loaiSv;
            this.khoa_id = khoa_id;
            this.hoadon_id = hoadon_id;

        }



        public string Sv_id { get => sv_id; set => sv_id = value; }
        public string LoaiSv { get => loaiSv; set => loaiSv = value; }
        public string Khoa_id { get => khoa_id; set => khoa_id = value; }
        public string Hoadon_id { get => hoadon_id; set => hoadon_id = value; }
    }
}
