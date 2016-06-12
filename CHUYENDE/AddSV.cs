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
        ArrayList listSV = new ArrayList();
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
            getListSV(lop1.maLop);
            foreach (SinhVien sinhvien in listSV)
            {
                dsSV.Items.Add(sinhvien.MASV);               
            }
           
            //dsSV.SelectedIndex =0;
            this.dsSV.SelectedIndexChanged +=
           new System.EventHandler(ComboBoxSV_SelectedIndexChanged);
        }

        private void getListSV(string malop){
            dsSV.Items.Clear();
            listSV.Clear();
            String strLenh = "DS_SINHVIEN '" + malop + "'";
            Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
             while (Program.myreader.Read()) {             
                SinhVien sinhvien = new SinhVien();
                sinhvien.MASV = Program.myreader.GetString(0);
                sinhvien.HO = Program.myreader.GetString(1);
                sinhvien.TEN = Program.myreader.GetString(2);
                sinhvien.MALOP = Program.myreader.GetString(3);
                sinhvien.PHAI = Program.myreader.GetBoolean(4);
                sinhvien.NGAYSINH = Program.myreader.GetDateTime(5).ToShortDateString();
                sinhvien.NOISINH = Program.myreader.GetString(6);
                sinhvien.DIACHI = Program.myreader.GetString(7);
                sinhvien.GHICHU = Program.myreader.GetString(8);
                sinhvien.NGHIHOC = Program.myreader.GetBoolean(9);
                listSV.Add(sinhvien);

            }
            Program.myreader.Close();
           // dsSV.SelectedIndex = 0;
        }
        private SinhVien displaySV(int index)
        {           
            SinhVien sinhvien = (SinhVien)listSV[index];
            hosv.Text = sinhvien.HO;
            tensv.Text = sinhvien.TEN;
            malop.Text = sinhvien.MALOP;
            noisinh.Text = sinhvien.NOISINH;
            diachi.Text = sinhvien.DIACHI;
            ghichu.Text = sinhvien.GHICHU;
            ngaysinh.Text = sinhvien.NGAYSINH;
            phai.Checked = sinhvien.PHAI;
            nghihoc.Checked = sinhvien.NGHIHOC;
            return sinhvien;
        }
        private void ComboBoxSV_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {
            int index = dsSV.SelectedIndex;
            // Console.WriteLine("index" + index);
            SinhVien sinhvien = displaySV(index);           
        }

        private void ComboBox1_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {
            int index = dslop.SelectedIndex;
           // Console.WriteLine("index" + index);
            Lop lop1 = (Lop)listLop[index];
            tenlop.Text = lop1.TenLop;
            getListSV(lop1.maLop);
            foreach (SinhVien sinhvien in listSV)
            {
                dsSV.Items.Add(sinhvien.MASV);
            }
           // dsSV.SelectedIndex = 0;
        }

        private void addsv_Click(object sender, EventArgs e)
        {
            /*
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
             */
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

        private void xoaSV_Click(object sender, EventArgs e)
        {
            
            String strLenh = "DELETE_SV '" + dsSV.SelectedItem.ToString() + "'";
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
            MessageBox.Show("xoa sinh vien thanh cong", "", MessageBoxButtons.OK);
        
        }

        private void ghiSV_Click(object sender, EventArgs e)
        {
            int isphai = 0;
            if (phai.Checked)
            {
                isphai = 1;
            }
            int isnghihoc = 0;
            if (nghihoc.Checked)
            {
                isnghihoc = 1;
            }
            // strLenh = "INSERT INTO SINHVIEN (MASV, HO, TEN, MALOP, PHAI, NGAYSINH, NOISINH, DIACHI, GHICHU, NGHIHOC) VALUES(" + masv.Text + ",'" + hosv.Text + "','" + tensv.Text + "','" + malop.Text + "',"+isphai+",'" + ngaysinh.Text + "','" + noisinh.Text
            //     + "','" + diachi.Text + "','" + ghichu.Text + "', 0)" ;
            string strLenh = "UPDATE_SINHVIEN '" + dsSV.SelectedItem.ToString() + "','" + hosv.Text + "','" + tensv.Text + "','" + malop.Text + "'," + isphai + ",'" + ngaysinh.Text + "','" + noisinh.Text
                + "','" + diachi.Text + "','" + ghichu.Text + "'," + isnghihoc;
            Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
            MessageBox.Show("UPDATE SINH VIEN THANH CONG");
            Program.myreader.Close();
        }

        private void phSV_Click(object sender, EventArgs e)
        {
            int index = dsSV.SelectedIndex;
            // Console.WriteLine("index" + index);
            SinhVien sinhvien = displaySV(index);   
        }
        
    }
}
