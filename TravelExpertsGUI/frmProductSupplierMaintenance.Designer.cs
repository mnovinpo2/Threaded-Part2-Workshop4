﻿namespace TravelExpertsGUI
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
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // btnModify
            // 
            btnModify.Location = new Point(266, 331);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 0;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnGetSupplier
            // 
            btnGetSupplier.Location = new Point(517, 331);
            btnGetSupplier.Name = "btnGetSupplier";
            btnGetSupplier.Size = new Size(106, 23);
            btnGetSupplier.TabIndex = 1;
            btnGetSupplier.Text = "Get Supplier";
            btnGetSupplier.UseVisualStyleBackColor = true;
            btnGetSupplier.Click += btnGetSupplier_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(266, 283);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(266, 379);
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
            dgvSuppliers.Size = new Size(723, 251);
            dgvSuppliers.TabIndex = 4;
            // 
            // txtProdSupId
            // 
            txtProdSupId.Location = new Point(127, 284);
            txtProdSupId.Name = "txtProdSupId";
            txtProdSupId.Size = new Size(100, 23);
            txtProdSupId.TabIndex = 5;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(127, 335);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(100, 23);
            txtProductId.TabIndex = 6;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(127, 373);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(100, 23);
            txtSupplierId.TabIndex = 7;
            // 
            // txtGet
            // 
            txtGet.Location = new Point(663, 331);
            txtGet.Name = "txtGet";
            txtGet.Size = new Size(100, 23);
            txtGet.TabIndex = 8;
            txtGet.Tag = "SupplierID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 287);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 9;
            label1.Text = "Product Supplier ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 339);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 10;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 380);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 11;
            label3.Text = "Supplier ID";
            // 
            // frmProductSupplierMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGet);
            Controls.Add(txtSupplierId);
            Controls.Add(txtProductId);
            Controls.Add(txtProdSupId);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnGetSupplier);
            Controls.Add(btnModify);
            Name = "frmProductSupplierMaintenance";
            Text = "Product Suppliers";
            Load += frmPackageMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
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
    }
}