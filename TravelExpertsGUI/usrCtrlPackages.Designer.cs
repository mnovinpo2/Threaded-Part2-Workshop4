﻿namespace TravelExpertsGUI
{
	partial class usrCtrlPackages
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
			dgvPackages = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
			SuspendLayout();
			// 
			// dgvPackages
			// 
			dgvPackages.AllowUserToAddRows = false;
			dgvPackages.AllowUserToDeleteRows = false;
			dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPackages.Dock = DockStyle.Fill;
			dgvPackages.Location = new Point(0, 0);
			dgvPackages.Margin = new Padding(3, 2, 3, 2);
			dgvPackages.Name = "dgvPackages";
			dgvPackages.ReadOnly = true;
			dgvPackages.RowHeadersWidth = 51;
			dgvPackages.Size = new Size(1032, 285);
			dgvPackages.TabIndex = 1;
			// 
			// usrCtrlPackages
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(dgvPackages);
			Name = "usrCtrlPackages";
			Size = new Size(1032, 285);
			Load += usrCtrlPackages_Load;
			((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvPackages;
	}
}
