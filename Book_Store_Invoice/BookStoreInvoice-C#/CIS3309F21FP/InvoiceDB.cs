using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS3309F21FP
{
    public static class InvoiceDB
    {

        public static int GetMaxID()
        {
            int max = -1;

            SqlConnection conn = MMABooksDB.GetConnection();
            string cmdText = "SELECT MAX(InvoiceID) FROM Invoices";
            SqlCommand comm = new SqlCommand(cmdText, conn);

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
                    conn.Close();
            }

            return max;
        }


        public static int InsertInvoice(Invoice i)
        {
            int n = InsertInvoice(i.CustomerID, i.InvoiceDate, i.ProductTotal, i.SalesTax,
                i.Shipping, i.InvoiceTotal, i);
            return n;
        }


        public static int InsertInvoice(int CustomerID, DateTime InvoiceDate,
            double ProductTotal, double SalesTax, double Shipping, double InvoiceTotal,
            Invoice i)
        {
            int n = -1;
            int m = -1;
            int max = -1;

            SqlConnection conn = MMABooksDB.GetConnection();
            string cmdText = "INSERT INTO Invoices (CustomerID, InvoiceDate," +
                " ProductTotal, SalesTax, Shipping, InvoiceTotal)" +
                " VALUES (@CustomerID, @InvoiceDate," +
                " @ProductTotal, @SalesTax, @Shipping, @InvoiceTotal)";
            SqlCommand comm = new SqlCommand(cmdText, conn);
            comm.Parameters.AddWithValue("@CustomerID", CustomerID);
            comm.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
            comm.Parameters.AddWithValue("@ProductTotal", ProductTotal);
            comm.Parameters.AddWithValue("@SalesTax", SalesTax);
            comm.Parameters.AddWithValue("@Shipping", Shipping);
            comm.Parameters.AddWithValue("@InvoiceTotal", InvoiceTotal);

            try
            {
                conn.Open();
                n = comm.ExecuteNonQuery();
                conn.Close();

                max = GetMaxID();

                foreach (InvoiceLineItem li in i.lineItems)
                {
                    li.InvoiceID = max;
                    m = InsertLineItem(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                n = -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            MessageBox.Show("max = " + max);

            return n;
        }



        public static int InsertLineItem(InvoiceLineItem li)
        {
            int n = InsertLineItem(li.InvoiceID, li.ProductCode, li.UnitPrice,
                li.Quantity, li.ItemTotal);
            return n;
        }


        public static int InsertLineItem(int InvoiceID, String ProductCode,
            double UnitPrice, double Quantity, double ItemTotal)
        {
            int n = -1;

            SqlConnection conn = MMABooksDB.GetConnection();
            string cmdText = "INSERT INTO InvoiceLineItems (InvoiceID, ProductCode," +
                " UnitPrice, Quantity, ItemTotal)" +
                " VALUES (@InvoiceID, @ProductCode," +
                " @UnitPrice, @Quantity, @ItemTotal)";
            SqlCommand comm = new SqlCommand(cmdText, conn);
            comm.Parameters.AddWithValue("@InvoiceID", InvoiceID);
            comm.Parameters.AddWithValue("@ProductCode", ProductCode);
            comm.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            comm.Parameters.AddWithValue("@Quantity", Quantity);
            comm.Parameters.AddWithValue("@ItemTotal", ItemTotal);

            try
            {
                conn.Open();
                n = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                n = -1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            return n;
        }

    }
}

