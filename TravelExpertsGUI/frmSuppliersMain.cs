using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class frmSuppliersMain : Form
    {
        private Supplier selectedSupplier = null!;
        private SupplierDB db = new SupplierDB();
        private TravelExpertsContext context = new();
        private Supplier? supplier = null;
        public frmSuppliersMain()
        {
            InitializeComponent();
        }

        private void TemporaryMainForm_Load(object sender, EventArgs e)
        {
            DisplaySuppliers();
        }

        private void DisplaySuppliers()
        {
            dgvSupplier.Columns.Clear(); //Clears first
            dgvSupplier.DataSource = SupplierDB.GetSupplier();

            if (dgvSupplier.Columns.Count <= 4)
            {
                DataGridViewButtonColumn editColumn = new() // creates modify buttons on the dvg in a seperate column
                {
                    UseColumnTextForButtonValue = true,
                    HeaderText = "",
                    Text = "Edit"
                };
                dgvSupplier.Columns.Add(editColumn);

                DataGridViewButtonColumn deleteColumn = new() // creates delete buttons on the dvg in a seperate column
                {
                    UseColumnTextForButtonValue = true,
                    HeaderText = "",
                    Text = "Delete"
                };
                dgvSupplier.Columns.Add(deleteColumn);

                dgvSupplier.Columns[2].Width = 63;

                dgvSupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
                dgvSupplier.EnableHeadersVisualStyles = false;
                dgvSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;

                dgvSupplier.ColumnHeadersDefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
            }
            
        }



        private void dgvSupplier_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        { 
            const int EditIndex = 4;
            const int DeleteIndex = 5;

            if (e.RowIndex > -1)  // make sure header row wasn't clicked
            {
                if (e.ColumnIndex == EditIndex || e.ColumnIndex == DeleteIndex)
                {
                    DataGridViewCell cell = dgvSupplier.Rows[e.RowIndex].Cells[0];
                    string supplierID = cell.Value?.ToString()?.Trim() ?? "";
                    selectedSupplier = db.FindSupplier(supplierID)!;
                }

                if (selectedSupplier != null)
                {
                    if (e.ColumnIndex == EditIndex)
                    {
                        ModifyProduct();
                    }
                    else if (e.ColumnIndex == DeleteIndex)
                    {
                        DeleteProduct();
                    }
                }
            }
        }

        private void DeleteProduct()
        {
            DialogResult warning =
                 MessageBox.Show($"Are you sure you want to delete {selectedSupplier.SupplierId.ToString().Trim()}?",
                     "Confirm Delete", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question); // Warning for the user
            if (warning == DialogResult.Yes) // if user clicks yes
            {
                try
                {
                    db.DeleteSupplier(selectedSupplier); // removes product from db
                    DisplaySuppliers(); // displays current product after deletion
                }
                catch (DataAccessException ex)
                {
                    HandleDataAccessError(ex);
                }
            }
        }
        private void ModifyProduct()
        {
            DialogResult result = DialogResult.Cancel;
            AddSuppliers EditForm = new()
            {
                supplier = selectedSupplier
            };
            result = EditForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    selectedSupplier = EditForm.supplier; // changes selected product to new modified one
                    db.UpdateSupplier(selectedSupplier); // updates it in db
                    DisplaySuppliers(); // displays
                }
                catch (DataAccessException ex)
                {
                    HandleDataAccessError(ex);
                }
            }
        }
        private void HandleDataAccessError(DataAccessException ex)
        {
            // if concurrency conflict, re-display products
            if (ex.IsConcurrencyError)
            {
                DisplaySuppliers();
            }

            // display error message in dialog with error type as title
            MessageBox.Show(ex.Message, ex.ErrorType);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSuppliers AddForm = new();

            DialogResult result = AddForm.ShowDialog();
            // checks when user is done with the add/modify form
            // through DialogResult
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedSupplier = AddForm.supplier; // changes current data to new and changed product
                    db.AddSupplier(selectedSupplier); // adds the new product to db
                    DisplaySuppliers(); // displays current products after the addition of the new one
                    
                }
                catch (DataAccessException ex)
                {
                    HandleDataAccessError(ex);
                }
            }
        }
    }
}
