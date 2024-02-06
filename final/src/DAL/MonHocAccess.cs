using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonHocAccess
    {
        public DataTable getAllMonHoc()
        {
            return DatabaseAccess.GetAllMonHoc();
        }

        public DataTable GetAllMonHocDKCuaSV(String userId)
        {
            return DatabaseAccess.GetAllMonHocDKCuaSV(userId);
        }
        public bool AddMonhoc(MonHoc mh , string user_id)
        {
            return DatabaseAccess.AddMonhoc(mh , user_id);
        }
        public bool UpdateMonHoc(MonHoc mh, string lichhoc_id , string user_id)
        {
            return DatabaseAccess.UpdateMonHoc(mh , lichhoc_id , user_id);
        }
        public bool DeleteMonHoc(string monhoc_id)
        {
            return DatabaseAccess.DeleteMonhoc(monhoc_id);
        }
            public string GenerateMonHocID()
        {
            return DatabaseAccess.GenerateMonHocID();
        }

        public DataTable GetAllIdSubjectRegister(string userId)
        {
            return DatabaseAccess.GetAllIdSubjectRegister(userId);
        }

        public void RegisterSubject(string userId, string subjectId)
        {
            DatabaseAccess.RegisterSubject(userId, subjectId);
        }

        public MonHoc GetMonHocById(String monHocId)
        {
            return DatabaseAccess.GetMonHocById(monHocId);
        }

        public DataTable GetAllMonHocByGvId(string gvId)
        {
            return DatabaseAccess.GetAllMonHocByGvId(gvId);
        }

        public void DeleteAllMonHocDKCuaSV(String userId)
        {
            DatabaseAccess.DeleteAllMonHocDKCuaSV(userId);
        }

        public DataTable GetMonHocDKCuaSV(String user_id)
        {
            return DatabaseAccess.GetMonHocDKCuaSV(user_id);
        }
    }
}
