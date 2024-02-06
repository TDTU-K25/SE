using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeacherAccess
    {
        public DataTable GetAllTeachers()
        {
            return DatabaseAccess.GetAllTeachers();
        }
        public string GenerateGiangVienID()
        {
            return DatabaseAccess.GenerateGiangVienID();
        }
        public bool InsertTeacher(Teacher teacher)
        {
            return DatabaseAccess.InsertProfileGV(teacher);
        }
        public bool UpdateGiangvien(Teacher teacher)
        {
            return DatabaseAccess.UpdateGiangvien(teacher);
        }
        public bool DeleteTeacher(string id)
        {
            return DatabaseAccess.DeleteGV(id);
        }

        public void InsertDiemDanh(String mh_id)
        {
            DatabaseAccess.InsertDiemDanh(mh_id);
        }
        public void InsertSV_DD(String user_id, String dd_id)
        {
            DatabaseAccess.InsertSV_DD(dd_id, user_id);
        }

        public String GetLastIdDiemDanh()
        {
            return DatabaseAccess.GetLastIdDiemDanh();
        }
    }
}
