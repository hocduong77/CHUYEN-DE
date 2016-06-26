namespace CHUYENDE
{
    partial class themGV
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
            this.phai = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maGV = new System.Windows.Forms.TextBox();
            this.ngaysinh = new System.Windows.Forms.TextBox();
            this.ho = new System.Windows.Forms.TextBox();
            this.ten = new System.Windows.Forms.TextBox();
            this.noisinh = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // phai
            // 
            this.phai.AutoSize = true;
            this.phai.Location = new System.Drawing.Point(321, 76);
            this.phai.Name = "phai";
            this.phai.Size = new System.Drawing.Size(47, 17);
            this.phai.TabIndex = 3;
            this.phai.Text = "Phái";
            this.phai.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh (mm/dd/yy)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nơi sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa chỉ";
            // 
            // maGV
            // 
            this.maGV.Location = new System.Drawing.Point(129, 33);
            this.maGV.Name = "maGV";
            this.maGV.Size = new System.Drawing.Size(115, 20);
            this.maGV.TabIndex = 7;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(129, 76);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(115, 20);
            this.ngaysinh.TabIndex = 8;
            // 
            // ho
            // 
            this.ho.Location = new System.Drawing.Point(321, 33);
            this.ho.Name = "ho";
            this.ho.Size = new System.Drawing.Size(100, 20);
            this.ho.TabIndex = 9;
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(470, 36);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(96, 20);
            this.ten.TabIndex = 10;
            // 
            // noisinh
            // 
            this.noisinh.Location = new System.Drawing.Point(321, 116);
            this.noisinh.Name = "noisinh";
            this.noisinh.Size = new System.Drawing.Size(100, 20);
            this.noisinh.TabIndex = 11;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(129, 120);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(115, 20);
            this.diachi.TabIndex = 12;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(240, 191);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 13;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // themGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 262);
            this.Controls.Add(this.add);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.noisinh);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.ho);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.maGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "themGV";
            this.Text = "themGV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox phai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maGV;
        private System.Windows.Forms.TextBox ngaysinh;
        private System.Windows.Forms.TextBox ho;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.TextBox noisinh;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.Button add;
    }
}