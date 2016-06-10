using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CHUYENDE
{
    public partial class F_AddSV : Form
    {
        public F_AddSV()
        {
            InitializeComponent();
            Load += new EventHandler(F_AddSV_Load);
        }
        ArrayList listLop = new ArrayList();
        private void F_AddSV_Load(object sender, System.EventArgs e)
        {
            

            String strLenh = "DS_LOP ";
            Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
            while (Program.myreader.Read()) {             
                Lop lop = new Lop();
                lop.maLop = Program.myreader.GetString(0);
                lop.TenLop = Program.myreader.GetString(1);
                listLop.Add(lop);

            }
            Program.myreader.Close();
            foreach (Lop lop in listLop)
            {
                dslop.Items.Add(lop.maLop);               
            }
            dslop.SelectedIndex = 0;
            Lop lop1 = (Lop)listLop[0];
            tenlop.Text = lop1.TenLop;
            this.dslop.SelectedIndexChanged +=
            new System.EventHandler(ComboBox1_SelectedIndexChanged);
        }

        private void ComboBox1_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {
            int index = dslop.SelectedIndex;
            Console.WriteLine("index" + index);
            Lop lop1 = (Lop)listLop[index];
            tenlop.Text = lop1.TenLop;
        }

        private void addsv_Click(object sender, EventArgs e)
        {
            
            String strLenh = "TAO_LOGIN '" + loginName.Text + "','" + pass.Text + "','" + masv.Text + "','" + "SINHVIEN" + "'";
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
            // strLenh = "INSERT INTO SINHVIEN (MASV, HO, TEN, MALOP, PHAI, NGAYSINH, NOISINH, DIACHI, GHICHU, NGHIHOC) VALUES(" + masv.Text + ",'" + hosv.Text + "','" + tensv.Text + "','" + malop.Text + "',"+isphai+",'" + ngaysinh.Text + "','" + noisinh.Text
           //     + "','" + diachi.Text + "','" + ghichu.Text + "', 0)" ;
            strLenh = "ADD_SV '" + masv.Text + "','" + hosv.Text + "','" + tensv.Text + "','" + malop.Text + "',"+isphai+",'" + ngaysinh.Text + "','" + noisinh.Text
                + "','" + diachi.Text + "','" + ghichu.Text + "'," + isnghihoc ;
            Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
            MessageBox.Show("insert thanh cong ");
            Program.myreader.Close();
        }

        private void themLop_Click(object sender, EventArgs e)
        {
            themlop adddLop = new themlop();
            adddLop.ShowDialog(this);
        }

        private void ghiLop_Click(object sender, EventArgs e)
        {            
            String strLenh = "UPDATE_LOP '" + dslop.SelectedItem.ToString() + "','" + tenlop.Text + "'";
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
            MessageBox.Show("sua ten lop thanh cong", "", MessageBoxButtons.OK);
        }

        private void phLop_Click(object sender, EventArgs e)
        {
            int index = dslop.SelectedIndex;
            Console.WriteLine("index" + index);
            Lop lop1 = (Lop)listLop[index];
            tenlop.Text = lop1.TenLop;
        }

        private void xoaLop_Click(object sender, EventArgs e)
        {
            String strLenh = "DELETE_LOP '" + dslop.SelectedItem.ToString() + "'";
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
            MessageBox.Show("xoa lop thanh cong", "", MessageBoxButtons.OK);
        }

        
    }
}
