using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonHocBLL
    {
        MonHocAccess monHocAccess = new MonHocAccess();
        string lichhoc_id;
        public DataTable GetAllMonHoc()
        {
            return monHocAccess.getAllMonHoc();
        }

        public DataTable GetAllMonHocDKCuaSV(String userId)
        {
            return monHocAccess.GetAllMonHocDKCuaSV(userId);
        }
        public bool AddMonhoc( MonHoc mh , string user_id)
        {
            return monHocAccess.AddMonhoc(mh, user_id);
        }
        public bool UpdateMonHoc(MonHoc mh,string lichhoc_id, string user_id)
        {
            return monHocAccess.UpdateMonHoc(mh , lichhoc_id, user_id);
        }
        public bool DeleteMonHoc(string monhoc_id)
        {
            return monHocAccess.DeleteMonHoc(monhoc_id);
        }
        public string GenerateMonHocID()
        {
            return monHocAccess.GenerateMonHocID();
        }

        public DataTable GetAllIdSubjectRegister(string userId)
        {
            return monHocAccess.GetAllIdSubjectRegister(userId);
        }

        public void RegisterSubject(string userId, string subjectId)
        {
            monHocAccess.RegisterSubject(userId, subjectId);
        }

        public MonHoc GetMonHocById(String monHocId)
        {
            return monHocAccess.GetMonHocById(monHocId);
        }

        public void DeleteAllMonHocDKCuaSV(String userId)
        {
            monHocAccess.DeleteAllMonHocDKCuaSV(userId);
        }

        public DataTable GetAllMonHocByGvId(string gvId)
        {
            return monHocAccess.GetAllMonHocByGvId(gvId);
        }


        public DataTable GetMonHocDKCuaSV(String user_id)
        {
            return monHocAccess.GetMonHocDKCuaSV(user_id);
        }
    }
}
