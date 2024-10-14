using System;
using System.Data;
using System.Windows.Forms;
using ThuVien.BUS;
using ThuVien.DTO;

namespace ThuVien.GUI
{
    public partial class DocGiaForm : Form
    {
        private DocGiaBUS docGiaBUS;
        public DocGiaForm()
        {
            docGiaBUS = new DocGiaBUS();
            InitializeComponent();

            AddGridView_DocGia_CellClick();
            LoadGridView_DocGia();
        }

        private void AddGridView_DocGia_CellClick()
        {
            dgv_docgia.CellClick += DataGridDocGia_CellClick;
        }


        private void LoadGridView_DocGia()
        {
            dgv_docgia.DataSource = docGiaBUS.GetAllDocGia();
            dgv_docgia.Columns[0].HeaderText = "Mã Độc Giả";
            dgv_docgia.Columns[1].HeaderText = "Tên Độc Giả";
            dgv_docgia.Columns[2].HeaderText = "Điện Thoại";
            dgv_docgia.Columns[3].HeaderText = "Email Độc Giả";
            dgv_docgia.Columns[4].HeaderText = "Địa Chỉ";
            dgv_docgia.Columns[5].HeaderText = "Tiền Cọc";
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dt = docGiaBUS.FindDocGiaWithText(txt_timkiem.Text);
            LoadGridView_DocGia();
        }

        private void DataGridDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_docgia.Rows[e.RowIndex];
                txt_MaDocGia.Text = row.Cells[0].Value.ToString();
                txt_hoten.Text = row.Cells[1].Value.ToString();
                txt_sdt.Text = row.Cells[2].Value.ToString();
                txt_email.Text = row.Cells[3].Value.ToString();
                txt_diachi.Text = row.Cells[4].Value.ToString();
                txt_tiencoc.Text = row.Cells[5].Value.ToString();
            }
        }

        private DocGiaDTO GetDocGiaFromForm()
        {
            string hoten = txt_hoten.Text;
            string email = txt_email.Text;
            string sdt = txt_sdt.Text;
            string diachi = txt_diachi.Text;

            if (
                string.IsNullOrEmpty(hoten) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(sdt) ||
                string.IsNullOrEmpty(diachi) ||
                string.IsNullOrEmpty(txt_tiencoc.Text))
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                return null;
            }

            if (!double.TryParse(txt_tiencoc.Text, out double tiencoc))
            {
                MessageBox.Show("TIỀN CỌC PHẢI LÀ SỐ!");
                txt_tiencoc.Text = "";
                return null;
            };

            DocGiaDTO docGiaDTO = new DocGiaDTO();
            docGiaDTO.Ten = hoten;
            docGiaDTO.Email = email;
            docGiaDTO.DienThoai = sdt;
            docGiaDTO.DiaChi = diachi;
            docGiaDTO.TienCoc = tiencoc;
            return docGiaDTO;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DocGiaDTO docgia = GetDocGiaFromForm();
            if (docgia != null)
            {
                // Kiểm tra dữ liệu
                if (!ValidateForm())
                {
                    return;
                }

                // Nếu dữ liệu hợp lệ, tiến hành thêm
                if (docGiaBUS.CreateDocGia(docgia))
                {
                    MessageBox.Show("Thêm Thành Công");
                    ResetValue();
                    LoadGridView_DocGia();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại");
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DocGiaDTO docgia = GetDocGiaFromForm();
            if (docgia != null)
            {
                // Kiểm tra dữ liệu
                if (!ValidateForm() || !ValidateId())
                {
                    return;
                }

                // Đặt Id trước khi gọi UpdateDocGia
                docgia.Id = int.Parse(txt_MaDocGia.Text);

                // Sau đó mới gọi Update
                if (docGiaBUS.UpdateDocGia(docgia))
                {
                    MessageBox.Show("Sửa Thành Công");
                    LoadGridView_DocGia();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra ID
            if (!ValidateId())
            {
                return;
            }

            int id = int.Parse(txt_MaDocGia.Text);
            if (docGiaBUS.DeleteDocGia(id))
            {
                MessageBox.Show("Xóa Thành Công");
                ResetValue();
                LoadGridView_DocGia();
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại");
            }

        }
        private void ResetValue()
        {
            txt_MaDocGia.Text = "Mã Độc Giả";
            txt_hoten.Text = "Họ Tên Độc Giả";
            txt_email.Text = "Email Độc Giả";
            txt_diachi.Text = "Địa Chỉ";
            txt_sdt.Text = "Số Điện Thoại Độc Giả";
            txt_tiencoc.Text = "Tiền Cọc Sách";
            txt_timkiem.Text = "Nhập Mã Sách";
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void DocGiaForm_Load(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void txt_hoten_Click(object sender, EventArgs e)
        {
            if (txt_hoten.Text == "Họ Tên Độc Giả")
            {
                txt_hoten.Text = "";
            }
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email Độc Giả")
            {
                txt_email.Text = "";
            }
        }

        private void txt_sdt_Click(object sender, EventArgs e)
        {
            if (txt_sdt.Text == "Số Điện Thoại Độc Giả")
            {
                txt_sdt.Text = "";
            }
        }

        private void txt_diachi_Click(object sender, EventArgs e)
        {
            if (txt_diachi.Text == "Địa Chỉ")
            {
                txt_diachi.Text = "";
            }
        }

        private void txt_tiencoc_Click(object sender, EventArgs e)
        {
            if (txt_tiencoc.Text == "Tiền Cọc Sách")
            {
                txt_tiencoc.Text = "";
            }
        }

        private void txt_MaDocGia_Click(object sender, EventArgs e)
        {
            if (txt_MaDocGia.Text == "Mã Độc Giả")
            {
                txt_MaDocGia.Text = "";
            }
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "Nhập Mã Sách")
            {
                txt_timkiem.Text = "";
            }
        }
        // Kiểm tra form nhập liệu
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txt_hoten.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(txt_diachi.Text) ||
                string.IsNullOrWhiteSpace(txt_tiencoc.Text))
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                return false;
            }

            if (!double.TryParse(txt_tiencoc.Text, out double _))
            {
                MessageBox.Show("TIỀN CỌC PHẢI LÀ SỐ!");
                txt_tiencoc.Text = "";
                return false;
            }

            // Kiểm tra email hợp lệ (ví dụ đơn giản)
            if (!txt_email.Text.Contains("@"))
            {
                MessageBox.Show("EMAIL KHÔNG HỢP LỆ!");
                return false;
            }

            return true;
        }

        // Kiểm tra ID hợp lệ
        private bool ValidateId()
        {
            if (string.IsNullOrWhiteSpace(txt_MaDocGia.Text))
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG MÃ ĐỘC GIẢ!");
                return false;
            }

            if (!int.TryParse(txt_MaDocGia.Text, out int id) || id <= 0)
            {
                MessageBox.Show("ID SAI!");
                return false;
            }

            return true;
        }

    }
}
