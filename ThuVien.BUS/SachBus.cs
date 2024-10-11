﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVien.DAL;
using ThuVien.DTO;

namespace ThuVien.BUS
{
    public class SachBus
    {
        SachDAL _sachDal = new SachDAL();
        public DataTable GetAllSach()
        {
            return _sachDal.GetAllSach();
        }
        public bool InsertSach(SachDTO sach)
        {
            return _sachDal.InsertSach(sach);
        }
        public bool UpdateSach(SachDTO sach) 
        {
            return _sachDal.UpdateSach(sach);
        }
        public bool DeleteSach(int id)
        {
            return _sachDal.DeleteSach(id);
        }
    }
}
