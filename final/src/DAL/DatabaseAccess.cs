
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Principal;
using System.Xml;
using System.Security.Cryptography;

namespace DAL
{
    public class MyDatabaseUtils
    {
        public static SqlConnection connect()
        {
            String connectionString = @"Data Source=DESKTOP-93HERDG;Initial Catalog=QLHTTTSV_TDT;Integrated Security=True";
            //String connectionString = @"Data Source=LAPTOP-Q14HCHT2\QUANGHUY;Initial Catalog=QLHTTTSV_TDT;Integrated Security=True";
            //String connectionString = @"Data Source=LAPTOP-2HQJOQF5\SQLEXPRESS;Initial Catalog=QLHTTTSV_TDT;Integrated Security=True";
            //String connectionString = @"Data Source=DESKTOP-19V9TDP\SQLEXPRESS;Initial Catalog=QLHTTTSV_TDT;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
   

    public class DatabaseAccess
    {
        public static String CheckLogin(Account account)
        {
            String accountId = null;
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", account.username);
            cmd.Parameters.AddWithValue("@password", account.password);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    accountId = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            } else
            {
                return "login_fail";
            }
            return accountId;
        }

        public static String GetRole(String accountId)
        {
            String role = null;
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_get_role", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@account_id", accountId);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    role = reader.GetString(7);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "get_role_fail";
            }
            return role;
        }

