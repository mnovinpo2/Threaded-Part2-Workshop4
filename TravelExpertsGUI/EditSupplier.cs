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
    public partial class EditSupplier : Form
    {
        private TravelExpertsContext context = new();
        private SupplierDB db = new();
        public Supplier supplier { get; set; } = null!;
        public EditSupplier()
        {
            InitializeComponent();
        }
        private void EditSupplier_Load(object sender, EventArgs e)
        {
            Text = "Modify Product";
            txtSupID.ReadOnly = true;   // user can't change product code ( product code should be the same )
            DisplaySuppliers();
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

            error += Validator.IsPresent(txtSupName);

            if (!string.IsNullOrEmpty(error))
            {
                success = false;
                MessageBox.Show(error, "Entry Error");
            }
            return success;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                LoadData();
                DialogResult = DialogResult.OK;
            }

        }
        private void LoadData()
        {
            supplier.SupName = txtSupName.Text;
            supplier.SupplierId = Convert.ToInt32(txtSupID.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //test
    }
}
