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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace TravelExpertsGUI
{
    
    public partial class AddSuppliers : Form
    {
        

        private TravelExpertsContext context = new();
        private SupplierDB db = new();
        public Supplier supplier { get; set; } = null!;
        public AddSuppliers()
        {
            InitializeComponent();
        }

        private void AddSuppliers_Load(object sender, EventArgs e)
        {
            //// can just be changes in desing mode later
            //Text = "Add Product"; 
            //txtSupID.ReadOnly = false;  // Can change on design
            //supplier = new();

            if (supplier == null) // if no product is present = adding product
            {
                Text = "Add Product";
                txtSupID.ReadOnly = false;  // Allow user to enter new product code
                
                
            }
            else if (supplier != null)// there will be a product present which means it is a modify
            {
                Text = "Modify Product";
                txtSupID.ReadOnly = true;   // user can't change product code ( product code should be the same )
                DisplaySuppliers();
            }
        }

        private void DisplaySuppliers() 
        {
            
            txtSupID.Text = supplier.SupplierId.ToString();
            txtSupName.Text = supplier.SupName;
        }

        private bool IsValidData()
        {
            bool success = true;
            string error = null;

            
            error += Validator.IsPresent(txtSupID);
            error += Validator.IsNonNegativeInt(txtSupID);
            if (Validator.IsNonNegativeInt(txtSupID) == "")
            {
                error += Validator.IsValidSupplierID(txtSupID);
            }
            error += Validator.IsPresent(txtSupName);

            if (!string.IsNullOrEmpty(error))
            {
                success = false;
                MessageBox.Show(error, "Entry Error");
            }
            return success;
        }

        private bool IsValidModifyData()
        {
            bool success = true;
            string error = null;

            error += Validator.IsPresent(txtSupName);
            error += Validator.IsPresent(txtSupID);
            error += Validator.IsNonNegativeInt(txtSupID);
            

            if (!string.IsNullOrEmpty(error))
            {
                success = false;
                MessageBox.Show(error, "Entry Error");
            }
            return success;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (supplier == null) // if its adding
            {
                // for adding NOT editing
                if (IsValidData())
                {
                    LoadData();
                    DialogResult = DialogResult.OK;
                }
            }
            else // if its edit
            {
                if (IsValidModifyData())
                {
                    LoadData();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        // Function that creates the supplier object
        private void LoadData()
        {
			supplier = new Supplier();
			supplier.SupName = txtSupName.Text;
            supplier.SupplierId = Convert.ToInt32(txtSupID.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
