namespace CIS3309F21FP
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnFindCustomerBy = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.gbxProducts = new System.Windows.Forms.GroupBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtQuantityToPurchase = new System.Windows.Forms.TextBox();
            this.lblQuantityToPurchase = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.txtOnHandQuantity = new System.Windows.Forms.TextBox();
            this.lblOnHandQuantity = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.gbxCart = new System.Windows.Forms.GroupBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.txtProductTotal = new System.Windows.Forms.TextBox();
            this.lblProductTotal = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.gbxCustomer.SuspendLayout();
            this.gbxProducts.SuspendLayout();
            this.gbxCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.btnClearCustomer);
            this.gbxCustomer.Controls.Add(this.btnAddNewCustomer);
            this.gbxCustomer.Controls.Add(this.btnFindCustomerBy);
            this.gbxCustomer.Controls.Add(this.txtAddress);
            this.gbxCustomer.Controls.Add(this.lblCustomerID);
            this.gbxCustomer.Controls.Add(this.lblAddress);
            this.gbxCustomer.Controls.Add(this.txtCustomerID);
            this.gbxCustomer.Controls.Add(this.txtName);
            this.gbxCustomer.Controls.Add(this.txtZipcode);
            this.gbxCustomer.Controls.Add(this.lblCity);
            this.gbxCustomer.Controls.Add(this.lblName);
            this.gbxCustomer.Controls.Add(this.lblState);
            this.gbxCustomer.Controls.Add(this.txtState);
            this.gbxCustomer.Controls.Add(this.txtCity);
            this.gbxCustomer.Controls.Add(this.lblZipcode);
            this.gbxCustomer.Location = new System.Drawing.Point(32, 29);
            this.gbxCustomer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbxCustomer.Size = new System.Drawing.Size(645, 901);
            this.gbxCustomer.TabIndex = 0;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "Customer";
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Location = new System.Drawing.Point(112, 556);
            this.btnClearCustomer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(397, 55);
            this.btnClearCustomer.TabIndex = 26;
            this.btnClearCustomer.Text = "Clear Customer";
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Location = new System.Drawing.Point(112, 486);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(397, 55);
            this.btnAddNewCustomer.TabIndex = 25;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnFindCustomerBy
            // 
            this.btnFindCustomerBy.Location = new System.Drawing.Point(112, 417);
            this.btnFindCustomerBy.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFindCustomerBy.Name = "btnFindCustomerBy";
            this.btnFindCustomerBy.Size = new System.Drawing.Size(397, 55);
            this.btnFindCustomerBy.TabIndex = 24;
            this.btnFindCustomerBy.Text = "Find Customer By ID";
            this.btnFindCustomerBy.UseVisualStyleBackColor = true;
            this.btnFindCustomerBy.Click += new System.EventHandler(this.btnFindCustomerBy_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(243, 169);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(380, 38);
            this.txtAddress.TabIndex = 17;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(53, 52);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(171, 32);
            this.lblCustomerID.TabIndex = 12;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(107, 176);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(119, 32);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(243, 45);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(260, 38);
            this.txtCustomerID.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 38);
            this.txtName.TabIndex = 15;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(243, 355);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(260, 38);
            this.txtZipcode.TabIndex = 23;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(163, 238);
            this.lblCity.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 32);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(133, 114);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 32);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(141, 300);
            this.lblState.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(82, 32);
            this.lblState.TabIndex = 18;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(243, 293);
            this.txtState.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(260, 38);
            this.txtState.TabIndex = 21;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(243, 231);
            this.txtCity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(260, 38);
            this.txtCity.TabIndex = 19;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(104, 362);
            this.lblZipcode.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(117, 32);
            this.lblZipcode.TabIndex = 20;
            this.lblZipcode.Text = "Zipcode";
            // 
            // gbxProducts
            // 
            this.gbxProducts.Controls.Add(this.btnAddToCart);
            this.gbxProducts.Controls.Add(this.txtQuantityToPurchase);
            this.gbxProducts.Controls.Add(this.lblQuantityToPurchase);
            this.gbxProducts.Controls.Add(this.lstProducts);
            this.gbxProducts.Controls.Add(this.txtOnHandQuantity);
            this.gbxProducts.Controls.Add(this.lblOnHandQuantity);
            this.gbxProducts.Controls.Add(this.txtUnitPrice);
            this.gbxProducts.Controls.Add(this.lblUnitPrice);
            this.gbxProducts.Controls.Add(this.txtDescription);
            this.gbxProducts.Controls.Add(this.lblDescription);
            this.gbxProducts.Controls.Add(this.txtProductCode);
            this.gbxProducts.Controls.Add(this.lblProductCode);
            this.gbxProducts.Location = new System.Drawing.Point(693, 29);
            this.gbxProducts.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbxProducts.Name = "gbxProducts";
            this.gbxProducts.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbxProducts.Size = new System.Drawing.Size(1496, 901);
            this.gbxProducts.TabIndex = 1;
            this.gbxProducts.TabStop = false;
            this.gbxProducts.Text = "Products";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(640, 823);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(309, 55);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtQuantityToPurchase
            // 
            this.txtQuantityToPurchase.Location = new System.Drawing.Point(357, 827);
            this.txtQuantityToPurchase.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtQuantityToPurchase.Name = "txtQuantityToPurchase";
            this.txtQuantityToPurchase.Size = new System.Drawing.Size(260, 38);
            this.txtQuantityToPurchase.TabIndex = 10;
            // 
            // lblQuantityToPurchase
            // 
            this.lblQuantityToPurchase.AutoSize = true;
            this.lblQuantityToPurchase.Location = new System.Drawing.Point(48, 835);
            this.lblQuantityToPurchase.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblQuantityToPurchase.Name = "lblQuantityToPurchase";
            this.lblQuantityToPurchase.Size = new System.Drawing.Size(289, 32);
            this.lblQuantityToPurchase.TabIndex = 9;
            this.lblQuantityToPurchase.Text = "Quantity To Purchase";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 31;
            this.lstProducts.Location = new System.Drawing.Point(56, 45);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(1415, 500);
            this.lstProducts.TabIndex = 8;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // txtOnHandQuantity
            // 
            this.txtOnHandQuantity.Location = new System.Drawing.Point(357, 765);
            this.txtOnHandQuantity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtOnHandQuantity.Name = "txtOnHandQuantity";
            this.txtOnHandQuantity.Size = new System.Drawing.Size(260, 38);
            this.txtOnHandQuantity.TabIndex = 7;
            // 
            // lblOnHandQuantity
            // 
            this.lblOnHandQuantity.AutoSize = true;
            this.lblOnHandQuantity.Location = new System.Drawing.Point(96, 773);
            this.lblOnHandQuantity.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOnHandQuantity.Name = "lblOnHandQuantity";
            this.lblOnHandQuantity.Size = new System.Drawing.Size(242, 32);
            this.lblOnHandQuantity.TabIndex = 6;
            this.lblOnHandQuantity.Text = "On Hand Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(357, 703);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(260, 38);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(200, 711);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(138, 32);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(357, 641);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(585, 38);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(181, 649);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(158, 32);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(357, 579);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(260, 38);
            this.txtProductCode.TabIndex = 1;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(149, 587);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(188, 32);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product Code";
            // 
            // gbxCart
            // 
            this.gbxCart.Controls.Add(this.txtSalesTax);
            this.gbxCart.Controls.Add(this.lblSalesTax);
            this.gbxCart.Controls.Add(this.txtInvoiceTotal);
            this.gbxCart.Controls.Add(this.lblInvoiceTotal);
            this.gbxCart.Controls.Add(this.txtShipping);
            this.gbxCart.Controls.Add(this.lblShipping);
            this.gbxCart.Controls.Add(this.txtProductTotal);
            this.gbxCart.Controls.Add(this.lblProductTotal);
            this.gbxCart.Controls.Add(this.btnSubmitOrder);
            this.gbxCart.Controls.Add(this.btnClearCart);
            this.gbxCart.Controls.Add(this.btnDeleteItem);
            this.gbxCart.Controls.Add(this.btnEditItem);
            this.gbxCart.Controls.Add(this.lstCart);
            this.gbxCart.Location = new System.Drawing.Point(2205, 29);
            this.gbxCart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbxCart.Name = "gbxCart";
            this.gbxCart.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbxCart.Size = new System.Drawing.Size(1240, 901);
            this.gbxCart.TabIndex = 2;
            this.gbxCart.TabStop = false;
            this.gbxCart.Text = "Cart";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(941, 689);
            this.txtSalesTax.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.Size = new System.Drawing.Size(260, 38);
            this.txtSalesTax.TabIndex = 15;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(781, 696);
            this.lblSalesTax.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(141, 32);
            this.lblSalesTax.TabIndex = 14;
            this.lblSalesTax.Text = "Sales Tax";
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(941, 751);
            this.txtInvoiceTotal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.Size = new System.Drawing.Size(260, 38);
            this.txtInvoiceTotal.TabIndex = 13;
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.AutoSize = true;
            this.lblInvoiceTotal.Location = new System.Drawing.Point(741, 758);
            this.lblInvoiceTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(176, 32);
            this.lblInvoiceTotal.TabIndex = 12;
            this.lblInvoiceTotal.Text = "Invoice Total";
            // 
            // txtShipping
            // 
            this.txtShipping.Location = new System.Drawing.Point(307, 751);
            this.txtShipping.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.Size = new System.Drawing.Size(260, 38);
            this.txtShipping.TabIndex = 13;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(163, 758);
            this.lblShipping.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(128, 32);
            this.lblShipping.TabIndex = 12;
            this.lblShipping.Text = "Shipping";
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.Location = new System.Drawing.Point(307, 689);
            this.txtProductTotal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.Size = new System.Drawing.Size(260, 38);
            this.txtProductTotal.TabIndex = 4;
            // 
            // lblProductTotal
            // 
            this.lblProductTotal.AutoSize = true;
            this.lblProductTotal.Location = new System.Drawing.Point(101, 696);
            this.lblProductTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblProductTotal.Name = "lblProductTotal";
            this.lblProductTotal.Size = new System.Drawing.Size(184, 32);
            this.lblProductTotal.TabIndex = 3;
            this.lblProductTotal.Text = "Product Total";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(941, 823);
            this.btnSubmitOrder.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(275, 55);
            this.btnSubmitOrder.TabIndex = 2;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(651, 823);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(275, 55);
            this.btnClearCart.TabIndex = 2;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(307, 823);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(275, 55);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(16, 820);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(275, 55);
            this.btnEditItem.TabIndex = 1;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 31;
            this.lstCart.Location = new System.Drawing.Point(16, 45);
            this.lstCart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(1201, 624);
            this.lstCart.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(3004, 968);
            this.Controls.Add(this.gbxCart);
            this.Controls.Add(this.gbxProducts);
            this.Controls.Add(this.gbxCustomer);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmMain";
            this.Text = "MMA Books Order Entry System";
            this.Load += new System.EventHandler(this.frmMMABooksPOS_Load);
            this.gbxCustomer.ResumeLayout(false);
            this.gbxCustomer.PerformLayout();
            this.gbxProducts.ResumeLayout(false);
            this.gbxProducts.PerformLayout();
            this.gbxCart.ResumeLayout(false);
            this.gbxCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnFindCustomerBy;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.TextBox txtOnHandQuantity;
        private System.Windows.Forms.Label lblOnHandQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtQuantityToPurchase;
        private System.Windows.Forms.Label lblQuantityToPurchase;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.GroupBox gbxCart;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox txtProductTotal;
        private System.Windows.Forms.Label lblProductTotal;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.Label lblShipping;
    }
}