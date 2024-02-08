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
        public frmAddModProductSupplier()
        {
            InitializeComponent();
        }

        private void frmAddModProductSupplier_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Text = "Add Product Supplier";
                DisplayProductSupplier();
                txtProdSupplierId.Enabled = true;
            }
            else // Modify operation
            {
                Text = "Modify Product Supplier";
                DisplayProductSupplier();
                txtProdSupplierId.Enabled = false;

            }
        }
        private void DisplayProductSupplier()
        {
            if (productsSupplier != null)
            {
                txtProdSupplierId.Text = productsSupplier.ProductSupplierId.ToString();
                txtProductId.Text = productsSupplier.ProductId.ToString(); ;
                txtSupplierId.Text = productsSupplier.SupplierId.ToString(); ;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // validate data
            //if (Validator.IsPresent(txtProdSupplierId) &&
            //    Validator.IsPresent(txtProductId) &&
            //    Validator.IsPresent(txtSupplierId) 
            //    ) //&&

            {
                if (isAdd)
                {
                    productsSupplier = new ProductsSupplier(); // creates empty object
                    GetProductSupplierData();
                }
                else // Modify
                {
                    // product is not null
                    GetProductSupplierData();
                }
                DialogResult = DialogResult.OK; // closes the form
            }
        }
        private void GetProductSupplierData()
        {
            if (productsSupplier != null)
            {
                productsSupplier.ProductSupplierId = Convert.ToInt32(txtProdSupplierId.Text);
                productsSupplier.ProductId = Convert.ToInt32(txtProductId.Text);
                productsSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                DisplayProductSupplier();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

}
        


