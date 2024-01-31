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
            SuspendLayout();
            // 
            // btnProductsFrm
            // 
            btnProductsFrm.Font = new Font("Segoe UI", 10F);
            btnProductsFrm.Location = new Point(342, 395);
            btnProductsFrm.Name = "btnProductsFrm";
            btnProductsFrm.Size = new Size(172, 40);
            btnProductsFrm.TabIndex = 0;
            btnProductsFrm.Text = "Product Form";
            btnProductsFrm.UseVisualStyleBackColor = true;
            btnProductsFrm.Click += btnProductsFrm_Click;
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
            Controls.Add(btnProductsFrm);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTravelExperts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Experts";
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip tsNav;
        private ToolStripLabel tsProducts;
        private ToolStripLabel toolStripLabel1;
        private Button btnProductsFrm;
    }
}
