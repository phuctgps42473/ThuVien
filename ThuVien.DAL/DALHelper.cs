
using System.Configuration;

namespace ThuVien.DAL
{
    internal class DALHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["ThuVienDatabaseConnection"].ConnectionString;
        public static string ConnectionString { get { return connectionString; } }
    }

}
