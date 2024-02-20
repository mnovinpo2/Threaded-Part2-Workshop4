namespace TravelExpertsGUI
{
    partial class frmAddModifyPackage
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
            btnOK = new Button();
            btnCancel = new Button();
            txtPkgName = new TextBox();
            txtPkgDesc = new TextBox();
            txtPrice = new TextBox();
            txtCom = new TextBox();
            dtpSDate = new DateTimePicker();
            dtpEDate = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 12F);
            btnOK.Location = new Point(126, 455);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(128, 34);
            btnOK.TabIndex = 0;
            btnOK.Text = "btnOK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(335, 455);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPkgName
            // 
            txtPkgName.Font = new Font("Segoe UI", 11.25F);
            txtPkgName.Location = new Point(219, 63);
            txtPkgName.Margin = new Padding(3, 2, 3, 2);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(364, 27);
            txtPkgName.TabIndex = 3;
            txtPkgName.Tag = "Package Name";
            // 
            // txtPkgDesc
            // 
            txtPkgDesc.Font = new Font("Segoe UI", 11.25F);
            txtPkgDesc.Location = new Point(219, 133);
            txtPkgDesc.Margin = new Padding(3, 2, 3, 2);
            txtPkgDesc.Name = "txtPkgDesc";
            txtPkgDesc.Size = new Size(364, 27);
            txtPkgDesc.TabIndex = 4;
            txtPkgDesc.Tag = "Package Description";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 11.25F);
            txtPrice.Location = new Point(219, 203);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(364, 27);
            txtPrice.TabIndex = 5;
            txtPrice.Tag = "Package Price";
            // 
            // txtCom
            // 
            txtCom.Font = new Font("Segoe UI", 11.25F);
            txtCom.Location = new Point(219, 265);
            txtCom.Margin = new Padding(3, 2, 3, 2);
            txtCom.Name = "txtCom";
            txtCom.Size = new Size(364, 27);
            txtCom.TabIndex = 6;
            txtCom.Tag = "Agency Commission";
            // 
            // dtpSDate
            // 
            dtpSDate.Font = new Font("Segoe UI", 9.75F);
            dtpSDate.Location = new Point(219, 322);
            dtpSDate.Margin = new Padding(3, 2, 3, 2);
            dtpSDate.Name = "dtpSDate";
            dtpSDate.Size = new Size(364, 25);
            dtpSDate.TabIndex = 7;
            // 
            // dtpEDate
            // 
            dtpEDate.Font = new Font("Segoe UI", 9.75F);
            dtpEDate.Location = new Point(219, 396);
            dtpEDate.Margin = new Padding(3, 2, 3, 2);
            dtpEDate.Name = "dtpEDate";
            dtpEDate.Size = new Size(364, 25);
            dtpEDate.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(64, 70);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 14;
            label3.Text = "Package Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(64, 206);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 16;
            label5.Text = "Package Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(45, 140);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 15;
            label6.Text = "Package Description:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(60, 401);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 18;
            label7.Text = "Package End Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(45, 327);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 17;
            label8.Text = "Package Start Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(45, 272);
            label9.Name = "label9";
            label9.Size = new Size(146, 20);
            label9.TabIndex = 19;
            label9.Text = "Agency Commission:";
            // 
            // frmAddModifyPackage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(619, 521);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(dtpEDate);
            Controls.Add(dtpSDate);
            Controls.Add(txtCom);
            Controls.Add(txtPrice);
            Controls.Add(txtPkgDesc);
            Controls.Add(txtPkgName);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAddModifyPackage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TravelExperts Add and Modify Packages";
            Load += frmAddModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private TextBox txtPkgName;
        private TextBox txtPkgDesc;
        private TextBox txtPrice;
        private TextBox txtCom;
        private DateTimePicker dtpSDate;
        private DateTimePicker dtpEDate;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}