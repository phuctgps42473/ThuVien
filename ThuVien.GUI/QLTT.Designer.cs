namespace ThuVien.GUI
{
    partial class QLTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLTT));
            this.dgv_qltt = new System.Windows.Forms.DataGridView();
            this.lbl_tendangnhap = new System.Windows.Forms.Label();
            this.panel_thongtin = new System.Windows.Forms.Panel();
            this.lbl_ngaythangnam = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_vaitro = new System.Windows.Forms.Label();
            this.panel_nhapdata = new System.Windows.Forms.Panel();
            this.txt_Manv = new System.Windows.Forms.RichTextBox();
            this.txt_sdt = new System.Windows.Forms.RichTextBox();
            this.txt_email = new System.Windows.Forms.RichTextBox();
            this.txt_hoten = new System.Windows.Forms.RichTextBox();
            this.panel_chucnang = new System.Windows.Forms.Panel();
            this.txt_timkiem = new System.Windows.Forms.RichTextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_qltt = new System.Windows.Forms.Label();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.rdo_quanly = new System.Windows.Forms.RadioButton();
            this.rdo_thuthu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltt)).BeginInit();
            this.panel_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_nhapdata.SuspendLayout();
            this.panel_chucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_qltt
            // 
            this.dgv_qltt.BackgroundColor = System.Drawing.Color.White;
            this.dgv_qltt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qltt.Location = new System.Drawing.Point(12, 112);
            this.dgv_qltt.Name = "dgv_qltt";
            this.dgv_qltt.RowHeadersWidth = 51;
            this.dgv_qltt.RowTemplate.Height = 24;
            this.dgv_qltt.Size = new System.Drawing.Size(884, 314);
            this.dgv_qltt.TabIndex = 0;
            // 
            // lbl_tendangnhap
            // 
            this.lbl_tendangnhap.AutoSize = true;
            this.lbl_tendangnhap.BackColor = System.Drawing.Color.White;
            this.lbl_tendangnhap.Location = new System.Drawing.Point(73, 10);
            this.lbl_tendangnhap.Name = "lbl_tendangnhap";
            this.lbl_tendangnhap.Size = new System.Drawing.Size(44, 16);
            this.lbl_tendangnhap.TabIndex = 1;
            this.lbl_tendangnhap.Text = "label1";
            // 
            // panel_thongtin
            // 
            this.panel_thongtin.BackColor = System.Drawing.Color.White;
            this.panel_thongtin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_thongtin.Controls.Add(this.lbl_ngaythangnam);
            this.panel_thongtin.Controls.Add(this.pictureBox1);
            this.panel_thongtin.Controls.Add(this.lbl_vaitro);
            this.panel_thongtin.Controls.Add(this.lbl_tendangnhap);
            this.panel_thongtin.Location = new System.Drawing.Point(0, -1);
            this.panel_thongtin.Name = "panel_thongtin";
            this.panel_thongtin.Size = new System.Drawing.Size(1282, 60);
            this.panel_thongtin.TabIndex = 2;
            // 
            // lbl_ngaythangnam
            // 
            this.lbl_ngaythangnam.AutoSize = true;
            this.lbl_ngaythangnam.Location = new System.Drawing.Point(1101, 26);
            this.lbl_ngaythangnam.Name = "lbl_ngaythangnam";
            this.lbl_ngaythangnam.Size = new System.Drawing.Size(44, 16);
            this.lbl_ngaythangnam.TabIndex = 4;
            this.lbl_ngaythangnam.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_vaitro
            // 
            this.lbl_vaitro.AutoSize = true;
            this.lbl_vaitro.BackColor = System.Drawing.Color.White;
            this.lbl_vaitro.Location = new System.Drawing.Point(73, 26);
            this.lbl_vaitro.Name = "lbl_vaitro";
            this.lbl_vaitro.Size = new System.Drawing.Size(44, 16);
            this.lbl_vaitro.TabIndex = 2;
            this.lbl_vaitro.Text = "label1";
            this.lbl_vaitro.Click += new System.EventHandler(this.lbl_vaitro_Click);
            // 
            // panel_nhapdata
            // 
            this.panel_nhapdata.BackColor = System.Drawing.Color.Silver;
            this.panel_nhapdata.Controls.Add(this.rdo_thuthu);
            this.panel_nhapdata.Controls.Add(this.rdo_quanly);
            this.panel_nhapdata.Controls.Add(this.txt_Manv);
            this.panel_nhapdata.Controls.Add(this.txt_sdt);
            this.panel_nhapdata.Controls.Add(this.txt_email);
            this.panel_nhapdata.Controls.Add(this.txt_hoten);
            this.panel_nhapdata.Location = new System.Drawing.Point(902, 112);
            this.panel_nhapdata.Name = "panel_nhapdata";
            this.panel_nhapdata.Size = new System.Drawing.Size(368, 314);
            this.panel_nhapdata.TabIndex = 3;
            // 
            // txt_Manv
            // 
            this.txt_Manv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Manv.Location = new System.Drawing.Point(15, 13);
            this.txt_Manv.Name = "txt_Manv";
            this.txt_Manv.Size = new System.Drawing.Size(339, 41);
            this.txt_Manv.TabIndex = 3;
            this.txt_Manv.Text = "";
            // 
            // txt_sdt
            // 
            this.txt_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sdt.Location = new System.Drawing.Point(15, 197);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(339, 41);
            this.txt_sdt.TabIndex = 2;
            this.txt_sdt.Text = "";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(15, 133);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(339, 41);
            this.txt_email.TabIndex = 1;
            this.txt_email.Text = "";
            // 
            // txt_hoten
            // 
            this.txt_hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hoten.Location = new System.Drawing.Point(15, 73);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(339, 41);
            this.txt_hoten.TabIndex = 0;
            this.txt_hoten.Text = "";
            // 
            // panel_chucnang
            // 
            this.panel_chucnang.BackColor = System.Drawing.Color.Silver;
            this.panel_chucnang.Controls.Add(this.btn_timkiem);
            this.panel_chucnang.Controls.Add(this.btn_lammoi);
            this.panel_chucnang.Controls.Add(this.txt_timkiem);
            this.panel_chucnang.Controls.Add(this.btn_them);
            this.panel_chucnang.Controls.Add(this.btn_xoa);
            this.panel_chucnang.Controls.Add(this.btn_sua);
            this.panel_chucnang.Location = new System.Drawing.Point(9, 432);
            this.panel_chucnang.Name = "panel_chucnang";
            this.panel_chucnang.Size = new System.Drawing.Size(1261, 109);
            this.panel_chucnang.TabIndex = 4;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timkiem.Location = new System.Drawing.Point(908, 38);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(339, 41);
            this.txt_timkiem.TabIndex = 3;
            this.txt_timkiem.Text = "";
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(69, 19);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 79);
            this.btn_them.TabIndex = 0;
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(350, 19);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(79, 79);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(210, 19);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(79, 79);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // lbl_qltt
            // 
            this.lbl_qltt.AutoSize = true;
            this.lbl_qltt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qltt.Location = new System.Drawing.Point(14, 66);
            this.lbl_qltt.Name = "lbl_qltt";
            this.lbl_qltt.Size = new System.Drawing.Size(341, 39);
            this.lbl_qltt.TabIndex = 5;
            this.lbl_qltt.Text = "QUẢN LÝ THỦ THƯ";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.Image")));
            this.btn_lammoi.Location = new System.Drawing.Point(491, 19);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(79, 79);
            this.btn_lammoi.TabIndex = 4;
            this.btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.Location = new System.Drawing.Point(798, 19);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(79, 79);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // rdo_quanly
            // 
            this.rdo_quanly.AutoSize = true;
            this.rdo_quanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_quanly.Location = new System.Drawing.Point(15, 266);
            this.rdo_quanly.Name = "rdo_quanly";
            this.rdo_quanly.Size = new System.Drawing.Size(115, 29);
            this.rdo_quanly.TabIndex = 4;
            this.rdo_quanly.TabStop = true;
            this.rdo_quanly.Text = "Quản Lý";
            this.rdo_quanly.UseVisualStyleBackColor = true;
            // 
            // rdo_thuthu
            // 
            this.rdo_thuthu.AutoSize = true;
            this.rdo_thuthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_thuthu.Location = new System.Drawing.Point(239, 266);
            this.rdo_thuthu.Name = "rdo_thuthu";
            this.rdo_thuthu.Size = new System.Drawing.Size(115, 29);
            this.rdo_thuthu.TabIndex = 5;
            this.rdo_thuthu.TabStop = true;
            this.rdo_thuthu.Text = "Thủ Thư";
            this.rdo_thuthu.UseVisualStyleBackColor = true;
            // 
            // QLTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1282, 553);
            this.Controls.Add(this.lbl_qltt);
            this.Controls.Add(this.panel_chucnang);
            this.Controls.Add(this.panel_nhapdata);
            this.Controls.Add(this.panel_thongtin);
            this.Controls.Add(this.dgv_qltt);
            this.Name = "QLTT";
            this.Text = "QLTT";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltt)).EndInit();
            this.panel_thongtin.ResumeLayout(false);
            this.panel_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_nhapdata.ResumeLayout(false);
            this.panel_nhapdata.PerformLayout();
            this.panel_chucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qltt;
        private System.Windows.Forms.Label lbl_tendangnhap;
        private System.Windows.Forms.Panel panel_thongtin;
        private System.Windows.Forms.Label lbl_vaitro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_nhapdata;
        private System.Windows.Forms.RichTextBox txt_hoten;
        private System.Windows.Forms.RichTextBox txt_Manv;
        private System.Windows.Forms.RichTextBox txt_sdt;
        private System.Windows.Forms.RichTextBox txt_email;
        private System.Windows.Forms.Panel panel_chucnang;
        private System.Windows.Forms.RichTextBox txt_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_ngaythangnam;
        private System.Windows.Forms.Label lbl_qltt;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.RadioButton rdo_quanly;
        private System.Windows.Forms.RadioButton rdo_thuthu;
    }
}