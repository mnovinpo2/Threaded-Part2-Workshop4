using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing.Text;
using TravelExpertsData;
using System.Globalization; // Add this line
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsGUI
{
    public partial class frmAddModifyPackage : Form
    {
        public bool isAdd;
        public Package? package;
        public TravelExpertsContext context = new();
        public bool isModified; 

        public frmAddModifyPackage()
        {
            InitializeComponent();
        }

        public void frmAddModify_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Text = "Add Package";
            }
            else // Modify operation
            {
                Text = "Modify Package";
                DisplayPackage();
            }
        }
        private void DisplayPackage() // Populate form fields with existing package data when modifying said package
        {
            if (package != null)
            {
                txtPkgName.Text = package.PkgName;
                txtPkgDesc.Text = package.PkgDesc;
                dtpSDate.Value = package.PkgStartDate;
                dtpEDate.Value = package.PkgEndDate;
                txtPrice.Text = package.PkgBasePrice.ToString("F2");
                txtCom.Text = package.PkgAgencyCommission.ToString("F2");
            }
        }

        private void GetPackageData() // updates package with data from form fields
        {
            if (package != null)
            {
                package.PkgName = txtPkgName.Text;
                package.PkgDesc = txtPkgDesc.Text;
                package.PkgStartDate = dtpSDate.Value;
                package.PkgEndDate = dtpEDate.Value;
                package.PkgBasePrice = Convert.ToDecimal(txtPrice.Text);
                package.PkgAgencyCommission = Convert.ToDecimal(txtCom.Text);
            }
        }

        private bool IsValidData() // Validates the data 
        {
            bool success = true;
            string error = null;

            error += Validator.IsPresent(txtPkgName);
            error += Validator.IsPresent(txtPkgDesc);
            error += Validator.IsPresent(txtPrice);
            error += Validator.IsNonNegativeDecimal(txtPrice);
            error += Validator.IsPresent(txtCom);
            error += Validator.IsNonNegativeDecimal(txtCom);
            error += Validator.IsValidDate(dtpSDate, dtpEDate);

            if (Convert.ToDecimal(txtCom.Text) > Convert.ToDecimal(txtPrice.Text))
            {
                error += "Agency Commission cannot be larger than Package Price.";
            }

            if (!string.IsNullOrEmpty(error))
            {
                success = false;
                MessageBox.Show(error, "Entry Error");
            }
            return success;
        }

        private void btnOK_Click(object sender, EventArgs e) // If adding a new package (isAdd is true) Creates a new Package object, populates it with data using                                                          GetPackageData, and adds it to the context.
        {
            if (IsValidData())
            {
                if (isAdd)
                {
                    
                    package = new Package();
                    GetPackageData();
                    context.Packages.Add(package);
                }
                else // Modify operation
                {
                    GetPackageData();
                }

                try
                {
                    context.SaveChanges();
                    isModified = !isAdd; // Set isModified to true when modifying a package
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving package: " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) 
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}