namespace ThuVien.DTO
{
    public class NhanVienDTO
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string MatKhau { set; get; }
        public string DienThoai { set; get; }
        public bool IsManager { get; set; }

    }
}
