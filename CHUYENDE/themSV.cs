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
    public partial class themSV : Form
    {
        public themSV()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            
           String strLenh = "TAO_LOGIN '" + masv.Text + "','" + "123" + "','" + masv.Text + "','" + "SINHVIEN" + "'";
           try
           {
               Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
           }
           catch (InvalidOperationException ex)
           {
               MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
               return;
           }
           Program.myreader.Close();
           int isphai = 0;
           if (phai.Checked) {
               isphai = 1;
           }
           int isnghihoc = 0;
           if (nghihoc.Checked)
           {
               isnghihoc = 1;
           }
     
           strLenh = "ADD_SV '" + masv.Text + "','" + ho.Text + "','" + ten.Text + "','" + malop.Text + "',"+isphai+",'" + ngaysinh.Text + "','" + noisinh.Text
               + "','" + diachi.Text + "','" + ghichu.Text + "'," + isnghihoc ;
           Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
           MessageBox.Show("insert thanh cong ");
           Program.myreader.Close();
            
        }
    }
}
