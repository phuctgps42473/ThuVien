using ThuVien.DAL;
using ThuVien.DTO;

namespace ThuVien.BUS
{
    public class AuthBUS
    {
        private NhanVienDAL _nhanVienDAL;

        public AuthBUS()
        {
            _nhanVienDAL = new NhanVienDAL();
        }

        public bool ValidateLogin(string email, string password)
        {
            NhanVienDTO NhanVien = _nhanVienDAL.GetNhanVienByEmail(email);

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
        //batocom


        public void Logout()
        {
            Session.Instance.ClearNhanVien();
        }

        public void ChangePassword(string matKhauMoi)
        {
            NhanVienDTO n = Session.Instance.NhanVien;
            n.MatKhau = matKhauMoi;
            _nhanVienDAL.UpdateNhanVien(n);
        }
    }
}
