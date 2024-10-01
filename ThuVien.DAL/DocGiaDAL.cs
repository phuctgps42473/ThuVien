using System.Collections.Generic;
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

        public List<DocGiaDTO> GetAllDocGia()
        {
            List<DocGiaDTO> l = new List<DocGiaDTO>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "SELECT id, ten, dienthoai, email, diachi, tiencoc FROM docgia";
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        DocGiaDTO d = new DocGiaDTO()
                        {
                            Id = (int)r["Id"],
                            Ten = r["id"].ToString(),
                            Email = r["email"].ToString(),
                            DiaChi = r["diachi"].ToString(),
                            DienThoai = r["dienthoai"].ToString(),
                            TienCoc = (double)r["tiencoc"]
                        };

                        l.Add(d);
                    }
                }
            }
            return l;
        }
    }

}
