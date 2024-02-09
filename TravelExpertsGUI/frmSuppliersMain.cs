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
            }
        }



        private void dgvSupplier_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvSupplier.BackgroundColor = Color.Blue;
            const int EditIndex = 4;

            if (e.RowIndex > -1)  // make sure header row wasn't clicked
            {
                if (e.ColumnIndex == EditIndex)
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
