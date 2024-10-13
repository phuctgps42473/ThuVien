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


        private void LoadGridView_DocGia(DataTable dt = null)
        {
            dgv_docgia.DataSource = dt ?? docGiaBUS.GetAllDocGia();
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
            LoadGridView_DocGia(dt);
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
                docGiaBUS.CreateDocGia(docgia);
                LoadGridView_DocGia();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DocGiaDTO docgia = GetDocGiaFromForm();
            if (docgia != null)
            {
                if (string.IsNullOrWhiteSpace(
                    txt_MaDocGia.Text))
                {

                    MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                    return;
                }
                
                if (!int.TryParse(txt_MaDocGia.Text, out int id) || id <= 0)
                {
                    MessageBox.Show("ID SAI!");
                    return;
                }
                docgia.Id = id;
                docGiaBUS.UpdateDocGia(docgia);
                LoadGridView_DocGia();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txt_MaDocGia.Text))
            {

                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                return;
            }
            if (!int.TryParse(txt_MaDocGia.Text, out int id) || id <= 0)
            {
                MessageBox.Show("ID SAI!");
                return;
            }

            docGiaBUS.DeleteDocGia(id);
            LoadGridView_DocGia();

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_MaDocGia.Text = "";
            txt_hoten.Text = "";
            txt_email.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            txt_tiencoc.Text = "";
        }
    }
}
