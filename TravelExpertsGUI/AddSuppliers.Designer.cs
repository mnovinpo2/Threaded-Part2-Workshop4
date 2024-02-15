namespace TravelExpertsGUI
{
    partial class AddSuppliers
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
            label1 = new Label();
            label2 = new Label();
            btnAccept = new Button();
            txtSupID = new TextBox();
            txtSupName = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Supplier ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 94);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Supplier Name:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(55, 175);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtSupID
            // 
            txtSupID.Location = new Point(132, 34);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new Size(152, 23);
            txtSupID.TabIndex = 3;
            txtSupID.Tag = "Supplier ID";
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(132, 91);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(152, 23);
            txtSupName.TabIndex = 4;
            txtSupName.Tag = "Supplier Name";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(186, 175);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Clouds;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(332, 271);
            Controls.Add(btnCancel);
            Controls.Add(txtSupName);
            Controls.Add(txtSupID);
            Controls.Add(btnAccept);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddSuppliers";
            Text = "AddSuppliers";
            Load += AddSuppliers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAccept;
        private TextBox txtSupID;
        private TextBox txtSupName;
        private Button btnCancel;
    }
}