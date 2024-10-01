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
