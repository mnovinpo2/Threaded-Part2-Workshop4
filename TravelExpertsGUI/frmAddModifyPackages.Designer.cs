﻿namespace TravelExpertsGUI
{
    partial class frmAddModifyPackages
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
            btnOK = new Button();
            btnCancel = new Button();
            txtPkgId = new TextBox();
            txtPkgName = new TextBox();
            txtPkgDesc = new TextBox();
            txtPrice = new TextBox();
            txtCom = new TextBox();
            dtpSDate = new DateTimePicker();
            dtpEDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(36, 279);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 0;
            btnOK.Text = "btnOK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(594, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPkgId
            // 
            txtPkgId.Location = new Point(311, 33);
            txtPkgId.Name = "txtPkgId";
            txtPkgId.Size = new Size(125, 27);
            txtPkgId.TabIndex = 2;
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(311, 77);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(125, 27);
            txtPkgName.TabIndex = 3;
            // 
            // txtPkgDesc
            // 
            txtPkgDesc.Location = new Point(311, 123);
            txtPkgDesc.Name = "txtPkgDesc";
            txtPkgDesc.Size = new Size(125, 27);
            txtPkgDesc.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(311, 166);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtCom
            // 
            txtCom.Location = new Point(311, 210);
            txtCom.Name = "txtCom";
            txtCom.Size = new Size(125, 27);
            txtCom.TabIndex = 6;
            // 
            // dtpSDate
            // 
            dtpSDate.Location = new Point(241, 291);
            dtpSDate.Name = "dtpSDate";
            dtpSDate.Size = new Size(250, 27);
            dtpSDate.TabIndex = 7;
            // 
            // dtpEDate
            // 
            dtpEDate.Location = new Point(241, 369);
            dtpEDate.Name = "dtpEDate";
            dtpEDate.Size = new Size(250, 27);
            dtpEDate.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 268);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 9;
            label1.Text = "Package Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 346);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 10;
            label2.Text = "Package End Date:";
            // 
            // frmAddModify
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpEDate);
            Controls.Add(dtpSDate);
            Controls.Add(txtCom);
            Controls.Add(txtPrice);
            Controls.Add(txtPkgDesc);
            Controls.Add(txtPkgName);
            Controls.Add(txtPkgId);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Name = "frmAddModify";
            Text = "Form1";
            Load += frmAddModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private TextBox txtPkgId;
        private TextBox txtPkgName;
        private TextBox txtPkgDesc;
        private TextBox txtPrice;
        private TextBox txtCom;
        private DateTimePicker dtpSDate;
        private DateTimePicker dtpEDate;
        private Label label1;
        private Label label2;
    }
}