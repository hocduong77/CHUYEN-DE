namespace CHUYENDE
{
    partial class CheckRole
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
            this.message = new System.Windows.Forms.Label();
            this.addsv = new System.Windows.Forms.Button();
            this.addGV = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(236, 61);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(76, 13);
            this.message.TabIndex = 0;
            this.message.Text = "cau thong bao";
            // 
            // addsv
            // 
            this.addsv.Location = new System.Drawing.Point(159, 131);
            this.addsv.Name = "addsv";
            this.addsv.Size = new System.Drawing.Size(95, 23);
            this.addsv.TabIndex = 1;
            this.addsv.Text = "Thêm sinh viên";
            this.addsv.UseVisualStyleBackColor = true;
            this.addsv.Click += new System.EventHandler(this.addsv_Click);
            // 
            // addGV
            // 
            this.addGV.Location = new System.Drawing.Point(293, 131);
            this.addGV.Name = "addGV";
            this.addGV.Size = new System.Drawing.Size(75, 23);
            this.addGV.TabIndex = 2;
            this.addGV.Text = "Thêm giảng viên";
            this.addGV.UseVisualStyleBackColor = true;
            this.addGV.Click += new System.EventHandler(this.addGV_Click);
            // 
            // backup
            // 
            this.backup.Location = new System.Drawing.Point(407, 131);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(75, 23);
            this.backup.TabIndex = 3;
            this.backup.Text = "Backup";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // CheckRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 262);
            this.Controls.Add(this.backup);
            this.Controls.Add(this.addGV);
            this.Controls.Add(this.addsv);
            this.Controls.Add(this.message);
            this.Name = "CheckRole";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CheckRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button addsv;
        private System.Windows.Forms.Button addGV;
        private System.Windows.Forms.Button backup;
    }
}

