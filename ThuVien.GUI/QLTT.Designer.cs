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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_vaitro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_hoten = new System.Windows.Forms.RichTextBox();
            this.txt_email = new System.Windows.Forms.RichTextBox();
            this.txt_sdt = new System.Windows.Forms.RichTextBox();
            this.txt_Manv = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_vaitro);
            this.panel1.Controls.Add(this.lbl_tendangnhap);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 60);
            this.panel1.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txt_Manv);
            this.panel2.Controls.Add(this.txt_sdt);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.txt_hoten);
            this.panel2.Location = new System.Drawing.Point(902, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 314);
            this.panel2.TabIndex = 3;
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
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(15, 133);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(339, 41);
            this.txt_email.TabIndex = 1;
            this.txt_email.Text = "";
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
            // txt_Manv
            // 
            this.txt_Manv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Manv.Location = new System.Drawing.Point(15, 13);
            this.txt_Manv.Name = "txt_Manv";
            this.txt_Manv.Size = new System.Drawing.Size(339, 41);
            this.txt_Manv.TabIndex = 3;
            this.txt_Manv.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(9, 432);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1261, 109);
            this.panel3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(908, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(339, 41);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1210, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // QLTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1282, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_qltt);
            this.Name = "QLTT";
            this.Text = "QLTT";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qltt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qltt;
        private System.Windows.Forms.Label lbl_tendangnhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_vaitro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txt_hoten;
        private System.Windows.Forms.RichTextBox txt_Manv;
        private System.Windows.Forms.RichTextBox txt_sdt;
        private System.Windows.Forms.RichTextBox txt_email;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}