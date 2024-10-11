using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.DTO
{
    public class PhieuMuonDTO
    {
        public int Id { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public int PhiThue { get; set; }
        public string TrangThai { get; set; }
        public int IdDocGia { get; set; }
        public int IdSach { get; set; }
        public int IdThuThu { get; set; }


        public PhieuMuonDTO(int soluong, DateTime ngaymuon, DateTime ngaytra, int phithue, string trangthai, int iddg, int ids, int idtt)
        {
            SoLuong = soluong;
            NgayMuon = ngaymuon;
            NgayTra = ngaytra;
            PhiThue = phithue;
            TrangThai = trangthai;
            IdDocGia = iddg;
            IdSach = ids;
            IdThuThu = idtt;
        }

        public PhieuMuonDTO(int id, int soluong, DateTime ngaymuon, DateTime ngaytra, int phithue, string trangthai, int iddg, int ids, int idtt)
        {
            Id = id;
            SoLuong = soluong;
            NgayMuon = ngaymuon;
            NgayTra = ngaytra;
            PhiThue = phithue;
            TrangThai = trangthai;
            IdDocGia = iddg;
            IdSach = ids;
            IdThuThu = idtt;
        }
    }
}
