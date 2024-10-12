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
    public partial class LoaiSachForm : Form
    {
        LoaiSach_BUS bussach = new BUS.LoaiSach_BUS();
        public LoaiSachForm()
        {
            InitializeComponent();
        }
        private void LoadGridView_LoaiSach()
        {
            dgv_qltt.DataSource = bussach.GetAllLoaiSach();
            dgv_qltt.Columns[0].HeaderText = "ID Loại Sách";
            dgv_qltt.Columns[1].HeaderText = "Tên Loại Sách";
            dgv_qltt.Columns[2].HeaderText = "Mô Tả";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_tenloaisach.Text) && string.IsNullOrWhiteSpace(txt_mota.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_tenloaisach.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Tên Loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenloaisach.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_mota.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mô Tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mota.Focus();
                return;
            }

            LoaiSachDTO nd = new LoaiSachDTO(txt_tenloaisach.Text.Trim(), txt_mota.Text.Trim());
            if (bussach.AddLoaiSach(nd))
            {
                MessageBox.Show("Thêm Thành Công");
                ResetValue();
                LoadGridView_LoaiSach();
            }
            else
            {
                MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ResetValue()
        {
            txt_idLoaiSach.Text = "ID Loại Sách";
            txt_tenloaisach.Text = "Tên Loại Sách";
            txt_mota.Text = "Mô Tả Thể Loại";         
        }
        private void txt_idLoaiSach_Click(object sender, EventArgs e)
        {
            if (txt_idLoaiSach.Text == "ID Loại Sách")
            {
                txt_idLoaiSach.Text = "";
            }
        }

        private void txt_tenloaisach_Click(object sender, EventArgs e)
        {
            if (txt_tenloaisach.Text == "Tên Loại Sách")
            {
                txt_tenloaisach.Text = "";
            }
        }

        private void txt_mota_Click(object sender, EventArgs e)
        {
            if (txt_mota.Text == "Mô Tả Thể Loại")
            {
                txt_mota.Text = "";
            }
        }

        private void LoaiSachForm_Load(object sender, EventArgs e)
        {
            LoadGridView_LoaiSach();
            ResetValue();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tenloaisach.Text) && string.IsNullOrWhiteSpace(txt_mota.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_tenloaisach.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Loại Sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenloaisach.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_mota.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mô Tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mota.Focus();
                return;
            }
            int id;
            bool isTaiBanValid = int.TryParse(txt_idLoaiSach.Text.Trim(), out id);
            LoaiSachDTO nd = new LoaiSachDTO(id, txt_tenloaisach.Text.Trim(), txt_mota.Text.Trim());
            if (bussach.UpdateLoaiSach(nd))
            {              
                MessageBox.Show("Sửa Thành Công");
                ResetValue();
                LoadGridView_LoaiSach();
            }
            else
            {
                MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = Session.Instance.NhanVien;

            if (txt_tenloaisach.Text == "Email Nhân Viên" || txt_mota.Text == null)
            {
                MessageBox.Show("Bạn Phải Chọn Nhân Viên Cần Xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          
            if (bussach.DeleteLoaiSach(int.Parse(txt_idLoaiSach.Text)))
            {
                MessageBox.Show("Xóa Thành Công");
                ResetValue();
                LoadGridView_LoaiSach();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_qltt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_qltt.Rows.Count > 1)
            {
                txt_idLoaiSach.Text = dgv_qltt.CurrentRow.Cells["id"].Value.ToString();
                txt_tenloaisach.Text = dgv_qltt.CurrentRow.Cells["ten"].Value.ToString();
                txt_mota.Text = dgv_qltt.CurrentRow.Cells["mota"].Value.ToString();                             
            }
            else
            {
                MessageBox.Show("Bảng Không Tồn Tại Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_LoaiSach();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

                string tensach = txt_timkiem.Text;
                DataTable ds = bussach.searchLoaiSach(tensach);
                if (ds.Rows.Count > 0)
                {
                    dgv_qltt.DataSource = ds;
                    txt_idLoaiSach.Text = "ID Loại Sách";
                    txt_tenloaisach.Text = "Tên Loại Sách";
                    txt_mota.Text = "Mô Tả Thể Loại";
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy Loại Sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetValue();
            
        }
    }
}
