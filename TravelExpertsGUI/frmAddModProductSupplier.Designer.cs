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
            txtProductId = new TextBox();
            txtSupplierId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtProdSupplierId
            // 
            txtProdSupplierId.Font = new Font("Segoe UI", 10.8F);
            txtProdSupplierId.Location = new Point(330, 68);
            txtProdSupplierId.Margin = new Padding(3, 2, 3, 2);
            txtProdSupplierId.Name = "txtProdSupplierId";
            txtProdSupplierId.Size = new Size(157, 27);
            txtProdSupplierId.TabIndex = 0;
            txtProdSupplierId.Tag = "ProductSupplierID";
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 10.8F);
            txtProductId.Location = new Point(330, 110);
            txtProductId.Margin = new Padding(3, 2, 3, 2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(157, 27);
            txtProductId.TabIndex = 1;
            txtProductId.Tag = "ProductID";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Font = new Font("Segoe UI", 10.8F);
            txtSupplierId.Location = new Point(326, 151);
            txtSupplierId.Margin = new Padding(3, 2, 3, 2);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(161, 27);
            txtSupplierId.TabIndex = 2;
            txtSupplierId.Tag = "SupplierID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(182, 70);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Product SupplierId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(180, 107);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "ProductId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(177, 151);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 5;
            label3.Text = "SupplierId";
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
            // frmAddModProductSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSupplierId);
            Controls.Add(txtProductId);
            Controls.Add(txtProdSupplierId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAddModProductSupplier";
            Text = "frmAddModProductSupplier";
            Load += frmAddModProductSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProdSupplierId;
        private TextBox txtProductId;
        private TextBox txtSupplierId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOK;
        private Button btnCancel;
    }
}