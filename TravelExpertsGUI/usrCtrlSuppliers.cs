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
	public partial class usrCtrlSuppliers : UserControl
	{
		public usrCtrlSuppliers()
		{
			InitializeComponent();
		}

		private void usrCtrlSuppliers_Load(object sender, EventArgs e)
		{
			DisplaySuppliers();
		}
		public void DisplaySuppliers()
		{
			dgvSuppliers.Columns.Clear();
			dgvSuppliers.DataSource = SupplierDB.GetSupplier();

			// Suplliers header and row styles
			dgvSuppliers.EnableHeadersVisualStyles = false;
			dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
				dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
			dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

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
	}
}
