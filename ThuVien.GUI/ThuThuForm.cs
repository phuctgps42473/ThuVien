using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.BUS;
using ThuVien.DTO;

namespace ThuVien.GUI
{
    public partial class ThuThuForm : Form
    {
        NhanVienBus bustt = new NhanVienBus();
        public ThuThuForm()
        {
            InitializeComponent();
        }

        private void lbl_vaitro_Click(object sender, EventArgs e)
        {

        }

        private void lbl_qltt_Click(object sender, EventArgs e)
        {

        }
        private void LoadGridView_NhanVien()
        {
            dgv_qltt.DataSource = bustt.GetAllNhanVien();
            dgv_qltt.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_qltt.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_qltt.Columns[2].HeaderText = "Email Nhân Viên";
            dgv_qltt.Columns[3].HeaderText = "Password Nhân Viên";
            dgv_qltt.Columns[4].HeaderText = "Số Điện Thoại Nhân Viên";
            dgv_qltt.Columns[5].HeaderText = "Là Quản Lý";
        }
        private void ResetValues()
        {
            txt_Manv.Text = "Mã Nhân Viên";
            txt_hoten.Text = "Tên Nhân Viên";
            txt_email.Text = "Email Nhân Viên";
            txt_sdt.Text = "Số Điện Thoại Nhân Viên";
            txt_matkhau.Text = "Password Nhân Viên";
            txt_timkiem.Text = "Tìm Tên Nhân Viên";
            rdo_quanly.Checked = false;
            rdo_thuthu.Checked = true;
        }

        private void dgv_qltt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_qltt.Rows.Count > 1)
            {
                txt_Manv.Text = dgv_qltt.CurrentRow.Cells["id"].Value.ToString();
                txt_hoten.Text = dgv_qltt.CurrentRow.Cells["ten"].Value.ToString();
                txt_email.Text = dgv_qltt.CurrentRow.Cells["email"].Value.ToString();
                txt_sdt.Text = dgv_qltt.CurrentRow.Cells["dienthoai"].Value.ToString();
                txt_matkhau.Text = dgv_qltt.CurrentRow.Cells["password"].Value.ToString();
                if (dgv_qltt.CurrentRow.Cells["la_quanly"].Value != null && (bool)dgv_qltt.CurrentRow.Cells["la_quanly"].Value == false)
                {
                    rdo_quanly.Checked = false;
                    rdo_thuthu.Checked = true;
                }
                else
                {
                    rdo_quanly.Checked = true;
                    rdo_thuthu.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Bảng Không Tồn Tại Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void btn_them_Click(object sender, EventArgs e)
        //{
        //    
        //}

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_NhanVien();
        }
        private void txt_Manv_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void ThuThuForm_Load_1(object sender, EventArgs e)
        {
            LoadGridView_NhanVien();
            ResetValues();
        }

        private void txt_hoten_Click(object sender, EventArgs e)
        {
            if (txt_hoten.Text == "Tên Nhân Viên")
            {
                txt_hoten.Text = "";
            }
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email Nhân Viên")
            {
                txt_email.Text = "";
            }
        }

        private void txt_sdt_Click(object sender, EventArgs e)
        {
            if (txt_sdt.Text == "Số Điện Thoại Nhân Viên")
            {
                txt_sdt.Text = "";
            }
        }

        private void txt_matkhau_Click(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "Password Nhân Viên")
            {
                txt_matkhau.Text = "";
            }
        }

