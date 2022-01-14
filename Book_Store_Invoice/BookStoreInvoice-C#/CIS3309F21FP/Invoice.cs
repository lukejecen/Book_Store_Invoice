using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CIS3309F21FP
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double ProductTotal { get; set; }
        public double SalesTax { get; set; }
        public double Shipping { get; set; }
        public double InvoiceTotal { get; set; }


        public List<InvoiceLineItem> lineItems;


        public Invoice(int invoiceId, int customerId, DateTime invoiceDate, double productTotal, double salesTax, double shipping, double invoiceTotal)
        {
            this.InvoiceID = invoiceId;
            this.CustomerID = customerId;
            this.InvoiceDate = invoiceDate;
            this.ProductTotal = productTotal;
            this.SalesTax = salesTax;
            this.Shipping = shipping;
            this.InvoiceTotal = invoiceTotal;
        }
        public Invoice()
        {
            lineItems = new List<InvoiceLineItem>();
        }


        public OrderOptions oo;

        readonly OrderOptions oO = OrderOptionsDB.GetOrderOptions();

        public override string ToString()
        {
            string s = "" + InvoiceID + " " + CustomerID + " " + InvoiceDate.ToShortDateString() +
                " " + ProductTotal + " " + SalesTax + " " + Shipping + " " + InvoiceTotal + "\r\n";
            foreach (InvoiceLineItem l in lineItems)
                s += l.ToString() + "\r\n";

            return s;
        }

        public InvoiceLineItem InvoiceLineItems { get; }

        public InvoiceLineItem this[int index]
        {
            get
            {
                return lineItems[index];
            }
            set
            {
                lineItems[index] = value;
            }
        }

        public void UpdateInvoiceLineItem(int index,double unitPrice, int quantity)
        {
            InvoiceLineItem li = lineItems.ElementAt(index);
            li.UnitPrice = unitPrice;
            li.Quantity = quantity;
            CalcAll(li);
        }
        public void SetDate()
        {
            InvoiceDate = DateTime.Now;
        }

        public void Add(InvoiceLineItem li)
        {
            SetDate();
            lineItems.Add(li);
            CalcAll(li);
        }

        public void CalcProductTotal()
        {
            foreach (InvoiceLineItem li in lineItems)
                ProductTotal = li.UnitPrice;
        }
        public void CalcShipping(InvoiceLineItem li)
        {
            foreach (InvoiceLineItem l in lineItems)
            if (li.Quantity == 1)
            {
                Shipping = Convert.ToDouble(oO.FirstBookShipCharge);
            }
            else if(li.Quantity > 1)
            {
                Shipping = (Convert.ToDouble(oO.AdditionalBookShipCharge) * (li.Quantity -1)) + Convert.ToDouble(oO.FirstBookShipCharge);
            }
            else
            {
                Shipping = 0;
            }
        }

        public void CalcSalesTax()
        {
            SalesTax = ProductTotal * Convert.ToDouble(oO.SalesTaxRate);
        }

        public void CalcInvoiceTotal()
        {
            InvoiceTotal = 0;
            foreach (InvoiceLineItem li in lineItems)
                InvoiceTotal += (li.UnitPrice * li.Quantity) + SalesTax + Shipping;
        }

        public void CalcAll(InvoiceLineItem li)
        {
            CalcProductTotal();
            CalcShipping(li);
            CalcSalesTax();
            CalcInvoiceTotal();
        }

        public void RemoveAt(int index, InvoiceLineItem li)
        {
            lineItems.RemoveAt(index);
            CalcAll(li);
        }

        public void clear()
        {
            Invoice i = null;
        }
    }
}
