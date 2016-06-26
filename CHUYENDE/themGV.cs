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
    public partial class themGV : Form
    {
        public themGV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
          
            String strLenh = "TAO_LOGIN '" + maGV.Text + "','" + "123" + "','" + maGV.Text + "','" + "GIANGVIEN" + "'";
            
            try
            {
                Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            if (null != Program.myreader)
            {
                Program.myreader.Close();
            }
            Program.myreader.Close();
            int isphai = 0;
            if (phai.Checked)
            {
                isphai = 1;
            }
            
            strLenh = "ADD_GV '" + maGV.Text + "','" + ho.Text + "','" + ten.Text + "'," + isphai + ",'" + ngaysinh.Text + "','" + noisinh.Text
                + "','" + diachi.Text + "'" ;
            Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
            if (null != Program.myreader)
            {
                Program.myreader.Close();
                MessageBox.Show("thêm giảng viên thành công", "", MessageBoxButtons.OK);
            }
          
        }
    }
}
