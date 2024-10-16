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
        public int CoSan { get; set; }
        public int IdLoai { get; set; }
        public SachDTO() { }


        public SachDTO(int id, string name, string tacgia, int taiban, int soluong,int cosan, int idloai)
        {
            Id = id;
            Ten = name;
            TacGia = tacgia;
            TaiBan = taiban;
            SoLuong = soluong;
            CoSan = cosan;
            IdLoai = idloai;
        }
        public SachDTO(string name, string tacgia, int taiban, int soluong, int cosan, int idloai)
        {
            Ten = name;
            TacGia = tacgia;
            TaiBan = taiban;
            SoLuong = soluong;
            CoSan = cosan;
            IdLoai = idloai;
        }
    }
}
