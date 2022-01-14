using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS3309F21FP
{
    public static class CustomerDB
    {
        public static Customer GetCustomer(int customerId)
        {
            Customer c = null;
            SqlConnection conn = MMABooksDB.GetConnection();
            string cmdText = "Select * From Customers Where CustomerID = " + customerId;
            SqlCommand comm = new SqlCommand(cmdText, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    c = new Customer();
                    c.CustomerId = (int)dr["CustomerID"];
                    c.Name = dr["Name"].ToString();
                    c.Address = dr["Address"].ToString();
                    c.City = dr["City"].ToString();
                    c.State = dr["State"].ToString();
                    c.ZipCode = dr["ZipCode"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                c = null;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return c;
        }

        public static int InsertCustomer(string name, string address,
            string city, string state, string zipCode)
        {
            int result = -1;
            SqlConnection conn = MMABooksDB.GetConnection();
            //sql command to inset a new product into the datbase
            string cmdTxt = "INSERT into Customers (Name, Address, City, State, ZipCode) " +
                "VALUES( @Name, @Address, @City, @State, @ZipCode)";
            SqlCommand comm = new SqlCommand(cmdTxt, conn);
            //adds all the new parameters to the database as a record
            //comm.Parameters.AddWithValue("@CustomerID", customerId);
            comm.Parameters.AddWithValue("@Name", name);
            comm.Parameters.AddWithValue("@Address", address);
            comm.Parameters.AddWithValue("@City", city);
            comm.Parameters.AddWithValue("@State", state);
            comm.Parameters.AddWithValue("@ZipCode", zipCode);
            result = MMABooksDB.ExecuteNonQuery(conn, comm);
            // returns the amount of items inserted should be 1
            return result;
        }
        
        public static int GetMaxId()
        {
            int max = -1;
            SqlConnection conn = MMABooksDB.GetConnection();
            string cmdTxt = "SELECT MAX(CustomerID) FROM Customers";
            SqlCommand comm = new SqlCommand(cmdTxt, conn);
            try
            {
                conn.Open();
                max = (int)comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                max = -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return max;
        }
    }
}
