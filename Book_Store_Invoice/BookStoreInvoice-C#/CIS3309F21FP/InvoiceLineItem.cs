using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309F21FP
{
    public class InvoiceLineItem
    {
        public int InvoiceID { get; set; }
        public string ProductCode { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double ItemTotal { get; set; }
        public InvoiceLineItem Li { get; }

        public InvoiceLineItem() { }

        public InvoiceLineItem(int invoiceId, string productCode, double price, int onHandQuantity, double itemTotal)
        {
            this.InvoiceID = invoiceId;
            this.ProductCode = productCode;
            this.UnitPrice = price;
            this.Quantity = onHandQuantity;
            this.ItemTotal = itemTotal;
        }

        public InvoiceLineItem(InvoiceLineItem li)
        {
            Li = li;
        }

        public override string ToString()
        {
            string s = "" + InvoiceID + " " + ProductCode + " " + UnitPrice +
                " " + Quantity + " " + ItemTotal;
            return s;
        }
    }
}
