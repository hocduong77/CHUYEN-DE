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
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            Program.myreader.Close();
            MessageBox.Show("them lop thanh cong", "", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
