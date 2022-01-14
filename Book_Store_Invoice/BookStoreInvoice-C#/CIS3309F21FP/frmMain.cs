using System;
using System.Linq;
using System.Windows.Forms;

namespace CIS3309F21FP
{
    public partial class frmMain : Form
    {
        // Declare references to a Customer, a Product, a ProductList, an Invoice and an InvoiceLineItem
        Customer c;
        Product p;
        ProductList pl;
        Invoice i;
        InvoiceLineItem li;

        public frmMain()
        {
            InitializeComponent();
        }

        /* Form initialization and reset*/

        // frmMain load event handler - Sets initial form settings
        private void frmMMABooksPOS_Load(object sender, EventArgs e)
        {
            // Call GetAllProducts to load Products into app
            GetAllProducts();
            // Make all Product TextBoxes read-only.
            txtProductCode.ReadOnly = true;
            txtDescription.ReadOnly = true;
            txtUnitPrice.ReadOnly = true;
            txtOnHandQuantity.ReadOnly = true;
            // Make all Cart TextBoxes read-only.
            txtProductTotal.ReadOnly = true;
            txtSalesTax.ReadOnly = true;
            txtShipping.ReadOnly = true;
            txtInvoiceTotal.ReadOnly = true;
            // Set all Cart Buttons to disabled
            SetCartButtons(false, false, false, false);

            // Instantiate the Invoice
            //*****Invoice 1. Add code here
            i = new Invoice();
            // Set Invoice CustomerID to -1 (Means no Customer for Invoice)
            //*****Invoice 2. Add code here
            i.CustomerID = -1;
            // Set contents of Cart TextBoxes to Zeros (Actually gets zeros from Invoice)
            SetCartTextBoxes();
        }


        // Reset form to initial state
        private void ResetForm()
        {
            // Clear Customer TextBoxes
            ClearCustomerTextBoxes();
            // Call GetAllProducts to load Products into app
            GetAllProducts();

            // Clear invoice
            //*****Invoice 3. Add code here
            i.clear();
            // Clear lstCart
            lstCart.Items.Clear();
            // Set data from Invoice to Cart TextBoxes
            SetCartTextBoxes();
        }




        /* Customer section */

        // Button event handler to find a Customer in DB
        private void btnFindCustomerBy_Click(object sender, EventArgs e)
        {
            // Try to convert CustomerID from string to int
            bool ok = Int32.TryParse(txtCustomerID.Text, out int id);
            // If previous conversion succeeded, add Customer to DB
            if (ok)
            {
                // Declare and instantiate a Customer and get from DB
                //*****Customer 1. Add code here 
                //gets the customer in the datbase based on customerid entered
                int customerId = Convert.ToInt32(txtCustomerID.Text);
                c = CustomerDB.GetCustomer(customerId);
                // If a Customer was found in DB set TextBoxes, Buttons and copy data to TextBoxes
                if (c != null)//*****Customer 2. Add condition here
                {
                    // Set Customer TextBoxes and Buttons
                    SetCustomerTextBoxes(true, true, true, true, true, true);
                    SetCustomerButtons(false, false, true);
                    // Copy data from Customer to TextBoxes in Customer section
                    //*****Customer 3. Add code here
                    txtName.Text = c.Name;
                    txtAddress.Text = c.Address;
                    txtCity.Text = c.City;
                    txtState.Text = c.State;
                    txtZipcode.Text = c.ZipCode;



                    // Copy CustomerID to Invoice CustomerID
                    //*****Invoice 4. Add code here
                    i.CustomerID = c.CustomerId;
                }
                else
                    MessageBox.Show("No record found");
            }
        }

        private void PutCustomerData(Customer c)
        {
            c.Name = txtName.Text;
            c.Address = txtAddress.Text;
            c.City = txtCity.Text;
            c.State = txtState.Text;
            c.ZipCode = txtZipcode.Text;
        }

        // Button event handler to Add a new Customer to DB
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            int maxID = -1;
            // If there is valid data in Customer TextBoxes, add Customer to DB
            if (ValidateCustomerTextBoxes())
            {
                // Instantiate a Customer into c (from class data) from Customer TextBoxes
                //*****Customer 4. Add code here 
                c = new Customer();
                this.PutCustomerData(c);
                // Insert Customer c to DB
                //*****Customer 5. Add code here 
                int result = 0;//***** Add code for Customer 4 here
                int customerId = Convert.ToInt32(txtCustomerID.Text);
                result = CustomerDB.InsertCustomer(txtName.Text, txtAddress.Text, txtCity.Text,
                    txtState.Text, txtZipcode.Text);
                // If insert is successful (returns > 0), get max Customer ID and copy to txtCustomerID
                if (result > 0)
                {
                    //*****Customer 6. Add code here
                    maxID = CustomerDB.GetMaxId();
                    txtCustomerID.Text = maxID.ToString();
                }
                // Set Customer TextBoxes and Buttons
                SetCustomerTextBoxes(true, true, true, true, true, true);
                SetCustomerButtons(false, false, true);
                // Get new CustomerID from DB (It will be the max id) and copy to txtCustomerID
                txtCustomerID.Text = maxID.ToString();
                c.CustomerId = maxID;
                // Copy CustomerID to Invoice CustomerID
                //*****Invoice 5. Add code here
                i.CustomerID = c.CustomerId;
            }
        }


