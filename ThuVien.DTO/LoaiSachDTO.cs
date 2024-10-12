namespace ThuVien.DTO
{
    public class LoaiSachDTO
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }


        public LoaiSachDTO() { }


        public LoaiSachDTO(int id, string ten, string mota)
        {
            Id = id;
            Ten = ten;
            Mota = mota;
        }
        public LoaiSachDTO(string ten, string mota)
        {
            Ten = ten;
            Mota = mota;
        }
    }
    
}
