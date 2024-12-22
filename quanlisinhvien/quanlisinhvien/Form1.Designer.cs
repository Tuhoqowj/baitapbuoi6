namespace quanlisinhvien
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.masv = new System.Windows.Forms.RichTextBox();
            this.hoTen = new System.Windows.Forms.RichTextBox();
            this.dienTrungBinh = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ma sinh vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "dtb";
            // 
            // masv
            // 
            this.masv.Location = new System.Drawing.Point(133, 102);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(208, 26);
            this.masv.TabIndex = 4;
            this.masv.Text = "";
            // 
            // hoTen
            // 
            this.hoTen.Location = new System.Drawing.Point(133, 152);
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(208, 26);
            this.hoTen.TabIndex = 5;
            this.hoTen.Text = "";
            // 
            // dienTrungBinh
            // 
            this.dienTrungBinh.Location = new System.Drawing.Point(104, 252);
            this.dienTrungBinh.Name = "dienTrungBinh";
            this.dienTrungBinh.Size = new System.Drawing.Size(208, 26);
            this.dienTrungBinh.TabIndex = 6;
            this.dienTrungBinh.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CNTT",
            "NNA",
            "QTKD"});
            this.comboBox1.Location = new System.Drawing.Point(133, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvien,
            this.ten,
            this.khoa,
            this.DTB});
            this.dataGridView1.Location = new System.Drawing.Point(382, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(406, 261);
            this.dataGridView1.TabIndex = 8;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(77, 328);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 9;
            this.them.Text = "them";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(158, 328);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 10;
            this.sua.Text = "sua";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(255, 328);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 11;
            this.xoa.Text = "xoa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // masinhvien
            // 
            this.masinhvien.HeaderText = "MÃ SINH VIÊN";
            this.masinhvien.MinimumWidth = 6;
            this.masinhvien.Name = "masinhvien";
            this.masinhvien.Width = 125;
            // 
            // ten
            // 
            this.ten.HeaderText = "TÊN";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // khoa
            // 
            this.khoa.HeaderText = "KHOA";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 125;
            // 
            // DTB
            // 
            this.DTB.HeaderText = "DIEM TB";
            this.DTB.MinimumWidth = 6;
            this.DTB.Name = "DTB";
            this.DTB.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dienTrungBinh);
            this.Controls.Add(this.hoTen);
            this.Controls.Add(this.masv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox masv;
        private System.Windows.Forms.RichTextBox hoTen;
        private System.Windows.Forms.RichTextBox dienTrungBinh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
    }
}

