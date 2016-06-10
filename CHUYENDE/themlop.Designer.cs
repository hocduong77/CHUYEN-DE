namespace CHUYENDE
{
    partial class themlop
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
            this.malop = new System.Windows.Forms.TextBox();
            this.tenlop = new System.Windows.Forms.TextBox();
            this.luu = new System.Windows.Forms.Button();
            this.huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma Lop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten lop";
            // 
            // malop
            // 
            this.malop.Location = new System.Drawing.Point(115, 43);
            this.malop.Name = "malop";
            this.malop.Size = new System.Drawing.Size(100, 20);
            this.malop.TabIndex = 2;
            // 
            // tenlop
            // 
            this.tenlop.Location = new System.Drawing.Point(115, 90);
            this.tenlop.Name = "tenlop";
            this.tenlop.Size = new System.Drawing.Size(100, 20);
            this.tenlop.TabIndex = 3;
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(52, 180);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 4;
            this.luu.Text = "Luu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // huy
            // 
            this.huy.Location = new System.Drawing.Point(162, 180);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(75, 23);
            this.huy.TabIndex = 5;
            this.huy.Text = "Huy";
            this.huy.UseVisualStyleBackColor = true;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // themlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.huy);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.tenlop);
            this.Controls.Add(this.malop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "themlop";
            this.Text = "themlop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox malop;
        private System.Windows.Forms.TextBox tenlop;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button huy;
    }
}