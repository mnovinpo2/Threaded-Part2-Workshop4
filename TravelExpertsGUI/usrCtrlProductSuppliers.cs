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
	public partial class usrCtrlProductSuppliers : UserControl
	{
		public usrCtrlProductSuppliers()
		{
			InitializeComponent();
		}

		private void usrCtrlProductSuppliers_Load(object sender, EventArgs e)
		{
			DisplayProductSuppliers();
		}
		public void DisplayProductSuppliers()
		{
			dgvProductSuppliers.Columns.Clear();
			dgvProductSuppliers.DataSource = ProductSupplierDB.GetProductSuppliers();
					  
			// changinSuplliers header and row styles
			dgvProductSuppliers.EnableHeadersVisualStyles = false;
			dgvProductSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
			dgvProductSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
			dgvProductSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
					

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
	}
}
