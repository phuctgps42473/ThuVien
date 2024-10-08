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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadUserInfoToTopBar();
            LoadTimeInfoToTopBar();
            LoadChildForm(new LoaiSachForm());
        }


        private void LoadTimeInfoToTopBar()
        {
            DateTime today = DateTime.Now;
            timeText.Text = today.ToString("HH:mm:ss");
            dateText.Text = today.Date.ToString();

            timer.Tick += (s, a) =>
            {
                today = DateTime.Now;
                timeText.Text = today.ToString("HH:mm:ss");
                dateText.Text = today.Date.ToString();
            };
            timer.Interval = 1000;
            timer.Start();
        }

        private void LoadUserInfoToTopBar()
        {
            NhanVienDTO nv = Session.Instance.NhanVien;

            nvNameText.Text = nv.Ten;
            nvRoleText.Text = nv.IsManager ? "Quản lý" : "Nhân viên";

        }

        private void LoadChildForm(Form childForm)
        {
            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.Clear();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(childForm);
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loaiSachBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new LoaiSachForm());
        }

        private void nhanVienBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new ThuThuForm());
        }

        private void sachBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new SachForm());
        }

        private void phieuMuonBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new PhieuMuonForm());
        }

        private void docGiaBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new DocGiaForm());
        }

        private void thongKeBtn_Click(object sender, EventArgs e)
        {
            //LoadChildForm(new ThongKe());
        }
    }
}
