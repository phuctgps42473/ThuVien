using System;
using System.Collections.Generic;
using System.Data;
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

        
        //public PhieuMuonDTO GetPhieuMuonById(int id)
        //{
        //    PhieuMuonDTO phieuMuon = null;
        //    using (SqlConnection conn = new SqlConnection(_connString))
        //    {
        //        string q = "SELECT id, soluong, ngaymuon, ngaytra, phithue, trangthai, id_docgia, id_sach, id_thuthu FROM phieumuon WHERE id = @id";
        //        SqlCommand cmd = new SqlCommand(q, conn);
        //        cmd.Parameters.AddWithValue("@id", id);

        //        conn.Open();
        //        using (SqlDataReader r = cmd.ExecuteReader())
        //        {
        //            if (r.Read())
        //            {
        //                phieuMuon = new PhieuMuonDTO()
        //                {
        //                    Id = (int)r["ID"],
        //                    IdDocGia = (int)r["id_docgia"],
        //                    IdSach = (int)r["id_sach"],
        //                    IdThuThu = (int)r["id_thuthu"],
        //                    NgayMuon = (DateTime)r["ngaymuon"],
        //                    NgayTra = (DateTime)r["ngaytra"],
        //                    SoLuong = (int)r["soluong"],
        //                    PhiThue = (double)r["phithue"],
        //                    TrangThai = r["trangthai"].ToString()
        //                };
        //            }
        //        }
        //    }
        //    return phieuMuon;
        //}
        public DataTable GetAllPhieuMuon()
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "SELECT id, soluong, ngaymuon,ngaytra, phithue,trangthai,id_docgia,id_sach,id_thuthu FROM phieumuon";
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
        }

        public DataTable GetAllIDDocGia()
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "SELECT id FROM docgia";
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
        }

        public DataTable GetAllIDSach()
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "SELECT id FROM sach";
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
        }

        public DataTable GetAllIDthuthu()
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string q = "SELECT id FROM nhanvien where la_quanly = 0";
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
        }

        public bool InsertPhieuMuon(PhieuMuonDTO phieuMuon)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
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
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool UpdatePhieuMuon(PhieuMuonDTO phieuMuon)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
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
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false; ; // Returns the number of rows affected
            }
        }

        public bool DeletePhieuMuon(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                string q = "DELETE FROM phieumuon WHERE id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", id);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;// Returns the number of rows affected
            }
        }
        public DataTable searchPhieuMuon(string mapm)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                try
                {
                    conn.Open();
                    string q = "SELECT id, soluong, ngaymuon,ngaytra, phithue,trangthai,id_docgia,id_sach,id_thuthu FROM phieumuon WHERE id LIKE '%' + @mapm + '%'";
                    SqlCommand cmd = new SqlCommand(q, conn);

                    // Use "@" prefix for parameter
                    cmd.Parameters.AddWithValue("@tennd", mapm);

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

    }

}
