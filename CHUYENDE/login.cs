using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CHUYENDE
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            Load += new EventHandler(login_Load);

        }
        public static String tensv;
        public static String nhom;
        private void login_Load(object sender, System.EventArgs e)
        {
            Console.Out.WriteLine("runnnn");
            try
            {
                var localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                var rk = localMachine.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server");
               // var instances = (String[])rk.GetValue("InstalledInstances");


               // RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server");
                String[] instances = (String[])rk.GetValue("InstalledInstances");
                if (instances.Length > 0){
                    foreach (String element in instances){
                        if (element == "MSSQLSERVER")
                        {
                            server.Items.Add(System.Environment.MachineName);
                        }
                        else {
                            server.Items.Add(System.Environment.MachineName + @"\" + element);
                        }
                    }
                   
                }
                server.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("no server valid", " message", MessageBoxButtons.OK);
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            Program.mLogin = username.Text;
            Program.password = pass.Text;
            Program.servername = server.SelectedItem.ToString();
            if (Program.KetNoi() == 0) {
                return ;
            }
            String strLenh = "SELECT name from sys.sysusers where sid = SUSER_sID('" + Program.mLogin + "')";
            Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
            Program.myreader.Read();
            Program.username = Program.myreader.GetString(0); // get user name
            if (Convert.IsDBNull(Program.username)) {
                MessageBox.Show("username invalid role in database","", MessageBoxButtons.OK);
                return;
            }
            Program.myreader.Close();
            strLenh = "sp_helpuser '" + Program.username + "'";

            // sp return username groupname loginname DfDBname userid sid

            try {
                Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
            }
            catch(InvalidOperationException ex){
                MessageBox.Show("username donot have role", "", MessageBoxButtons.OK);
                return;
            }
            //get groupname frome username
            if (Program.myreader.Read())
            {
                Program.mGroup = Program.myreader.GetString(1);
            }
            else {
                MessageBox.Show("error define user role", "", MessageBoxButtons.OK);
            }
            Program.myreader.Close();

            // get ho ten frome username
            strLenh = "Select HO +' '+ TEN as HoTen from SINHVIEN where MASV = " + Program.username;
            Program.myreader = Program.execSqlDataReader(strLenh, Program.connsrt);
            if (Program.myreader.HasRows)
            {
                Program.myreader.Read();
                Program.mHoten = Program.myreader.GetString(0);
            }
            else { 
            MessageBox.Show("loginname not link to sinhvien","", MessageBoxButtons.OK);
            Program.myreader.Close();
            Program.conn.Close();
            return;
            }

            Program.myreader.Close();
           // Program.conn.Close();
            tensv = "ho ten sv " + Program.mHoten;
            nhom = "nhom " + Program.mGroup;
            CheckRole f1 = new CheckRole();
            f1.Show();
            this.Hide();
        }
    }
}
