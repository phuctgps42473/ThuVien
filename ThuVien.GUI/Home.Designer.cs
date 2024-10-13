namespace ThuVien.GUI
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dangXuatBtn = new System.Windows.Forms.Button();
            this.sachBtn = new System.Windows.Forms.Button();
            this.loaiSachBtn = new System.Windows.Forms.Button();
            this.nhanVienBtn = new System.Windows.Forms.Button();
            this.thongKeBtn = new System.Windows.Forms.Button();
            this.docGiaBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phieuMuonBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.nvRoleText = new System.Windows.Forms.Label();
            this.nvNameText = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.checkAuthTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.dangXuatBtn);
            this.panel1.Controls.Add(this.sachBtn);
            this.panel1.Controls.Add(this.loaiSachBtn);
            this.panel1.Controls.Add(this.nhanVienBtn);
            this.panel1.Controls.Add(this.thongKeBtn);
            this.panel1.Controls.Add(this.docGiaBtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.phieuMuonBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 805);
            this.panel1.TabIndex = 0;
            // 
            // dangXuatBtn
            // 
            this.dangXuatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dangXuatBtn.BackColor = System.Drawing.Color.Black;
            this.dangXuatBtn.FlatAppearance.BorderSize = 0;
            this.dangXuatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangXuatBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangXuatBtn.ForeColor = System.Drawing.Color.White;
            this.dangXuatBtn.Location = new System.Drawing.Point(3, 696);
            this.dangXuatBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dangXuatBtn.Name = "dangXuatBtn";
            this.dangXuatBtn.Size = new System.Drawing.Size(216, 58);
            this.dangXuatBtn.TabIndex = 6;
            this.dangXuatBtn.Text = "Đăng xuất";
            this.dangXuatBtn.UseVisualStyleBackColor = false;
            // 
            // sachBtn
            // 
            this.sachBtn.BackColor = System.Drawing.Color.Black;
            this.sachBtn.FlatAppearance.BorderSize = 0;
            this.sachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sachBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sachBtn.ForeColor = System.Drawing.Color.White;
            this.sachBtn.Location = new System.Drawing.Point(3, 228);
            this.sachBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sachBtn.Name = "sachBtn";
            this.sachBtn.Size = new System.Drawing.Size(215, 58);
            this.sachBtn.TabIndex = 5;
            this.sachBtn.Text = "Sách";
            this.sachBtn.UseVisualStyleBackColor = false;
            this.sachBtn.Click += new System.EventHandler(this.sachBtn_Click);
            // 
            // loaiSachBtn
            // 
            this.loaiSachBtn.BackColor = System.Drawing.Color.Black;
            this.loaiSachBtn.FlatAppearance.BorderSize = 0;
            this.loaiSachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loaiSachBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiSachBtn.ForeColor = System.Drawing.Color.White;
            this.loaiSachBtn.Location = new System.Drawing.Point(3, 164);
            this.loaiSachBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loaiSachBtn.Name = "loaiSachBtn";
            this.loaiSachBtn.Size = new System.Drawing.Size(215, 58);
            this.loaiSachBtn.TabIndex = 4;
            this.loaiSachBtn.Text = "Loại sách";
            this.loaiSachBtn.UseVisualStyleBackColor = false;
            this.loaiSachBtn.Click += new System.EventHandler(this.loaiSachBtn_Click);
            // 
            // nhanVienBtn
            // 
            this.nhanVienBtn.BackColor = System.Drawing.Color.Black;
            this.nhanVienBtn.FlatAppearance.BorderSize = 0;
            this.nhanVienBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nhanVienBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanVienBtn.ForeColor = System.Drawing.Color.White;
            this.nhanVienBtn.Location = new System.Drawing.Point(3, 484);
            this.nhanVienBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhanVienBtn.Name = "nhanVienBtn";
            this.nhanVienBtn.Size = new System.Drawing.Size(215, 58);
            this.nhanVienBtn.TabIndex = 3;
            this.nhanVienBtn.Text = "Nhân viên";
            this.nhanVienBtn.UseVisualStyleBackColor = false;
            this.nhanVienBtn.Click += new System.EventHandler(this.nhanVienBtn_Click);
            // 
            // thongKeBtn
            // 
            this.thongKeBtn.BackColor = System.Drawing.Color.Black;
            this.thongKeBtn.FlatAppearance.BorderSize = 0;
            this.thongKeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thongKeBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongKeBtn.ForeColor = System.Drawing.Color.White;
            this.thongKeBtn.Location = new System.Drawing.Point(3, 420);
            this.thongKeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thongKeBtn.Name = "thongKeBtn";
            this.thongKeBtn.Size = new System.Drawing.Size(215, 58);
            this.thongKeBtn.TabIndex = 2;
            this.thongKeBtn.Text = "Thống kê";
            this.thongKeBtn.UseVisualStyleBackColor = false;
            this.thongKeBtn.Click += new System.EventHandler(this.thongKeBtn_Click);
            // 
            // docGiaBtn
            // 
            this.docGiaBtn.BackColor = System.Drawing.Color.Black;
            this.docGiaBtn.FlatAppearance.BorderSize = 0;
            this.docGiaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docGiaBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docGiaBtn.ForeColor = System.Drawing.Color.White;
            this.docGiaBtn.Location = new System.Drawing.Point(3, 356);
            this.docGiaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docGiaBtn.Name = "docGiaBtn";
            this.docGiaBtn.Size = new System.Drawing.Size(215, 58);
            this.docGiaBtn.TabIndex = 1;
            this.docGiaBtn.Text = "Độc giả";
            this.docGiaBtn.UseVisualStyleBackColor = false;
            this.docGiaBtn.Click += new System.EventHandler(this.docGiaBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 148);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThuVien.GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // phieuMuonBtn
            // 
            this.phieuMuonBtn.BackColor = System.Drawing.Color.Black;
            this.phieuMuonBtn.FlatAppearance.BorderSize = 0;
            this.phieuMuonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phieuMuonBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieuMuonBtn.ForeColor = System.Drawing.Color.White;
            this.phieuMuonBtn.Location = new System.Drawing.Point(3, 292);
            this.phieuMuonBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phieuMuonBtn.Name = "phieuMuonBtn";
            this.phieuMuonBtn.Size = new System.Drawing.Size(215, 58);
            this.phieuMuonBtn.TabIndex = 0;
            this.phieuMuonBtn.Text = "Phiếu mượn";
            this.phieuMuonBtn.UseVisualStyleBackColor = false;
            this.phieuMuonBtn.Click += new System.EventHandler(this.phieuMuonBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.dateText);
            this.panel2.Controls.Add(this.timeText);
            this.panel2.Controls.Add(this.nvRoleText);
            this.panel2.Controls.Add(this.nvNameText);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 72);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 62);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // dateText
            // 
            this.dateText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateText.Location = new System.Drawing.Point(976, 41);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(142, 28);
            this.dateText.TabIndex = 3;
            this.dateText.Text = "ngày tháng";
            // 
            // timeText
            // 
            this.timeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText.Location = new System.Drawing.Point(977, 8);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(129, 28);
            this.timeText.TabIndex = 2;
            this.timeText.Text = "thời gian";
            // 
            // nvRoleText
            // 
            this.nvRoleText.AutoSize = true;
            this.nvRoleText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvRoleText.Location = new System.Drawing.Point(80, 41);
            this.nvRoleText.Name = "nvRoleText";
            this.nvRoleText.Size = new System.Drawing.Size(103, 28);
            this.nvRoleText.TabIndex = 1;
            this.nvRoleText.Text = "vai tro";
            // 
            // nvNameText
            // 
            this.nvNameText.AutoSize = true;
            this.nvNameText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvNameText.Location = new System.Drawing.Point(80, 8);
            this.nvNameText.Name = "nvNameText";
            this.nvNameText.Size = new System.Drawing.Size(181, 28);
            this.nvNameText.TabIndex = 0;
            this.nvNameText.Text = "ten nhan vien";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.Gray;
            this.mainPanel.Location = new System.Drawing.Point(3, 78);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1121, 725);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(222, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 805);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1349, 805);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button phieuMuonBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nvNameText;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label nvRoleText;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sachBtn;
        private System.Windows.Forms.Button loaiSachBtn;
        private System.Windows.Forms.Button nhanVienBtn;
        private System.Windows.Forms.Button thongKeBtn;
        private System.Windows.Forms.Button docGiaBtn;
        private System.Windows.Forms.Button dangXuatBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer checkAuthTimer;
    }
}