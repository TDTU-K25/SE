﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhaoSatAccess
    {
        public DataTable GetAllKhaoSat(String maMH)
        {
            return DatabaseAccess.GetKhaoSatByMonHoc(maMH);
        }
    }
}