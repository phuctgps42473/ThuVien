

using System.Collections.Generic;
using System.Data;
using ThuVien.DAL;
using ThuVien.DTO;

namespace ThuVien.BUS
{
    public class NhanVienBus
    {
        NhanVienDAL dAL_QLTT = new NhanVienDAL();
        public DataTable GetAllNhanVien()
        {
            return dAL_QLTT.GetAllNhanVien();
        }

        public DataTable searchNhanVien(string tennd)
        {
            return dAL_QLTT.searchNguoiDung(tennd);
        }

        public bool InsertNhanVien(NhanVienDTO nv)
        {
            return dAL_QLTT.InsertNhanVien(nv);
        }

        public bool UpdateNhanVien(NhanVienDTO nv)
        {
            return dAL_QLTT.UpdateNhanVien(nv);
        }

        public bool DeleteNhanVien(int id)
        {
            return dAL_QLTT.DeleteNhanVien(id);
        }
    }
}
