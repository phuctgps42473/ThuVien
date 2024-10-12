using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVien.DAL;
using ThuVien.DTO;

namespace ThuVien.BUS
{
    public class LoaiSach_BUS
    {
        LoaiSachDAL loaiDAL = new LoaiSachDAL();
       
        public bool AddLoaiSach(LoaiSachDTO loai)
        {
            return loaiDAL.InsertLoaiSach(loai);
        }
        public bool UpdateLoaiSach( LoaiSachDTO loai)
        { 
            return loaiDAL.UpdateLoaiSach(loai);
        }
        public bool DeleteLoaiSach(int id)
        {
            return loaiDAL.DeleteLoaiSach(id);
        }
        
        public DataTable GetAllLoaiSach()
        {
            return loaiDAL.GetAllLoaiSach();
        }
        public DataTable searchLoaiSach(string tensach)
        {
            return loaiDAL.searchLoaiSach(tensach);
        }

    }
}
