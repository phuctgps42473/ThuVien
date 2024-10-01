using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.DTO
{
    public class SachDTO
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string TacGia { get; set; }
        public int TaiBan { get; set; }
        public int SoLuong { get; set; }
        public int TonKho { get; set; }
        public bool IsAvailable { get; set; }
        public int IdLoai { get; set; }

    }
}
