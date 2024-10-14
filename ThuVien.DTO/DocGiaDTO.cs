namespace ThuVien.DTO
{
    public class DocGiaDTO
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public double TienCoc { get; set; }

        public DocGiaDTO() { }
        public DocGiaDTO(int id, string ten, string dienThoai, string email, string diaChi, double tienCoc)
        {
            Id = id;
            Ten = ten;
            DienThoai = dienThoai;
            Email = email;
            DiaChi = diaChi;
            TienCoc = tienCoc;
        }
        public DocGiaDTO( string ten, string dienThoai, string email, string diaChi, double tienCoc)
        {
            Ten = ten;
            DienThoai = dienThoai;
            Email = email;
            DiaChi = diaChi;
            TienCoc = tienCoc;
        }
    }
}
