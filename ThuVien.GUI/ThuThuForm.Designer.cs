namespace ThuVien.GUI
{
    partial class ThuThuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuThuForm));
            this.dgv_qltt = new System.Windows.Forms.DataGridView();
            this.panel_nhapdata = new System.Windows.Forms.Panel();
            this.txt_matkhau = new System.Windows.Forms.RichTextBox();
            this.txt_Manv = new System.Windows.Forms.RichTextBox();
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
            this.rdo_quanly = new System.Windows.Forms.RadioButton();
            this.rdo_thuthu = new System.Windows.Forms.RadioButton();
            this.grb_vaitro = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltt)).BeginInit();
            this.panel_nhapdata.SuspendLayout();
            this.panel_chucnang.SuspendLayout();
            this.grb_vaitro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_qltt
            // 
            this.dgv_qltt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_qltt.BackgroundColor = System.Drawing.Color.White;
            this.dgv_qltt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qltt.Location = new System.Drawing.Point(11, 53);
            this.dgv_qltt.Name = "dgv_qltt";
            this.dgv_qltt.ReadOnly = true;
            this.dgv_qltt.RowHeadersWidth = 51;
            this.dgv_qltt.RowTemplate.Height = 24;
            this.dgv_qltt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qltt.Size = new System.Drawing.Size(653, 373);
            this.dgv_qltt.TabIndex = 0;
            this.dgv_qltt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qltt_CellContentClick);
            // 
            // panel_nhapdata
            // 
            this.panel_nhapdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_nhapdata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_nhapdata.BackColor = System.Drawing.Color.Silver;
            this.panel_nhapdata.Controls.Add(this.grb_vaitro);
            this.panel_nhapdata.Controls.Add(this.txt_matkhau);
            this.panel_nhapdata.Controls.Add(this.txt_Manv);
            this.panel_nhapdata.Controls.Add(this.txt_sdt);
            this.panel_nhapdata.Controls.Add(this.txt_email);
            this.panel_nhapdata.Controls.Add(this.txt_hoten);
            this.panel_nhapdata.Location = new System.Drawing.Point(670, 53);
            this.panel_nhapdata.Name = "panel_nhapdata";
            this.panel_nhapdata.Size = new System.Drawing.Size(368, 373);
            this.panel_nhapdata.TabIndex = 3;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_matkhau.Location = new System.Drawing.Point(15, 259);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(339, 41);
            this.txt_matkhau.TabIndex = 6;
            this.txt_matkhau.Text = "";
            this.txt_matkhau.Click += new System.EventHandler(this.txt_matkhau_Click);
            // 
            // txt_Manv
            // 
            this.txt_Manv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Manv.Location = new System.Drawing.Point(15, 13);
            this.txt_Manv.Name = "txt_Manv";
            this.txt_Manv.ReadOnly = true;
            this.txt_Manv.Size = new System.Drawing.Size(339, 41);
            this.txt_Manv.TabIndex = 3;
            this.txt_Manv.Text = "";
            this.txt_Manv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Manv_MouseClick);
            // 
            // txt_sdt
            // 
            this.txt_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sdt.Location = new System.Drawing.Point(15, 197);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(339, 41);
            this.txt_sdt.TabIndex = 2;
            this.txt_sdt.Text = "";
            this.txt_sdt.Click += new System.EventHandler(this.txt_sdt_Click);
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(15, 133);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(339, 41);
            this.txt_email.TabIndex = 1;
            this.txt_email.Text = "";
            this.txt_email.Click += new System.EventHandler(this.txt_email_Click);
            // 
            // txt_hoten
            // 
            this.txt_hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hoten.Location = new System.Drawing.Point(15, 73);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(339, 41);
            this.txt_hoten.TabIndex = 0;
            this.txt_hoten.Text = "";
            this.txt_hoten.Click += new System.EventHandler(this.txt_hoten_Click);
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
            this.btn_timkiem.Location = new System.Drawing.Point(788, 18);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(79, 79);
            this.btn_timkiem.TabIndex = 11;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.Image")));
            this.btn_lammoi.Location = new System.Drawing.Point(368, 18);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(79, 79);
            this.btn_lammoi.TabIndex = 10;
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timkiem.Location = new System.Drawing.Point(892, 38);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(120, 41);
            this.txt_timkiem.TabIndex = 9;
            this.txt_timkiem.Text = "";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(40, 18);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(79, 79);
            this.btn_them.TabIndex = 6;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(260, 18);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(79, 79);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(150, 18);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(79, 79);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lbl_qltt
            // 
            this.lbl_qltt.AutoSize = true;
            this.lbl_qltt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qltt.Location = new System.Drawing.Point(12, 6);
            this.lbl_qltt.Name = "lbl_qltt";
            this.lbl_qltt.Size = new System.Drawing.Size(331, 38);
            this.lbl_qltt.TabIndex = 5;
            this.lbl_qltt.Text = "QUẢN LÝ THỦ THƯ";
            this.lbl_qltt.Click += new System.EventHandler(this.lbl_qltt_Click);
            // 
            // rdo_quanly
            // 
            this.rdo_quanly.AutoSize = true;
            this.rdo_quanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_quanly.Location = new System.Drawing.Point(19, 21);
            this.rdo_quanly.Name = "rdo_quanly";
            this.rdo_quanly.Size = new System.Drawing.Size(100, 24);
            this.rdo_quanly.TabIndex = 0;
            this.rdo_quanly.TabStop = true;
            this.rdo_quanly.Text = "Quản Lý";
            this.rdo_quanly.UseVisualStyleBackColor = true;
            // 
            // rdo_thuthu
            // 
            this.rdo_thuthu.AutoSize = true;
            this.rdo_thuthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_thuthu.Location = new System.Drawing.Point(201, 21);
            this.rdo_thuthu.Name = "rdo_thuthu";
            this.rdo_thuthu.Size = new System.Drawing.Size(116, 24);
            this.rdo_thuthu.TabIndex = 1;
            this.rdo_thuthu.TabStop = true;
            this.rdo_thuthu.Text = "Nhân Viên";
            this.rdo_thuthu.UseVisualStyleBackColor = true;
            // 
            // grb_vaitro
            // 
            this.grb_vaitro.Controls.Add(this.rdo_thuthu);
            this.grb_vaitro.Controls.Add(this.rdo_quanly);
            this.grb_vaitro.Location = new System.Drawing.Point(15, 306);
            this.grb_vaitro.Name = "grb_vaitro";
            this.grb_vaitro.Size = new System.Drawing.Size(336, 64);
            this.grb_vaitro.TabIndex = 6;
            this.grb_vaitro.TabStop = false;
            this.grb_vaitro.Text = "Vai Trò";
            // 
            // ThuThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1052, 553);
            this.Controls.Add(this.lbl_qltt);
            this.Controls.Add(this.panel_chucnang);
            this.Controls.Add(this.panel_nhapdata);
            this.Controls.Add(this.dgv_qltt);
            this.Name = "ThuThuForm";
            this.Text = "QLTT";
            this.Load += new System.EventHandler(this.ThuThuForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltt)).EndInit();
            this.panel_nhapdata.ResumeLayout(false);
            this.panel_chucnang.ResumeLayout(false);
            this.grb_vaitro.ResumeLayout(false);
            this.grb_vaitro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qltt;
        private System.Windows.Forms.Panel panel_nhapdata;
        private System.Windows.Forms.RichTextBox txt_hoten;
        private System.Windows.Forms.RichTextBox txt_Manv;
        private System.Windows.Forms.RichTextBox txt_sdt;
        private System.Windows.Forms.RichTextBox txt_email;
        private System.Windows.Forms.Panel panel_chucnang;
        private System.Windows.Forms.Label lbl_qltt;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.RichTextBox txt_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.RichTextBox txt_matkhau;
        private System.Windows.Forms.GroupBox grb_vaitro;
        private System.Windows.Forms.RadioButton rdo_thuthu;
        private System.Windows.Forms.RadioButton rdo_quanly;
    }
}