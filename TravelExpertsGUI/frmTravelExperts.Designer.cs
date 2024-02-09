namespace TravelExpertsGUI
{
    partial class frmTravelExperts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnProductsFrm = new Button();
			btnPackageFrm = new Button();
			btnSuppliersFrm = new Button();
			btnProdSup = new Button();
			pnlMain = new Panel();
			usrCtrlProductSuppliersFrm = new usrCtrlProductSuppliers();
			usrCtrlSuppliersFrm = new usrCtrlSuppliers();
			usrCtrlProductsFrm = new usrCtrlProducts();
			usrCtrlPackagesFrm = new usrCtrlPackages();
			btnFrm = new Button();
			btnExit = new Button();
			pnlMain.SuspendLayout();
			SuspendLayout();
			// 
			// btnProductsFrm
			// 
			btnProductsFrm.Font = new Font("Segoe UI", 11.25F);
			btnProductsFrm.Location = new Point(636, 28);
			btnProductsFrm.Name = "btnProductsFrm";
			btnProductsFrm.Size = new Size(172, 40);
			btnProductsFrm.TabIndex = 0;
			btnProductsFrm.Text = "Product";
			btnProductsFrm.UseVisualStyleBackColor = true;
			btnProductsFrm.Click += btnProductsFrm_Click;
			// 
			// btnPackageFrm
			// 
			btnPackageFrm.Font = new Font("Segoe UI", 11.25F);
			btnPackageFrm.Location = new Point(280, 28);
			btnPackageFrm.Name = "btnPackageFrm";
			btnPackageFrm.Size = new Size(172, 40);
			btnPackageFrm.TabIndex = 1;
			btnPackageFrm.Text = "Packages";
			btnPackageFrm.UseVisualStyleBackColor = true;
			btnPackageFrm.Click += btnPackageFrm_Click;
			// 
			// btnSuppliersFrm
			// 
			btnSuppliersFrm.Font = new Font("Segoe UI", 11.25F);
			btnSuppliersFrm.Location = new Point(458, 28);
			btnSuppliersFrm.Name = "btnSuppliersFrm";
			btnSuppliersFrm.Size = new Size(172, 40);
			btnSuppliersFrm.TabIndex = 2;
			btnSuppliersFrm.Text = "Suppliers";
			btnSuppliersFrm.UseVisualStyleBackColor = true;
			btnSuppliersFrm.Click += btnSuppliersFrm_Click;
			// 
			// btnProdSup
			// 
			btnProdSup.Font = new Font("Segoe UI", 11.25F);
			btnProdSup.Location = new Point(814, 28);
			btnProdSup.Name = "btnProdSup";
			btnProdSup.Size = new Size(172, 40);
			btnProdSup.TabIndex = 3;
			btnProdSup.Text = "Product Suppliers";
			btnProdSup.UseVisualStyleBackColor = true;
			btnProdSup.Click += btnProdSup_Click;
			// 
			// pnlMain
			// 
			pnlMain.Controls.Add(usrCtrlProductSuppliersFrm);
			pnlMain.Controls.Add(usrCtrlSuppliersFrm);
			pnlMain.Controls.Add(usrCtrlProductsFrm);
			pnlMain.Controls.Add(usrCtrlPackagesFrm);
			pnlMain.Location = new Point(103, 91);
			pnlMain.Name = "pnlMain";
			pnlMain.Size = new Size(1032, 285);
			pnlMain.TabIndex = 4;
			// 
			// usrCtrlProductSuppliersFrm
			// 
			usrCtrlProductSuppliersFrm.Dock = DockStyle.Fill;
			usrCtrlProductSuppliersFrm.Location = new Point(0, 0);
			usrCtrlProductSuppliersFrm.Name = "usrCtrlProductSuppliersFrm";
			usrCtrlProductSuppliersFrm.Size = new Size(1032, 285);
			usrCtrlProductSuppliersFrm.TabIndex = 3;
			// 
			// usrCtrlSuppliersFrm
			// 
			usrCtrlSuppliersFrm.Dock = DockStyle.Fill;
			usrCtrlSuppliersFrm.Location = new Point(0, 0);
			usrCtrlSuppliersFrm.Name = "usrCtrlSuppliersFrm";
			usrCtrlSuppliersFrm.Size = new Size(1032, 285);
			usrCtrlSuppliersFrm.TabIndex = 2;
			// 
			// usrCtrlProductsFrm
			// 
			usrCtrlProductsFrm.Dock = DockStyle.Fill;
			usrCtrlProductsFrm.Location = new Point(0, 0);
			usrCtrlProductsFrm.Name = "usrCtrlProductsFrm";
			usrCtrlProductsFrm.Size = new Size(1032, 285);
			usrCtrlProductsFrm.TabIndex = 1;
			// 
			// usrCtrlPackagesFrm
			// 
			usrCtrlPackagesFrm.Dock = DockStyle.Fill;
			usrCtrlPackagesFrm.Location = new Point(0, 0);
			usrCtrlPackagesFrm.Name = "usrCtrlPackagesFrm";
			usrCtrlPackagesFrm.Size = new Size(1032, 285);
			usrCtrlPackagesFrm.TabIndex = 0;
			// 
			// btnFrm
			// 
			btnFrm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnFrm.Location = new Point(536, 405);
			btnFrm.Name = "btnFrm";
			btnFrm.Size = new Size(178, 37);
			btnFrm.TabIndex = 5;
			btnFrm.Text = "Edit";
			btnFrm.UseVisualStyleBackColor = true;
			btnFrm.Click += btnFrm_Click;
			// 
			// btnExit
			// 
			btnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnExit.Location = new Point(957, 405);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(178, 37);
			btnExit.TabIndex = 6;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// frmTravelExperts
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = SystemColors.Control;
			BackgroundImage = Properties.Resources.Clouds;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1219, 556);
			Controls.Add(btnExit);
			Controls.Add(btnFrm);
			Controls.Add(pnlMain);
			Controls.Add(btnProdSup);
			Controls.Add(btnSuppliersFrm);
			Controls.Add(btnPackageFrm);
			Controls.Add(btnProductsFrm);
			Cursor = Cursors.Hand;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmTravelExperts";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Travel Experts";
			Load += frmTravelExperts_Load;
			pnlMain.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private ToolStrip tsNav;
        private ToolStripLabel tsProducts;
        private ToolStripLabel toolStripLabel1;
        private Button btnProductsFrm;
        private Button btnPackageFrm;
        private Button btnSuppliersFrm;
		private Button btnProdSup;
		private Panel pnlMain;
		private usrCtrlPackages usrCtrlPackagesFrm;
		private usrCtrlProducts usrCtrlProductsFrm;
		private Button btnFrm;
		private usrCtrlProductSuppliers usrCtrlProductSuppliersFrm;
		private usrCtrlSuppliers usrCtrlSuppliersFrm;
		private Button btnExit;
	}
}
