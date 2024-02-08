using TravelExpertsData;

namespace TravelExpertsGUI
{
	public partial class frmTravelExperts : Form
	{
		public frmTravelExperts()
		{
			InitializeComponent();
		}

		private void btnProductsFrm_Click(object sender, EventArgs e)
		{
			frmProducts fp = new();
			fp.ShowDialog();
		}

		private void btnPackageFrm_Click(object sender, EventArgs e)
		{
			frmPackageMain fpm = new();
			fpm.ShowDialog();
		}

		private void btnSuppliersFrm_Click(object sender, EventArgs e)
		{
			TemporaryMainForm fs = new();
			fs.ShowDialog();
		}

		private void btnProdSup_Click(object sender, EventArgs e)
		{
			frmProductSupplierMaintenance fpsm = new();
			fpsm.ShowDialog();
		}
	}
}
