using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS3309F21FP
{
    public partial class frmEditItem : Form
    {
        // Reference to InvoiceLineItem to be edited
        InvoiceLineItem li;

        public frmEditItem()
        {
            InitializeComponent();
        }


        // Form load event handler to get InvoiceLineItem from Tag and put in TextBoxes on Form
        private void frmEditItem_Load(object sender, EventArgs e)
        {
            //*****InvoiceLineItem 1. Add code here
            li = (InvoiceLineItem)Tag;
            //txtProductCode.Text = "7";
            txtProductCode.Text = li.ProductCode;
            txtUnitPrice.Text = li.UnitPrice.ToString();
            txtQuantity.Text = li.Quantity.ToString();
            txtItemTotal.Text = li.ItemTotal.ToString();


            txtProductCode.ReadOnly = true;
            txtItemTotal.ReadOnly = true;
        }


        // Button event handler to commit changes and return to frmMain
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }


        //  Button event handler to cancel changes and return to frmMain
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


        // Text changed event handler for txtUnitPrice
        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            // Calc the unit price for given data in TextBoxes
            CalcItemPrice();
        }


        // Text changed event handler for txtQuantity
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            // Calc the unit price for given data in TextBoxes
            CalcItemPrice();
        }


        // Calc the unit price for given data in TextBoxes
        private void CalcItemPrice()
        {
            // Try to convert txtUnitPrice to an int
            bool okup = Decimal.TryParse(txtUnitPrice.Text, out decimal up);
            // Try to convert txtQuantity to an int
            bool okq = Int32.TryParse(txtQuantity.Text, out int q);
            // If both conversions to int are successful, copy data to li and txtItemTotal
            if (okup && okq)
            {
                // Copy data to li
                //*****InvoiceLineItem 2. Add code here
                li.UnitPrice = Convert.ToDouble(up);
                li.Quantity = q;
                li.ItemTotal = li.UnitPrice * li.Quantity;



                // Copy total to txtItemTotal (li calculates it's own total)
                //*****InvoiceLineItem 3. Add code here
                txtItemTotal.Text = li.ItemTotal.ToString();
            }
        }
    }
}
