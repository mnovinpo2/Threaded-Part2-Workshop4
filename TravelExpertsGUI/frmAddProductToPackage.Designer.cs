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
            label1 = new Label();
            label2 = new Label();
            dgvPkgProduct = new DataGridView();
            label3 = new Label();
            cboPkg = new ComboBox();
            btnOK = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPkgProduct).BeginInit();
            SuspendLayout();
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(313, 424);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(121, 23);
            cboProduct.TabIndex = 0;
            cboProduct.SelectedValueChanged += cboProduct_SelectedValueChanged;
            // 
            // cboSupplier
            // 
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(313, 485);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(121, 23);
            cboSupplier.TabIndex = 1;
            cboSupplier.SelectedValueChanged += cboSupplier_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 427);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 488);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Suppliers";
            // 
            // dgvPkgProduct
            // 
            dgvPkgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPkgProduct.Location = new Point(32, 34);
            dgvPkgProduct.Name = "dgvPkgProduct";
            dgvPkgProduct.Size = new Size(903, 312);
            dgvPkgProduct.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 370);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Packages";
            // 
            // cboPkg
            // 
            cboPkg.FormattingEnabled = true;
            cboPkg.Location = new Point(313, 367);
            cboPkg.Name = "cboPkg";
            cboPkg.Size = new Size(121, 23);
            cboPkg.TabIndex = 5;
            cboPkg.SelectedValueChanged += cboPkg_SelectedValueChanged;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(569, 426);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(709, 426);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmAddProductToPackage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 609);
            Controls.Add(btnExit);
            Controls.Add(btnOK);
            Controls.Add(label3);
            Controls.Add(cboPkg);
            Controls.Add(dgvPkgProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboSupplier);
            Controls.Add(cboProduct);
            Name = "frmAddProductToPackage";
            Text = "frmAddProductToPackage";
            Load += frmAddProductToPackage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPkgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboProduct;
        private ComboBox cboSupplier;
        private Label label1;
        private Label label2;
        private DataGridView dgvPkgProduct;
        private Label label3;
        private ComboBox cboPkg;
        private Button btnOK;
        private Button btnExit;
    }
}