﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhaoSatBLL
    {
        KhaoSatAccess khaoSatAccess = new KhaoSatAccess();
        public DataTable GetAllKhaoSat(String maMH)
        {
            return khaoSatAccess.GetAllKhaoSat(maMH);
        }
    }
}
