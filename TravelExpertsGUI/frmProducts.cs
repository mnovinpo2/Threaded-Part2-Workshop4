using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class frmProducts : Form
    {
        Product selectedProd = null!;
        public frmProducts()
        {
            InitializeComponent();
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        /// <summary>
        /// Displays Products in DataGridView
        /// </summary>
        public void DisplayProducts()
        {
            dgvProducts.Columns.Clear();
            dgvProducts.DataSource = ProductsDB.GetProducts();

            DataGridViewButtonColumn modifyCol = new() // Adding and Initalizing Column for Modify Button
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvProducts.Columns.Add(modifyCol);

            DataGridViewButtonColumn deleteCol = new() // Adding and Initializing Delete Button Column
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvProducts.Columns.Add(deleteCol);

            // changing header and row styles
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 9, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;

            dgvProducts.Columns[0].HeaderText = "Product ID";
            dgvProducts.Columns[0].Width = 150;

            dgvProducts.Columns[1].HeaderText = "Product Name";
            dgvProducts.Columns[1].Width = 200;

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

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Consts for button indexes
            const int MODIFY_INDEX = 3;
            const int DELETE_INDEX = 4;

            if (e.RowIndex > -1) // making sure header row wasnt clicked
            {
                if (e.ColumnIndex == MODIFY_INDEX || e.ColumnIndex == DELETE_INDEX)
                {
                    DataGridViewCell cell = dgvProducts.Rows[e.RowIndex].Cells[0];
                    int prodID = Convert.ToInt32(cell.Value);
                    selectedProd = ProductsDB.GetProductByID(prodID);
                }
                if (selectedProd != null)
                {
                    if (e.ColumnIndex == MODIFY_INDEX)
                    {
                        EditProduct();
                    }
                    else if (e.ColumnIndex == DELETE_INDEX)
                    {
                        DeleteProduct();
                    }

                }
            }
        }
        private void DeleteProduct()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedProd.ProdName}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ProductsDB.DeleteProduct(selectedProd);
                    DisplayProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        private void EditProduct()
        {
            frmAddModifyProduct editForm = new()
            {
                prod = selectedProd
            };
            DialogResult result = editForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProd = editForm.prod;
                    ProductsDB.EditProduct(selectedProd);
                    DisplayProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void AddProduct()
        {
            frmAddModifyProduct addForm = new();

            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProd = addForm.prod;
                    ProductsDB.AddProduct(selectedProd);
                    DisplayProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
