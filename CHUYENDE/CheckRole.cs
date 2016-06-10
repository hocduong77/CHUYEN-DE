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
    public partial class CheckRole : Form
    {
        public CheckRole()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //name.Text = login.tensv;
           // group.Text = login.nhom;

            if (Program.mGroup == "QUANLY")
            {
                message.Text = "XIN CHAO QUAN LY " ;
                addsv.Visible = true;
            }
            else {
                message.Text = "XIN CHAO SINH VIEN " ;
                addsv.Visible = false;
            }
        }

        private void addsv_Click(object sender, EventArgs e)
        {
            F_AddSV addsv = new F_AddSV();
            addsv.Show();
            this.Hide();
        }
    }
}
