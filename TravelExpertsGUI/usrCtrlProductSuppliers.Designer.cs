namespace TravelExpertsGUI
{
	partial class usrCtrlProductSuppliers
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvProductSuppliers = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).BeginInit();
			SuspendLayout();
			// 
			// dgvProductSuppliers
			// 
			dgvProductSuppliers.AllowUserToAddRows = false;
			dgvProductSuppliers.AllowUserToDeleteRows = false;
			dgvProductSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProductSuppliers.Dock = DockStyle.Fill;
			dgvProductSuppliers.Location = new Point(0, 0);
			dgvProductSuppliers.Margin = new Padding(3, 2, 3, 2);
			dgvProductSuppliers.Name = "dgvProductSuppliers";
			dgvProductSuppliers.ReadOnly = true;
			dgvProductSuppliers.RowHeadersWidth = 51;
			dgvProductSuppliers.Size = new Size(1032, 285);
			dgvProductSuppliers.TabIndex = 2;
			// 
			// usrCtrlProductSuppliers
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dgvProductSuppliers);
			Name = "usrCtrlProductSuppliers";
			Size = new Size(1032, 285);
			Load += usrCtrlProductSuppliers_Load;
			((System.ComponentModel.ISupportInitialize)dgvProductSuppliers).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvProductSuppliers;
	}
}
