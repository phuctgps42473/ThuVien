using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.BUS;
using ThuVien.DTO;

namespace ThuVien.GUI
{
    public partial class PhieuMuonForm : Form
    {
        MuonTra_BUS muonTra_BUS = new MuonTra_BUS();
        public PhieuMuonForm()
        {
            InitializeComponent();
        }

        private void lbl_vaitro_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string mapm = txt_timkiem.Text;
            DataTable ds = muonTra_BUS.searchPhieuMuon(mapm);
            if (ds.Rows.Count > 0)
            {
                dgv_qlpm.DataSource = ds;
                dgv_qlpm.Columns[0].HeaderText = "Mã Phiếu Mượn";
                dgv_qlpm.Columns[1].HeaderText = "Số Lượng";
                dgv_qlpm.Columns[2].HeaderText = "Ngày Mượn";
                dgv_qlpm.Columns[3].HeaderText = "Ngày Trả";
                dgv_qlpm.Columns[4].HeaderText = "Phí Thuê";
                dgv_qlpm.Columns[5].HeaderText = "Trạng Thái";
                dgv_qlpm.Columns[6].HeaderText = "Mã Độc Giả";
                dgv_qlpm.Columns[7].HeaderText = "Mã Sách";
                dgv_qlpm.Columns[8].HeaderText = "Mã Thủ Thư";
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Phiếu Mượn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ResetValues();
        }

        private void ResetValues()
        {
            txt_Mapm.Text = "Mã Phiếu Mượn";
            txt_phithue.Text = "Phí Thuê";
            txt_soluong.Text = "Số Lượng";
            txt_timkiem.Text = "Tìm Kiếm Mã Phiếu";
            txt_trangthai.Text = "Trạng Thái Phiếu";
            cbo_madg.Text = "Mã Độc Giả";
            cbo_mas.Text = "Mã Sách";
            cbo_matt.Text = "Mã Thủ Thư";
            dtp_ngaymuon.Value = DateTime.Now;
            dtp_ngaytra.Value = DateTime.Now;
        }

        private void Load_GridViewPhieuMUon()
        {
            dgv_qlpm.DataSource = muonTra_BUS.GetAllPhieuMuon();
            dgv_qlpm.Columns[0].HeaderText = "Mã Phiếu Mượn";
            dgv_qlpm.Columns[1].HeaderText = "Số Lượng";
            dgv_qlpm.Columns[2].HeaderText = "Ngày Mượn";
            dgv_qlpm.Columns[3].HeaderText = "Ngày Trả";
            dgv_qlpm.Columns[4].HeaderText = "Phí Thuê";
            dgv_qlpm.Columns[5].HeaderText = "Trạng Thái Phiếu";
            dgv_qlpm.Columns[6].HeaderText = "Mã Độc Giả";
            dgv_qlpm.Columns[7].HeaderText = "Mã Sách";
            dgv_qlpm.Columns[8].HeaderText = "Mã Thủ Thư";
        }

        public void Load_Combobox()
        {
            DataTable dsdg = muonTra_BUS.GetAllIDDocGia();
            cbo_madg.DataSource = dsdg;
            cbo_madg.DisplayMember = "id";
            cbo_madg.ValueMember = "id";
            DataTable dss = muonTra_BUS.GetAllIDSach();
            cbo_mas.DataSource = dss;
            cbo_mas.DisplayMember = "id";
            cbo_mas.ValueMember = "id";
            DataTable dstt = muonTra_BUS.GetAllIDThuThu();
            cbo_matt.DataSource = dstt;
            cbo_matt.DisplayMember = "id";
            cbo_matt.ValueMember = "id";
        }

        private void PhieuMuonForm_Load(object sender, EventArgs e)
        {
            Load_GridViewPhieuMUon();
            Load_Combobox();
            ResetValues();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_soluong.Text) && string.IsNullOrWhiteSpace(txt_phithue.Text) && string.IsNullOrWhiteSpace(txt_trangthai.Text) && string.IsNullOrWhiteSpace(cbo_madg.Text) && string.IsNullOrWhiteSpace(cbo_mas.Text) && string.IsNullOrWhiteSpace(cbo_matt.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_soluong.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Số Lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }

