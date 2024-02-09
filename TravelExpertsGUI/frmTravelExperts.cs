using TravelExpertsData;

namespace TravelExpertsGUI
{
	public partial class frmTravelExperts : Form
	{
		public bool EditPrdFrm { get; set; } = false;
		public bool EditPkgFrm { get; set; } = false;
		public bool EditSupFrm { get; set; } = false;
		public bool EditPrdSupFrm { get; set; } = false;
		public frmTravelExperts()
		{
			InitializeComponent();
		}

		private void frmTravelExperts_Load(object sender, EventArgs e)
		{
			EditPkgFrm = true;
			btnFrm.Text = "Edit Packages";
			CurrentControl(usrCtrlPackagesFrm);
		}

		private void btnPackageFrm_Click(object sender, EventArgs e)
		{
			EditPkgFrm = true;
			EditSupFrm = false;
			EditPrdSupFrm = false;
			EditPrdFrm = false;
			btnFrm.Text = "Edit Packages";
			CurrentControl(usrCtrlPackagesFrm);
		}

		private void btnProductsFrm_Click(object sender, EventArgs e)
		{
			EditPkgFrm = false;
			EditSupFrm = false;
			EditPrdSupFrm = false;
			EditPrdFrm = true;
			btnFrm.Text = "Edit Products";
			CurrentControl(usrCtrlProductsFrm);
		}
		private void btnSuppliersFrm_Click(object sender, EventArgs e)
		{
			EditPkgFrm = false;
			EditSupFrm = true;
			EditPrdSupFrm = false;
			EditPrdFrm = false;
			btnFrm.Text = "Edit Suppliers";
			CurrentControl(usrCtrlSuppliersFrm);
		}

		private void btnProdSup_Click(object sender, EventArgs e)
		{
			EditPkgFrm = false;
			EditSupFrm = false;
			EditPrdSupFrm = true;
			EditPrdFrm = false;
			btnFrm.Text = "Edit Product Suppliers";
			CurrentControl(usrCtrlProductSuppliersFrm);
		}
		public void CurrentControl(UserControl userControl)
		{
			usrCtrlPackagesFrm.Visible = false;
			usrCtrlProductsFrm.Visible = false;
			usrCtrlSuppliersFrm.Visible = false;
			usrCtrlProductSuppliersFrm.Visible = false;

			userControl.Visible = true;
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

		
	}
}
