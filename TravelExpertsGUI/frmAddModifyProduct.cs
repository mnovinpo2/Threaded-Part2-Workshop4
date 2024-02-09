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
                btnSubmit.Text = "Add Product";
                lblProducts.Visible = false;
                txtProductID.Visible = false;
                prod = new(); // instantiate product on add operation
            }
            else
            {
                Text = "Edit Product";
                btnSubmit.Text = "Edit Product";
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
            if (Validator.IsPresent(txtProductName))
            {
                SetProducts();
				DialogResult = DialogResult.OK;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
