namespace ThuVien.GUI
{
    partial class PhieuMuonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuMuonForm));
            this.dgv_qlpm = new System.Windows.Forms.DataGridView();
            this.panel_nhapdata = new System.Windows.Forms.Panel();
            this.lbl_ngaytra = new System.Windows.Forms.Label();
            this.lbl_ngaymuon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_matt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_mas = new System.Windows.Forms.ComboBox();
            this.lbl_iddg = new System.Windows.Forms.Label();
            this.cbo_madg = new System.Windows.Forms.ComboBox();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.txt_Mapm = new System.Windows.Forms.RichTextBox();
            this.txt_trangthai = new System.Windows.Forms.RichTextBox();
            this.txt_phithue = new System.Windows.Forms.RichTextBox();
            this.txt_soluong = new System.Windows.Forms.RichTextBox();
            this.panel_chucnang = new System.Windows.Forms.Panel();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.RichTextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_qltt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlpm)).BeginInit();
            this.panel_nhapdata.SuspendLayout();
            this.panel_chucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_qlpm
            // 
            this.dgv_qlpm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_qlpm.BackgroundColor = System.Drawing.Color.White;
            this.dgv_qlpm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlpm.Location = new System.Drawing.Point(11, 53);
            this.dgv_qlpm.Name = "dgv_qlpm";
            this.dgv_qlpm.RowHeadersWidth = 51;
            this.dgv_qlpm.RowTemplate.Height = 24;
            this.dgv_qlpm.Size = new System.Drawing.Size(653, 373);
            this.dgv_qlpm.TabIndex = 0;
            // 
            // panel_nhapdata
            // 
            this.panel_nhapdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_nhapdata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_nhapdata.BackColor = System.Drawing.Color.Silver;
            this.panel_nhapdata.Controls.Add(this.lbl_ngaytra);
            this.panel_nhapdata.Controls.Add(this.lbl_ngaymuon);
            this.panel_nhapdata.Controls.Add(this.label2);
            this.panel_nhapdata.Controls.Add(this.cbo_matt);
            this.panel_nhapdata.Controls.Add(this.label1);
            this.panel_nhapdata.Controls.Add(this.cbo_mas);
            this.panel_nhapdata.Controls.Add(this.lbl_iddg);
            this.panel_nhapdata.Controls.Add(this.cbo_madg);
            this.panel_nhapdata.Controls.Add(this.dtp_ngaytra);
            this.panel_nhapdata.Controls.Add(this.dtp_ngaymuon);
            this.panel_nhapdata.Controls.Add(this.txt_Mapm);
            this.panel_nhapdata.Controls.Add(this.txt_trangthai);
            this.panel_nhapdata.Controls.Add(this.txt_phithue);
            this.panel_nhapdata.Controls.Add(this.txt_soluong);
            this.panel_nhapdata.Location = new System.Drawing.Point(670, 53);
            this.panel_nhapdata.Name = "panel_nhapdata";
            this.panel_nhapdata.Size = new System.Drawing.Size(368, 373);
            this.panel_nhapdata.TabIndex = 3;
            // 
            // lbl_ngaytra
            // 
            this.lbl_ngaytra.AutoSize = true;
            this.lbl_ngaytra.Location = new System.Drawing.Point(14, 146);
            this.lbl_ngaytra.Name = "lbl_ngaytra";
            this.lbl_ngaytra.Size = new System.Drawing.Size(64, 16);
            this.lbl_ngaytra.TabIndex = 15;
            this.lbl_ngaytra.Text = "Ngày Trả";
            // 
            // lbl_ngaymuon
            // 
            this.lbl_ngaymuon.AutoSize = true;
            this.lbl_ngaymuon.Location = new System.Drawing.Point(13, 104);
            this.lbl_ngaymuon.Name = "lbl_ngaymuon";
            this.lbl_ngaymuon.Size = new System.Drawing.Size(76, 16);
            this.lbl_ngaymuon.TabIndex = 14;
            this.lbl_ngaymuon.Text = "Ngày Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Thủ Thư";
            // 
            // cbo_matt
            // 
            this.cbo_matt.FormattingEnabled = true;
            this.cbo_matt.Location = new System.Drawing.Point(95, 346);
            this.cbo_matt.Name = "cbo_matt";
            this.cbo_matt.Size = new System.Drawing.Size(259, 24);
            this.cbo_matt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Sách";
            // 
            // cbo_mas
            // 
            this.cbo_mas.FormattingEnabled = true;
            this.cbo_mas.Location = new System.Drawing.Point(95, 316);
            this.cbo_mas.Name = "cbo_mas";
            this.cbo_mas.Size = new System.Drawing.Size(259, 24);
            this.cbo_mas.TabIndex = 10;
            // 
            // lbl_iddg
            // 
            this.lbl_iddg.AutoSize = true;
            this.lbl_iddg.Location = new System.Drawing.Point(12, 289);
            this.lbl_iddg.Name = "lbl_iddg";
            this.lbl_iddg.Size = new System.Drawing.Size(77, 16);
            this.lbl_iddg.TabIndex = 9;
            this.lbl_iddg.Text = "Mã Độc Giả";
            // 
            // cbo_madg
            // 
            this.cbo_madg.FormattingEnabled = true;
            this.cbo_madg.Location = new System.Drawing.Point(95, 286);
            this.cbo_madg.Name = "cbo_madg";
            this.cbo_madg.Size = new System.Drawing.Size(259, 24);
            this.cbo_madg.TabIndex = 8;
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.Location = new System.Drawing.Point(15, 164);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(339, 22);
            this.dtp_ngaytra.TabIndex = 7;
            // 
            // dtp_ngaymuon
            // 
            this.dtp_ngaymuon.Location = new System.Drawing.Point(15, 121);
            this.dtp_ngaymuon.Name = "dtp_ngaymuon";
            this.dtp_ngaymuon.Size = new System.Drawing.Size(339, 22);
            this.dtp_ngaymuon.TabIndex = 6;
            // 
            // txt_Mapm
            // 
            this.txt_Mapm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mapm.Location = new System.Drawing.Point(15, 13);
            this.txt_Mapm.Name = "txt_Mapm";
            this.txt_Mapm.ReadOnly = true;
            this.txt_Mapm.Size = new System.Drawing.Size(339, 41);
            this.txt_Mapm.TabIndex = 3;
            this.txt_Mapm.Text = "";
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_trangthai.Location = new System.Drawing.Point(15, 239);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(339, 41);
            this.txt_trangthai.TabIndex = 2;
            this.txt_trangthai.Text = "";
            this.txt_trangthai.Click += new System.EventHandler(this.txt_trangthai_Click);
            this.txt_trangthai.TextChanged += new System.EventHandler(this.txt_trangthai_TextChanged);
            // 
            // txt_phithue
            // 
            this.txt_phithue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phithue.Location = new System.Drawing.Point(15, 192);
            this.txt_phithue.Name = "txt_phithue";
            this.txt_phithue.Size = new System.Drawing.Size(339, 41);
            this.txt_phithue.TabIndex = 1;
            this.txt_phithue.Text = "";
            this.txt_phithue.Click += new System.EventHandler(this.txt_phithue_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soluong.Location = new System.Drawing.Point(15, 60);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(339, 41);
            this.txt_soluong.TabIndex = 0;
            this.txt_soluong.Text = "";
            this.txt_soluong.Click += new System.EventHandler(this.txt_soluong_Click);
            // 
            // panel_chucnang
            // 
            this.panel_chucnang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_chucnang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_chucnang.BackColor = System.Drawing.Color.Silver;
            this.panel_chucnang.Controls.Add(this.btn_timkiem);
            this.panel_chucnang.Controls.Add(this.btn_lammoi);
            this.panel_chucnang.Controls.Add(this.txt_timkiem);
            this.panel_chucnang.Controls.Add(this.btn_them);
            this.panel_chucnang.Controls.Add(this.btn_xoa);
            this.panel_chucnang.Controls.Add(this.btn_sua);
            this.panel_chucnang.Location = new System.Drawing.Point(9, 432);
            this.panel_chucnang.Name = "panel_chucnang";
            this.panel_chucnang.Size = new System.Drawing.Size(1031, 109);
            this.panel_chucnang.TabIndex = 4;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.Location = new System.Drawing.Point(796, 19);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(79, 79);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.Image")));
            this.btn_lammoi.Location = new System.Drawing.Point(376, 19);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(79, 79);
            this.btn_lammoi.TabIndex = 4;
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timkiem.Location = new System.Drawing.Point(900, 39);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(120, 41);
            this.txt_timkiem.TabIndex = 3;
            this.txt_timkiem.Text = "";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(48, 19);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 79);
            this.btn_them.TabIndex = 0;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(268, 19);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(79, 79);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(158, 19);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(79, 79);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lbl_qltt
            // 
            this.lbl_qltt.AutoSize = true;
            this.lbl_qltt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qltt.Location = new System.Drawing.Point(12, 6);
            this.lbl_qltt.Name = "lbl_qltt";
            this.lbl_qltt.Size = new System.Drawing.Size(399, 38);
            this.lbl_qltt.TabIndex = 5;
            this.lbl_qltt.Text = "QUẢN LÝ PHIẾU MƯỢN";
            // 
            // PhieuMuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1052, 553);
            this.Controls.Add(this.lbl_qltt);
            this.Controls.Add(this.panel_chucnang);
            this.Controls.Add(this.panel_nhapdata);
            this.Controls.Add(this.dgv_qlpm);
            this.Name = "PhieuMuonForm";
            this.Text = "QLTT";
            this.Load += new System.EventHandler(this.PhieuMuonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlpm)).EndInit();
            this.panel_nhapdata.ResumeLayout(false);
            this.panel_nhapdata.PerformLayout();
            this.panel_chucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qlpm;
        private System.Windows.Forms.Panel panel_nhapdata;
        private System.Windows.Forms.RichTextBox txt_soluong;
        private System.Windows.Forms.RichTextBox txt_Mapm;
        private System.Windows.Forms.RichTextBox txt_trangthai;
        private System.Windows.Forms.RichTextBox txt_phithue;
        private System.Windows.Forms.Panel panel_chucnang;
        private System.Windows.Forms.RichTextBox txt_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_qltt;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.DateTimePicker dtp_ngaytra;
        private System.Windows.Forms.DateTimePicker dtp_ngaymuon;
        private System.Windows.Forms.Label lbl_ngaytra;
        private System.Windows.Forms.Label lbl_ngaymuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_matt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_mas;
        private System.Windows.Forms.Label lbl_iddg;
        private System.Windows.Forms.ComboBox cbo_madg;
    }
}