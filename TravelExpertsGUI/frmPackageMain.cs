
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelExpertsData;
using TravelExpertsGUI;
using static Azure.Core.HttpHeader;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public record PackagesDTO(int PackageId, string PkgName, DateTime PkgStartDate, DateTime pkgEndDate, // DTO for simplified package information
    string PkgDesc, decimal PkgBasePrice, decimal PkgCom);



namespace TravelExpertsPackageMaintenance
{



    public partial class frmPackageMain : Form
    {
        private readonly TravelExpertsContext context = new();
        private TravelExpertsData.Package selectedPackage; // Use alias here

        public DbSet<TravelExpertsData.Package> Packages { get; set; }
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
            LoadPackages(); //calls method to populate a combo box with available packages.
            DisplayPackage(); // calls method to display the selected package.
            DisableModifyDeleteButtons();
        }

        private void LoadPackages() // populates dropdownlist cboGetPkg with Package names.
        {
            try
            {
                List<TravelExpertsData.Package> packages = context.Packages.ToList();
                packages.Insert(0, new TravelExpertsData.Package { PackageId = 0, PkgName = "Choose a Package" });
                cboGetPkg.DataSource = packages;
                cboGetPkg.DisplayMember = "PkgName";
                cboGetPkg.ValueMember = "PackageId";
                cboGetPkg.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading packages");
            }
        }

        public List<PackagesDTO> GetAllPackages() => //Retrieves a list of all packages as PackagesDTO objects.
             context.Packages
                 .OrderBy(p => p.PackageId)
                 .Select(p => new PackagesDTO(p.PackageId, p.PkgName, p.PkgStartDate, p.PkgEndDate, p.PkgDesc, p.PkgBasePrice, p.PkgAgencyCommission))
                 .ToList();

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

        private void DisplayPackage(TravelExpertsData.Package package = null)
        {
            dgvPackages.Columns.Clear();
            dgvPackages.DataSource = GetAllPackages();
            dgvPackages.Columns[5].DefaultCellStyle.Format = "c";
            dgvPackages.Columns[6].DefaultCellStyle.Format = "c";
            dgvPackages.DefaultCellStyle.Font = new Font("Sanscript", 10);
            dgvPackages.AutoResizeColumns();
            dgvPackages.EnableHeadersVisualStyles = false;
            dgvPackages.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
            dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            dgvPackages.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPackages.ColumnHeadersHeight = 35;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPackages.BackgroundColor = Color.FloralWhite;
            dgvPackages.RowHeadersVisible = false;
            UpdateControls(package);
            EnableModifyDeleteButtons();
   

        }
        private void UpdateControls(TravelExpertsData.Package package)
        {
            if (package != null)
            {
                txtPkgId.Text = package.PackageId.ToString();
                txtPkgName.Text = package.PkgName;
                txtPkgDesc.Text = package.PkgDesc;
                txtSDate.Text = package.PkgStartDate.ToShortDateString();
                txtEDate.Text = package.PkgEndDate.ToShortDateString();
                txtPrice.Text = package.PkgBasePrice.ToString("c");
                txtCom.Text = package.PkgAgencyCommission.ToString("c");
            }
        }
        public bool IsDuplicatePackageName(string packageName)
        {
            // Check if there is any other package with the same name
            return context.Packages.Any(p => p.PkgName == packageName);
        }


        private void btnAdd_Click(object sender, EventArgs e) //Opens a new form (frmAddModifyPackage) for adding a new package.
        {
            using (var secondForm = new frmAddModifyPackage())
            {
                secondForm.isAdd = true;

                if (secondForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedPackage = secondForm.package;
                        selectedPackage.PkgStartDate = selectedPackage.PkgStartDate.Date;
                        selectedPackage.PkgEndDate = selectedPackage.PkgEndDate.Date;

                        if (!IsValidPackage(selectedPackage))
                        {
                            // Display a more specific error message based on the validation failure
                            return;
                        }

                        context.Packages.Add(selectedPackage);
                        context.SaveChanges();

                        LoadPackages();
                        DisplayPackage(selectedPackage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding package: {ex.Message}", "Database Error");
                    }
                }
            }
        }

        // Validation method for the package
        private bool IsValidPackage(TravelExpertsData.Package package)
        {
            if (string.IsNullOrWhiteSpace(package.PkgName))
            {
                MessageBox.Show("Package Name cannot be empty.", "Validation Error");
                return false;
            }

            if (IsDuplicatePackageName(package.PkgName))
            {
                MessageBox.Show("Error adding package: Package with the same name already exists.", "Duplicate Package Name");
                return false;
            }

            // Add any additional validation checks here

            return true;
        }

