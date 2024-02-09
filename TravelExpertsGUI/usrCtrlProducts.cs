using TravelExpertsData;

namespace TravelExpertsGUI
{
	public partial class usrCtrlProducts : UserControl
	{
		public usrCtrlProducts()
		{
			InitializeComponent();
		}

		private void usrCtrlProducts_Load(object sender, EventArgs e)
		{
			DisplayProducts();
		}
		public void DisplayProducts()
		{
			dgvProducts.Columns.Clear();
			dgvProducts.DataSource = ProductsDB.GetProducts();

			// changing header and row styles
			dgvProducts.EnableHeadersVisualStyles = false;
			dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
			dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
			dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

			//dgvProducts.Columns[0].HeaderText = "Product ID";

			//dgvProducts.Columns[1].HeaderText = "Product Name";

			// hide product suppliers column
			//dgvProducts.Columns[2].Visible = false;

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
	}
}
