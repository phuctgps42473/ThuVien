using System.Data;
using ThuVien.DAL;

namespace ThuVien.BUS
{
    public class ThongKeBUS
    {
        private ThongKeDAL thongKeDAL;
        public ThongKeBUS()
        {
            thongKeDAL = new ThongKeDAL();
        }

        public DataTable getThongKeSach()
        {
            return thongKeDAL.SelectBookBorrowedEachMonth();
        }

        public DataTable getThongKeDoanhThu()
        {
            return thongKeDAL.SelectRevenue();
        }

    }
}
