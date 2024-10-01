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
        public double PhiThue { get; set; }
        public string TrangThai { get; set; }
        public int IdDocGia { get; set; }
        public int IdSach { get; set; }
        public int IdThuThu { get; set; }
    }
}
