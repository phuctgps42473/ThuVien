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
    }
}
