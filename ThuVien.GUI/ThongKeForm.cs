using System.Data;
using System.Windows.Forms;
using ThuVien.BUS;
using ThuVien.DTO;

namespace ThuVien.GUI
{
    public partial class ThongKeForm : Form
    {
        private ThongKeBUS thongKeBUS;
        public ThongKeForm()
        {
            thongKeBUS = new ThongKeBUS();

            InitializeComponent();
            this.LoadThongKe();
        }

        private void LoadThongKe()
        {
            this.LoadThongKeSach();
            this.LoadThongKeDoanhThu();
            this.LoadThongKeNam();

        }

        private void LoadThongKeNam()
        {
            growthChart.Series["doanh thu (theo năm)"].Points.AddXY(2019, 47800000);
            growthChart.Series["doanh thu (theo năm)"].Points.AddXY(2020, 50000000);
            growthChart.Series["doanh thu (theo năm)"].Points.AddXY(2021, 53800000);
            growthChart.Series["doanh thu (theo năm)"].Points.AddXY(2022, 58800000);
            growthChart.Series["doanh thu (theo năm)"].Points.AddXY(2023, 57800000);
            growthChart.Series["doanh thu (theo năm)"].Points.AddXY(2024, 62800000);
        }

        private void LoadThongKeDoanhThu()
        {
            DataTable doanhThuDT = thongKeBUS.getThongKeDoanhThu();
            moneyChart.DataSource = doanhThuDT;

            moneyChart.Series[0].XValueMember = doanhThuDT.Columns[0].ColumnName;
            moneyChart.Series[0].YValueMembers = doanhThuDT.Columns[1].ColumnName;

        }

        private void LoadThongKeSach()
        {
            DataTable sachDT = thongKeBUS.getThongKeSach();
            bookChart.DataSource = sachDT;

            bookChart.Series[0].XValueMember = sachDT.Columns[0].ColumnName;
            bookChart.Series[0].YValueMembers = sachDT.Columns[1].ColumnName;
        }
    }

}
