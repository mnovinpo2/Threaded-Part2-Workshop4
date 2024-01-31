using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class frmAddModifyProduct : Form
    {
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        public Product prod { get; set; } = null!;

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (prod == null)
            {
                Text = "Add Product";
                lblProducts.Visible = false;
                txtProductID.Visible = false;
                prod = new(); // instantiate product on add operation
            }
            else
            {
                Text = "Edit Product";
                txtProductID.Visible = true;
                txtProductID.Enabled = false;
                txtProductID.BackColor = Color.Silver;
                DisplayProduct();
            }
        }

        private void DisplayProduct()
        {
            txtProductID.Text = prod.ProductId.ToString();
            txtProductName.Text = prod.ProdName;
        }
        private void SetProducts()
        {
            prod.ProdName = txtProductName.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SetProducts();
            DialogResult = DialogResult.OK;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
