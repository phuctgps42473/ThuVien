namespace ThuVien.GUI
{
    partial class SachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SachForm));
            this.dgv_qltt = new System.Windows.Forms.DataGridView();
            this.panel_chucnang = new System.Windows.Forms.Panel();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.RichTextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_qltt = new System.Windows.Forms.Label();
            this.panel_nhapdata = new System.Windows.Forms.Panel();
            this.cbo_loaisach = new System.Windows.Forms.ComboBox();
            this.txt_cosan = new System.Windows.Forms.RichTextBox();
            this.txt_tonkho = new System.Windows.Forms.RichTextBox();
            this.txt_soluong = new System.Windows.Forms.RichTextBox();
            this.txt_masach = new System.Windows.Forms.RichTextBox();
            this.txt_taiban = new System.Windows.Forms.RichTextBox();
            this.txt_tacgia = new System.Windows.Forms.RichTextBox();
            this.txt_tensach = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltt)).BeginInit();
            this.panel_chucnang.SuspendLayout();
            this.panel_nhapdata.SuspendLayout();
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
            this.dgv_qltt.RowHeadersWidth = 51;
            this.dgv_qltt.RowTemplate.Height = 24;
            this.dgv_qltt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qltt.Size = new System.Drawing.Size(653, 373);
            this.dgv_qltt.TabIndex = 0;
            this.dgv_qltt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qltt_CellContentClick);
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
            this.lbl_qltt.Size = new System.Drawing.Size(275, 38);
            this.lbl_qltt.TabIndex = 5;
            this.lbl_qltt.Text = "QUẢN LÝ SÁCH";
            // 
            // panel_nhapdata
            // 
            this.panel_nhapdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_nhapdata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_nhapdata.BackColor = System.Drawing.Color.Silver;
            this.panel_nhapdata.Controls.Add(this.cbo_loaisach);
            this.panel_nhapdata.Controls.Add(this.txt_cosan);
            this.panel_nhapdata.Controls.Add(this.txt_tonkho);
            this.panel_nhapdata.Controls.Add(this.txt_soluong);
            this.panel_nhapdata.Controls.Add(this.txt_masach);
            this.panel_nhapdata.Controls.Add(this.txt_taiban);
            this.panel_nhapdata.Controls.Add(this.txt_tacgia);
            this.panel_nhapdata.Controls.Add(this.txt_tensach);
            this.panel_nhapdata.Location = new System.Drawing.Point(672, 53);
            this.panel_nhapdata.Name = "panel_nhapdata";
            this.panel_nhapdata.Size = new System.Drawing.Size(368, 373);
            this.panel_nhapdata.TabIndex = 6;
            // 
            // cbo_loaisach
            // 
            this.cbo_loaisach.FormattingEnabled = true;
            this.cbo_loaisach.Location = new System.Drawing.Point(15, 332);
            this.cbo_loaisach.Name = "cbo_loaisach";
            this.cbo_loaisach.Size = new System.Drawing.Size(342, 24);
            this.cbo_loaisach.TabIndex = 7;
            this.cbo_loaisach.SelectedIndexChanged += new System.EventHandler(this.cbo_loaisach_SelectedIndexChanged);
            // 
            // txt_cosan
            // 
            this.txt_cosan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cosan.Location = new System.Drawing.Point(15, 285);
            this.txt_cosan.Name = "txt_cosan";
            this.txt_cosan.Size = new System.Drawing.Size(339, 41);
            this.txt_cosan.TabIndex = 8;
            this.txt_cosan.Text = "";
            this.txt_cosan.Click += new System.EventHandler(this.txt_cosan_Click);
            // 
            // txt_tonkho
            // 
            this.txt_tonkho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tonkho.Location = new System.Drawing.Point(15, 238);
            this.txt_tonkho.Name = "txt_tonkho";
            this.txt_tonkho.Size = new System.Drawing.Size(339, 41);
            this.txt_tonkho.TabIndex = 7;
            this.txt_tonkho.Text = "";
            this.txt_tonkho.Click += new System.EventHandler(this.txt_tonkho_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soluong.Location = new System.Drawing.Point(15, 191);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(339, 41);
            this.txt_soluong.TabIndex = 6;
            this.txt_soluong.Text = "";
            this.txt_soluong.Click += new System.EventHandler(this.txt_soluong_Click);
            // 
            // txt_masach
            // 
            this.txt_masach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_masach.Location = new System.Drawing.Point(15, 3);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.ReadOnly = true;
            this.txt_masach.Size = new System.Drawing.Size(339, 41);
            this.txt_masach.TabIndex = 3;
            this.txt_masach.Text = "";
            this.txt_masach.Click += new System.EventHandler(this.txt_Manv_Click);
            // 
            // txt_taiban
            // 
            this.txt_taiban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_taiban.Location = new System.Drawing.Point(15, 144);
            this.txt_taiban.Name = "txt_taiban";
            this.txt_taiban.Size = new System.Drawing.Size(339, 41);
            this.txt_taiban.TabIndex = 2;
            this.txt_taiban.Text = "";
            this.txt_taiban.Click += new System.EventHandler(this.txt_taiban_Click);
            // 
            // txt_tacgia
            // 
            this.txt_tacgia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tacgia.Location = new System.Drawing.Point(15, 97);
            this.txt_tacgia.Name = "txt_tacgia";
            this.txt_tacgia.Size = new System.Drawing.Size(339, 41);
            this.txt_tacgia.TabIndex = 1;
            this.txt_tacgia.Text = "";
            this.txt_tacgia.Click += new System.EventHandler(this.txt_tacgia_Click);
            // 
            // txt_tensach
            // 
            this.txt_tensach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tensach.Location = new System.Drawing.Point(15, 50);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(339, 41);
            this.txt_tensach.TabIndex = 0;
            this.txt_tensach.Text = "";
            this.txt_tensach.Click += new System.EventHandler(this.txt_tensach_Click);
            this.txt_tensach.TextChanged += new System.EventHandler(this.txt_tensach_TextChanged);
            // 
            // SachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1052, 553);
            this.Controls.Add(this.panel_nhapdata);
            this.Controls.Add(this.lbl_qltt);
            this.Controls.Add(this.panel_chucnang);
            this.Controls.Add(this.dgv_qltt);
            this.Name = "SachForm";
            this.Text = "QLTT";
            this.Load += new System.EventHandler(this.SachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltt)).EndInit();
            this.panel_chucnang.ResumeLayout(false);
            this.panel_nhapdata.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qltt;
        private System.Windows.Forms.Panel panel_chucnang;
        private System.Windows.Forms.RichTextBox txt_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_qltt;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Panel panel_nhapdata;
        private System.Windows.Forms.RichTextBox txt_cosan;
        private System.Windows.Forms.RichTextBox txt_tonkho;
        private System.Windows.Forms.RichTextBox txt_soluong;
        private System.Windows.Forms.RichTextBox txt_masach;
        private System.Windows.Forms.RichTextBox txt_taiban;
        private System.Windows.Forms.RichTextBox txt_tacgia;
        private System.Windows.Forms.RichTextBox txt_tensach;
        private System.Windows.Forms.ComboBox cbo_loaisach;
    }
}