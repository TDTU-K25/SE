using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongBaoAccess
    {
        public DataTable GetAllThongBao()
        {
            return DatabaseAccess.GetAllThongBao();
        }
        public bool AddThongBao(ThongBao tb)
        {
            return DatabaseAccess.AddThongBao(tb);
        }
        public bool UpdateThongBao(ThongBao tb)
        {
            return DatabaseAccess.UpdateThongBao(tb);
        }
        public bool DeleteThongBao(string tb_id)
        {
            return DatabaseAccess.DeleteThongBao(tb_id);
        }
        public string GenerateThongBaoID()
        {
            return DatabaseAccess.GenerateThongBaoID();
        }
    }
}
