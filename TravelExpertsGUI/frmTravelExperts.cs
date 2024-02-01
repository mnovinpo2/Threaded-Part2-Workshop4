using TravelExpertsData;
using TravelExpertsPackageMaintenance;

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

        private void btnPackagefrm_Click(object sender, EventArgs e)
        {
            frmPackageMain fpm = new();
            fpm.ShowDialog();
        }
    }
}
