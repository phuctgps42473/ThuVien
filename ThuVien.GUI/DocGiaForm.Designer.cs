namespace ThuVien.GUI
{
    partial class DocGiaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocGiaForm));
            this.dgv_docgia = new System.Windows.Forms.DataGridView();
            this.panel_nhapdata = new System.Windows.Forms.Panel();
            this.txt_MaDocGia = new System.Windows.Forms.RichTextBox();
            this.txt_sdt = new System.Windows.Forms.RichTextBox();
            this.txt_email = new System.Windows.Forms.RichTextBox();
            this.txt_hoten = new System.Windows.Forms.RichTextBox();
            this.panel_chucnang = new System.Windows.Forms.Panel();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.RichTextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_qltt = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.RichTextBox();
            this.txt_tiencoc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docgia)).BeginInit();
            this.panel_nhapdata.SuspendLayout();
            this.panel_chucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_docgia
            // 
            this.dgv_docgia.AllowUserToAddRows = false;
            this.dgv_docgia.AllowUserToDeleteRows = false;
            this.dgv_docgia.AllowUserToOrderColumns = true;
            this.dgv_docgia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_docgia.BackgroundColor = System.Drawing.Color.White;
            this.dgv_docgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_docgia.Location = new System.Drawing.Point(12, 66);
            this.dgv_docgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_docgia.MultiSelect = false;
            this.dgv_docgia.Name = "dgv_docgia";
            this.dgv_docgia.ReadOnly = true;
            this.dgv_docgia.RowHeadersWidth = 51;
            this.dgv_docgia.RowTemplate.Height = 24;
            this.dgv_docgia.Size = new System.Drawing.Size(735, 466);
            this.dgv_docgia.TabIndex = 0;
            // 
            // panel_nhapdata
            // 
            this.panel_nhapdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_nhapdata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_nhapdata.BackColor = System.Drawing.Color.Silver;
            this.panel_nhapdata.Controls.Add(this.txt_tiencoc);
            this.panel_nhapdata.Controls.Add(this.txt_diachi);
            this.panel_nhapdata.Controls.Add(this.txt_MaDocGia);
            this.panel_nhapdata.Controls.Add(this.txt_sdt);
            this.panel_nhapdata.Controls.Add(this.txt_email);
            this.panel_nhapdata.Controls.Add(this.txt_hoten);
            this.panel_nhapdata.Location = new System.Drawing.Point(754, 66);
            this.panel_nhapdata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_nhapdata.Name = "panel_nhapdata";
            this.panel_nhapdata.Size = new System.Drawing.Size(414, 466);
            this.panel_nhapdata.TabIndex = 3;
            // 
            // txt_MaDocGia
            // 
            this.txt_MaDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaDocGia.Location = new System.Drawing.Point(17, 16);
            this.txt_MaDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaDocGia.Name = "txt_MaDocGia";
            this.txt_MaDocGia.ReadOnly = true;
            this.txt_MaDocGia.Size = new System.Drawing.Size(381, 50);
            this.txt_MaDocGia.TabIndex = 3;
            this.txt_MaDocGia.Text = "";
            // 
            // txt_sdt
            // 
            this.txt_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sdt.Location = new System.Drawing.Point(17, 246);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(381, 50);
            this.txt_sdt.TabIndex = 2;
            this.txt_sdt.Text = "";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(17, 166);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(381, 50);
            this.txt_email.TabIndex = 1;
            this.txt_email.Text = "";
            // 
            // txt_hoten
            // 
            this.txt_hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hoten.Location = new System.Drawing.Point(17, 91);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(381, 50);
            this.txt_hoten.TabIndex = 0;
            this.txt_hoten.Text = "";
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
            this.panel_chucnang.Location = new System.Drawing.Point(10, 540);
            this.panel_chucnang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_chucnang.Name = "panel_chucnang";
            this.panel_chucnang.Size = new System.Drawing.Size(1160, 136);
            this.panel_chucnang.TabIndex = 4;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.Location = new System.Drawing.Point(895, 24);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(89, 99);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.Image")));
            this.btn_lammoi.Location = new System.Drawing.Point(423, 24);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(89, 99);
            this.btn_lammoi.TabIndex = 4;
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timkiem.Location = new System.Drawing.Point(1013, 49);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(135, 50);
            this.txt_timkiem.TabIndex = 3;
            this.txt_timkiem.Text = "";
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(54, 24);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(89, 99);
            this.btn_them.TabIndex = 0;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(301, 24);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(89, 99);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(178, 24);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(89, 99);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lbl_qltt
            // 
            this.lbl_qltt.AutoSize = true;
            this.lbl_qltt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qltt.Location = new System.Drawing.Point(14, 8);
            this.lbl_qltt.Name = "lbl_qltt";
            this.lbl_qltt.Size = new System.Drawing.Size(389, 46);
            this.lbl_qltt.TabIndex = 5;
            this.lbl_qltt.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diachi.Location = new System.Drawing.Point(17, 322);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(381, 50);
            this.txt_diachi.TabIndex = 4;
            this.txt_diachi.Text = "";
            // 
            // txt_tiencoc
            // 
            this.txt_tiencoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tiencoc.Location = new System.Drawing.Point(17, 398);
            this.txt_tiencoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tiencoc.Name = "txt_tiencoc";
            this.txt_tiencoc.Size = new System.Drawing.Size(381, 50);
            this.txt_tiencoc.TabIndex = 5;
            this.txt_tiencoc.Text = "";
            // 
            // DocGiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1183, 691);
            this.Controls.Add(this.lbl_qltt);
            this.Controls.Add(this.panel_chucnang);
            this.Controls.Add(this.panel_nhapdata);
            this.Controls.Add(this.dgv_docgia);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DocGiaForm";
            this.Text = "QLTT";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docgia)).EndInit();
            this.panel_nhapdata.ResumeLayout(false);
            this.panel_chucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_docgia;
        private System.Windows.Forms.Panel panel_nhapdata;
        private System.Windows.Forms.RichTextBox txt_hoten;
        private System.Windows.Forms.RichTextBox txt_MaDocGia;
        private System.Windows.Forms.RichTextBox txt_sdt;
        private System.Windows.Forms.RichTextBox txt_email;
        private System.Windows.Forms.Panel panel_chucnang;
        private System.Windows.Forms.RichTextBox txt_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_qltt;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.RichTextBox txt_diachi;
        private System.Windows.Forms.RichTextBox txt_tiencoc;
    }
}