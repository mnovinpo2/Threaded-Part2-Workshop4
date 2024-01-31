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
    }
}
