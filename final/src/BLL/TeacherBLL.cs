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
    public class TeacherBLL
    {
        TeacherAccess teacherAccess = new TeacherAccess();

        public DataTable GetAllTeachers()
        {
            return teacherAccess.GetAllTeachers();
        }
        public string GenerateGiangVienID()
        {
            return teacherAccess.GenerateGiangVienID();
        }
        public bool InsertTeacher(Teacher teacher)
        {
            return teacherAccess.InsertTeacher(teacher);
        }
        public bool UpdateGiangvien(Teacher teacher)
        {
            return teacherAccess.UpdateGiangvien(teacher);
        }
        public bool DeleteTeacher(string id)
        {
            return teacherAccess.DeleteTeacher(id);
        }

        public String GetLastIdDiemDanh()
        {
            return teacherAccess.GetLastIdDiemDanh();
        }

        public void InsertDiemDanh(String mh_id)
        {
            teacherAccess.InsertDiemDanh(mh_id);
        }
        public void InsertSV_DD(String user_id, String dd_id)
        {
            teacherAccess.InsertSV_DD(dd_id, user_id);
        }
    }
}
