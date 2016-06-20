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
            themSV adddSV = new themSV();
            adddSV.ShowDialog(this);

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
        private string[] Headers = { "MSV", "Họ", "Tên", "Phái", "Ngày sinh", "Nơi sinh", "Dịa chỉ", "Ghi chú" };
        private string[,] Data =
        {
    {"Alice Archer", "1276 Ash Ave", "Ann Arbor", "MI", "12893"},
    {"Bill Blaze", "26157 Beach Blvd", "Boron", "CA", "23617"},
    {"Cindy Carruthers", "352 Cherry Ct", "Chicago", "IL", "35271"},
    {"Dean Dent", "4526 Deerfield Dr", "Denver", "CO", "47848"},
        };
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Font header_font = new Font("Times New Roman",
        16, FontStyle.Bold))
            {
                using (Font body_font = new Font("Times New Roman", 12))
                {
                    // We'll skip this much space between rows.
                    int line_spacing = 20;
                    
                    // See how wide the columns must be.
                    //int[] column_widths = new int[]  { 153,  153, 100, 76, 68};
                    int[] column_widths = new int[] { 76, 100, 76, 76, 120, 100, 100, 100 };
                    // Start at the left margin.
                    int x = 20;

                    // Print by columns.
                    for (int col = 0; col < Headers.Length; col++)
                    {
                       
                        // Print the header.
                        int y = e.MarginBounds.Top;
                        e.Graphics.DrawString(Headers[col],
                            header_font, Brushes.Blue, x, y);
                        y += (int)(line_spacing * 1.5);

                        // Print the items in the column.
                        for (int row = 0; row <
                            listSV.Count; row++)
                        {
                            SinhVien sinhvien = (SinhVien)listSV[row];
                            if (col == 0)
                            {
                                Console.WriteLine("sinhvien.MASV" + sinhvien.MASV);
                                e.Graphics.DrawString(sinhvien.MASV,
                               body_font, Brushes.Black, x, y);
                            }
                            else if (col == 1)
                            {
                                e.Graphics.DrawString(sinhvien.HO,
                                  body_font, Brushes.Black, x, y);
                            }
                            else if (col == 2)
                            {
                                e.Graphics.DrawString(sinhvien.TEN,
                                  body_font, Brushes.Black, x, y);
                            }
                            else if (col == 3)
                            {
                                if (sinhvien.PHAI == true)
                                {
                                    e.Graphics.DrawString("Nam",
                                      body_font, Brushes.Black, x, y);
                                }
                                else {
                                    e.Graphics.DrawString("Nữ",
                                        body_font, Brushes.Black, x, y);
                                }
                            }
                            else if (col == 4)
                            {
                                e.Graphics.DrawString(sinhvien.NGAYSINH,
                                  body_font, Brushes.Black, x, y);
                            }
                            else if (col == 5)
                            {
                                e.Graphics.DrawString(sinhvien.NOISINH,
                                  body_font, Brushes.Black, x, y);
                            }
                            else if (col == 6)
                            {
                                e.Graphics.DrawString(sinhvien.DIACHI,
                                  body_font, Brushes.Black, x, y);
                            }
                            else if (col == 6)
                            {
                                e.Graphics.DrawString(sinhvien.GHICHU,
                                  body_font, Brushes.Black, x, y);
                            }
                            y += line_spacing;
                        }

                        // Move to the next column.
                        x += column_widths[col];
                    } // Looping over columns
                } // using body_font
            } // using header_font

         
            e.HasMorePages = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            
        }

        private void In_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK) {
                printDocument1.Print();
            }
        }
        
    }
}
