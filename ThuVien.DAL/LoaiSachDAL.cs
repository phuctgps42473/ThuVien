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
        public int InsertLoaiSach(LoaiSachDTO l)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "insert into loaisach(ten, mota) value (@ten, @mota)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", l.Ten);
                cmd.Parameters.AddWithValue("@email", l.Mota);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery(); 
                conn.Close();

                return rowsAffected;

            }
        }


        public int UpdateLoaiSach(LoaiSachDTO l)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "update loaisach set ten = @ten, mota = @mota) where id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", l.Ten);
                cmd.Parameters.AddWithValue("@email", l.Mota);
                cmd.Parameters.AddWithValue("@email", l.Id);
                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
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
