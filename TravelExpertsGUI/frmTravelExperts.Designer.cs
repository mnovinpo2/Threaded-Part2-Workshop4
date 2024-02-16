namespace TravelExpertsGUI
{
    partial class frmTravelExperts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProductsFrm = new Button();
            btnPackageFrm = new Button();
            btnSuppliersFrm = new Button();
            btnProdSup = new Button();
            btnFrm = new Button();
            btnExit = new Button();
            pnlPackage = new Panel();
            dgvProductSuppliers = new DataGridView();
            dgvSuppliers = new DataGridView();
            dgvProducts = new DataGridView();
            dgvPackages = new DataGridView();
            pnlPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // btnProductsFrm
            // 
            btnProductsFrm.Font = new Font("Segoe UI", 11.25F);
            btnProductsFrm.Location = new Point(636, 28);
            btnProductsFrm.Name = "btnProductsFrm";
            btnProductsFrm.Size = new Size(172, 40);
            btnProductsFrm.TabIndex = 0;
            btnProductsFrm.Text = "Product";
            btnProductsFrm.UseVisualStyleBackColor = true;
            btnProductsFrm.Click += btnProductsFrm_Click;
            // 
            // btnPackageFrm
            // 
            btnPackageFrm.Font = new Font("Segoe UI", 11.25F);
            btnPackageFrm.Location = new Point(280, 28);
            btnPackageFrm.Name = "btnPackageFrm";
            btnPackageFrm.Size = new Size(172, 40);
            btnPackageFrm.TabIndex = 1;
            btnPackageFrm.Text = "Packages";
            btnPackageFrm.UseVisualStyleBackColor = true;
            btnPackageFrm.Click += btnPackageFrm_Click;
            // 
            // btnSuppliersFrm
            // 
            btnSuppliersFrm.Font = new Font("Segoe UI", 11.25F);
            btnSuppliersFrm.Location = new Point(458, 28);
            btnSuppliersFrm.Name = "btnSuppliersFrm";
            btnSuppliersFrm.Size = new Size(172, 40);
            btnSuppliersFrm.TabIndex = 2;
            btnSuppliersFrm.Text = "Suppliers";
            btnSuppliersFrm.UseVisualStyleBackColor = true;
            btnSuppliersFrm.Click += btnSuppliersFrm_Click;
            // 
            // btnProdSup
            // 
            btnProdSup.Font = new Font("Segoe UI", 11.25F);
            btnProdSup.Location = new Point(814, 28);
            btnProdSup.Name = "btnProdSup";
            btnProdSup.Size = new Size(172, 40);
            btnProdSup.TabIndex = 3;
            btnProdSup.Text = "Product Suppliers";
            btnProdSup.UseVisualStyleBackColor = true;
            btnProdSup.Click += btnProdSup_Click;
            // 
            // btnFrm
            // 
            btnFrm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFrm.Location = new Point(536, 405);
            btnFrm.Name = "btnFrm";
            btnFrm.Size = new Size(228, 37);
            btnFrm.TabIndex = 5;
            btnFrm.Text = "Edit";
            btnFrm.UseVisualStyleBackColor = true;
            btnFrm.Click += btnFrm_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(907, 405);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(228, 37);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlPackage
            // 
            pnlPackage.Controls.Add(dgvProductSuppliers);
            pnlPackage.Controls.Add(dgvSuppliers);
            pnlPackage.Controls.Add(dgvProducts);
            pnlPackage.Controls.Add(dgvPackages);
            pnlPackage.Location = new Point(103, 91);
            pnlPackage.Name = "pnlPackage";
            pnlPackage.Size = new Size(1032, 285);
            pnlPackage.TabIndex = 4;
            // 
            // dgvProductSuppliers
            // 
            dgvProductSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSuppliers.Dock = DockStyle.Fill;
            dgvProductSuppliers.Location = new Point(0, 0);
            dgvProductSuppliers.Name = "dgvProductSuppliers";
            dgvProductSuppliers.Size = new Size(1032, 285);
            dgvProductSuppliers.TabIndex = 3;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Dock = DockStyle.Fill;
            dgvSuppliers.Location = new Point(0, 0);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.Size = new Size(1032, 285);
            dgvSuppliers.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(1032, 285);
            dgvProducts.TabIndex = 1;
            // 
            // dgvPackages
            // 
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Dock = DockStyle.Fill;
            dgvPackages.Location = new Point(0, 0);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.Size = new Size(1032, 285);
            dgvPackages.TabIndex = 0;
            // 
            // frmTravelExperts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1219, 556);
            Controls.Add(btnExit);
            Controls.Add(btnFrm);
            Controls.Add(pnlPackage);
            Controls.Add(btnProdSup);
            Controls.Add(btnSuppliersFrm);
            Controls.Add(btnPackageFrm);
            Controls.Add(btnProductsFrm);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTravelExperts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Experts";
            Load += frmTravelExperts_Load;
            pnlPackage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip tsNav;
        private ToolStripLabel tsProducts;
        private ToolStripLabel toolStripLabel1;
        private Button btnProductsFrm;
        private Button btnPackageFrm;
        private Button btnSuppliersFrm;
		private Button btnProdSup;
		private Button btnFrm;
		private Button btnExit;
        private Panel pnlPackage;
        private DataGridView dgvPackages;
        private DataGridView dgvProducts;
        private DataGridView dgvSuppliers;
        private DataGridView dgvProductSuppliers;
    }
}
