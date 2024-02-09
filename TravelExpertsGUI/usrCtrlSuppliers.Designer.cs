namespace TravelExpertsGUI
{
	partial class usrCtrlSuppliers
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
			dgvSuppliers = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
			SuspendLayout();
			// 
			// dgvSuppliers
			// 
			dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSuppliers.Dock = DockStyle.Fill;
			dgvSuppliers.Location = new Point(0, 0);
			dgvSuppliers.Name = "dgvSuppliers";
			dgvSuppliers.Size = new Size(1032, 285);
			dgvSuppliers.TabIndex = 0;
			// 
			// usrCtrlSuppliers
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dgvSuppliers);
			Name = "usrCtrlSuppliers";
			Size = new Size(1032, 285);
			Load += usrCtrlSuppliers_Load;
			((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvSuppliers;
	}
}
