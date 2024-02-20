namespace TravelExpertsGUI
{
    partial class frmProductSupplierMaintenance
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
            btnModify = new Button();
            btnGetSupplier = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvSuppliers = new DataGridView();
            txtProdSupId = new TextBox();
            txtProductId = new TextBox();
            txtSupplierId = new TextBox();
            txtGet = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnOk = new Button();
            gbGet = new GroupBox();
            label4 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            gbGet.SuspendLayout();
            SuspendLayout();
            // 
            // btnModify
            // 
            btnModify.Location = new Point(306, 412);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 0;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnGetSupplier
            // 
            btnGetSupplier.Location = new Point(186, 118);
            btnGetSupplier.Name = "btnGetSupplier";
            btnGetSupplier.Size = new Size(106, 23);
            btnGetSupplier.TabIndex = 1;
            btnGetSupplier.Text = "Get Supplier";
            btnGetSupplier.UseVisualStyleBackColor = true;
            btnGetSupplier.Click += btnGetSupplier_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(40, 280);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(403, 412);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(40, 12);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(771, 251);
            dgvSuppliers.TabIndex = 4;
            // 
            // txtProdSupId
            // 
            txtProdSupId.Location = new Point(409, 286);
            txtProdSupId.Name = "txtProdSupId";
            txtProdSupId.Size = new Size(67, 23);
            txtProdSupId.TabIndex = 5;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(409, 337);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(67, 23);
            txtProductId.TabIndex = 6;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(409, 375);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(67, 23);
            txtSupplierId.TabIndex = 7;
            // 
            // txtGet
            // 
            txtGet.Location = new Point(192, 40);
            txtGet.Name = "txtGet";
            txtGet.Size = new Size(100, 23);
            txtGet.TabIndex = 8;
            txtGet.Tag = "SupplierID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 289);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 9;
            label1.Text = "Product Supplier ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 340);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 10;
            label2.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 383);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 11;
            label3.Text = "Supplier ID:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(40, 408);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 30);
            btnOk.TabIndex = 12;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // gbGet
            // 
            gbGet.BackColor = Color.Transparent;
            gbGet.Controls.Add(label4);
            gbGet.Controls.Add(txtGet);
            gbGet.Controls.Add(btnGetSupplier);
            gbGet.Location = new Point(494, 280);
            gbGet.Name = "gbGet";
            gbGet.Size = new Size(317, 158);
            gbGet.TabIndex = 13;
            gbGet.TabStop = false;
            gbGet.Text = "Select a Product Supplier";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 43);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 9;
            label4.Text = "Enter a Product Supplier ID:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(174, 412);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmProductSupplierMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(843, 450);
            Controls.Add(btnExit);
            Controls.Add(gbGet);
            Controls.Add(btnOk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSupplierId);
            Controls.Add(txtProductId);
            Controls.Add(txtProdSupId);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnModify);
            Name = "frmProductSupplierMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Suppliers";
            Load += frmPackageMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            gbGet.ResumeLayout(false);
            gbGet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModify;
        private Button btnGetSupplier;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvSuppliers;
        private TextBox txtProdSupId;
        private TextBox txtProductId;
        private TextBox txtSupplierId;
        private TextBox txtGet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOk;
        private GroupBox gbGet;
        private Label label4;
        private Button btnExit;
    }
}