
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

        public void CreateDocGia(DocGiaDTO docgia)
        {
            DocGiaDAL.InsertDocGia(docgia);
        }
        public void UpdateDocGia(DocGiaDTO docgia)
        {
            DocGiaDAL.UpdateDocGia(docgia);
        }

        public void DeleteDocGia(int id)
        {
            DocGiaDAL.DeleteDocGia(id);
        }
    }
}
