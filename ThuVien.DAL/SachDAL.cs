using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using ThuVien.DTO;

namespace ThuVien.DAL
{
    public class SachDAL
    {
        private string _connString;

        public SachDAL()
        {
            _connString = DALHelper.ConnectionString;
        }

        public SachDTO GetSachById(int id)
        {
            SachDTO sach = null;
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                string q = "SELECT id, ten, tacgia, taiban, soluong, id_loaisach FROM sach WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        sach = new SachDTO()
                        {
                            Id = (int)r["id"],
                            Ten = r["ten"].ToString(),
                            TacGia = r["tacgia"].ToString(),
                            TaiBan = (int)r["taiban"],
                            SoLuong = (int)r["soluong"],
                            IdLoai = (int)r["id_loaisach"]
                        };
                    }
                }
            }
            return sach;
        }
       

        public DataTable GetAllSach()
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "SELECT id, ten, tacgia, taiban, soluong, id_loaisach FROM sach";
                SqlCommand cmd = new SqlCommand(q, conn);
                conn.Open();
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
        }

        public bool InsertSach(SachDTO sach)
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                conn.Open();
                string q = "INSERT INTO sach (ten, tacgia, taiban, soluong, id_loaisach) " +
                           "VALUES (@ten, @tacgia, @taiban, @soluong, @id_loaisach)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", sach.Ten);
                cmd.Parameters.AddWithValue("@tacgia", sach.TacGia);
                cmd.Parameters.AddWithValue("@taiban", sach.TaiBan);
                cmd.Parameters.AddWithValue("@soluong", sach.SoLuong);
                cmd.Parameters.AddWithValue("@id_loaisach", sach.IdLoai);

                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool UpdateSach(SachDTO sach)
        {

            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                conn.Open();
                string q = "UPDATE sach SET ten = @ten, tacgia = @tacgia, taiban = @taiban, " +
                           "soluong = @soluong, id_loaisach = @id_loaisach WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", sach.Ten);
                cmd.Parameters.AddWithValue("@tacgia", sach.TacGia);
                cmd.Parameters.AddWithValue("@taiban", sach.TaiBan);
                cmd.Parameters.AddWithValue("@soluong", sach.SoLuong);
                cmd.Parameters.AddWithValue("@id_loaisach", sach.IdLoai);
                cmd.Parameters.AddWithValue("@id", sach.Id);

                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;// Returns the number of rows affected
            }
        }

        public bool DeleteSach(int id)
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                conn.Open();
                string q = "DELETE FROM sach WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public DataTable searchSach(string tensach)
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string q = "SELECT id, ten, tacgia, taiban, soluong, id_loaisach FROM sach WHERE ten LIKE '%' + @ten + '%'";
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
        public DataTable LoaiSach()
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
            
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text; 
                cmd.CommandText = "SELECT * FROM loaisach"; 
                cmd.Connection = conn;

                DataTable dsLoaiHang = new DataTable();
                dsLoaiHang.Load(cmd.ExecuteReader());

                return dsLoaiHang;
            

            }
        }

    }
}
