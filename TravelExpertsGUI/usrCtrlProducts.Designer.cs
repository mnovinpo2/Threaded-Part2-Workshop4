namespace TravelExpertsGUI
{
	partial class usrCtrlProducts
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
			dgvProducts = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
			SuspendLayout();
			// 
			// dgvProducts
			// 
			dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProducts.Dock = DockStyle.Fill;
			dgvProducts.Location = new Point(0, 0);
			dgvProducts.Margin = new Padding(3, 2, 3, 2);
			dgvProducts.Name = "dgvProducts";
			dgvProducts.RowHeadersWidth = 51;
			dgvProducts.Size = new Size(1032, 285);
			dgvProducts.TabIndex = 1;
			// 
			// usrCtrlProducts
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dgvProducts);
			Name = "usrCtrlProducts";
			Size = new Size(1032, 285);
			Load += usrCtrlProducts_Load;
			((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvProducts;
	}
}
