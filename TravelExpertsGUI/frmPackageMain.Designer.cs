

namespace TravelExpertsPackageMaintenance
{
    partial class frmPackageMain
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
            dgvPackages = new DataGridView();
            txtEDate = new TextBox();
            txtPkgId = new TextBox();
            txtGetPkg = new TextBox();
            txtPkgDesc = new TextBox();
            txtPkgName = new TextBox();
            txtSDate = new TextBox();
            txtPrice = new TextBox();
            btnGet = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            txtCom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAddProducts = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // dgvPackages
            // 
            dgvPackages.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.GridColor = SystemColors.MenuHighlight;
            dgvPackages.Location = new Point(30, 32);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 51;
            dgvPackages.Size = new Size(1094, 248);
            dgvPackages.TabIndex = 0;
            // 
            // txtEDate
            // 
            txtEDate.Font = new Font("Segoe UI", 12F);
            txtEDate.Location = new Point(206, 456);
            txtEDate.Name = "txtEDate";
            txtEDate.Size = new Size(100, 29);
            txtEDate.TabIndex = 1;
            // 
            // txtPkgId
            // 
            txtPkgId.Font = new Font("Segoe UI", 12F);
            txtPkgId.Location = new Point(559, 403);
            txtPkgId.Name = "txtPkgId";
            txtPkgId.Size = new Size(100, 29);
            txtPkgId.TabIndex = 2;
            // 
            // txtGetPkg
            // 
            txtGetPkg.Font = new Font("Segoe UI", 12F);
            txtGetPkg.Location = new Point(1024, 302);
            txtGetPkg.Name = "txtGetPkg";
            txtGetPkg.Size = new Size(100, 29);
            txtGetPkg.TabIndex = 3;
            // 
            // txtPkgDesc
            // 
            txtPkgDesc.Font = new Font("Segoe UI", 12F);
            txtPkgDesc.Location = new Point(559, 591);
            txtPkgDesc.Name = "txtPkgDesc";
            txtPkgDesc.Size = new Size(347, 29);
            txtPkgDesc.TabIndex = 4;
            // 
            // txtPkgName
            // 
            txtPkgName.Font = new Font("Segoe UI", 12F);
            txtPkgName.Location = new Point(559, 502);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(347, 29);
            txtPkgName.TabIndex = 5;
            // 
            // txtSDate
            // 
            txtSDate.Font = new Font("Segoe UI", 12F);
            txtSDate.Location = new Point(206, 390);
            txtSDate.Name = "txtSDate";
            txtSDate.Size = new Size(100, 29);
            txtSDate.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(206, 520);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 29);
            txtPrice.TabIndex = 7;
            // 
            // btnGet
            // 
            btnGet.Font = new Font("Segoe UI", 12F);
            btnGet.Location = new Point(959, 363);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(165, 34);
            btnGet.TabIndex = 8;
            btnGet.Text = "Get Package";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(42, 302);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(713, 302);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("Segoe UI", 12F);
            btnModify.Location = new Point(335, 302);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(133, 34);
            btnModify.TabIndex = 11;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // txtCom
            // 
            txtCom.Font = new Font("Segoe UI", 12F);
            txtCom.Location = new Point(206, 581);
            txtCom.Name = "txtCom";
            txtCom.Size = new Size(100, 29);
            txtCom.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(433, 411);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 13;
            label1.Text = "PackageId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(408, 502);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 14;
            label2.Text = "Package Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(380, 599);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 15;
            label3.Text = "Package Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 393);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 16;
            label4.Text = "Package Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(18, 530);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 17;
            label5.Text = "Package Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(17, 462);
            label6.Name = "label6";
            label6.Size = new Size(132, 21);
            label6.TabIndex = 18;
            label6.Text = "Package End Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 586);
            label7.Name = "label7";
            label7.Size = new Size(145, 21);
            label7.TabIndex = 19;
            label7.Text = "Agency Commision";
            // 
            // btnAddProducts
            // 
            btnAddProducts.Font = new Font("Segoe UI", 12F);
            btnAddProducts.Location = new Point(959, 502);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(165, 49);
            btnAddProducts.TabIndex = 21;
            btnAddProducts.Text = "Add a product";
            btnAddProducts.UseVisualStyleBackColor = true;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // frmPackageMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 648);
            Controls.Add(btnAddProducts);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCom);
            Controls.Add(btnModify);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnGet);
            Controls.Add(txtPrice);
            Controls.Add(txtSDate);
            Controls.Add(txtPkgName);
            Controls.Add(txtPkgDesc);
            Controls.Add(txtGetPkg);
            Controls.Add(txtPkgId);
            Controls.Add(txtEDate);
            Controls.Add(dgvPackages);
            Name = "frmPackageMain";
            Text = "TravelExperts Packages";
            Load += PackageMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private DataGridView dgvPackages;
        private TextBox txtEDate;
        private TextBox txtPkgId;
        private TextBox txtGetPkg;
        private TextBox txtPkgDesc;
        private TextBox txtPkgName;
        private TextBox txtSDate;
        private TextBox txtPrice;
        private Button btnGet;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnModify;
        private TextBox txtCom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAddProducts;
    }
}