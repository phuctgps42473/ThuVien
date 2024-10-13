using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ThuVien.DTO;

namespace ThuVien.DAL
{
    public class DocGiaDAL
    {
        private readonly string _connectionString;

        public DocGiaDAL()
        {
            _connectionString = DALHelper.ConnectionString;
        }

        public DocGiaDTO GetDocGiaById(int id)
        {
            DocGiaDTO docGia = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "SELECT id, ten, dienthoai, email, diachi, tiencoc FROM docgia WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        docGia = new DocGiaDTO()
                        {
                            Id = (int)r["Id"],
                            Ten = r["ten"].ToString(),
                            Email = r["email"].ToString(),
                            DiaChi = r["diachi"].ToString(),
                            DienThoai = r["dienthoai"].ToString(),
                            TienCoc = (double)r["tiencoc"]
                        };
                    }
                }
            }
            return docGia;
        }


        public DataTable GetAllDocGia()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "SELECT id, ten, dienthoai, email, diachi, tiencoc FROM docgia";
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }

        public DataTable GetDocGiaWithText(string text) {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "select id, ten, dienthoai, email, diachi, tiencoc FROM docgia where ten like @ten OR email like @email OR diachi like @diachi";
                SqlCommand c = new SqlCommand(q, conn);
                c.Parameters.AddWithValue("@ten", "%"+text+"%");
                c.Parameters.AddWithValue("@email", "%"+text+"%");
                c.Parameters.AddWithValue("@diachi", "%"+text+"%");

                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(c.ExecuteReader());
                return dt;
            }
        }

        public int InsertDocGia(DocGiaDTO docGia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "INSERT INTO docgia (ten, dienthoai, email, diachi, tiencoc) " +
                           "VALUES (@ten, @dienthoai, @email, @diachi, @tiencoc)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", docGia.Ten);
                cmd.Parameters.AddWithValue("@dienthoai", docGia.DienThoai);
                cmd.Parameters.AddWithValue("@email", docGia.Email);
                cmd.Parameters.AddWithValue("@diachi", docGia.DiaChi);
                cmd.Parameters.AddWithValue("@tiencoc", docGia.TienCoc);

                conn.Open();
                return cmd.ExecuteNonQuery(); // Returns the number of rows affected
            }
        }

        public int UpdateDocGia(DocGiaDTO docGia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "UPDATE docgia SET ten = @ten, dienthoai = @dienthoai, email = @email, diachi = @diachi, tiencoc = @tiencoc WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", docGia.Ten);
                cmd.Parameters.AddWithValue("@dienthoai", docGia.DienThoai);
                cmd.Parameters.AddWithValue("@email", docGia.Email);
                cmd.Parameters.AddWithValue("@diachi", docGia.DiaChi);
                cmd.Parameters.AddWithValue("@tiencoc", docGia.TienCoc);
                cmd.Parameters.AddWithValue("@id", docGia.Id);

                conn.Open();
                return cmd.ExecuteNonQuery(); // Returns the number of rows affected
            }
        }

        public int DeleteDocGia(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "DELETE FROM docgia WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                return cmd.ExecuteNonQuery(); // Returns the number of rows affected
            }
        }



    }

}
