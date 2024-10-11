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
    public partial class SachForm : Form
    {
        SachBus bussach = new SachBus();
        public SachForm()
        {
            InitializeComponent();
        }
        private void LoadGridView_NhanVien()
        {
            dgv_qltt.DataSource = bussach.GetAllSach();
            dgv_qltt.Columns[0].HeaderText = "Mã Sách";
            dgv_qltt.Columns[1].HeaderText = "Tên Sách";
            dgv_qltt.Columns[2].HeaderText = "Tác Giả";
            dgv_qltt.Columns[3].HeaderText = "Tái Bản";
            dgv_qltt.Columns[4].HeaderText = "Số lượng";
            dgv_qltt.Columns[5].HeaderText = "Tồn Kho";
            dgv_qltt.Columns[6].HeaderText = "Có Sẵn";
        }
        

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

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
            
            if (string.IsNullOrWhiteSpace(txt_tensach.Text) && string.IsNullOrWhiteSpace(txt_tacgia.Text) && string.IsNullOrWhiteSpace(txt_taiban.Text) && string.IsNullOrWhiteSpace(txt_soluong.Text) && string.IsNullOrWhiteSpace(txt_tonkho.Text) && string.IsNullOrWhiteSpace(txt_cosan.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_tensach.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensach.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tacgia.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Tác Giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tacgia.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_taiban.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Số Lần Tái Bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_taiban.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_soluong.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tonkho.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tonkho.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_cosan.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cosan.Focus();
                return;
            }

            int taiBan, soLuong, tonKho,cosan, idLoai;
            bool isAvailable = true; // Set this based on your application's logic

            // Try parsing the input values to integers
            bool isTaiBanValid = int.TryParse(txt_taiban.Text.Trim(), out taiBan);
            bool isSoLuongValid = int.TryParse(txt_soluong.Text.Trim(), out soLuong);
            bool isTonKhoValid = int.TryParse(txt_tonkho.Text.Trim(), out tonKho);
            bool isCoSanValid = int.TryParse(txt_cosan.Text.Trim(), out cosan); // Assuming this is meant to be an integer
            bool isIdLoaiValid = int.TryParse(cbo_loaisach.Text.Trim(), out idLoai);
            // Check if all values are valid
            if (isTaiBanValid && isSoLuongValid && isTonKhoValid && isIdLoaiValid)
            {
                // Create an instance of SachDTO with the correct types
                SachDTO sach = new SachDTO(
                    txt_tensach.Text.Trim(), // string
                    txt_tacgia.Text.Trim(),  // string
                    taiBan,                  // int
                    soLuong,                 // int
                    tonKho,                  // int
                    cosan,             
                    idLoai                   // int
                );

                // Insert the new SachDTO into the database or collection
                if (bussach.InsertSach(sach))
                {
                    MessageBox.Show("Thêm Thành Công");
                    ResetValue();
                    LoadGridView_NhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng, tồn kho, và loại ID hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SachForm_Load(object sender, EventArgs e)
        {
            LoadGridView_NhanVien();
            ResetValue();
        }

        private void txt_tensach_Click(object sender, EventArgs e)
        {
            if (txt_tensach.Text == "Tên Sách")
            {
                txt_tensach.Text = "";
            }
        }

        private void txt_tacgia_Click(object sender, EventArgs e)
        {
            if (txt_tacgia.Text == "Tên Tác Giả")
            {
                txt_tacgia.Text = "";
            }
        }

        private void txt_taiban_Click(object sender, EventArgs e)
        {
            if (txt_taiban.Text == "Tái Bản Lần Thứ Mấy")
            {
                txt_taiban.Text = "";
            }
        }

        private void txt_soluong_Click(object sender, EventArgs e)
        {
            if (txt_soluong.Text == "Nhập Số Lượng Sách")
            {
                txt_soluong.Text = "";
            }
        }

        private void txt_tonkho_Click(object sender, EventArgs e)
        {
            if (txt_tonkho.Text == "Có Bao Nhiêu Sách Trong Kho")
            {
                txt_tonkho.Text = "";
            }
        }

        private void txt_cosan_Click(object sender, EventArgs e)
        {
            if (txt_cosan.Text == "Sách Có Sẳn Hay Không")
            {
                txt_cosan.Text = "";
            }
        }

        private void txt_Manv_Click(object sender, EventArgs e)
        {
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_tensach.Text) && string.IsNullOrWhiteSpace(txt_tacgia.Text) && string.IsNullOrWhiteSpace(txt_taiban.Text) && string.IsNullOrWhiteSpace(txt_soluong.Text) && string.IsNullOrWhiteSpace(txt_tonkho.Text) && string.IsNullOrWhiteSpace(txt_cosan.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_tensach.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensach.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tacgia.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Tên Tác Giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tacgia.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_taiban.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Số Lần Tái Bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_taiban.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_soluong.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tonkho.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tonkho.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_cosan.Text))
            {
                MessageBox.Show("Bạn Phải Nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cosan.Focus();
                return;
            }

            int taiBan, soLuong, tonKho, cosan, idLoai;
            bool isAvailable = true; // Set this based on your application's logic

            // Try parsing the input values to integers
            bool isTaiBanValid = int.TryParse(txt_taiban.Text.Trim(), out taiBan);
            bool isSoLuongValid = int.TryParse(txt_soluong.Text.Trim(), out soLuong);
            bool isTonKhoValid = int.TryParse(txt_tonkho.Text.Trim(), out tonKho);
            bool isCoSanValid = int.TryParse(txt_cosan.Text.Trim(), out cosan); // Assuming this is meant to be an integer
            bool isIdLoaiValid = int.TryParse(cbo_loaisach.Text.Trim(), out idLoai);
            // Check if all values are valid
            if (isTaiBanValid && isSoLuongValid && isTonKhoValid && isIdLoaiValid)
            {
                // Create an instance of SachDTO with the correct types
                SachDTO sach = new SachDTO(
                    txt_tensach.Text.Trim(), // string
                    txt_tacgia.Text.Trim(),  // string
                    taiBan,                  // int
                    soLuong,                 // int
                    tonKho,                  // int
                    cosan,
                    idLoai                   // int
                );

                // Insert the new SachDTO into the database or collection
                if (bussach.UpdateSach(sach))
                {
                    MessageBox.Show("Thêm Thành Công");
                    ResetValue();
                    LoadGridView_NhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng, tồn kho, và loại ID hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_theloai_Click(object sender, EventArgs e)
        {

        }

        private void cbo_loaisach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ResetValue()
        {
            txt_tensach.Text = "Tên Sách";
            txt_taiban.Text = "Tái Bản Lần Thứ Mấy";
            txt_tacgia.Text = "Tên Tác Giả";
            txt_soluong.Text = "Nhập Số Lượng Sách";
            txt_tonkho.Text = "Có Bao Nhiêu Sách Trong Kho";
            txt_cosan.Text = "Sách Có Sẳn Hay Không";
            cbo_loaisach.Text = "Nhập ID Thể Loại";
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SachDTO sach = new SachDTO();
            
            if (txt_tensach.Text == "Tên Sách" || txt_taiban.Text == "Tái Bản Lần Thứ Mấy" || txt_tacgia.Text == "Tên Tác Giả" || txt_soluong.Text == "Nhập Số Lượng Sách" || txt_tonkho.Text == "Có Bao Nhiêu Sách Trong Kho" || txt_cosan.Text == "Sách Có Sẳn Hay Không" || cbo_loaisach.Text == "Nhập ID Thể Loại")
            {
                MessageBox.Show("Bạn Phải Chọn Sách Để Xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (bussach.DeleteSach(int.Parse(txt_masach.Text)))
            {
                MessageBox.Show("Xóa Thành Công");
                ResetValue();
                LoadGridView_NhanVien();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
