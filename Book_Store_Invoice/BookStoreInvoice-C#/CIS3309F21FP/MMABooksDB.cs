using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS3309F21FP
{
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\lukej\source\repos\Cis3309F21FinalProject\Database\MMABooks.mdf; Integrated Security = True; Connect Timeout = 30";
            return new SqlConnection(connStr);
        }

        public static int ExecuteNonQuery(SqlConnection conn, SqlCommand comm)
        {
            int result = -1;
            try
            {
                conn.Open();
                result = comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                result = -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            // returns the amount of items inserted should be 1
            return result;
        }
    }
}
