
using System.Data;
using System.Runtime.Versioning;
using ThuVien.DAL;
using ThuVien.DTO;

namespace ThuVien.BUS
{
    public class DocGiaBUS
    {
        private DocGiaDAL DocGiaDAL;

        public DocGiaBUS()
        {
            DocGiaDAL = new DocGiaDAL();
        }

        public DataTable GetAllDocGia()
        {
            return DocGiaDAL.GetAllDocGia();
        }

        public DataTable FindDocGiaWithText(string text)
        {
            string Keyword = text.Trim();
            return DocGiaDAL.GetDocGiaWithText(Keyword);
        }

        public bool CreateDocGia(DocGiaDTO docGiaDTO)
        {
           return DocGiaDAL.InsertDocGia(docGiaDTO);
        }
        public bool UpdateDocGia(DocGiaDTO docgia)
        {
            return DocGiaDAL.UpdateDocGia(docgia);
        }

        public bool DeleteDocGia(int id)
        {
            return DocGiaDAL.DeleteDocGia(id);
        }
    }
}
