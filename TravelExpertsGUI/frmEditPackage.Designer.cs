namespace TravelExpertsGUI
{
    partial class frmEditPackage
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
            dgv1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(46, 29);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(691, 376);
            dgv1.TabIndex = 0;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // frmEditPackage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 548);
            Controls.Add(dgv1);
            Name = "frmEditPackage";
            Text = "frmEditPkg";
            Load += frmEditPkg_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv1;
    }
}