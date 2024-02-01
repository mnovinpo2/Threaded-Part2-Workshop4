namespace TravelExpertsGUI
{
    partial class frmAddModifyProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddModifyProduct));
            lblProducts = new Label();
            label2 = new Label();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            btnSubmit = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 12F);
            lblProducts.Location = new Point(219, 130);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(86, 21);
            lblProducts.TabIndex = 0;
            lblProducts.Text = "Product ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(219, 187);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(390, 128);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(122, 27);
            txtProductID.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(390, 185);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(248, 27);
            txtProductName.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 10F);
            btnSubmit.Location = new Point(390, 258);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(122, 30);
            btnSubmit.TabIndex = 4;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.Location = new Point(546, 258);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 30);
            btnClose.TabIndex = 5;
            btnClose.Text = "Cancel";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSubmit);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(label2);
            Controls.Add(lblProducts);
            Name = "frmAddModifyProduct";
            Text = "frmAddModifyProduct";
            Load += frmAddModifyProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducts;
        private Label label2;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private Button btnSubmit;
        private Button btnClose;
    }
}