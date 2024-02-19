namespace TravelExpertsGUI
{
    partial class frmAddProductToPackage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboProduct = new ComboBox();
            cboSupplier = new ComboBox();
            dgvPkgProduct = new DataGridView();
            cboPkg = new ComboBox();
            btnAddProd = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPkgProduct).BeginInit();
            SuspendLayout();
            // 
            // cboProduct
            // 
            cboProduct.Font = new Font("Segoe UI", 11.25F);
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(154, 345);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(121, 28);
            cboProduct.TabIndex = 0;
            cboProduct.SelectedValueChanged += cboProduct_SelectedValueChanged;
            // 
            // cboSupplier
            // 
            cboSupplier.Font = new Font("Segoe UI", 11.25F);
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(154, 402);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(121, 28);
            cboSupplier.TabIndex = 1;
            cboSupplier.SelectedValueChanged += cboSupplier_SelectedValueChanged;
            // 
            // dgvPkgProduct
            // 
            dgvPkgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPkgProduct.Location = new Point(32, 34);
            dgvPkgProduct.Name = "dgvPkgProduct";
            dgvPkgProduct.Size = new Size(903, 212);
            dgvPkgProduct.TabIndex = 4;
            // 
            // cboPkg
            // 
            cboPkg.Font = new Font("Segoe UI", 11.25F);
            cboPkg.FormattingEnabled = true;
            cboPkg.Location = new Point(154, 281);
            cboPkg.Name = "cboPkg";
            cboPkg.Size = new Size(121, 28);
            cboPkg.TabIndex = 5;
            cboPkg.SelectedValueChanged += cboPkg_SelectedValueChanged;
            // 
            // btnAddProd
            // 
            btnAddProd.Font = new Font("Segoe UI", 11.25F);
            btnAddProd.Location = new Point(151, 465);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(124, 35);
            btnAddProd.TabIndex = 7;
            btnAddProd.Text = "Add Product";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11.25F);
            btnExit.Location = new Point(844, 456);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 35);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmAddProductToPackage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(973, 512);
            Controls.Add(btnExit);
            Controls.Add(btnAddProd);
            Controls.Add(cboPkg);
            Controls.Add(dgvPkgProduct);
            Controls.Add(cboSupplier);
            Controls.Add(cboProduct);
            Name = "frmAddProductToPackage";
            Text = "frmAddProductToPackage";
            Load += frmAddProductToPackage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPkgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboProduct;
        private ComboBox cboSupplier;
        private DataGridView dgvPkgProduct;
        private ComboBox cboPkg;
        private Button btnAddProd;
        private Button btnExit;
    }
}