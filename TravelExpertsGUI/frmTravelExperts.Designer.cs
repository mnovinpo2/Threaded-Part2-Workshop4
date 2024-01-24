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
            SuspendLayout();
            // 
            // frmTravelExperts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1393, 741);
            Cursor = Cursors.Hand;
            Name = "frmTravelExperts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Experts";
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip tsNav;
        private ToolStripLabel tsProducts;
        private ToolStripLabel toolStripLabel1;
    }
}