        private void btnModify_Click(object sender, EventArgs e) //Opens a new form (frmAddModifyPackage) for modifying an existing package.
                                                                 //Checks for duplicate package names and updates the modified package in the database.
        {
            // Ensure a package is selected in the combo box
            if (cboGetPkg.SelectedIndex > 0)
            {
                // Retrieve the selected package from the combo box
                TravelExpertsData.Package selectedPackage = (TravelExpertsData.Package)cboGetPkg.SelectedItem;

                // Open the modify form
                frmAddModifyPackage modifyForm = new frmAddModifyPackage();
                modifyForm.isAdd = false;
                modifyForm.package = selectedPackage;

                DialogResult result = modifyForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        // Check for a duplicate package name
                        if (IsDuplicatePackageName(modifyForm.package.PkgName) && modifyForm.package.PkgName != selectedPackage.PkgName)
                        {
                            MessageBox.Show("Error modifying package: Package with the same name already exists.", "Duplicate Package Name");
                        }
                        else
                        {
                            modifyForm.package.PkgStartDate = modifyForm.package.PkgStartDate.Date;
                            modifyForm.package.PkgEndDate = modifyForm.package.PkgEndDate.Date;

                            // Update the selected package with the modified data
                            selectedPackage.PkgName = modifyForm.package.PkgName;
                            selectedPackage.PkgDesc = modifyForm.package.PkgDesc;
                            selectedPackage.PkgStartDate = modifyForm.package.PkgStartDate;
                            selectedPackage.PkgEndDate = modifyForm.package.PkgEndDate;
                            selectedPackage.PkgBasePrice = modifyForm.package.PkgBasePrice;
                            selectedPackage.PkgAgencyCommission = modifyForm.package.PkgAgencyCommission;

                            context.Entry(selectedPackage).State = EntityState.Modified;
                            context.SaveChanges();

                            // Refresh the display with the updated information
                            LoadPackages();
                            DisplayPackage(selectedPackage);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error modifying package: " + ex.Message, ex.GetType().ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a package from the dropdown.", "Selection Error");
            }
        }




        private void btnDelete_Click(object sender, EventArgs e) //Deletes the selected package from the database after confirming with the user.
        {
            // Ensure a package is selected in the combo box
            if (cboGetPkg.SelectedIndex > 0)  // Assuming index 0 is reserved for "Choose a Package"
            {
                // Retrieve the selected package from the combo box
                TravelExpertsData.Package selectedPackage = (TravelExpertsData.Package)cboGetPkg.SelectedItem;

                DialogResult answer = MessageBox.Show(
                    $"Do you really want to delete {selectedPackage.PkgName}?",
                    "Confirm delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            // Delete related records from join table
                            string deleteJoinTableQuery = $"DELETE FROM Packages_Products_Suppliers WHERE PackageId = {selectedPackage.PackageId}";
                            db.Database.ExecuteSqlRaw(deleteJoinTableQuery);

                            // Remove the selected package from the database
                            db.Packages.Remove(selectedPackage);
                            db.SaveChanges();

                            // Clear controls and refresh the display
                            selectedPackage = null;
                            ClearControls();
                            LoadPackages();
                        }
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
            else
            {
                MessageBox.Show("Please select a package from the dropdown.", "Selection Error");
            }
        }
        // Clears various controls on the form.
        private void ClearControls()
        {
            txtPkgId.Text = "";
            txtPkgName.Text = "";
            txtPkgDesc.Text = "";
            txtSDate.Text = "";
            txtEDate.Text = "";
            txtPrice.Text = "";
            txtCom.Text = "";
            DisableModifyDeleteButtons();
        }

        private void EnableModifyDeleteButtons() //Enable the Modify and Delete buttons based on the current state.
        {
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void DisableModifyDeleteButtons() //disable the Modify and Delete buttons based on the current state.
        {
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void btnAddProducts_Click(object sender, EventArgs e) //Opens a new form frmAddProductToPackage for adding products to a package.
        {
            frmAddProductToPackage secondForm = new frmAddProductToPackage();
            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ProductSupplierId = secondForm.productSupplierId;

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


        private void btnOk_Click(object sender, EventArgs e) // Closes the form with a DialogResult of OK.
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void cboGetPkg_SelectedIndexChanged(object sender, EventArgs e) //Handles the event when the selected index changes in the packages combo box.
                                                                                //Calls DisplayPackage and adjusts the visibility of controls based on the selected package.
        {
            try
            {
                if (cboGetPkg.SelectedItem is TravelExpertsData.Package selectedPackage)
                {
                    DisplayPackage(selectedPackage);
                    if (cboGetPkg.SelectedIndex == 0 && cboGetPkg.Text == "Choose a Package")
                    {
                        gbPkgInfo.Visible = false; // Set the visibility of the group box to false
                        DisableModifyDeleteButtons(); // Disable Modify and Delete buttons
                    }
                    else
                    {
                        gbPkgInfo.Visible = true; // Set the visibility of the group box to true
                        EnableModifyDeleteButtons(); // Enable Modify and Delete buttons
                    }
                }
                else
                {
                    ClearControls();
                    MessageBox.Show("Please select a Package from the dropdown.");
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
}

    







