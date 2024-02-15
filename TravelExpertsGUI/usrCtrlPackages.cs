using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class usrCtrlPackages : UserControl
    {
        private void usrCtrlPackages_Load(object sender, EventArgs e)
        {
            // Your code to initialize or load data
            DisplayPackages();
        }
        public usrCtrlPackages()
        {

            InitializeComponent();
            Load += usrCtrlPackages_Load;

        }


        public void DisplayPackages()
        {
            dgvPackages.Columns.Clear();
            dgvPackages.DataSource = PackageDB.GetPackages();

            // Packages header and row styles
            dgvPackages.EnableHeadersVisualStyles = false;
            dgvPackages.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
            dgvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            dgvPackages.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            dgvPackages.Columns[5].HeaderText = "Price";
            dgvPackages.Columns[5].DefaultCellStyle.Format = "c";


            dgvPackages.Columns[6].HeaderText = "Commission";
            dgvPackages.Columns[6].DefaultCellStyle.Format = "c";


            dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Packages height of headers
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvPackages.ColumnHeadersHeight = 35;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Packages background color of data gridview
            dgvPackages.BackgroundColor = Color.FloralWhite;

            // Packagesrid of row headers 
            dgvPackages.RowHeadersVisible = false;

        }
    }
}
