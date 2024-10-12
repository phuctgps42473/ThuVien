using System;
using System.Collections.Generic;
using System.Data;
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
        public bool InsertLoaiSach(LoaiSachDTO l)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string q = "insert into loaisach(ten, mota) values (@ten, @mota)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", l.Ten);
                cmd.Parameters.AddWithValue("@mota", l.Mota); // This was also incorrect, it should match the parameter in your query

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }
        


        public bool UpdateLoaiSach(LoaiSachDTO l)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string q = "update loaisach set ten = @ten, mota = @mota where id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", l.Id);    
                cmd.Parameters.AddWithValue("@ten", l.Ten);
                cmd.Parameters.AddWithValue("@mota", l.Mota);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool DeleteLoaiSach(int id)
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                conn.Open();
                string q = "DELETE FROM loaisach WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public DataTable searchLoaiSach(string tensach)
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string q = "SELECT id, ten, mota FROM loaisach WHERE ten LIKE '%' + @ten + '%'";
                    SqlCommand cmd = new SqlCommand(q, conn);

                    // Use "@" prefix for parameter
                    cmd.Parameters.AddWithValue("@ten", tensach);

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

        public DataTable GetAllLoaiSach()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string q = "SELECT id, ten, mota FROM loaisach";
                SqlCommand cmd = new SqlCommand(q, conn);
                conn.Open();
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
        }



    }

}
