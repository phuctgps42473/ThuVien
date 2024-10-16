using System;
using System.Net.Mail;
using System.Net;
using System.Text;
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
        //public string RandomString(int size, bool lowerCase)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    Random random = new Random();
        //    char ch;
        //    for (int i = 0; i < size; i++)
        //    {
        //        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
        //        builder.Append(ch);
        //    }
        //    if (lowerCase)
        //        return builder.ToString().ToLower();
        //    return builder.ToString();
        //}
        ////Tao day so ngau nhien
        //public int RandomNumber(int min, int max)
        //{
        //    Random random = new Random();
        //    return random.Next(min, max);
        //}

        ////Gui email
        //public void SendMail(string email, string password)
        //{
        //    try
        //    {
        //        MailMessage Msg = new MailMessage();
        //        Msg.Body = "Chào anh/ chị. Mật khẩu mới: " + password;
        //        Msg.To.Add(email);
        //        Msg.From = new MailAddress("DuAnQuanLyNongSan@gmail.com");
        //        Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";

        //        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //        client.EnableSsl = true;

        //        client.Credentials = new NetworkCredential("DuAnQuanLyNongSan@gmail.com", "sqsc sbex rmcs ypjp");
        //        client.Send(Msg);
        //        MessageBox.Show("Gửi mail thành công");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
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
