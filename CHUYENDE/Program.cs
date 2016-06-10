using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CHUYENDE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.Out.WriteLine("runnnn main");
            Application.Run(new login());
        }
        public static SqlConnection conn = new SqlConnection();
        public static String connsrt;
        public static SqlDataAdapter da;
        public static SqlDataReader myreader;
        public static String servername = "";
        public static String username;
        public static String password;
        public static String database = "QL_SINHVIEN";
        public static String mLogin;
        public static String mGroup;
        public static String mHoten;

        public static int KetNoi() {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) {
                Program.conn.Close();
            }
            try
            {
                Program.connsrt = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" + Program.mLogin
                    + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connsrt;
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex) {
                MessageBox.Show("please check username and passord ", "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader execSqlDataReader(String cmd, String connectionString) {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Program.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (Program.conn.State == ConnectionState.Closed) {
                Program.conn.Open();
            }
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (Exception ex) {
                MessageBox.Show("error access database QL_SINHVIEN " + ex.Message);

                Program.conn.Close();
                return null;
            }     
        }

        public static DataTable execSqlQuery(String cmd, String connectionString)
        {
            DataTable tb1 = new DataTable();
            conn = new SqlConnection(connectionString);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(tb1);
            return tb1;
        }

        public static int execSqlNonQuery(String cmd, String connectionString)
        {
            
            conn = new SqlConnection(connectionString);
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (SqlException ex)
            {
                conn.Close();
                return 0;
            }  
        }

        public static void setEnableOfButton(Form fm, Boolean active) {
            foreach (Control ctrl in fm.Controls) {
                if (ctrl is Button)
                {
                    ctrl.Enabled = active;
                }
            }
        
        }

    }
}