            if (!int.TryParse(txt_soluong.Text, out int sdt))
            {
                MessageBox.Show("Số Lượng Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (sdt <= 0)
            {
                MessageBox.Show("Số Lượng Phải Lớn Hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (dtp_ngaytra.Value < dtp_ngaymuon.Value)
            {
                MessageBox.Show("Bạn Phải Nhập Ngày Trả Lớn Hơn Ngày Mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_ngaytra.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_phithue.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Phí Thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_phithue.Focus();
                return;
            }

            if (!int.TryParse(txt_phithue.Text, out int phithue))
            {
                MessageBox.Show("Phí Thuê Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (phithue <= 0)
            {
                MessageBox.Show("Phí Thuê Phải Lớn Hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_trangthai.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Phí Thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_phithue.Focus();
                return;
            }
            PhieuMuonDTO pm = new PhieuMuonDTO(int.Parse(txt_soluong.Text), dtp_ngaymuon.Value, dtp_ngaytra.Value, int.Parse(txt_phithue.Text), txt_trangthai.Text, int.Parse(cbo_madg.Text), int.Parse(cbo_mas.Text), int.Parse(cbo_matt.Text));
            if (muonTra_BUS.InsertPhieuMuon(pm))
            {
                MessageBox.Show("Thêm Thành Công");
                ResetValues();
                Load_Combobox();
                Load_GridViewPhieuMUon();
            }
            else
            {
                MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void txt_soluong_Click(object sender, EventArgs e)
        {
            if (txt_soluong.Text == "Số Lượng")
            {
                txt_soluong.Text = "";
            }
        }

        private void txt_phithue_Click(object sender, EventArgs e)
        {
            if (txt_phithue.Text == "Phí Thuê")
            {
                txt_phithue.Text = "";
            }
        }

        private void txt_trangthai_Click(object sender, EventArgs e)
        {
            if (txt_trangthai.Text == "Trạng Thái Phiếu")
            {
                txt_trangthai.Text = "";
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_soluong.Text) && string.IsNullOrWhiteSpace(txt_phithue.Text) && string.IsNullOrWhiteSpace(txt_trangthai.Text) && string.IsNullOrWhiteSpace(cbo_madg.Text) && string.IsNullOrWhiteSpace(cbo_mas.Text) && string.IsNullOrWhiteSpace(cbo_matt.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_soluong.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Số Lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }

            if (!int.TryParse(txt_soluong.Text, out int sdt))
            {
                MessageBox.Show("Số Lượng Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (sdt <= 0)
            {
                MessageBox.Show("Số Lượng Phải Lớn Hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (dtp_ngaytra.Value < dtp_ngaymuon.Value)
            {
                MessageBox.Show("Bạn Phải Nhập Ngày Trả Lớn Hơn Ngày Mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_ngaytra.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_phithue.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Phí Thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_phithue.Focus();
                return;
            }

            if (!int.TryParse(txt_phithue.Text, out int phithue))
            {
                MessageBox.Show("Phí Thuê Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (phithue <= 0)
            {
                MessageBox.Show("Phí Thuê Phải Lớn Hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_trangthai.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Phí Thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_phithue.Focus();
                return;
            }
            PhieuMuonDTO pm = new PhieuMuonDTO(int.Parse(txt_Mapm.Text),int.Parse(txt_soluong.Text), dtp_ngaymuon.Value, dtp_ngaytra.Value, int.Parse(txt_phithue.Text), txt_trangthai.Text, int.Parse(cbo_madg.Text), int.Parse(cbo_mas.Text), int.Parse(cbo_matt.Text));
            if (muonTra_BUS.UpdatePhieuMuon(pm))
            {
                MessageBox.Show("Cập Nhật Thành Công");
                ResetValues();
                Load_Combobox();
                Load_GridViewPhieuMUon();
            }
            else
            {
                MessageBox.Show("Cập Nhật Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_soluong.Text) && string.IsNullOrWhiteSpace(txt_phithue.Text) && string.IsNullOrWhiteSpace(txt_trangthai.Text) && string.IsNullOrWhiteSpace(cbo_madg.Text) && string.IsNullOrWhiteSpace(cbo_mas.Text) && string.IsNullOrWhiteSpace(cbo_matt.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_soluong.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Số Lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }

            if (!int.TryParse(txt_soluong.Text, out int sdt))
            {
                MessageBox.Show("Số Lượng Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (sdt <= 0)
            {
                MessageBox.Show("Số Lượng Phải Lớn Hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (dtp_ngaytra.Value < dtp_ngaymuon.Value)
            {
                MessageBox.Show("Bạn Phải Nhập Ngày Trả Lớn Hơn Ngày Mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_ngaytra.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_phithue.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Phí Thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_phithue.Focus();
                return;
            }

            if (!int.TryParse(txt_phithue.Text, out int phithue))
            {
                MessageBox.Show("Phí Thuê Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            if (phithue <= 0)
            {
                MessageBox.Show("Phí Thuê Phải Lớn Hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_trangthai.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Phí Thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_phithue.Focus();
                return;
            }
            if (muonTra_BUS.DeletePhieuMuon(int.Parse(txt_Mapm.Text)))
            {
                MessageBox.Show("Xóa Thành Công");
                ResetValues();
                Load_Combobox();
                Load_GridViewPhieuMUon();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
        }

        private void txt_trangthai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
