using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TravelExpertsData;

public record PackagesDTO(int PackageId, string PkgName, DateTime? PkgStartDate, DateTime pkgEndDate, string PkgDesc, decimal PkgBasePrice, decimal PkgCom);


namespace TravelExpertsGUI
{

    public partial class frmPackageMain : Form
    {
        private TravelExpertsContext context = new();
        private Package? selectedPackage = null;

        public frmPackageMain()
        {
            InitializeComponent();
        }

        private void PackageMain_Load(object sender, EventArgs e)
        {
            DisplayPackage();
            EditPackage();
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        public List<PackagesDTO> GetAllpackages() =>
                context.Packages
            .OrderBy(p => p.PackageId).Select(p => new PackagesDTO(p.PackageId, p.PkgName, p.PkgStartDate, p.PkgEndDate, p.PkgDesc!, p.PkgBasePrice, p.PkgAgencyCommission)).ToList();




        private void btnGet_Click(object sender, EventArgs e)
        {
            //if (//Validator.IsPresent(txtGet)) // if valid ProductCode
            //)
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
                            MessageBox.Show
                                ($"There is no Product with ID = {pkgID}");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while retrieving product data: " + ex.Message,
                        "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message,
                        ex.GetType().ToString());
                }
            }

        }

        public void EditPackage()
        {
            var connection = new SqlConnection(@"Server=LOCALHOST\SQLEXPRESS;Database=TravelExperts;Trusted_connection=True; TrustServerCertificate=True");

            connection.Open();
            string SQL = "select pk.PackageId, PkgName, p.ProductId, ProdName, s.SupplierId, SupName\r\nfrom Products p join Products_Suppliers ps on p.ProductId = ps.ProductId\r\n                join Suppliers s on s.SupplierId = ps.SupplierId\r\n\t\t\t\tjoin Packages_Products_Suppliers pps on pps.ProductSupplierId = ps.ProductSupplierId\r\n\t\t\t\tjoin Packages pk on pk.PackageId = pps.PackageId";
            var cmd = new SqlCommand(SQL, connection);
            var dataReader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dataReader);
            dgv1.DataSource = table;
        }

        private void DisplayPackage()
        {
            dgvPackages.Columns.Clear();
            dgvPackages.DataSource = GetAllpackages();
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


                // enable Modify and Delete
                btnModify.Enabled = true;
                btnDelete.Enabled = true;


            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyPackage secondForm = new();
            secondForm.isAdd = true;
            secondForm.package = null;


            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK)
            {

                try
                {
                    if (selectedPackage == null)
                    {
                        selectedPackage = secondForm.package;
                        context.Packages.Add(selectedPackage);
                        context.SaveChanges();
                        DisplayPackage();
                    }

                    var packageId = context.Packages.FirstOrDefault(x => x.PkgName == secondForm.package.PkgName).PackageId;
                    var productSupplierId = secondForm.productSupplierId;
                    
                    // Add product supplier to package
                    context.Database.ExecuteSql($"INSERT INTO Packages_Products_Suppliers VALUES({packageId}, {productSupplierId})");

                    EditPackage();

                }
                catch (DbUpdateException ex)
                {
                    string msg = "";
                    var sqlException =
                        (SqlException)ex.InnerException!;
                    foreach (SqlError error in sqlException.Errors)
                    {
                        msg += $"ERROR CODE {error.Number}: {error.Message}\n";
                    }
                    MessageBox.Show(msg, "Database Error");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while adding product: " + ex.Message,
                        "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message,
                        ex.GetType().ToString());
                }

            }
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyPackage secondForm =
                new frmAddModifyPackage();
            secondForm.isAdd = false;
            secondForm.package = selectedPackage;



            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK) // second form collected new data
            {
                // perform the update
                try
                {
                    if (secondForm.package != null)
                    {
                        context.Packages.Update(secondForm.package);
                        context.SaveChanges();
                        DisplayPackage();
                    }
                }
                catch (DbUpdateException ex)
                {
                    string msg = "";
                    var sqlException =
                        (SqlException)ex.InnerException!;
                    foreach (SqlError error in sqlException.Errors)
                    {
                        msg += $"ERROR CODE {error.Number}: {error.Message}\n";
                    }
                    MessageBox.Show(msg, "Database Error");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while modifying product: " + ex.Message,
                        "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message,
                        ex.GetType().ToString());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPackage != null)
            {
                // get the user's confirmation
                DialogResult answer = MessageBox.Show(
                    $"Do you really want to delete {selectedPackage.PkgName}",
                    "Confirm delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) // user confirmed
                {
                    // perform delete
                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            db.Packages.Remove(selectedPackage);
                            db.SaveChanges();
                            selectedPackage = null;
                            ClearControls();
                            DisplayPackage();
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        string msg = "";
                        var sqlException =
                            (SqlException)ex.InnerException!;
                        foreach (SqlError error in sqlException.Errors)
                        {
                            msg += $"ERROR CODE {error.Number}:{error.Message}\n";
                        }
                        MessageBox.Show(msg, "Database Error");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error while deleting customer: " + ex.Message,
                            "Database Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unanticipated error: " + ex.Message,
                            ex.GetType().ToString());
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
            // disable Modify and Delete
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            txtGetPkg.Focus(); // facilitate selecting another Product
        }
    }
}





