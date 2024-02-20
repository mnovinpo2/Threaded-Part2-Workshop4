using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelExpertsData;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace TravelExpertsGUI
{
    public partial class frmAddModProductSupplier : Form
    {
        public bool isAdd;
        public ProductsSupplier? productsSupplier;
        private List<Product> products;
        private List<Supplier> suppliers;
        private TravelExpertsContext context = new();
        public frmAddModProductSupplier(List<Product> products, List<Supplier> suppliers)
        {
            InitializeComponent();
            this.products = products;
            this.suppliers = suppliers;
        }
        public frmAddModProductSupplier() : this(new List<Product>(), new List<Supplier>())
        {
        }

        private void frmAddModProductSupplier_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();

            if (isAdd)
            {
                Text = "Add Product Supplier";
                txtProdSupplierId.Enabled = true;
            }
            else // Modify operation
            {
                Text = "Modify Product Supplier";
                txtProdSupplierId.Enabled = false;
                DisplayProductSupplier();
            }
        }
        private void LoadComboBoxes()
        {
            try
            {
                // Load products into the combo box
                List<Product> productList = context.Products.ToList();
                productList.Insert(0, new Product { ProductId = 0, ProdName = "Choose a Product" });
                cboProducts.DataSource = productList;
                cboProducts.DisplayMember = "ProdName";
                cboProducts.ValueMember = "ProductId";
                cboProducts.SelectedIndex = 0;

                // Load suppliers into the combo box
                List<Supplier> supplierList = context.Suppliers.ToList();
                supplierList.Insert(0, new Supplier { SupplierId = 0, SupName = "Choose a Supplier" });
                cboSuppliers.DataSource = supplierList;
                cboSuppliers.DisplayMember = "SupName";
                cboSuppliers.ValueMember = "SupplierId";
                cboSuppliers.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading products or suppliers");
            }
        }
        private void DisplayProductSupplier()
        {
            if (productsSupplier != null)
            {
                txtProdSupplierId.Text = productsSupplier.ProductSupplierId.ToString();
                cboProducts.SelectedValue = productsSupplier.ProductId;
                cboSuppliers.SelectedValue = productsSupplier.SupplierId;
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string error = null;

            // Validate the rest of the data if needed...

            if (!string.IsNullOrEmpty(error))
            {
                success = false;
                MessageBox.Show(error, "Entry Error");
            }
            return success;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (isAdd)
                {
                    productsSupplier = new ProductsSupplier();
                    GetProductSupplierData();
                }
                else // Modify
                {
                    GetProductSupplierData();
                }
                DialogResult = DialogResult.OK;
            }
        }

        //private bool IsValidData()
        //{
        //    bool success = true;
        //    string error = null;

        //    // Commented-out lines removed
        //    // error += Validator.IsPresent(txtProdSupplierId);
        //    // error += Validator.IsNonNegativeInt(txtProdSupplierId);

        //    if (Validator.IsNonNegativeInt(txtProdSupplierId) == "")
        //    {
        //        error += Validator.IsValidProdSupID(txtProdSupplierId);
        //    }

        //    error += Validator.IsPresent(txtProductId);
        //    error += Validator.IsNonNegativeInt(txtProductId);

        //    if (Validator.IsNonNegativeInt(txtProductId) == "")
        //    {
        //        error += Validator.IsExistingProductID(txtProductId);
        //    }

        //    error += Validator.IsPresent(txtSupplierId);
        //    error += Validator.IsNonNegativeInt(txtSupplierId);

        //    if (Validator.IsNonNegativeInt(txtSupplierId) == "")
        //    {
        //        error += Validator.IsExistingSupplierID(txtSupplierId);
        //    }

        //    // Rest of your code...

        //    return success;



        //    if (!string.IsNullOrEmpty(error))
        //    {
        //        success = false;
        //        MessageBox.Show(error, "Entry Error");
        //    }
        //    return success;
        //}

        private void GetProductSupplierData()
        {
            if (productsSupplier != null)
            {
                productsSupplier.ProductId = Convert.ToInt32(cboProducts.SelectedValue);
                productsSupplier.SupplierId = Convert.ToInt32(cboSuppliers.SelectedValue);
                DisplayProductSupplier();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

}
        


