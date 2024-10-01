using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ThuVien.DTO;

namespace ThuVien.DAL
{
    public class PhieuMuonDAL
    {
        private string _connString;
        public PhieuMuonDAL()
        {
            _connString = DALHelper.ConnectionString;
        }

        public List<PhieuMuonDTO> GetAllPhieuMuon()
        {
            List<PhieuMuonDTO> l = new List<PhieuMuonDTO>();

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "SELECT id, soluong, ngaymuon,ngaytra, phithue,trangthai,id_docgia,id_sach,id_thuthu FROM phieumuon";
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        PhieuMuonDTO p = new PhieuMuonDTO()
                        {
                            Id = (int)r["ID"],
                            IdDocGia = (int)r["id_docgia"],
                            IdSach = (int)r["id_sach"],
                            IdThuThu = (int)r["id_thuthu"],
                            NgayMuon = (DateTime)r["ngaymuon"],
                            NgayTra = (DateTime)r["ngaytra"],
                            SoLuong = (int)r["soluong"],
                            PhiThue = (double)r["phithue"],
                            TrangThai = r["trangthai"].ToString()
                        };
                        l.Add(p);
                    }
                }
            }
            return l;
        }

    }

}
