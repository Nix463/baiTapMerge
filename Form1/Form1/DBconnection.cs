using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    internal class DBconnection
    {
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private SqlConnection Connect {  get; set; }

        public DBconnection() { 
            Connect = new SqlConnection(Properties.Settings.Default.connStr);
        }
        public void ThucThi(string yeuCau)
        {
            try
            {
                // Ket noi
                Connect.Open();

                SqlCommand cmd = new SqlCommand(yeuCau, Connect);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai" + ex);
            }
            finally
            {
                Connect.Close();
            }
        }
        public void open()
        {
            Connect.Open ();
        }
        public void close()
        {
            Connect.Close();
        }
        public SqlConnection GetConnection()
        {
            return Connect;
        }

    }
}
