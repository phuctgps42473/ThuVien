using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ThuVien.DTO;

namespace ThuVien.DAL
{
    public class NhanVienDAL
    {
        private readonly string _connectionString;

        public NhanVienDAL()
        {
            _connectionString = DALHelper.ConnectionString;
        }

        public bool InsertNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string q = "insert into nhanvien(ten, email, password, dienthoai,la_quanly) values (@ten, @email, @password, @dienthoai, @la_quanly)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", nv.Ten);
                cmd.Parameters.AddWithValue("@email", nv.Email);
                cmd.Parameters.AddWithValue("@password", nv.MatKhau);
                cmd.Parameters.AddWithValue("@dienthoai", nv.DienThoai);
                cmd.Parameters.AddWithValue("@la_quanly", nv.IsManager);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;

            }
        }


        public bool DeleteNhanVien(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string q = "Delete from nhanvien where id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;

            }
        }


        public bool UpdateNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string q = "update nhanvien set ten = @ten, email = @email, password = @password, dienthoai = @dienthoai,la_quanly = @la_quanly where id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", nv.Ten);
                cmd.Parameters.AddWithValue("@email", nv.Email);
                cmd.Parameters.AddWithValue("@password", nv.MatKhau);
                cmd.Parameters.AddWithValue("@dienthoai", nv.DienThoai);
                cmd.Parameters.AddWithValue("@la_quanly", nv.IsManager);
                cmd.Parameters.AddWithValue("@id", nv.Id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public NhanVienDTO GetNhanVienByEmail(string email)
        {
            NhanVienDTO nv = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "SELECT id, ten, email, password, dienthoai, la_quanly FROM nhanvien where email = @email";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@email", email);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nv = new NhanVienDTO()
                        {
                            Id = (int)reader["id"],
                            Ten = reader["ten"].ToString(),
                            Email = reader["email"].ToString(),
                            MatKhau = reader["password"].ToString(),
                            DienThoai = reader["dienthoai"].ToString(),
                            IsManager = (bool)reader["la_quanly"]
                        };
                    }
                }

            }

            return nv;
        }

        public NhanVienDTO GetNhanVienById(int id)
        {
            NhanVienDTO nv = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "SELECT id, ten, email, password, dienthoai, la_quanly FROM nhanvien WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nv = new NhanVienDTO()
                        {
                            Id = (int)reader["id"],
                            Ten = reader["ten"].ToString(),
                            Email = reader["email"].ToString(),
                            MatKhau = reader["password"].ToString(),
                            DienThoai = reader["dienthoai"].ToString(),
                            IsManager = (bool)reader["la_quanly"]
                        };
                    }
                }
            }
            return nv;
        }


        public DataTable GetAllNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "SELECT id,ten,email,password, dienthoai,la_quanly FROM nhanvien";
                SqlCommand cmd = new SqlCommand(q, conn);
                conn.Open();
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
        }


        public DataTable searchNguoiDung(string tennd)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string q = "SELECT id, ten, email, password, dienthoai, la_quanly FROM nhanvien WHERE ten LIKE '%' + @tennd + '%'";
                    SqlCommand cmd = new SqlCommand(q, conn);

                    // Use "@" prefix for parameter
                    cmd.Parameters.AddWithValue("@tennd", tennd);

                    DataTable ds = new DataTable();
                    ds.Load(cmd.ExecuteReader());

                    return ds;
                }
                catch (SqlException ex)
                {
                    // Handle SQL exceptions
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return null; // Or handle it as needed
                }
            }
        }
    }
}
