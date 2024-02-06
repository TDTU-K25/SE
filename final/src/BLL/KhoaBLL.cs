using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhoaBLL
    {
        KhoaAccess khoaAccess = new KhoaAccess();

        public DataTable GetAllKhoa()
        {
            return khoaAccess.GetAllKhoa();
        }
    }
}
