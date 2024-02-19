using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using TravelExpertsData;
using TravelExpertsGUI;

namespace TravelExpertsGUI
{
    public partial class frmAddProductToPackage : Form
    {
        public int productSupplierId;
        public TravelExpertsContext context = new();

        public frmAddProductToPackage()
        {
            InitializeComponent();
        }
        private void frmAddProductToPackage_Load(object sender, EventArgs e)
        {
            GetAllProducts();
            GetAllSuppliers();
            buildTable();
            GetAllPackages();


        }

        public void buildTable()
        {
            var connection = new SqlConnection(@"Server=LOCALHOST\SQLEXPRESS;Database=TravelExperts;Trusted_connection=True; TrustServerCertificate=True");

            connection.Open();
            string SQL = "select pk.PackageId, PkgName, p.ProductId, ProdName, s.SupplierId, SupName\r\nfrom Products p join Products_Suppliers ps on p.ProductId = ps.ProductId\r\n                join Suppliers s on s.SupplierId = ps.SupplierId\r\n\t\t\t\tjoin Packages_Products_Suppliers pps on pps.ProductSupplierId = ps.ProductSupplierId\r\n\t\t\t\tjoin Packages pk on pk.PackageId = pps.PackageId";
            var cmd = new SqlCommand(SQL, connection);
            var dataReader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dataReader);
            dgvPkgProduct.DataSource = table;

            dgvPkgProduct.EnableHeadersVisualStyles = false;
            dgvPkgProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
            dgvPkgProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            dgvPkgProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            dgvPkgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Packages height of headers
            dgvPkgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPkgProduct.ColumnHeadersHeight = 35;
            dgvPkgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Packages background color of data gridview
            dgvPkgProduct.BackgroundColor = Color.FloralWhite;

            // Packagesrid of row headers 
            dgvPkgProduct.RowHeadersVisible = false;

        }

        private void cboProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboProduct.SelectedValue);

            cboSupplier.DataSource = null;

            cboSupplier.DataSource = (from s in context.Suppliers
                                      join ps in context.ProductsSuppliers
                                      on s.SupplierId equals ps.SupplierId
                                      where ps.ProductId == id
                                      select new { s.SupName, s.SupplierId, ps.ProductId }).ToList();
            cboSupplier.DisplayMember = "SupName";
            cboSupplier.ValueMember = "SupplierId";
            cboSupplier.SelectedIndex = -1;
        }

        private void cboSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedValue != null && cboSupplier.SelectedValue != null)
            {
                int productId = Convert.ToInt32(cboProduct.SelectedValue);
                int supplierId = Convert.ToInt32(cboSupplier.SelectedValue);

                productSupplierId = (from ps in context.ProductsSuppliers
                                     where ps.ProductId == productId && ps.SupplierId == supplierId
                                     select ps.ProductSupplierId)
                        .FirstOrDefault();
            }
        }

        private void GetAllProducts()
        {
            var productList = context.Products.Select(x => new { ProductId = x.ProductId, ProdName = x.ProdName }).ToList();
            productList.Insert(0, new { ProductId = 0, ProdName = "Select Product" });

            cboProduct.DisplayMember = "ProdName";
            cboProduct.ValueMember = "ProductId";
            cboProduct.DataSource = productList;
        }

        private void GetAllSuppliers()
        {
            var supplierList = (from s in context.Suppliers
                                join ps in context.ProductsSuppliers
                                on s.SupplierId equals ps.SupplierId
                                select new { s.SupName, s.SupplierId, ps.ProductId }).ToList();

            supplierList.Insert(0, new { SupName = "Select Supplier", SupplierId = 0, ProductId = (int?)null });

            cboSupplier.DisplayMember = "SupName";
            cboSupplier.ValueMember = "SupplierId";
            cboSupplier.DataSource = supplierList;
            cboSupplier.SelectedIndex = 0; // Set the default "Select Supplier" option
        }

        private void GetAllPackages()
        {
            var packageList = context.Packages.ToList();

            packageList.Insert(0, new Package { PkgName = "Select Package", PackageId = 0 });

            cboPkg.DisplayMember = "PkgName";
            cboPkg.ValueMember = "PackageId";
            cboPkg.DataSource = packageList;
            cboPkg.SelectedIndex = 0; // Set the default "Select Package" option
        }

        private void cboPkg_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboPkg.SelectedValue != null)
            {
                int packageId = Convert.ToInt32(cboPkg.SelectedValue);

            }
        }

        private void AddProduct()
        {
            try
            {
                if (cboPkg.SelectedValue != null && cboSupplier.SelectedValue != null && productSupplierId != 0)
                {
                    int packageId = Convert.ToInt32(cboPkg.SelectedValue);

                    // Add product supplier to package
                    context.Database.ExecuteSqlRaw($"INSERT INTO Packages_Products_Suppliers (PackageId, ProductSupplierId) VALUES ({packageId}, {productSupplierId})");

                    // Refresh the table or perform any other necessary actions
                    buildTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
    }
}


 
    
