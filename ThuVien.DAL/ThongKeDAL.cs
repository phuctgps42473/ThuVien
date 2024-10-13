using System;
using System.Data;
using System.Data.SqlClient;

namespace ThuVien.DAL
{

    public class ThongKeDAL
    {
        public DataTable SelectRevenue()
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                string q = "select MONTH(ngaytra) as thang,  SUM(phithue) as doanhthu from phieumuon group by MONTH(ngaytra)";

                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }

        }

        public DataTable SelectBookBorrowedEachMonth()
        {
            using (SqlConnection conn = new SqlConnection(DALHelper.ConnectionString))
            {
                string q = "select MONTH(ngaytra) as thang,  SUM(soluong) as soluong from phieumuon group by MONTH(ngaytra)";

                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }

        }

    }
}
