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
    public class MuonTra_BUS
    {
        PhieuMuonDAL _phieuMuonDAL = new PhieuMuonDAL();

        public DataTable GetAllPhieuMuon()
        {
            return _phieuMuonDAL.GetAllPhieuMuon();
        }

        public int GetAllSoLuong(int id)
        {
            return _phieuMuonDAL.GetSoLuong(id);
        }

        public int GetAllSoLuongKho(int id)
        {
            return _phieuMuonDAL.GetSoLuongKho(id);
        }
        public int GetPreviousBorrowQuantity(int id)
        {
            return _phieuMuonDAL.GetPreviousBorrowQuantity(id);
        }


        public DataTable GetAllIDDocGia()
        {
            return _phieuMuonDAL.GetAllIDDocGia();
        }
        public DataTable GetAllIDSach()
        {
            return _phieuMuonDAL.GetAllIDSach();
        }
        public DataTable GetAllIDThuThu()
        {
            return _phieuMuonDAL.GetAllIDthuthu();
        }

        public bool InsertPhieuMuon(PhieuMuonDTO pm)
        {
            return _phieuMuonDAL.InsertPhieuMuon(pm);
        }

        public bool UpdatePhieuMuon(PhieuMuonDTO pm)
        {
            return _phieuMuonDAL.UpdatePhieuMuon(pm);
        }

        public bool DeletePhieuMuon(int id)
        {
            return _phieuMuonDAL.DeletePhieuMuon(id);
        }

        public DataTable searchPhieuMuon(string mapm)
        {
            return _phieuMuonDAL.searchPhieuMuon(mapm);
        }
    }
}
