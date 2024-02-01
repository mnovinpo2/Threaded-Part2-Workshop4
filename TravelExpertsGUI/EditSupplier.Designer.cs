namespace TravelExpertsGUI
{
    partial class EditSupplier
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
            btnAccept = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSupID = new TextBox();
            txtSupName = new TextBox();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(55, 170);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(190, 170);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 58);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "Supplier ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 122);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Supplier Name:";
            // 
            // txtSupID
            // 
            txtSupID.Location = new Point(165, 55);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new Size(100, 23);
            txtSupID.TabIndex = 4;
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(165, 119);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(100, 23);
            txtSupName.TabIndex = 5;
            // 
            // EditSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 254);
            Controls.Add(txtSupName);
            Controls.Add(txtSupID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Name = "EditSupplier";
            Text = "EditSupplier";
            Load += EditSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccept;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private TextBox txtSupID;
        private TextBox txtSupName;
    }
}