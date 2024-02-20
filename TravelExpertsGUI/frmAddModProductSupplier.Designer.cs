namespace TravelExpertsGUI
{
    partial class frmAddModProductSupplier
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
            txtProdSupplierId = new TextBox();
            label1 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            cboProducts = new ComboBox();
            cboSuppliers = new ComboBox();
            SuspendLayout();
            // 
            // txtProdSupplierId
            // 
            txtProdSupplierId.Font = new Font("Segoe UI", 10.8F);
            txtProdSupplierId.Location = new Point(785, 397);
            txtProdSupplierId.Margin = new Padding(3, 2, 3, 2);
            txtProdSupplierId.Name = "txtProdSupplierId";
            txtProdSupplierId.Size = new Size(157, 27);
            txtProdSupplierId.TabIndex = 0;
            txtProdSupplierId.Tag = "ProductSupplierID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(568, 397);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Product SupplierId";
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 10.8F);
            btnOK.Location = new Point(130, 230);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(110, 27);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.8F);
            btnCancel.Location = new Point(289, 231);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 27);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboProducts
            // 
            cboProducts.DisplayMember = "ProductID";
            cboProducts.FormattingEnabled = true;
            cboProducts.Location = new Point(209, 101);
            cboProducts.Name = "cboProducts";
            cboProducts.Size = new Size(121, 23);
            cboProducts.TabIndex = 8;
            cboProducts.ValueMember = "ProductID";
            // 
            // cboSuppliers
            // 
            cboSuppliers.DisplayMember = "SupplierID";
            cboSuppliers.FormattingEnabled = true;
            cboSuppliers.Location = new Point(209, 169);
            cboSuppliers.Name = "cboSuppliers";
            cboSuppliers.Size = new Size(121, 23);
            cboSuppliers.TabIndex = 9;
            cboSuppliers.ValueMember = "SupplierID";
            // 
            // frmAddModProductSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(517, 335);
            Controls.Add(cboSuppliers);
            Controls.Add(cboProducts);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label1);
            Controls.Add(txtProdSupplierId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAddModProductSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddModProductSupplier";
            Load += frmAddModProductSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProdSupplierId;
        private Label label1;
        private Button btnOK;
        private Button btnCancel;
        private ComboBox cboProducts;
        private ComboBox cboSuppliers;
    }
}