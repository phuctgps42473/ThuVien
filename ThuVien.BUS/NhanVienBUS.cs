using ThuVien.DAL;
using ThuVien.DTO;


namespace ThuVien.BUS
{
    public class NhanVienBus
    {
        private NhanVienDAL nhanVienDAL;

        public NhanVienBus()
        {
            nhanVienDAL = new NhanVienDAL();
        }

        public bool ValidateLogin(string email, string password)
        {
            NhanVienDTO NhanVien = nhanVienDAL.GetNhanVienByEmail(email);

            if (NhanVien != null)
            {
                if (NhanVien.MatKhau == password)
                {
                    Session.Instance.SetNhanVien(NhanVien);
                    return true;
                }
            }
            return false;

        }

        public void logout()
        {
            Session.Instance.clearNhanVien();
        }
    }
}
