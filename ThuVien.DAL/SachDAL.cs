using System.Collections.Generic;
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
                string q = "SELECT id, ten, tacgia, taiban, soluong, tonkho, cosan, id_loaisach FROM sach WHERE id = @id";
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
                            TonKho = (int)r["tonkho"],
                            IsAvailable = (bool)r["cosan"],
                            IdLoai = (int)r["id_loaisach"]
                        };
                    }
                }
            }
            return sach;
        }


        public List<SachDTO> GetAllSach()
        {
            List<SachDTO> l = new List<SachDTO>();

            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                string q = "SELECT id, ten, tacgia, taiban, soluong, tonkho, cosan,id_loaisach FROM sach";
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        SachDTO s = new SachDTO()
                        {
                            Id = (int)r["id"],
                            Ten = r["ten"].ToString(),
                            TacGia = r["tacgia"].ToString(),
                            TaiBan = (int)r["taiban"],
                            SoLuong = (int)r["soluong"],
                            TonKho = (int)r["tonkho"],
                            IsAvailable = (bool)r["cosan"],
                            IdLoai = (int)r["id_loai"]
                        };
                        l.Add(s);
                    }

                }
            }
            return l;
        }

        public int InsertSach(SachDTO sach)
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                string q = "INSERT INTO sach (ten, tacgia, taiban, soluong, tonkho, cosan, id_loaisach) " +
                           "VALUES (@ten, @tacgia, @taiban, @soluong, @tonkho, @cosan, @id_loaisach)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", sach.Ten);
                cmd.Parameters.AddWithValue("@tacgia", sach.TacGia);
                cmd.Parameters.AddWithValue("@taiban", sach.TaiBan);
                cmd.Parameters.AddWithValue("@soluong", sach.SoLuong);
                cmd.Parameters.AddWithValue("@tonkho", sach.TonKho);
                cmd.Parameters.AddWithValue("@cosan", sach.IsAvailable);
                cmd.Parameters.AddWithValue("@id_loaisach", sach.IdLoai);

                conn.Open();
                return cmd.ExecuteNonQuery(); // Returns the number of rows affected
            }
        }

        public int UpdateSach(SachDTO sach)
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                string q = "UPDATE sach SET ten = @ten, tacgia = @tacgia, taiban = @taiban, " +
                           "soluong = @soluong, tonkho = @tonkho, cosan = @cosan, id_loaisach = @id_loaisach WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@ten", sach.Ten);
                cmd.Parameters.AddWithValue("@tacgia", sach.TacGia);
                cmd.Parameters.AddWithValue("@taiban", sach.TaiBan);
                cmd.Parameters.AddWithValue("@soluong", sach.SoLuong);
                cmd.Parameters.AddWithValue("@tonkho", sach.TonKho);
                cmd.Parameters.AddWithValue("@cosan", sach.IsAvailable);
                cmd.Parameters.AddWithValue("@id_loaisach", sach.IdLoai);
                cmd.Parameters.AddWithValue("@id", sach.Id);

                conn.Open();
                return cmd.ExecuteNonQuery(); // Returns the number of rows affected
            }
        }

        public int DeleteSach(int id)
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                string q = "DELETE FROM sach WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                return cmd.ExecuteNonQuery(); // Returns the number of rows affected
            }
        }


    }
}
