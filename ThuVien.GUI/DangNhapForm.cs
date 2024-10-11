using System;
using System.Windows.Forms;
using ThuVien.BUS;

namespace ThuVien.GUI
{
    public partial class DangNhapForm : Form
    {
        private AuthBUS authBUS = new AuthBUS();
        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void danhNhapBtn_Click(object sender, EventArgs e)
        {
            string email = taiKhoanText.Text.Trim();
            string password = matkhauText.Text.Trim();
            if (authBUS.ValidateLogin(email, password))
            {
                Home home = new Home();

                home.FormClosed += (s, a) =>
                {
                    home.Dispose();
                    this.Show();
                };

                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }

        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {

        }
    }
}
