using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVien.DTO;

namespace ThuVien.BUS
{
    public class Session
    {
        private static Session _instance;
        public NhanVienDTO NhanVien { get; set; }

        public static Session Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Session();
                }
                return _instance;


            }
        }

        public void SetNhanVien(NhanVienDTO nv)
        {
            this.NhanVien = nv;
        }

        public void ClearNhanVien()
        {
            this.NhanVien = null;

        }


    }


}
