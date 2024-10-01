using System.Collections.Generic;
using System.Data.SqlClient;
using ThuVien.DTO;

namespace ThuVien.DAL
{
    public class LoaiSachDAL
    {
        private string _connectionString;

        public LoaiSachDAL()
        {
            _connectionString = DALHelper.ConnectionString;
        }

        public List<LoaiSachDTO> GetAllLoaiSach()
        {
            List<LoaiSachDTO> l = new List<LoaiSachDTO>();


            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "SELECT * FROM loaisach";
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        LoaiSachDTO loai = new LoaiSachDTO()
                        {
                            Id = (int)reader["id"],
                            Ten = reader["ten"].ToString(),
                            Mota = reader["mota"].ToString()
                        };

                        l.Add(loai);

                    }
                }

            }

            return l;

        }



    }

}
