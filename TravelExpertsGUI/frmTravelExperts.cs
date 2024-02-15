using TravelExpertsData;
using TravelExpertsPackageMaintenance;

namespace TravelExpertsGUI
{
	public partial class frmTravelExperts : Form
	{
		private bool EditPrdFrm { get; set; } = false;
		private bool EditPkgFrm { get; set; } = false;
		private bool EditSupFrm { get; set; } = false;
		private bool EditPrdSupFrm { get; set; } = false;
		public frmTravelExperts()
		{
			InitializeComponent();
		}

		private void frmTravelExperts_Load(object sender, EventArgs e)
		{
			EditPkgFrm = true;
			btnFrm.Text = "Edit Packages";
			CurrentControl(usrCtrlPackagesFrm, btnPackageFrm);
		}

		private void btnPackageFrm_Click(object sender, EventArgs e)
		{
			EditPkgFrm = true;
			EditSupFrm = false;
			EditPrdSupFrm = false;
			EditPrdFrm = false;
			btnFrm.Text = "Edit Packages";
			CurrentControl(usrCtrlPackagesFrm, btnPackageFrm);
		}

		private void btnProductsFrm_Click(object sender, EventArgs e)
		{
			EditPkgFrm = false;
			EditSupFrm = false;
			EditPrdSupFrm = false;
			EditPrdFrm = true;
			btnFrm.Text = "Edit Products";
			CurrentControl(usrCtrlProductsFrm, btnProductsFrm);
		}
		private void btnSuppliersFrm_Click(object sender, EventArgs e)
		{
			EditPkgFrm = false;
			EditSupFrm = true;
			EditPrdSupFrm = false;
			EditPrdFrm = false;
			btnFrm.Text = "Edit Suppliers";
			CurrentControl(usrCtrlSuppliersFrm, btnSuppliersFrm);
		}

		private void btnProdSup_Click(object sender, EventArgs e)
		{
			EditPkgFrm = false;
			EditSupFrm = false;
			EditPrdSupFrm = true;
			EditPrdFrm = false;
			btnFrm.Text = "Edit Product Suppliers";
			CurrentControl(usrCtrlProductSuppliersFrm, btnProdSup);
		}
		private void CurrentControl(UserControl userControl, Button btn)
		{
			// setting all user controls to hidden
			usrCtrlPackagesFrm.Visible = false;
			usrCtrlProductsFrm.Visible = false;
			usrCtrlSuppliersFrm.Visible = false;
			usrCtrlProductSuppliersFrm.Visible = false;

			// setting all buttons to white
			btnProductsFrm.BackColor = Color.White;
			btnPackageFrm.BackColor = Color.White;
			btnSuppliersFrm.BackColor = Color.White;
			btnProdSup.BackColor = Color.White;

			// setting active user controls and buttons
			userControl.Visible = true;
			btn.BackColor = Color.CornflowerBlue;
		}



		private void btnFrm_Click(object sender, EventArgs e)
		{
			if (EditPkgFrm)
			{
                frmPackageMain frmPkg = new();
				DialogResult result = frmPkg.ShowDialog();
				if (result == DialogResult.OK)
				{
					usrCtrlPackagesFrm.DisplayPackages();
				}
			}
			else if (EditPrdFrm)
			{
				frmProducts frmProd = new();
				DialogResult result = frmProd.ShowDialog();
				if (result == DialogResult.OK)
				{
					usrCtrlProductsFrm.DisplayProducts();
				}
			}
			else if (EditSupFrm)
			{
				frmSuppliersMain frmSup = new();
				DialogResult result = frmSup.ShowDialog();
				if (result == DialogResult.OK)
				{
					usrCtrlSuppliersFrm.DisplaySuppliers();
				}
			}
			else if (EditPrdSupFrm)
			{
				frmProductSupplierMaintenance frmProdSup = new();
				DialogResult result = frmProdSup.ShowDialog();
				if (result == DialogResult.OK)
				{
					usrCtrlProductSuppliersFrm.DisplayProductSuppliers();
				}
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