        public bool isValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool quanly = rdo_quanly.Checked ? true : false;
            if (string.IsNullOrWhiteSpace(txt_hoten.Text) && string.IsNullOrWhiteSpace(txt_email.Text) && string.IsNullOrWhiteSpace(txt_matkhau.Text) && string.IsNullOrWhiteSpace(txt_sdt.Text) && !rdo_quanly.Checked && !rdo_thuthu.Checked)
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_hoten.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_hoten.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;
            }
            if (!isValid(txt_email.Text))
            {
                MessageBox.Show("Email Không Hợp Lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_matkhau.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_matkhau.Focus();
                return;
            }

            if (!rdo_quanly.Checked && !rdo_thuthu.Checked)
            {
                MessageBox.Show("Bạn Phải Chọn Vai Trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdo_quanly.Focus();
                return;
            }

            if (!int.TryParse(txt_sdt.Text, out int sdt))
            {
                MessageBox.Show("Số Điện Thoại Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }

            NhanVienDTO nd = new NhanVienDTO(txt_hoten.Text.Trim(), txt_email.Text.Trim(), txt_matkhau.Text.Trim(), txt_sdt.Text.Trim(), quanly);
            if (bustt.InsertNhanVien(nd))
            {
                MessageBox.Show("Thêm Thành Công");
                ResetValues();
                LoadGridView_NhanVien();
            }
            else
            {
                MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = Session.Instance.NhanVien;
            bool quanly = rdo_quanly.Checked ? true : false;
            if (string.IsNullOrWhiteSpace(txt_hoten.Text) && string.IsNullOrWhiteSpace(txt_email.Text) && string.IsNullOrWhiteSpace(txt_matkhau.Text) && string.IsNullOrWhiteSpace(txt_sdt.Text) && !rdo_quanly.Checked && !rdo_thuthu.Checked)
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_hoten.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_hoten.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;
            }
            if (!isValid(txt_email.Text))
            {
                MessageBox.Show("Email Không Hợp Lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_matkhau.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_matkhau.Focus();
                return;
            }

            if (!rdo_quanly.Checked && !rdo_thuthu.Checked)
            {
                MessageBox.Show("Bạn Phải Chọn Vai Trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdo_quanly.Focus();
                return;
            }

            if (!int.TryParse(txt_sdt.Text, out int sdt))
            {
                MessageBox.Show("Số Điện Thoại Phải Là Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }
            
            NhanVienDTO nd = new NhanVienDTO(int.Parse(txt_Manv.Text), txt_hoten.Text.Trim(), txt_email.Text.Trim(), txt_matkhau.Text.Trim(), txt_sdt.Text.Trim(), quanly);
            if (bustt.UpdateNhanVien(nd))
            {
                if (nv.Ten == txt_hoten.Text && nv.IsManager && rdo_thuthu.Checked)
                {
                    Session.Instance.ClearNhanVien();
                    return;
                }
                MessageBox.Show("Sửa Thành Công");
                ResetValues();
                LoadGridView_NhanVien();
            }
            else
            {
                MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = Session.Instance.NhanVien;
            bool quanly = rdo_quanly.Checked ? true : false;
            if (txt_email.Text == "Email Nhân Viên" || txt_email.Text == null || txt_hoten.Text == "Tên Nhân Viên" || txt_hoten.Text == null || txt_sdt.Text == "Số Điện Thoại Nhân Viên" || txt_sdt.Text == null || txt_matkhau.Text == "Mật Khẩu Nhân Viên" || txt_matkhau.Text == null)
            {
                MessageBox.Show("Bạn Phải Chọn Nhân Viên Cần Xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nv.Ten == txt_hoten.Text && nv.Email == txt_email.Text)
            {
                // Close or hide the current Home form
                MessageBox.Show("Bạn Không Thể Xóa Bản Thân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (bustt.DeleteNhanVien(int.Parse(txt_Manv.Text)))
            {
                MessageBox.Show("Xóa Thành Công");
                ResetValues();
                LoadGridView_NhanVien();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tennd = txt_timkiem.Text;
            DataTable ds = bustt.searchNhanVien(tennd);
            if (ds.Rows.Count > 0)
            {
                dgv_qltt.DataSource = ds;
                dgv_qltt.Columns[0].HeaderText = "Mã Nhân Viên";
                dgv_qltt.Columns[1].HeaderText = "Tên Nhân Viên";
                dgv_qltt.Columns[2].HeaderText = "Email Nhân Viên";
                dgv_qltt.Columns[3].HeaderText = "Password Nhân Viên";
                dgv_qltt.Columns[4].HeaderText = "Số Điện Thoại Nhân Viên";
                dgv_qltt.Columns[5].HeaderText = "Là Quản Lý";
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ResetValues();
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
        }
    }
}
