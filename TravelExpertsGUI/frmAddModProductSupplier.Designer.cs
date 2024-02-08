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
            txtProdSupplierId.Location = new Point(377, 91);
            txtProdSupplierId.Name = "txtProdSupplierId";
            txtProdSupplierId.Size = new Size(179, 31);
            txtProdSupplierId.TabIndex = 0;
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 10.8F);
            txtProductId.Location = new Point(377, 147);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(179, 31);
            txtProductId.TabIndex = 1;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Font = new Font("Segoe UI", 10.8F);
            txtSupplierId.Location = new Point(373, 201);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(183, 31);
            txtSupplierId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(208, 94);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 3;
            label1.Text = "Product SupplierId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(206, 143);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 4;
            label2.Text = "ProductId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(202, 201);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 5;
            label3.Text = "SupplierId";
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 10.8F);
            btnOK.Location = new Point(148, 306);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(126, 36);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.8F);
            btnCancel.Location = new Point(330, 308);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddModProductSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSupplierId);
            Controls.Add(txtProductId);
            Controls.Add(txtProdSupplierId);
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