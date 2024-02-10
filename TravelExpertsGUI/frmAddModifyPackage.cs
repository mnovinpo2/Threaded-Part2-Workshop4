using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.Data;
using System.Drawing.Text;
using TravelExpertsData;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Package = TravelExpertsData.Package;


namespace TravelExpertsGUI
{
    public partial class frmAddModifyPackage : Form
    {
        public bool isAdd;
        public Package? package;
        public int productSupplierId;
        public TravelExpertsContext context = new();
        public void GetAllProducts()
        {
            //cboProduct.DataSource = (from p in context.Products
            //                          select new { p.ProductId, p.ProdName}).ToList();
            //cboProduct.DisplayMember = "ProdName";
            //cboProduct.ValueMember = "ProductId";

            cboProduct.DataSource = context.Products.Select(x => new { ProductId = x.ProductId, ProdName = x.ProdName }).ToList();
            cboProduct.DisplayMember = "ProdName";
            cboProduct.ValueMember = "ProductId";

            int id = Convert.ToInt32(cboProduct.SelectedValue);

        }

        public void GetAllSuppliers()
        {
            cboSupplier.DataSource = (from s in context.Suppliers
                                      join ps in context.ProductsSuppliers
                                      on s.SupplierId equals ps.SupplierId
                                      select new { s.SupName, s.SupplierId, ps.ProductId, }).ToList();
            cboSupplier.DisplayMember = "SupName";
            cboSupplier.ValueMember = "SupplierId";
        }



        public frmAddModifyPackage()
        {
            InitializeComponent();
        }
        public void frmAddModify_Load(object sender, EventArgs e)
        {
            GetAllProducts();
            GetAllSuppliers();

            if (isAdd)
            {
                Text = "Add Package";
                DisplayPackage();
                txtPkgId.Enabled = true;
            }
            else // Modify operation
            {
                Text = "Modify Product";
                DisplayPackage();
                txtPkgId.Enabled = false;
            }
        }

        private void DisplayPackage()
        {
            if (package != null)
            {
                txtPkgId.Text = package.PackageId.ToString();
                txtPkgName.Text = package.PkgName;
                txtPkgDesc.Text = package.PkgDesc;
                dtpSDate.Text = package.PkgStartDate.ToShortDateString();
                dtpEDate.Text = package.PkgEndDate.ToShortDateString();
                txtPrice.Text = package.PkgBasePrice.ToString();
                txtCom.Text = package.PkgAgencyCommission.ToString();
            }
        }
        private bool IsValidData()
        {
            bool success = true;
            string error = null;

            error += Validator.IsPresent(txtPkgId);
            error += Validator.IsNonNegativeInt(txtPkgId);
            if (Validator.IsNonNegativeInt(txtPkgId) == "")
            {
                error += Validator.IsValidPackageID(txtPkgId);
            }

            error += Validator.IsPresent(txtPkgName);
            error += Validator.IsPresent(txtPkgDesc);
            error += Validator.IsPresent(txtPrice);
            error += Validator.IsNonNegativeInt(txtPrice);
            error += Validator.IsPresent(txtCom);
            error += Validator.IsNonNegativeInt(txtCom);
            error += Validator.IsValidDate(dtpSDate, dtpEDate);

            if (!string.IsNullOrEmpty(error))
            {
                success = false;
                MessageBox.Show(error, "Entry Error");
            }
            return success;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

            if (isAdd &&
                IsValidData()) // check if start date is before end date and not the same as end date
            {
                package = new Package(); // creates empty object
                GetPackageData();
                DialogResult = DialogResult.OK; // closes the form
            }
            else if (IsValidData()) // Modify
            {
                // product is not null
                GetPackageData();
                DialogResult = DialogResult.OK; // closes the form
            }
            
        }

        private void GetPackageData()
        {
            if (package != null)
            {
                package.PkgName = txtPkgName.Text;
                package.PkgDesc = txtPkgDesc.Text;
                package.PkgStartDate = dtpSDate.Value;
                package.PkgEndDate = dtpEDate.Value;
                package.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
                package.PkgAgencyCommission = Convert.ToDecimal(txtCom.Text);
                DisplayPackage();

            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void cboProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboProduct.SelectedValue);
            cboSupplier.DataSource = (from s in context.Suppliers
                                      join ps in context.ProductsSuppliers
                                      on s.SupplierId equals ps.SupplierId
                                      where ps.ProductId == id
                                      select new { s.SupName, s.SupplierId, ps.ProductId }).ToList();
            cboSupplier.DisplayMember = "SupName";
            cboSupplier.ValueMember = "SupplierId";
        }


        public void cboSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedValue != null && cboSupplier.SelectedValue != null)
            {
                int productId = Convert.ToInt32(cboProduct.SelectedValue);
                int supplierId = Convert.ToInt32(cboSupplier.SelectedValue);

                // Assuming prodSupplierId is a class-level variable to store the result
                productSupplierId = (from ps in context.ProductsSuppliers
                            where ps.ProductId == productId && ps.SupplierId == supplierId
                            select ps.ProductSupplierId)
                        .FirstOrDefault();
            }
        }
    }
}

