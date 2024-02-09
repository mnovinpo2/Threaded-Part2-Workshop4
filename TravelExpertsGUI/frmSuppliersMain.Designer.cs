namespace TravelExpertsGUI
{
    partial class frmSuppliersMain
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
            btnAdd = new Button();
            dgvSupplier = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(324, 352);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Supplier";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvSupplier
            // 
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(126, 58);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.Size = new Size(562, 262);
            dgvSupplier.TabIndex = 2;
            dgvSupplier.CellContentClick += dgvSupplier_CellContentClick_1;
            // 
            // TemporaryMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSupplier);
            Controls.Add(btnAdd);
            Name = "TemporaryMainForm";
            Text = "TemporaryMainForm";
            Load += TemporaryMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private DataGridView dgvSupplier;
    }
}