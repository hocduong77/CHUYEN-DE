using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHUYENDE
{
    public partial class Backup_Restore : Form
    {
        public Backup_Restore()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(backupFile.Text)))
            {
                MessageBox.Show("Thư mục không tồn tại !");
            }
            else
            {
                String strLenh = "BACKUP DATABASE QL_SINHVIEN TO DISK ='" + backupFile.Text + "\\QL_SINHVIEN-" + DateTime.Now.Ticks.ToString() + ".bak'";
                Program.execSqlNonQuery(strLenh, Program.connsrt);
                Program.myreader.Close();
                MessageBox.Show("backup dữ liệu thành công !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                backupFile.Text = dlg.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                restoreFile.Text = dlg.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(restoreFile.Text))
            {
                MessageBox.Show("File không tồn tại !");
            }else{
            String strLenh = "ALTER DATABASE QL_SINHVIEN SET OFFLINE WITH ROLLBACK IMMEDIATE " + "USE master RESTORE DATABASE QL_SINHVIEN FROM DISK  = '" + restoreFile.Text + "'" + "WITH REPLACE ALTER DATABASE QL_SINHVIEN SET ONLINE";
            Program.execSqlNonQuery(strLenh, Program.connsrt);
            Program.myreader.Close();
            MessageBox.Show("Restore dữ liệu thành công !");
            }
            
        }
    }
}
