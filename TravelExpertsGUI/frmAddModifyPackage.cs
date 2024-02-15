using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing.Text;
using TravelExpertsData;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TravelExpertsGUI
{
    public partial class frmAddModifyPackage : Form
    {
        public bool isAdd;
        public Package? package;
        public TravelExpertsContext context = new();

        public frmAddModifyPackage()
        {
            InitializeComponent();
        }

        public void frmAddModify_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Text = "Add Package";
                DisplayPackage();
                txtPkgId.Enabled = true;
            }
            else // Modify operation
            {
                Text = "Modify Package";
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
            if (isAdd && IsValidData())
            {
                package = new Package();
                GetPackageData();
                DialogResult = DialogResult.OK;
            }
            else if (IsValidData())
            {
                GetPackageData();
                DialogResult = DialogResult.OK;
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
    }
}