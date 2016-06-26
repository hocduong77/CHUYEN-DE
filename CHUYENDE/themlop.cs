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
    public partial class themlop : Form
    {
        public themlop()
        {
            InitializeComponent();
        }

        private void huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luu_Click(object sender, EventArgs e)
        {
          
            String strLenh = "ADD_LOP '" + malop.Text + "','" + tenlop.Text + "'";
            try
            {
                Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
            }
            catch (System.Data.SqlClient.SqlException exception)
            {  
                MessageBox.Show(exception.Number.ToString(), "", MessageBoxButtons.OK);
                return;
            }
            if (null !=Program.myreader)
            {
                Program.myreader.Close();
                MessageBox.Show("them lop thanh cong", "", MessageBoxButtons.OK);
            }
            //Parent.Refresh();
            //F_AddSV.Getlop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
