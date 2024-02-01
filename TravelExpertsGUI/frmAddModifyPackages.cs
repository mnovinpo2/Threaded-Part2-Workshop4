using TravelExpertsData;

namespace TravelExpertsPackageMaintenance
{
    public partial class frmAddModifyPackages : Form
    {
        public bool isAdd;
        public Package? package;

        public frmAddModifyPackages()
        {
            InitializeComponent();
        }

        public void frmAddModify_Load(object sender, EventArgs e)
        {
            // Add operation enables Product Code Entry
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
                dtpSDate.Text = package.PkgStartDate.ToString();
                dtpEDate.Text = package.PkgEndDate.ToString();
                txtPrice.Text = package.PkgBasePrice.ToString();
                txtCom.Text = package.PkgAgencyCommission.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                package = new TravelExpertsData.Package(); // creates empty object
                GetPackageData();
            }
            else // Modify
            {
                // product is not null
                GetPackageData();
            }
            DialogResult = DialogResult.OK; // closes the form
        }

        private void GetPackageData()
        {
            if (package != null)
            {
                package.PackageId = Convert.ToInt32(txtPkgId.Text);
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