        public static DataTable GetAllMonHoc()
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_all_mon_hoc", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetAllThongBao()
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_all_thong_bao", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetDiemCuaSV(String userId)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_diem_cua_SV", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSV", userId);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetAllLichThi()
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("selectAllLichThi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public static DataTable GetLichThiGKCuaSV(String userId)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_lich_thi_gk_cua_sv", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetLichThiCKCuaSV(String userId)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_lich_thi_ck_cua_sv", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetAllMonHocDKCuaSV(String userId)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_dsmh_cua_sv", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSV", userId);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetAllSKDrlSVJoin(String userId)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_hoat_dong_drl_cua_sv", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSV", userId);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetHocPhiCuaSV(String userId)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_get_hoa_don_sv", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSV", userId);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static SinhVien GetSVByUserId(String accountId)
        {
            SinhVien sv = new SinhVien();
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_select_sv_theo_account_id", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@account_id", accountId);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sv.user_id = reader.GetString(0);
                    sv.hovaten = reader.GetString(1);
                    sv.diachi = reader.GetString(2);
                    sv.numberPhone = reader.GetString(3);
                    sv.gioitinh = reader.GetString(4);
                    sv.Ngaysinh = reader.GetDateTime(5);
                    sv.email = reader.GetString(6);
                    sv.role = reader.GetString(7);
                    sv.Sv_id = reader.GetString(9);
                    sv.LoaiSv = reader.GetString(10);
                    sv.Khoa_id = reader.GetString(12);
                    sv.Hoadon_id = reader.GetString(13);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return null;
            }
            return sv;
        }

        public static User GetSvByUserId_LoadInputSV(string userId)
        {
            try
            {
                SqlConnection conn = MyDatabaseUtils.connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_select_sv_user_id", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();

                User user = new User();

                if (reader.Read())
                {
                    user.user_id = reader["user_id"].ToString();
                    user.hovaten = reader["hovaten"].ToString();
                    user.diachi = reader["diachi"].ToString();
                    user.numberPhone = reader["numberPhone"].ToString();
                    user.gioitinh = reader["gioitinh"].ToString();
                    user.Ngaysinh = Convert.ToDateTime(reader["Ngaysinh"]);
                    user.email = reader["email"].ToString();
                    user.role = reader["role"].ToString();
                    user.account_id = reader["account_id"].ToString();
                }

                reader.Close();
                conn.Close();
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string GenerateSinhVienID()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GenerateSinhVien_ID", conn);
            cmd.Connection = conn;
            return (string)cmd.ExecuteScalar();
        }

        public static DataTable GetAllSv()
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_all_sv", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static void ChangePasswordSV(String newPassword, String accountId)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_doi_mat_khau_sv", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@account_id", accountId);
            cmd.Parameters.AddWithValue("@new_password", newPassword);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }

        public static void UpadteProfileSV(SinhVien sv)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_cap_nhat_info_sv", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_id", sv.user_id);
            cmd.Parameters.AddWithValue("@hovaten", sv.hovaten);
            cmd.Parameters.AddWithValue("@diachi", sv.diachi);
            cmd.Parameters.AddWithValue("@numberPhone", sv.numberPhone);
            cmd.Parameters.AddWithValue("@gioitinh", sv.gioitinh);
            cmd.Parameters.AddWithValue("@Ngaysinh", sv.Ngaysinh);
            cmd.Parameters.AddWithValue("@email", sv.email);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }

        public static void InsertSinhVien(SinhVien sv)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("ThemSinhVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = sv.email;
                    cmd.Parameters.Add("@loaiSv", SqlDbType.NVarChar, 50).Value = sv.LoaiSv;
                    cmd.Parameters.Add("@khoa_id", SqlDbType.VarChar, 10).Value = sv.Khoa_id;
                    cmd.Parameters.Add("@hoadon_id", SqlDbType.VarChar, 10).Value = sv.Hoadon_id;
                    cmd.Parameters.Add("@hovaten", SqlDbType.NVarChar, 50).Value = sv.hovaten;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = sv.diachi;
                    cmd.Parameters.Add("@numberPhone", SqlDbType.VarChar, 15).Value = sv.numberPhone;
                    cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar, 10).Value = sv.gioitinh;
                    cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = sv.Ngaysinh;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = sv.email;
                    cmd.Parameters.Add("@role", SqlDbType.NVarChar, 20).Value = sv.role;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static void UpdateSinhvien(SinhVien sv)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SuaSinhVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@sv_id", SqlDbType.VarChar, 10).Value = sv.Sv_id;
                    //cmd.Parameters.Add("@user_id", SqlDbType.VarChar, 10).Value = sv.user_id;
                    //cmd.Parameters.Add("@account_id", SqlDbType.VarChar, 10).Value = sv.account_id;

                    cmd.Parameters.Add("@new_username", SqlDbType.VarChar, 50).Value = sv.email;
                    cmd.Parameters.Add("@new_loaiSv", SqlDbType.NVarChar, 50).Value = sv.LoaiSv;
                    cmd.Parameters.Add("@new_khoa_id", SqlDbType.VarChar, 10).Value = sv.Khoa_id;
                    cmd.Parameters.Add("@new_hoadon_id", SqlDbType.VarChar, 10).Value = sv.Hoadon_id;
                    cmd.Parameters.Add("@new_hovaten", SqlDbType.NVarChar, 50).Value = sv.hovaten;
                    cmd.Parameters.Add("@new_diachi", SqlDbType.NVarChar, 50).Value = sv.diachi;
                    cmd.Parameters.Add("@new_numberPhone", SqlDbType.VarChar, 15).Value = sv.numberPhone;
                    cmd.Parameters.Add("@new_gioitinh", SqlDbType.NVarChar, 10).Value = sv.gioitinh;
                    cmd.Parameters.Add("@new_Ngaysinh", SqlDbType.Date).Value = sv.Ngaysinh;
                    cmd.Parameters.Add("@new_email", SqlDbType.VarChar, 50).Value = sv.email;
                    cmd.Parameters.Add("@new_role", SqlDbType.NVarChar, 20).Value = sv.role;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static void DeleteSinhvien(string sv_id)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("XoaSinhVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@sv_id", SqlDbType.VarChar, 10).Value = sv_id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static DataTable GetAllTeachers()
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("selectAllGiangVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        
        public static Teacher GetGVByUserId(String accountId)
        {
            Teacher gv = new Teacher();
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_select_gv_theo_account_id", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@account_id", accountId);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    gv.user_id = reader.GetString(0);
                    gv.hovaten = reader.GetString(1);
                    gv.diachi = reader.GetString(2);
                    gv.numberPhone = reader.GetString(3);
                    gv.gioitinh = reader.GetString(4);
                    gv.Ngaysinh = reader.GetDateTime(5);
                    gv.email = reader.GetString(6);
                    gv.role = reader.GetString(7);
                    gv.gv_id = reader.GetString(9);
                    gv.type = reader.GetString(10);
                    gv.khoa_id = reader.GetString(12);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return null;
            }
            return gv;
        }

        

        public static string GetLastIdByTableName(string columnIdName, string tableName)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT TOP 1 LOWER({columnIdName}) FROM {tableName} ORDER BY {columnIdName} DESC", conn);
            string id = (string) cmd.ExecuteScalar();
            conn.Close();
            return id;
        }

        public static void InsertAccount(Account account)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertAccount", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", account.username);
            cmd.Parameters.AddWithValue("@password", account.password);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close ();
        }

        public static void InsertUser(User user)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hovaten", user.hovaten);
            cmd.Parameters.AddWithValue("@diachi", user.diachi);
            cmd.Parameters.AddWithValue("@numberPhone", user.numberPhone);
            cmd.Parameters.AddWithValue("@gioitinh", user.gioitinh);
            cmd.Parameters.AddWithValue("@Ngaysinh", user.Ngaysinh);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@role", user.role);
            cmd.Parameters.AddWithValue("@account_id", user.account_id);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
        public static bool InsertProfileGV(Teacher gv)
        {
            try
            {
                SqlConnection conn = MyDatabaseUtils.connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThemGiangVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@loaiGv", gv.type);
                cmd.Parameters.AddWithValue("@user_id", gv.user_id);
                cmd.Parameters.AddWithValue("@khoa_id", gv.khoa_id);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception) 
            {
                return false;
            }
        }
        
        public static bool UpdateGiangvien(Teacher gv)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SuaGiangVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@gv_id", SqlDbType.VarChar, 10).Value = gv.gv_id;
                    //cmd.Parameters.Add("@user_id", SqlDbType.VarChar, 10).Value = sv.user_id;
                    //cmd.Parameters.Add("@account_id", SqlDbType.VarChar, 10).Value = sv.account_id;

                    cmd.Parameters.Add("@new_username", SqlDbType.VarChar, 50).Value = gv.email;
                    cmd.Parameters.Add("@new_loaigv", SqlDbType.NVarChar, 50).Value = gv.type;
                    cmd.Parameters.Add("@new_khoa_id", SqlDbType.VarChar, 10).Value = gv.khoa_id;
         
                    cmd.Parameters.Add("@new_hovaten", SqlDbType.NVarChar, 50).Value = gv.hovaten;
                    cmd.Parameters.Add("@new_diachi", SqlDbType.NVarChar, 50).Value = gv.diachi;
                    cmd.Parameters.Add("@new_numberPhone", SqlDbType.VarChar, 15).Value = gv.numberPhone;
                    cmd.Parameters.Add("@new_gioitinh", SqlDbType.NVarChar, 10).Value = gv.gioitinh;
                    cmd.Parameters.Add("@new_Ngaysinh", SqlDbType.Date).Value = gv.Ngaysinh;
                    cmd.Parameters.Add("@new_email", SqlDbType.VarChar, 50).Value = gv.email; 
                    cmd.Parameters.Add("@new_role", SqlDbType.NVarChar, 20).Value = gv.role;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
        }

        public static bool DeleteGV(string gv_id)
        {
            try
            {
                SqlConnection conn = MyDatabaseUtils.connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("XoaGiangVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@gv_id", gv_id);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static User GetGvByUserId(string userId)
        {
            try
            {
                SqlConnection conn = MyDatabaseUtils.connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM User_sub WHERE user_id = @userId", conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                SqlDataReader reader = cmd.ExecuteReader();

                User user = new User();

                if (reader.Read())
                {
                    user.user_id = reader["user_id"].ToString();
                    user.hovaten = reader["hovaten"].ToString();
                    user.diachi = reader["diachi"].ToString();
                    user.numberPhone = reader["numberPhone"].ToString();
                    user.gioitinh = reader["gioitinh"].ToString();
                    user.Ngaysinh = Convert.ToDateTime(reader["Ngaysinh"]);
                    user.email = reader["email"].ToString();
                    user.role = reader["role"].ToString();
                    user.account_id = reader["account_id"].ToString();
                }

                reader.Close();
                conn.Close();
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public static bool AddMonhoc(MonHoc mh , string user_id)
        {
            try
            {
                SqlConnection conn = MyDatabaseUtils.connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThemMonHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenMonhoc", mh.tenMonhoc);
                cmd.Parameters.AddWithValue("@tinChi", mh.tinChi);
                cmd.Parameters.AddWithValue("@hocPhimon", mh.hocPhiMon);
                cmd.Parameters.AddWithValue("@phonghoc", mh.phonghoc);
                cmd.Parameters.AddWithValue("@ca", mh.cahoc);
                cmd.Parameters.AddWithValue("@thu", mh.thu);
                cmd.Parameters.AddWithValue("@ngaybatdau", mh.ngaybatdau);
                cmd.Parameters.AddWithValue("@ngayketthuc", mh.ngayketthuc);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool UpdateMonHoc(MonHoc mh , string lichhoc_id,string user_id)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SuaMonHoc", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@monhoc_id", mh.monhoc_id);
                    cmd.Parameters.AddWithValue("@tenMonhoc", mh.tenMonhoc);
                    cmd.Parameters.AddWithValue("@tinChi", mh.tinChi);
                    cmd.Parameters.AddWithValue("@hocPhimon", mh.hocPhiMon);
                    cmd.Parameters.AddWithValue("@phonghoc", mh.phonghoc);
                    cmd.Parameters.AddWithValue("@licHoc_id", lichhoc_id);
                    cmd.Parameters.AddWithValue("@ca", mh.cahoc);
                    cmd.Parameters.AddWithValue("@thu", mh.thu);
                    cmd.Parameters.AddWithValue("@ngaybatdau", mh.ngaybatdau);
                    cmd.Parameters.AddWithValue("@ngayketthuc", mh.ngayketthuc);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
        }
        public static bool DeleteMonhoc(string monhoc_id)
        {
            try
            {
                SqlConnection conn = MyDatabaseUtils.connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("XoaMonHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@monhoc_id", monhoc_id);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static string GenerateMonHocID()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select dbo.GenerateMonHocID()", conn);
            cmd.Connection = conn;
            return (string)cmd.ExecuteScalar();
        }
        public static string GenerateGiangVienID()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select dbo.GenerateGiangVienID()", conn);
            cmd.Connection = conn;
            return (string)cmd.ExecuteScalar();
        }
        public static DataTable GetAllKhoa()
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Khoa", conn))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                } // 
            }
        }

        public static bool AddThongBao(ThongBao tb)
        {

                SqlConnection conn = MyDatabaseUtils.connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThemThongBao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@noiDung", tb.noiDung);
                cmd.Parameters.AddWithValue("@loaiThongBao", tb.loaiThongBao);
                cmd.Parameters.AddWithValue("@doiTuong", tb.doiTuong);
                cmd.Parameters.AddWithValue("@ngayHetHan", tb.ngayHetHan);
                cmd.Parameters.AddWithValue("@khoa_id", tb.khoa_id);
                cmd.Parameters.AddWithValue("@user_id",tb.user_id);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return true;
            // bt r nó bảo thiếu thiếu trong proc hay khi thêm nó thiếu thêm thiếu m nhớ cái udes ste lde t lam
            
        }
        public static string GenerateThongBaoID()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select dbo.GenerateThongBaoID()", conn);
            cmd.Connection = conn;
            return (string)cmd.ExecuteScalar();
        }

        public static string GetAdminIdByAccId(string acc)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand($"Select user_id FROM User_sub where account_id = '{acc}'", conn);
            cmd.Connection = conn;
            return (string)cmd.ExecuteScalar();
        }
        public static bool UpdateThongBao(ThongBao tb)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SuaThongBao", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tb_id", tb.tb_id);
                    cmd.Parameters.AddWithValue("@noiDung", tb.noiDung);
                    cmd.Parameters.AddWithValue("@loaiThongBao", tb.loaiThongBao);
                    cmd.Parameters.AddWithValue("@doiTuong", tb.doiTuong);
                    cmd.Parameters.AddWithValue("@ngayHetHan", tb.ngayHetHan);
                    cmd.Parameters.AddWithValue("@khoa_id", tb.khoa_id);
                    cmd.Parameters.AddWithValue("@user_id", tb.user_id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
        }
        public static bool DeleteThongBao(string tb_id)
        {
            try
            {
                SqlConnection conn = MyDatabaseUtils.connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("XoaThongBao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tb_id", tb_id);

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable GetAllIdSubjectRegister(string userId)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_get_all_id_subject_register", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static void RegisterSubject(string userId, string subjectId)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_register_subject", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_id", userId);
            cmd.Parameters.AddWithValue("@monhoc_id", subjectId);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static MonHoc GetMonHocById(String monHocId)
        {
            MonHoc mh = new MonHoc();
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_select_mh_theo_id", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mh_id", monHocId);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mh.monhoc_id = reader.GetString(0);
                    mh.tenMonhoc = reader.GetString(1);
                    mh.tinChi = reader.GetInt32(2);
                    mh.hocPhiMon = reader.GetInt32(3);
                    mh.ngaybatdau = reader.GetDateTime(4);
                    mh.ngayketthuc = reader.GetDateTime(5);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return null;
            }
            return mh;
        }

        public static void CreateOrder(String userId, int tongTienCacMon)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_tao_hoa_don_cho_sv", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_id", userId);
            cmd.Parameters.AddWithValue("@Tongtiencacmon", tongTienCacMon);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void CreateDetailOrder(String hd_id, String mh_id)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_them_hoa_don_chi_tiet_cua_hd", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hd_id", hd_id);
            cmd.Parameters.AddWithValue("@monhoc_id", mh_id);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void CreateSuKienDrl(SuKienDrl suKienDrl)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_create_SKRDL", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@loaiDRL", suKienDrl.loaiDRL);
            cmd.Parameters.AddWithValue("@TenSK", suKienDrl.tenSK);
            cmd.Parameters.AddWithValue("@Diem", suKienDrl.Diem);
            cmd.Parameters.AddWithValue("@ngaytochuc", suKienDrl.ngaytochuc);
            cmd.Parameters.AddWithValue("@thoigiantochuc", suKienDrl.thoigiantochuc);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static String GetLastIdSuKienDrl()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_get_id_latest_SKDRL", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            String id = (String)cmd.ExecuteScalar();
            conn.Close();
            return id;
        }

        public static void ThemSvJoinSuKienDrl(String user_id, string drl_id)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_insert_sv_drl", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@drl_id", drl_id);
            cmd.Parameters.AddWithValue("@maSV", user_id);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable GetCacChiTietHoaDon(String hd_id)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_get_all_cthd_by_hd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@hd_id", hd_id);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static void DeleteAllMonHocDKCuaSV(String userId)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_delete_register_subjects", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_id", userId);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void ThanhToanHocPhi(String hd_id, int tongSoTienThanhToan)
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_thanh_toan_hoc_phi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hd_id", hd_id);
            cmd.Parameters.AddWithValue("@tongSoTienThanhToan", tongSoTienThanhToan);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static string GenerateLichThiID()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GenerateLichThi_ID", conn);
            cmd.Connection = conn;
            return (string)cmd.ExecuteScalar();
        }

        public static void InsertLichThi(LichThi lt)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("ThemLichThi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ngayThi", SqlDbType.Date).Value = lt.ngayThi;
                    cmd.Parameters.Add("@thoiGianThi", SqlDbType.Time).Value = lt.thoiGianThi;
                    cmd.Parameters.Add("@diaDiemThi", SqlDbType.NVarChar, 20).Value = lt.diaDiemThi;
                    cmd.Parameters.Add("@hinhthucthi", SqlDbType.NVarChar, 20).Value = lt.hinhThucThi;
                    cmd.Parameters.Add("@user_id", SqlDbType.VarChar, 10).Value = lt.user_id;
                    cmd.Parameters.Add("@monhoc_id", SqlDbType.VarChar, 10).Value = lt.monhoc_id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static void UpdateLichThi(LichThi lt)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SuaLichThi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@lt_id", SqlDbType.VarChar, 10).Value = lt.lt_id;
                    cmd.Parameters.Add("@ngayThi", SqlDbType.Date).Value = lt.ngayThi;
                    cmd.Parameters.Add("@thoiGianThi", SqlDbType.Time).Value = lt.thoiGianThi;
                    cmd.Parameters.Add("@diaDiemThi", SqlDbType.NVarChar, 20).Value = lt.diaDiemThi;
                    cmd.Parameters.Add("@hinhthucthi", SqlDbType.NVarChar, 20).Value = lt.hinhThucThi;
                    cmd.Parameters.Add("@user_id", SqlDbType.VarChar, 10).Value = lt.user_id;
                    cmd.Parameters.Add("@monhoc_id", SqlDbType.VarChar, 10).Value = lt.monhoc_id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void DeleteLichThi(string lt_id)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("XoaLichThi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@lt_id", SqlDbType.VarChar, 10).Value = lt_id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static DataTable GetAllLoaiDRL()
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("selectCacLoaiDRL", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public static DataTable GetAllSKDRL()
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("selectAllSKDRL", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static string GenerateSuKienID()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GenerateSKDRLID", conn);
            cmd.Connection = conn;
            return (string)cmd.ExecuteScalar();
        }

        public static void InsertSuKien(SuKien sk)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("ThemSKDRL", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@loaiDRL", SqlDbType.NVarChar, 20).Value = sk.loaiDRL;
                    cmd.Parameters.Add("@TenSK", SqlDbType.NVarChar, 20).Value = sk.TenSK;
                    cmd.Parameters.Add("@Diem", SqlDbType.Int).Value = sk.Diem;
                    cmd.Parameters.Add("@ngaytochuc", SqlDbType.Date).Value = sk.ngaytochuc;
                    cmd.Parameters.Add("@thoigiantochuc", SqlDbType.Time).Value = sk.thoigiantochuc;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static void UpdateSuKien(SuKien sk)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SuaSKDRL", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@DRL_id", SqlDbType.VarChar, 10).Value = sk.DRL_id;
                    cmd.Parameters.Add("@loaiDRL", SqlDbType.NVarChar, 20).Value = sk.loaiDRL;
                    cmd.Parameters.Add("@TenSK", SqlDbType.NVarChar, 20).Value = sk.TenSK;
                    cmd.Parameters.Add("@Diem", SqlDbType.Int).Value = sk.Diem;
                    cmd.Parameters.Add("@ngaytochuc", SqlDbType.Date).Value = sk.ngaytochuc;
                    cmd.Parameters.Add("@thoigiantochuc", SqlDbType.Time).Value = sk.thoigiantochuc;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static void DeleteSuKien(string drl_id)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("XoaSKDRL", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@DRL_id", SqlDbType.VarChar, 10).Value = drl_id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static DataTable GetAllMonHocByGvId(string gvId)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_getmonByGVid", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@gv_id", SqlDbType.VarChar, 10).Value = gvId;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetAllSVStudyMonHoc(string mh_id)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_getSvStudyMonHocId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@monhoc_id", SqlDbType.VarChar, 10).Value = mh_id;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetAllDiemSvByMonHocId(string monHocId)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_getSvByMonHocId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@monhoc_id", SqlDbType.VarChar, 10).Value = monHocId;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public static void UpdateDiemThi(DiemThi diem)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("SuaDiemThi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@diemQT1", SqlDbType.Float).Value = diem.diemQT1 != null ? (object)diem.diemQT1 : DBNull.Value;
                    cmd.Parameters.Add("@diemQT2", SqlDbType.Float).Value = diem.diemQT2 != null ? (object)diem.diemQT2 : DBNull.Value;
                    cmd.Parameters.Add("@diemCuoiKi", SqlDbType.Float).Value = diem.diemCuoiKi != null ? (object)diem.diemCuoiKi : DBNull.Value;
                    cmd.Parameters.Add("@diemGiuaKi", SqlDbType.Float).Value = diem.diemGiuaKi != null ? (object)diem.diemGiuaKi : DBNull.Value;
                    cmd.Parameters.Add("@diemTb", SqlDbType.Float).Value = diem.diemTb != null ? (object)diem.diemTb : DBNull.Value;
                    cmd.Parameters.Add("@user_id", SqlDbType.VarChar, 10).Value = diem.user_id;
                    cmd.Parameters.Add("@monhoc_id", SqlDbType.VarChar, 10).Value = diem.monhoc_id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    
        public static DataTable GetKhaoSatByMonHoc(string maMH)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_select_khaosat_monhoc", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maMH", maMH);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetMonHocDKCuaSV(String user_id)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_get_mh_dk_cua_sv", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSV", user_id);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static double GetDiemTrungBinhCaTruong()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_tinh_trung_binh_diem_truong", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            double dtb = (double)cmd.ExecuteScalar();
            conn.Close();
            return dtb;
        }

        public static int GetDRLTrungBinhCaTruong()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_tinh_trung_binh_drl", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            int drl_tb = (int)cmd.ExecuteScalar();
            conn.Close();
            return drl_tb;
        }

        public static DataTable GetDanhSachSinhVienTheoDtbVaDRL(int drl, float dtb)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_get_all_sv_by_drl_va_dtb", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@drl", drl);
                    cmd.Parameters.AddWithValue("@dtb", dtb);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetDanhSachSinhVienTheoTrangThaiHD(string trangThai)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("proc_get_all_sv_by_trang_thai_hoa_don", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        sqlDataAdapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static String GetLastIdDiemDanh()
        {
            SqlConnection conn = MyDatabaseUtils.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_get_id_latest_DD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            String id = (String)cmd.ExecuteScalar();
            conn.Close();
            return id;
        }

        public static void InsertDiemDanh(String mh_id)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("ThemDiemDanhSV", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@monhoc_id", SqlDbType.VarChar, 10).Value = mh_id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static void InsertSV_DD(String user_id, String dd_id)
        {
            using (SqlConnection conn = MyDatabaseUtils.connect())
            {
                using (SqlCommand cmd = new SqlCommand("ThemSV_DD", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@user_id", SqlDbType.VarChar, 10).Value = user_id;
                    cmd.Parameters.Add("@DD_id", SqlDbType.VarChar, 10).Value = dd_id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}

       


    