        // Button event handler to clear a Customer from form
        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            // Clear Customer TextBoxes
            ClearCustomerTextBoxes();
            // Set Invoice CustomerID to -1 (Means no Customer for Invoice)
            //*****Invoice 6. Add code here
            i.CustomerID = -1;
        }


        // Set Customer TextBoxes to read-only or read-write
        private void SetCustomerTextBoxes(bool bCID, bool bN, bool bA, bool bC, bool bS, bool bZ)
        {
            txtCustomerID.ReadOnly = bCID;
            txtName.ReadOnly = bN;
            txtAddress.ReadOnly = bA;
            txtCity.ReadOnly = bC;
            txtState.ReadOnly = bS;
            txtZipcode.ReadOnly = bZ;
        }


        // Enable or disable Customer Buttons
        private void SetCustomerButtons(bool bFCBID, bool bANC, bool bCC)
        {
            btnFindCustomerBy.Enabled = bFCBID;
            btnAddNewCustomer.Enabled = bANC;
            btnClearCustomer.Enabled = bCC;
        }


        // Validate data in Customer TestBoxes (Check that TestBoxes are not empty)
        private bool ValidateCustomerTextBoxes()
        {
            if (txtName.Text == "")
                return false;
            if (txtAddress.Text == "")
                return false;
            if (txtCity.Text == "")
                return false;
            if (txtState.Text == "")
                return false;
            if (txtZipcode.Text == "")
                return false;
            return true;
        }


        // Clear Customer TextBoxes
        private void ClearCustomerTextBoxes()
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipcode.Text = "";
            SetCustomerTextBoxes(false, false, false, false, false, false);
            SetCustomerButtons(true, true, true);
        }





        /* Products section */

        // Load Products into app and lstProducts
        private void GetAllProducts()
        {
            // Get all Products from DB
            //*****Product 1. Add code here
            pl = ProductDB.GetAllProducts();
            // Clear all Products from lstProducts
            lstProducts.Items.Clear();
            // Copy new Products to lstProducts
            //*****Product 2. Add code here
            foreach(Product p in pl)
                lstProducts.Items.Add(p.ToString());
            lstProducts.SelectedIndex = 0;
            // Select 
            if (lstCart.Items.Count > 0)
                lstProducts.SelectedIndex = 0;
        }


        // Selected index changed event handler for lstProducts
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected item and copy reference to p (the Product reference from class data)
            //*****Product 3. Add code here
            Product p = pl[lstProducts.SelectedIndex];
            // Copy data from selected item to Product TextBoxes and set txtQuantityToPurchase to empty string
            //*****Product 4. Add code here
            txtProductCode.Text = p.ProductCode;
            txtDescription.Text = p.Description;
            txtUnitPrice.Text = p.Price.ToString();
            txtOnHandQuantity.Text = p.OnHandQuantity.ToString();
            txtQuantityToPurchase.Text = "";
        }

        public bool InCart()
        {
            bool ok = Int32.TryParse(txtQuantityToPurchase.Text, out int qty);
            bool inCart = true;
            p = pl[lstProducts.SelectedIndex];
            foreach (InvoiceLineItem li in i.lineItems)
                if (p.ProductCode == li.ProductCode || p.OnHandQuantity <= qty)
                {
                    inCart = false;
                }
                return inCart;
        }
        // Button event handler to add a Product to Cart
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Try to convert txtQuantityToPurchase from string to int
            bool ok = Int32.TryParse(txtQuantityToPurchase.Text, out int qty);
            double tot = qty * Convert.ToDouble(txtUnitPrice.Text);
            // Declare a bool to check if Product with same ProductCode is in Cart
            bool inCart = false;
            //***** 7. Add code here
            inCart = InCart();
            //MessageBox.Show(InCart().ToString());
                    // If previous conversion succeeded, cart item does not have more book than are in stock
                    // and Product is not in Cart, add Product to Cart
                    //*****Invoice 8. Add code here
                    if (inCart == true)
                {
                    // Calculate cost of all items purchased for this Product (Get UnitPrice from p and qty from TryParse)
                    //*****Invoice 9. Add code here
                    i.ProductTotal = Convert.ToDouble(p.Price) * qty;
                    // Instantiate a new InvoiceLineItem (enter -1 for CustomerID, get ProductCode and UnitPrice from p
                    // and qty from TryParse and tot)
                    //*****Invoice 10. Add code here
                    li = new InvoiceLineItem(-1, p.ProductCode, Convert.ToDouble(p.Price), qty, tot);
                    // Add InvoiceLineItem to Invoice
                    //*****Invoice 11. Add code here
                    i.Add(li);
                    // Add InvoiceLineItem to lstCart
                    //*****Invoice 12. Add code here
                    lstCart.Items.Add(li);
                    // Set data from Invoice to Cart TextBoxes
                    SetCartTextBoxes();
                    // Enable Cart Buttons
                    SetCartButtons(true, true, true, true);
                    if(lstCart.Items.Count > 0)
                        lstCart.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Item was not added to cart.");
                }
        }


        // Resets Product data to current state in DB
        private void ResetProducts()
        {
            // Get all Products from DB and copy new Products to lstProducts
            GetAllProducts();
            // Reset form to initial state
            ResetForm();
        }




        /* Cart section */

        // Button event handler to open a Form to edit the unit price or quantity in Cart
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // Declare and instantiate a Form
            frmEditItem f = new frmEditItem();
            // Copy the selected item in Cart to Form Tag
            f.Tag = lstCart.Items[lstCart.SelectedIndex];
            // Declare a DialogResult
            DialogResult dr;
            // Open form and copy Form DialogResult
            dr = f.ShowDialog();
            // If DialogResult is OK, copy Tag to selected index's element
            if(dr == DialogResult.OK)
            {
                // Copy Tag to selected index's element (Need to use an Indexer)
                lstCart.Items[lstCart.SelectedIndex] = (InvoiceLineItem)f.Tag;

                // Copy Tag to li
                //*****InvoiceLineItem 4. Add code here
                li = (InvoiceLineItem)f.Tag;
                // Copy li to selected index's element (Need to use an Indexer)
                //*****InvoiceLineItem 5. Add code here
                i[lstCart.SelectedIndex] = li;
                // Call UpdateInvoiceLineItem in i to pass new values for lstCart selected index
                //*****Invoice 13. Add code here
                i.UpdateInvoiceLineItem(lstCart.SelectedIndex, li.UnitPrice, li.Quantity);
                // Set data from Invoice to Cart TextBoxes
                SetCartTextBoxes();
            }
        }


        // Button event handler to delete an Product from Cart
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            // Delete Product from Invoice SelectedIndex
            //*****Invoice 14. Add code here
            i.RemoveAt(lstCart.SelectedIndex, li);
            // Delete Product from lstCart
            lstCart.Items.RemoveAt(lstCart.SelectedIndex);
            // If Cart is empty, disable Cart Buttons
            if(lstCart.Items.Count == 0)
                SetCartButtons(false, false, false, false);
            // Set data from Invoice to Cart TextBoxes
            SetCartTextBoxes();
        }


        // Button event handle to clear all Products from Cart
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            // Clear Invoice
            //*****Invoice 15. Add code here
            for(int j = i.lineItems.Count()-1; j >= 0; j--)
            {
                i.RemoveAt(j, li);
            }
            i.clear();
            // Clear lstCart
            lstCart.Items.Clear();
            // Disable Cart Buttons
            SetCartButtons(false, false, false, false);
            // Set data from Invoice to Cart TextBoxes
            SetCartTextBoxes();
        }


        // Button event handler to submit an invoice to DB
        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            // Check to see if a Customer has been found or added (If CustomerID is -1 -> no Customer)
            //*****Invoice 16. Add code here
            if (i.CustomerID == -1)
            {
                MessageBox.Show("Please add or find a customer.");
                return;
            }
            else
            {
                // Insert Invoice to DB
                //*****Invoice 17. Add code here
                i.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                //MessageBox.Show(i.ToString());
                int result = InvoiceDB.InsertInvoice(i);
                MessageBox.Show(result + " Invoices added");
                // Reset form to initial state
                ResetForm();
            }
        }


        // Enable or disable Cart Buttons
        private void SetCartButtons(bool bEI, bool bDI, bool bCC, bool bSO)
        {
            btnEditItem.Enabled = bEI;
            btnDeleteItem.Enabled = bDI;
            btnClearCart.Enabled = bCC;
            btnSubmitOrder.Enabled = bSO;
        }


        // Set data from Invoice to Cart TextBoxes
        private void SetCartTextBoxes()
        {
            // Set data in form
            //*****Invoice 18. Add code here
            if (i == null)
            {
                txtProductTotal.Text = "";
                txtShipping.Text = "";
                txtSalesTax.Text = "";
                txtInvoiceTotal.Text = "";
            }
            else
            {
                txtProductTotal.Text = i.ProductTotal.ToString();
                txtShipping.Text = i.Shipping.ToString();
                txtSalesTax.Text = i.SalesTax.ToString();
                txtInvoiceTotal.Text = i.InvoiceTotal.ToString();
            }
        }


    }
}
