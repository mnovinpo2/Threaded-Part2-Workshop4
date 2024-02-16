using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelExpertsData;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public record PSupplierDTO(int ProductSupplierId, int ProductId, int SupplierId);
//public record PSupplierDTO(int ProductId, int SupplierId);


namespace TravelExpertsGUI
{
    public partial class frmProductSupplierMaintenance : Form
    {
        private TravelExpertsContext context = new();
        private ProductsSupplier? selectedSupplier = null;
        public frmProductSupplierMaintenance()
        {
            InitializeComponent();
        }

        private void frmPackageMaintenance_Load(object sender, EventArgs e)
        {
            DisplaySupplier();
            btnDelete.Enabled = false;
            btnModify.Enabled = false;
        }
        public List<PSupplierDTO> GetAllSuppliers() =>
            context.ProductsSuppliers
        .OrderBy(p => p.ProductSupplierId)
        .Select(p => new PSupplierDTO((int)p.ProductSupplierId, (int)p.ProductId!, (int)p.SupplierId!))
        .ToList();

        private bool IsValidData()
        {
            bool success = true;
            string error = null;

            //error += Validator.IsPresent(txtGet);
            //error += Validator.IsNonNegativeInt(txtGet);

            if (!string.IsNullOrEmpty(error))
            {
                success = false;
                MessageBox.Show(error, "Entry Error");
            }
            return success;
        }
        private void btnGetSupplier_Click(object sender, EventArgs e)
        {

            //if (//Validator.IsPresent(txtGet)) // if valid ProductCode
            //)
            if (IsValidData())
            {
                int supID = Convert.ToInt32(txtGet.Text);
                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        selectedSupplier = db.ProductsSuppliers.Find(supID);
                        if (selectedSupplier != null)
                        {
                            DisplaySupplier();
                        }
                        else
                        {
                            MessageBox.Show
                                ($"There is no Product with ID = {supID}");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while retrieving product data: " + ex.Message,
                        "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message,
                        ex.GetType().ToString());
                }
            }
        }

        private void DisplaySupplier()
        {
            dgvSuppliers.Columns.Clear();
            dgvSuppliers.DataSource = GetAllSuppliers();
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.DefaultCellStyle.Font = new Font("Sanscript", 10);
            dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Sanscript", 10, FontStyle.Bold);
            dgvSuppliers.AutoResizeColumns();
            if (selectedSupplier != null)
            {
                txtSupplierId.Text = selectedSupplier.SupplierId.ToString();
                txtProdSupId.Text = selectedSupplier.ProductSupplierId.ToString();
                txtProductId.Text = selectedSupplier.ProductId.ToString();

                // enable Modify and Delete
                btnModify.Enabled = true;
                btnDelete.Enabled = true;

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModProductSupplier secondForm = new();
            secondForm.isAdd = true;
            secondForm.productsSupplier = null;


            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK)
            {

                try
                {
                    using (TravelExpertsContext db = new TravelExpertsContext())
                    {
                        if (selectedSupplier == null)
                        {
                            selectedSupplier = secondForm.productsSupplier;
                            db.ProductsSuppliers.Add(selectedSupplier);
                            db.SaveChanges();
                            DisplaySupplier();
                        }
                    }

                }

                catch (DbUpdateException ex)
                {
                    string msg = "";
                    var sqlException =
                        (SqlException)ex.InnerException!;
                    foreach (SqlError error in sqlException.Errors)
                    {
                        msg += $"ERROR CODE {error.Number}: {error.Message}\n";
                    }
                    MessageBox.Show(msg, "Database Error");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while adding product: " + ex.Message,
                        "Database Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error: " + ex.Message,
                        ex.GetType().ToString());
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplier != null)
            {
                // get the user's confirmation
                DialogResult answer = MessageBox.Show(
                    $"Do you really want to delete {selectedSupplier.ProductSupplierId}",
                    "Confirm delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) // user confirmed
                {
                    // perform delete
                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            db.ProductsSuppliers.Remove(selectedSupplier);
                            db.SaveChanges();
                            selectedSupplier = null;
                            ClearControls();
                            DisplaySupplier();
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        string msg = "";
                        var sqlException =
                            (SqlException)ex.InnerException!;
                        foreach (SqlError error in sqlException.Errors)
                        {
                            msg += $"ERROR CODE {error.Number}:{error.Message}\n";
                        }
                        MessageBox.Show(msg, "Database Error");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error while deleting customer: " + ex.Message,
                            "Database Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unanticipated error: " + ex.Message,
                            ex.GetType().ToString());
                    }
                    // clear controls and display updated list


                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            {
                frmAddModProductSupplier secondForm = new();
                secondForm.isAdd = false;
                secondForm.productsSupplier = selectedSupplier;


                DialogResult result = secondForm.ShowDialog();

                if (result == DialogResult.OK)
                {

                    try
                    {
                        using (TravelExpertsContext db = new TravelExpertsContext())
                        {
                            if (selectedSupplier == null)
                            {
                                selectedSupplier = secondForm.productsSupplier;
                                db.ProductsSuppliers.Add(selectedSupplier);
                                db.SaveChanges();
                                DisplaySupplier();
                            }
                        }

                    }

                    catch (DbUpdateException ex)
                    {
                        string msg = "";
                        var sqlException =
                            (SqlException)ex.InnerException!;
                        foreach (SqlError error in sqlException.Errors)
                        {
                            msg += $"ERROR CODE {error.Number}: {error.Message}\n";
                        }
                        MessageBox.Show(msg, "Database Error");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error while adding product: " + ex.Message,
                            "Database Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unanticipated error: " + ex.Message,
                            ex.GetType().ToString());
                    }

                }
            }
        }
        private void ClearControls()
        {
            txtProdSupId.Text = "";
            txtProductId.Text = "";
            txtSupplierId.Text = "";
            txtGet.Text = "";
            // disable Modify and Delete
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            txtGet.Focus(); // facilitate selecting another Product
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

