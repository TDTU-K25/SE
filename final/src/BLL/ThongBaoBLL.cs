using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongBaoBLL
    {
        ThongBaoAccess thongBaoAccess = new ThongBaoAccess();
        public DataTable GetAllThongBao()
        {
            return thongBaoAccess.GetAllThongBao();
        }
        public bool AddThongBao(ThongBao tb)
        {
            return thongBaoAccess.AddThongBao(tb);
        }
        public bool UpdateThongBao(ThongBao tb)
        {
            return thongBaoAccess.UpdateThongBao(tb);
        }
        public bool DeleteThongBao(string tb_id)
        {
            return thongBaoAccess.DeleteThongBao(tb_id);
        }
        public string GenerateMonHocID()
        {
            return thongBaoAccess.GenerateThongBaoID();
        }
    }
}
