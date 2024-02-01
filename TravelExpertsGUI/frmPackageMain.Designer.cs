

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
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // dgvPackages
            // 
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(42, 30);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 51;
            dgvPackages.Size = new Size(807, 377);
            dgvPackages.TabIndex = 0;
            dgvPackages.CellContentClick += dgvPackages_CellContentClick;
            // 
            // txtEDate
            // 
            txtEDate.Location = new Point(137, 536);
            txtEDate.Name = "txtEDate";
            txtEDate.Size = new Size(100, 23);
            txtEDate.TabIndex = 1;
            // 
            // txtPkgId
            // 
            txtPkgId.Location = new Point(423, 433);
            txtPkgId.Name = "txtPkgId";
            txtPkgId.Size = new Size(100, 23);
            txtPkgId.TabIndex = 2;
            // 
            // txtGetPkg
            // 
            txtGetPkg.Location = new Point(749, 523);
            txtGetPkg.Name = "txtGetPkg";
            txtGetPkg.Size = new Size(100, 23);
            txtGetPkg.TabIndex = 3;
            // 
            // txtPkgDesc
            // 
            txtPkgDesc.Location = new Point(423, 494);
            txtPkgDesc.Name = "txtPkgDesc";
            txtPkgDesc.Size = new Size(100, 23);
            txtPkgDesc.TabIndex = 4;
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(423, 552);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(100, 23);
            txtPkgName.TabIndex = 5;
            // 
            // txtSDate
            // 
            txtSDate.Location = new Point(137, 472);
            txtSDate.Name = "txtSDate";
            txtSDate.Size = new Size(100, 23);
            txtSDate.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(137, 584);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 7;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(731, 476);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(107, 23);
            btnGet.TabIndex = 8;
            btnGet.Text = "Get Package";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(602, 552);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(602, 432);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(602, 494);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 11;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // txtCom
            // 
            txtCom.Location = new Point(137, 623);
            txtCom.Name = "txtCom";
            txtCom.Size = new Size(100, 23);
            txtCom.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 441);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 13;
            label1.Text = "PackageId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 502);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 14;
            label2.Text = "Package Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 560);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 15;
            label3.Text = "Package Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 480);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 16;
            label4.Text = "Package Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 592);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 17;
            label5.Text = "Package Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 536);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 18;
            label6.Text = "Package End Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 631);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 19;
            label7.Text = "Agency Commision";
            // 
            // PackageMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 658);
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
            Name = "PackageMain";
            Text = "Form1";
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
    }
}