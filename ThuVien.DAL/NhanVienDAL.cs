using System.Collections.Generic;
using System.Configuration;
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

        public int InsertNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "insert into(ten, email, password, dienthoai,la_quanly) value (@ten, @email, @password, @dienthoai, @la_quanly)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", nv.Ten);
                cmd.Parameters.AddWithValue("@email", nv.Email);
                cmd.Parameters.AddWithValue("@password", nv.MatKhau);
                cmd.Parameters.AddWithValue("@dienthoai", nv.DienThoai);
                cmd.Parameters.AddWithValue("@la_quanly", nv.IsManager);
                conn.Open();
                // What is next?

                int rowsAffected = cmd.ExecuteNonQuery(); // Executes the insert command
                conn.Close();
                return rowsAffected;

            }
        }


        public int UpdateNhanVien(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "update nhanvien set ten = @ten, email = @email, password = @password, dienthoai = @dienthoai,la_quanly = @la_quanly) where id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", nv.Ten);
                cmd.Parameters.AddWithValue("@email", nv.Email);
                cmd.Parameters.AddWithValue("@password", nv.MatKhau);
                cmd.Parameters.AddWithValue("@dienthoai", nv.DienThoai);
                cmd.Parameters.AddWithValue("@la_quanly", nv.IsManager);
                cmd.Parameters.AddWithValue("@id", nv.Id);
                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery(); 
                conn.Close();
                return rowsAffected;

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

        public List<NhanVienDTO> GetAllNhanVien()
        {
            List<NhanVienDTO> l = new List<NhanVienDTO>();


            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "SELECT id, ten,email, password, dienthoai, la_quanly FROM nhanvien";
                SqlCommand cmd = new SqlCommand(q, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NhanVienDTO nv = new NhanVienDTO()
                        {
                            Id = (int)reader["id"],
                            Ten = reader["ten"].ToString(),
                            Email = reader["email"].ToString(),
                            MatKhau = reader["password"].ToString(),
                            DienThoai = reader["dienthoai"].ToString(),
                            IsManager = (bool)reader["la_quanly"]
                        };

                        l.Add(nv);
                    }
                }

            }
            return l;
        }
    }
}
