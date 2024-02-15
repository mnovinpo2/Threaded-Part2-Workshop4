
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelExpertsData;
using TravelExpertsGUI;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public record PackagesDTO(int PackageId, string PkgName, DateTime PkgStartDate, DateTime pkgEndDate, string PkgDesc, decimal PkgBasePrice, decimal PkgCom);



namespace TravelExpertsPackageMaintenance
{



    public partial class frmPackageMain : Form
    {
        private TravelExpertsContext context = new();
        private Package? selectedPackage = null;

        public DbSet<Package> Packages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        // Property to hold productSupplierId
        public int ProductSupplierId { get; set; }

        public frmPackageMain()
        {
            InitializeComponent();
        }

        private void PackageMain_Load(object sender, EventArgs e)
        {
            DisplayPackage();
            btnModify.Enabled = false;
            btnDelete.Enabled = false;




        }

        public List<PackagesDTO> GetAllPackages() =>
                context.Packages
            .OrderBy(p => p.PackageId).Select(p => new PackagesDTO(p.PackageId, p.PkgName, p.PkgStartDate, p.PkgEndDate, p.PkgDesc, p.PkgBasePrice, p.PkgAgencyCommission)).ToList();

        private bool IsValidData()
        {
            bool success = true;
            string error = null;

            //error += Validator.IsPresent(txtGetPkg);
            //error += Validator.IsNonNegativeInt(txtGetPkg);

            if (!string.IsNullOrEmpty(error))
            {
                success = false;
                MessageBox.Show(error, "Entry Error");
            }

            return success;
        }


        private void btnGet_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    int pkgID = Convert.ToInt32(txtGetPkg.Text);
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        selectedPackage = db.Packages.Find(pkgID);
                        if (selectedPackage != null)
                        {
                            DisplayPackage();
                        }
                        else
                        {
                            MessageBox.Show($"There is no Package with ID = {pkgID}");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while retrieving package data: " + ex.Message, "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        //public void EditPackage()
        //{
        //    var connection = new SqlConnection(@"Server=LOCALHOST\SQLEXPRESS;Database=TravelExperts;Trusted_connection=True; TrustServerCertificate=True");

        //    connection.Open();
        //    string SQL = "select pk.PackageId, PkgName, p.ProductId, ProdName, s.SupplierId, SupName\r\nfrom Products p join Products_Suppliers ps on p.ProductId = ps.ProductId\r\n                join Suppliers s on s.SupplierId = ps.SupplierId\r\n\t\t\t\tjoin Packages_Products_Suppliers pps on pps.ProductSupplierId = ps.ProductSupplierId\r\n\t\t\t\tjoin Packages pk on pk.PackageId = pps.PackageId";
        //    var cmd = new SqlCommand(SQL, connection);
        //    var dataReader = cmd.ExecuteReader();
        //    DataTable table = new DataTable();
        //    table.Load(dataReader);
        //    dgv1.DataSource = table;
        //}

        private void DisplayPackage()
        {
            dgvPackages.Columns.Clear();
            dgvPackages.DataSource = GetAllPackages();
            dgvPackages.Columns[5].DefaultCellStyle.Format = "c";
            dgvPackages.Columns[6].DefaultCellStyle.Format = "c";
            dgvPackages.DefaultCellStyle.Font = new Font("Sanscript", 10);
            dgvPackages.ColumnHeadersDefaultCellStyle.Font = new Font("Sanscript", 10, FontStyle.Bold);
            dgvPackages.AutoResizeColumns();

            if (selectedPackage != null)
            {
                txtPkgId.Text = selectedPackage.PackageId.ToString();
                txtPkgName.Text = selectedPackage.PkgName;
                txtPkgDesc.Text = selectedPackage.PkgDesc;
                txtSDate.Text = selectedPackage.PkgStartDate.ToShortDateString();
                txtEDate.Text = selectedPackage.PkgEndDate.ToShortDateString();
                txtPrice.Text = selectedPackage.PkgBasePrice.ToString("c");
                txtCom.Text = selectedPackage.PkgAgencyCommission.ToString("c");

                // Enable Modify and Delete
                btnModify.Enabled = true;
                btnDelete.Enabled = true;


            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyPackage secondForm = new frmAddModifyPackage();
            secondForm.isAdd = true;
            secondForm.package = selectedPackage;

            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Continue with other operations using ProductSupplierId
                try
                {
                    // ... (update package in the database) 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while modifying package: " + ex.Message, "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message, ex.GetType().ToString());
                }
            }
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyPackage secondForm = new frmAddModifyPackage();
            secondForm.isAdd = false;
            secondForm.package = selectedPackage;

            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Continue with other operations using ProductSupplierId
                try
                {
                    // ... (update package in the database) 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while modifying package: " + ex.Message, "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPackage != null)
            {
                DialogResult answer = MessageBox.Show(
                    $"Do you really want to delete {selectedPackage.PkgName}",
                    "Confirm delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    try
                    {

                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            string deleteJoinTableQuery = $"DELETE FROM Packages_Products_Suppliers WHERE PackageId = {selectedPackage.PackageId}";
                            db.Database.ExecuteSqlRaw(deleteJoinTableQuery);

                            db.Packages.Remove(selectedPackage);
                            db.SaveChanges();

                            selectedPackage = null;
                            ClearControls();
                            DisplayPackage();
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error while deleting package: " + ex.Message, "Database Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unanticipated error: " + ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }
        // Clears Controls and prepares for new CRUD Entry
        private void ClearControls()
        {
            txtPkgId.Text = "";
            txtPkgName.Text = "";
            txtPkgDesc.Text = "";
            txtSDate.Text = "";
            txtEDate.Text = "";
            txtGetPkg.Text = "";
            txtPrice.Text = "";
            txtCom.Text = "";

            // Disable Modify and Delete
            btnModify.Enabled = false;
            btnDelete.Enabled = false;

            txtGetPkg.Focus(); // Facilitate selecting another Package
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            frmAddProductToPackage secondForm = new frmAddProductToPackage();
            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ProductSupplierId = secondForm.productSupplierId;

                // Continue with other operations using ProductSupplierId
                try
                {
                    // ... (add package and product supplier to database)

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while adding package: " + ex.Message, "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message, ex.GetType().ToString());
                }

            }
        }

    //    frmAddProductToPackage addProductForm = new frmAddProductToPackage();

    //        DialogResult result = addProductForm.ShowDialog();

    //        if (result == DialogResult.OK)
    //        {
    //            ProductSupplierId = secondForm.productSupplierId;

    //            // Continue with other operations using ProductSupplierId
    //            try
    //            {
    //                // ... (add package and product supplier to database)

    //            }
    //            catch (DbUpdateException ex)
    //            {
    //            }
    //            catch (SqlException ex)
    //            {
    //                MessageBox.Show("Error while adding package: " + ex.Message, "Database Error");
    //            }
    //            catch (Exception ex)
    //            {
    //                MessageBox.Show("Unanticipated error: " + ex.Message, ex.GetType().ToString());
    //            }

    //        }
    //    }
    //}
    }
}




