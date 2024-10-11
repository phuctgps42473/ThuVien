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

        public NhanVienDTO() { }
        public NhanVienDTO(string name, string email, string pass, string sdt, bool manager)
        {
            Ten = name;
            Email = email;
            MatKhau = pass;
            DienThoai = sdt;
            IsManager = manager;
        }

        public NhanVienDTO(int id, string name, string email, string pass, string sdt, bool manager)
        {
            Id = id;
            Ten = name;
            Email = email;
            MatKhau = pass;
            DienThoai = sdt;
            IsManager = manager;
        }
    }
}
