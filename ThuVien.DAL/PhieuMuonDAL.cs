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

        public PhieuMuonDTO GetPhieuMuonById(int id)
        {
            PhieuMuonDTO phieuMuon = null;
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "SELECT id, soluong, ngaymuon, ngaytra, phithue, trangthai, id_docgia, id_sach, id_thuthu FROM phieumuon WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        phieuMuon = new PhieuMuonDTO()
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
                    }
                }
            }
            return phieuMuon;
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

        public int InsertPhieuMuon(PhieuMuonDTO phieuMuon)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "INSERT INTO phieumuon (soluong, ngaymuon, ngaytra, phithue, trangthai, id_docgia, id_sach, id_thuthu) " +
                           "VALUES (@soluong, @ngaymuon, @ngaytra, @phithue, @trangthai, @id_docgia, @id_sach, @id_thuthu)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@soluong", phieuMuon.SoLuong);
                cmd.Parameters.AddWithValue("@ngaymuon", phieuMuon.NgayMuon);
                cmd.Parameters.AddWithValue("@ngaytra", phieuMuon.NgayTra);
                cmd.Parameters.AddWithValue("@phithue", phieuMuon.PhiThue);
                cmd.Parameters.AddWithValue("@trangthai", phieuMuon.TrangThai);
                cmd.Parameters.AddWithValue("@id_docgia", phieuMuon.IdDocGia);
                cmd.Parameters.AddWithValue("@id_sach", phieuMuon.IdSach);
                cmd.Parameters.AddWithValue("@id_thuthu", phieuMuon.IdThuThu);

                conn.Open();
                return cmd.ExecuteNonQuery(); // Returns the number of rows affected
            }
        }

        public int UpdatePhieuMuon(PhieuMuonDTO phieuMuon)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "UPDATE phieumuon SET soluong = @soluong, ngaymuon = @ngaymuon, ngaytra = @ngaytra, " +
                           "phithue = @phithue, trangthai = @trangthai, id_docgia = @id_docgia, id_sach = @id_sach, id_thuthu = @id_thuthu WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@soluong", phieuMuon.SoLuong);
                cmd.Parameters.AddWithValue("@ngaymuon", phieuMuon.NgayMuon);
                cmd.Parameters.AddWithValue("@ngaytra", phieuMuon.NgayTra);
                cmd.Parameters.AddWithValue("@phithue", phieuMuon.PhiThue);
                cmd.Parameters.AddWithValue("@trangthai", phieuMuon.TrangThai);
                cmd.Parameters.AddWithValue("@id_docgia", phieuMuon.IdDocGia);
                cmd.Parameters.AddWithValue("@id_sach", phieuMuon.IdSach);
                cmd.Parameters.AddWithValue("@id_thuthu", phieuMuon.IdThuThu);
                cmd.Parameters.AddWithValue("@id", phieuMuon.Id);

                conn.Open();
                return cmd.ExecuteNonQuery(); // Returns the number of rows affected
            }
        }

        public int DeletePhieuMuon(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "DELETE FROM phieumuon WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                return cmd.ExecuteNonQuery(); // Returns the number of rows affected
            }
        }


    }

}
