

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
            txtPkgDesc = new TextBox();
            txtPkgName = new TextBox();
            txtSDate = new TextBox();
            txtPrice = new TextBox();
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
            btnOk = new Button();
            cboGetPkg = new ComboBox();
            gbPkgInfo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            gbPkgInfo.SuspendLayout();
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
            txtEDate.ForeColor = SystemColors.MenuHighlight;
            txtEDate.Location = new Point(212, 139);
            txtEDate.Name = "txtEDate";
            txtEDate.ReadOnly = true;
            txtEDate.Size = new Size(100, 29);
            txtEDate.TabIndex = 1;
            // 
            // txtPkgId
            // 
            txtPkgId.Font = new Font("Segoe UI", 12F);
            txtPkgId.Location = new Point(494, 89);
            txtPkgId.Name = "txtPkgId";
            txtPkgId.ReadOnly = true;
            txtPkgId.Size = new Size(100, 29);
            txtPkgId.TabIndex = 2;
            // 
            // txtPkgDesc
            // 
            txtPkgDesc.Font = new Font("Segoe UI", 12F);
            txtPkgDesc.Location = new Point(480, 274);
            txtPkgDesc.Name = "txtPkgDesc";
            txtPkgDesc.ReadOnly = true;
            txtPkgDesc.Size = new Size(408, 29);
            txtPkgDesc.TabIndex = 4;
            // 
            // txtPkgName
            // 
            txtPkgName.Font = new Font("Segoe UI", 12F);
            txtPkgName.Location = new Point(494, 188);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.ReadOnly = true;
            txtPkgName.Size = new Size(394, 29);
            txtPkgName.TabIndex = 5;
            // 
            // txtSDate
            // 
            txtSDate.Font = new Font("Segoe UI", 12F);
            txtSDate.Location = new Point(212, 73);
            txtSDate.Name = "txtSDate";
            txtSDate.ReadOnly = true;
            txtSDate.Size = new Size(100, 29);
            txtSDate.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(212, 203);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(100, 29);
            txtPrice.TabIndex = 7;
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
            txtCom.Location = new Point(212, 264);
            txtCom.Name = "txtCom";
            txtCom.ReadOnly = true;
            txtCom.Size = new Size(100, 29);
            txtCom.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(368, 97);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 13;
            label1.Text = "PackageId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(343, 188);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 14;
            label2.Text = "Package Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(358, 277);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 15;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(18, 76);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 16;
            label4.Text = "Package Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 213);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 17;
            label5.Text = "Package Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(23, 145);
            label6.Name = "label6";
            label6.Size = new Size(132, 21);
            label6.TabIndex = 18;
            label6.Text = "Package End Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(18, 269);
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
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 12F);
            btnOk.Location = new Point(991, 604);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(133, 34);
            btnOk.TabIndex = 23;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // cboGetPkg
            // 
            cboGetPkg.BackColor = SystemColors.ButtonHighlight;
            cboGetPkg.DisplayMember = "PkgName";
            cboGetPkg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboGetPkg.ForeColor = SystemColors.WindowText;
            cboGetPkg.FormattingEnabled = true;
            cboGetPkg.Location = new Point(918, 307);
            cboGetPkg.Name = "cboGetPkg";
            cboGetPkg.Size = new Size(206, 29);
            cboGetPkg.TabIndex = 26;
            cboGetPkg.ValueMember = "PkgName";
            cboGetPkg.SelectedIndexChanged += cboGetPkg_SelectedIndexChanged;
            // 
            // gbPkgInfo
            // 
            gbPkgInfo.BackColor = Color.Transparent;
            gbPkgInfo.Controls.Add(txtPkgId);
            gbPkgInfo.Controls.Add(txtEDate);
            gbPkgInfo.Controls.Add(txtPkgDesc);
            gbPkgInfo.Controls.Add(txtPkgName);
            gbPkgInfo.Controls.Add(label7);
            gbPkgInfo.Controls.Add(txtSDate);
            gbPkgInfo.Controls.Add(label6);
            gbPkgInfo.Controls.Add(txtPrice);
            gbPkgInfo.Controls.Add(label5);
            gbPkgInfo.Controls.Add(txtCom);
            gbPkgInfo.Controls.Add(label4);
            gbPkgInfo.Controls.Add(label1);
            gbPkgInfo.Controls.Add(label3);
            gbPkgInfo.Controls.Add(label2);
            gbPkgInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPkgInfo.Location = new Point(30, 358);
            gbPkgInfo.Name = "gbPkgInfo";
            gbPkgInfo.Size = new Size(923, 352);
            gbPkgInfo.TabIndex = 27;
            gbPkgInfo.TabStop = false;
            gbPkgInfo.Text = "Package Information";
            // 
            // frmPackageMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = TravelExpertsGUI.Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1153, 789);
            Controls.Add(gbPkgInfo);
            Controls.Add(cboGetPkg);
            Controls.Add(btnOk);
            Controls.Add(btnAddProducts);
            Controls.Add(btnModify);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvPackages);
            Name = "frmPackageMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TravelExperts Packages";
            Load += PackageMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            gbPkgInfo.ResumeLayout(false);
            gbPkgInfo.PerformLayout();
            ResumeLayout(false);
        }





        #endregion

        private DataGridView dgvPackages;
        private TextBox txtEDate;
        private TextBox txtPkgId;
        private TextBox txtPkgDesc;
        private TextBox txtPkgName;
        private TextBox txtSDate;
        private TextBox txtPrice;
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
        private Button btnOk;
        private ComboBox cboGetPkg;
        private GroupBox gbPkgInfo;
    }
}