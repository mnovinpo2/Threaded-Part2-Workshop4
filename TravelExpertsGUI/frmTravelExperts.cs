using TravelExpertsData;
using TravelExpertsPackageMaintenance;

namespace TravelExpertsGUI
{
    /// <summary>
	/// Main form
	/// for navigating to other forms 
    /// Author: Mustafa Hersi
    /// Date: Feb 2024
    /// </summary>
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

		/// <summary>
		/// Display Packages info on load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frmTravelExperts_Load(object sender, EventArgs e)
		{
			EditPkgFrm = true;
			btnFrm.Text = "Edit Packages";
			CurrentDGV(dgvPackages, btnPackageFrm);
			Display();
		}

		/// <summary>
		/// Seeting values and bool properties on current clicked button
		/// for each button (packages, products, suppliers, and product suppliers)
		/// </summary>
		private void btnPackageFrm_Click(object sender, EventArgs e)
		{
			EditPkgFrm = true;
			EditSupFrm = false;
			EditPrdSupFrm = false;
			EditPrdFrm = false;
			btnFrm.Text = "Edit Packages";
			CurrentDGV(dgvPackages, btnPackageFrm);
            Display();
        }

        private void btnProductsFrm_Click(object sender, EventArgs e)
		{
			EditPkgFrm = false;
			EditSupFrm = false;
			EditPrdSupFrm = false;
			EditPrdFrm = true;
			btnFrm.Text = "Edit Products";
			CurrentDGV(dgvProducts, btnProductsFrm);
			Display();
		}
		private void btnSuppliersFrm_Click(object sender, EventArgs e)
		{
			EditPkgFrm = false;
			EditSupFrm = true;
			EditPrdSupFrm = false;
			EditPrdFrm = false;
			btnFrm.Text = "Edit Suppliers";
			CurrentDGV(dgvSuppliers, btnSuppliersFrm);
            Display();
        }

        private void btnProdSup_Click(object sender, EventArgs e)
		{
			EditPkgFrm = false;
			EditSupFrm = false;
			EditPrdSupFrm = true;
			EditPrdFrm = false;
			btnFrm.Text = "Edit Product Suppliers";
			CurrentDGV(dgvProductSuppliers, btnProdSup);
            Display();
        }

		/// <summary>
		/// Method to set visisbility of datagridviews and current active button
		/// </summary>
		/// <param name="dgv">for passing the current datagriview and setting to visible</param>
		/// <param name="btn">for seeting the current button to blue</param>
        private void CurrentDGV(DataGridView dgv, Button btn)
		{
			// setting all datagridviews to hidden
			dgvPackages.Visible = false;
			dgvProducts.Visible = false;
			dgvSuppliers.Visible = false;
			dgvProductSuppliers.Visible = false;
			
			// setting all buttons to white for changing active button
			btnProductsFrm.BackColor = Color.White;
			btnPackageFrm.BackColor = Color.White;
			btnSuppliersFrm.BackColor = Color.White;
			btnProdSup.BackColor = Color.White;

			// setting active user controls and buttons
			dgv.Visible = true;
			btn.BackColor = Color.CornflowerBlue;
		}

		/// <summary>
		/// Method to Display items based on clicked button
		/// </summary>
		private void Display()
		{
			if (EditPkgFrm)
                DisplayPackages();
            else if (EditPrdFrm)
				DisplayProducts();
			else if (EditSupFrm)
				DisplaySuppliers();
			else if (EditPrdSupFrm)
				DisplayProductSuppliers();
        }

		/// <summary>
		/// Method to display Packages in datagridview
		/// </summary>
        private void DisplayPackages()
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

			// hide columns
            dgvPackages.Columns[7].Visible = false;
            dgvPackages.Columns[8].Visible = false;


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

        /// <summary>
        /// Method to display products in datagridview
        /// </summary>
        private void DisplayProducts()
        {
            dgvProducts.Columns.Clear();
            dgvProducts.DataSource = ProductsDB.GetProducts();

            // changing header and row styles
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;


			dgvProducts.Columns[0].HeaderText = "Product ID";

			dgvProducts.Columns[1].HeaderText = "Product Name";

			// hide product suppliers column
			dgvProducts.Columns[2].Visible = false;

			// hide grey space in data grid view 
			dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // changing height of headers
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProducts.ColumnHeadersHeight = 35;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // changing background color of data gridview
            dgvProducts.BackgroundColor = Color.FloralWhite;

            // getting rid of row headers 
            dgvProducts.RowHeadersVisible = false;

        }

        /// <summary>
        /// Method to display suppliers in datagridview
        /// </summary>
        private void DisplaySuppliers()
        {
            dgvSuppliers.Columns.Clear();
            dgvSuppliers.DataSource = SupplierDB.GetSupplier();

            // Suplliers header and row styles
            dgvSuppliers.EnableHeadersVisualStyles = false;
            dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
            dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

			// hide columns
            dgvSuppliers.Columns[2].Visible = false;
            dgvSuppliers.Columns[3].Visible = false;

            // Suplliersy space in data grid view 
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Suplliers height of headers
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSuppliers.ColumnHeadersHeight = 35;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // Suplliers background color of data gridview
            dgvSuppliers.BackgroundColor = Color.FloralWhite;
            // Suplliersrid of row headers 
            dgvSuppliers.RowHeadersVisible = false;
        }

        /// <summary>
        /// Method to display product suppliers in datagridview
        /// </summary>
        private void DisplayProductSuppliers()
        {
            dgvProductSuppliers.Columns.Clear();
            dgvProductSuppliers.DataSource = ProductSupplierDB.GetProductSuppliers();

            // changinSuplliers header and row styles
            dgvProductSuppliers.EnableHeadersVisualStyles = false;
            dgvProductSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
            dgvProductSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            dgvProductSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            // hide columns
            dgvProductSuppliers.Columns[3].Visible = false;
            dgvProductSuppliers.Columns[4].Visible = false;
            dgvProductSuppliers.Columns[5].Visible = false;
            dgvProductSuppliers.Columns[6].Visible = false;

            // hide grSuplliersy space in data grid view 
            dgvProductSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // changinSuplliers height of headers
            dgvProductSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProductSuppliers.ColumnHeadersHeight = 35;
            dgvProductSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // changinSuplliers background color of data gridview
            dgvProductSuppliers.BackgroundColor = Color.FloralWhite;
            // gettingSuplliersrid of row headers 
            dgvProductSuppliers.RowHeadersVisible = false;

        }

		/// <summary>
		/// Opening form for currently clicked button, using bool property to decide 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnFrm_Click(object sender, EventArgs e)
		{
			if (EditPkgFrm)
			{
                frmPackageMain frmPkg = new();
				DialogResult result = frmPkg.ShowDialog();
				if (result == DialogResult.OK)
				{
					DisplayPackages();
				}
			}
			else if (EditPrdFrm)
			{
				frmProducts frmProd = new();
				DialogResult result = frmProd.ShowDialog();
				if (result == DialogResult.OK)
				{
					DisplayProducts();
				}
			}
			else if (EditSupFrm)
			{
				frmSuppliersMain frmSup = new();
				DialogResult result = frmSup.ShowDialog();
				if (result == DialogResult.OK)
				{
					DisplaySuppliers();
				}
			}
			else if (EditPrdSupFrm)
			{
				frmProductSupplierMaintenance frmProdSup = new();
				DialogResult result = frmProdSup.ShowDialog();
				if (result == DialogResult.OK)
				{
					DisplayProductSuppliers();
				}
			}
		}

		/// <summary>
		/// Exit Method
		/// </summary>
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
