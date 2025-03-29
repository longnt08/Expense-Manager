namespace ExpenseManager {
    partial class UpdateTransactionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateTransactionBtn = new System.Windows.Forms.Button();
            this.exitLbl = new System.Windows.Forms.Label();
            this.rdoSupplier = new System.Windows.Forms.RadioButton();
            this.rdoStaff = new System.Windows.Forms.RadioButton();
            this.rdoCustomer = new System.Windows.Forms.RadioButton();
            this.chooseUpdateFileBtn = new System.Windows.Forms.Button();
            this.txtUpdateAttachment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPartner = new System.Windows.Forms.ComboBox();
            this.cmbUpdateFund = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.txtUpdateAmount = new System.Windows.Forms.TextBox();
            this.cmbUpdateCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoUpdateSupplier = new System.Windows.Forms.RadioButton();
            this.rdoUpdateStaff = new System.Windows.Forms.RadioButton();
            this.rdoUpdateCustomer = new System.Windows.Forms.RadioButton();
            this.cmbUpdatePartner = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE TRANSACTION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.exitLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 46);
            this.panel1.TabIndex = 1;
            // 
            // updateTransactionBtn
            // 
            this.updateTransactionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.updateTransactionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateTransactionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.updateTransactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.updateTransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTransactionBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTransactionBtn.ForeColor = System.Drawing.Color.White;
            this.updateTransactionBtn.Location = new System.Drawing.Point(412, 211);
            this.updateTransactionBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateTransactionBtn.Name = "updateTransactionBtn";
            this.updateTransactionBtn.Size = new System.Drawing.Size(93, 37);
            this.updateTransactionBtn.TabIndex = 17;
            this.updateTransactionBtn.Text = "Update";
            this.updateTransactionBtn.UseVisualStyleBackColor = false;
            this.updateTransactionBtn.Click += new System.EventHandler(this.updateTransactionBtn_Click);
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.exitLbl.ForeColor = System.Drawing.Color.White;
            this.exitLbl.Location = new System.Drawing.Point(525, 9);
            this.exitLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(15, 16);
            this.exitLbl.TabIndex = 18;
            this.exitLbl.Text = "X";
            this.exitLbl.Click += new System.EventHandler(this.exitLbl_Click);
            // 
            // rdoSupplier
            // 
            this.rdoSupplier.AutoSize = true;
            this.rdoSupplier.ForeColor = System.Drawing.Color.Black;
            this.rdoSupplier.Location = new System.Drawing.Point(657, 122);
            this.rdoSupplier.Name = "rdoSupplier";
            this.rdoSupplier.Size = new System.Drawing.Size(72, 20);
            this.rdoSupplier.TabIndex = 36;
            this.rdoSupplier.TabStop = true;
            this.rdoSupplier.Text = "Supplier";
            this.rdoSupplier.UseVisualStyleBackColor = true;
            // 
            // rdoStaff
            // 
            this.rdoStaff.AutoSize = true;
            this.rdoStaff.ForeColor = System.Drawing.Color.Black;
            this.rdoStaff.Location = new System.Drawing.Point(657, 148);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(52, 20);
            this.rdoStaff.TabIndex = 35;
            this.rdoStaff.TabStop = true;
            this.rdoStaff.Text = "Staff";
            this.rdoStaff.UseVisualStyleBackColor = true;
            // 
            // rdoCustomer
            // 
            this.rdoCustomer.AutoSize = true;
            this.rdoCustomer.ForeColor = System.Drawing.Color.Black;
            this.rdoCustomer.Location = new System.Drawing.Point(657, 94);
            this.rdoCustomer.Name = "rdoCustomer";
            this.rdoCustomer.Size = new System.Drawing.Size(80, 20);
            this.rdoCustomer.TabIndex = 34;
            this.rdoCustomer.TabStop = true;
            this.rdoCustomer.Text = "Customer";
            this.rdoCustomer.UseVisualStyleBackColor = true;
            // 
            // chooseUpdateFileBtn
            // 
            this.chooseUpdateFileBtn.ForeColor = System.Drawing.Color.Black;
            this.chooseUpdateFileBtn.Location = new System.Drawing.Point(439, 139);
            this.chooseUpdateFileBtn.Name = "chooseUpdateFileBtn";
            this.chooseUpdateFileBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseUpdateFileBtn.TabIndex = 33;
            this.chooseUpdateFileBtn.Text = "choose file";
            this.chooseUpdateFileBtn.UseVisualStyleBackColor = true;
            // 
            // txtUpdateAttachment
            // 
            this.txtUpdateAttachment.Location = new System.Drawing.Point(379, 113);
            this.txtUpdateAttachment.Multiline = true;
            this.txtUpdateAttachment.Name = "txtUpdateAttachment";
            this.txtUpdateAttachment.Size = new System.Drawing.Size(135, 20);
            this.txtUpdateAttachment.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(292, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Attachment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Partner";
            // 
            // cmbPartner
            // 
            this.cmbPartner.FormattingEnabled = true;
            this.cmbPartner.Location = new System.Drawing.Point(657, 171);
            this.cmbPartner.Name = "cmbPartner";
            this.cmbPartner.Size = new System.Drawing.Size(135, 24);
            this.cmbPartner.TabIndex = 29;
            // 
            // cmbUpdateFund
            // 
            this.cmbUpdateFund.FormattingEnabled = true;
            this.cmbUpdateFund.Items.AddRange(new object[] {
            "Main Bank Account",
            "Cash on hand",
            "Petty Cash",
            "Savings Account"});
            this.cmbUpdateFund.Location = new System.Drawing.Point(77, 65);
            this.cmbUpdateFund.Name = "cmbUpdateFund";
            this.cmbUpdateFund.Size = new System.Drawing.Size(135, 24);
            this.cmbUpdateFund.TabIndex = 28;
            this.cmbUpdateFund.Text = "Select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fund";
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(379, 65);
            this.txtUpdateDescription.Multiline = true;
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(135, 20);
            this.txtUpdateDescription.TabIndex = 26;
            // 
            // txtUpdateAmount
            // 
            this.txtUpdateAmount.Location = new System.Drawing.Point(77, 158);
            this.txtUpdateAmount.Multiline = true;
            this.txtUpdateAmount.Name = "txtUpdateAmount";
            this.txtUpdateAmount.Size = new System.Drawing.Size(135, 20);
            this.txtUpdateAmount.TabIndex = 25;
            // 
            // cmbUpdateCategory
            // 
            this.cmbUpdateCategory.FormattingEnabled = true;
            this.cmbUpdateCategory.Items.AddRange(new object[] {
            "Product Sales",
            "Service Revenue",
            "Investment Income",
            "Utilities Expense",
            "Salary Expense",
            "Office Supplies",
            "Tax Expense"});
            this.cmbUpdateCategory.Location = new System.Drawing.Point(77, 113);
            this.cmbUpdateCategory.Name = "cmbUpdateCategory";
            this.cmbUpdateCategory.Size = new System.Drawing.Size(135, 24);
            this.cmbUpdateCategory.TabIndex = 24;
            this.cmbUpdateCategory.Text = "Select";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(294, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Amout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category";
            // 
            // rdoUpdateSupplier
            // 
            this.rdoUpdateSupplier.AutoSize = true;
            this.rdoUpdateSupplier.ForeColor = System.Drawing.Color.Black;
            this.rdoUpdateSupplier.Location = new System.Drawing.Point(163, 198);
            this.rdoUpdateSupplier.Name = "rdoUpdateSupplier";
            this.rdoUpdateSupplier.Size = new System.Drawing.Size(72, 20);
            this.rdoUpdateSupplier.TabIndex = 40;
            this.rdoUpdateSupplier.TabStop = true;
            this.rdoUpdateSupplier.Text = "Supplier";
            this.rdoUpdateSupplier.UseVisualStyleBackColor = true;
            this.rdoUpdateSupplier.CheckedChanged += new System.EventHandler(this.rdoUpdateSupplier_CheckedChanged);
            // 
            // rdoUpdateStaff
            // 
            this.rdoUpdateStaff.AutoSize = true;
            this.rdoUpdateStaff.ForeColor = System.Drawing.Color.Black;
            this.rdoUpdateStaff.Location = new System.Drawing.Point(241, 198);
            this.rdoUpdateStaff.Name = "rdoUpdateStaff";
            this.rdoUpdateStaff.Size = new System.Drawing.Size(52, 20);
            this.rdoUpdateStaff.TabIndex = 39;
            this.rdoUpdateStaff.TabStop = true;
            this.rdoUpdateStaff.Text = "Staff";
            this.rdoUpdateStaff.UseVisualStyleBackColor = true;
            this.rdoUpdateStaff.CheckedChanged += new System.EventHandler(this.rdoUpdateStaff_CheckedChanged);
            // 
            // rdoUpdateCustomer
            // 
            this.rdoUpdateCustomer.AutoSize = true;
            this.rdoUpdateCustomer.ForeColor = System.Drawing.Color.Black;
            this.rdoUpdateCustomer.Location = new System.Drawing.Point(77, 198);
            this.rdoUpdateCustomer.Name = "rdoUpdateCustomer";
            this.rdoUpdateCustomer.Size = new System.Drawing.Size(80, 20);
            this.rdoUpdateCustomer.TabIndex = 38;
            this.rdoUpdateCustomer.TabStop = true;
            this.rdoUpdateCustomer.Text = "Customer";
            this.rdoUpdateCustomer.UseVisualStyleBackColor = true;
            this.rdoUpdateCustomer.CheckedChanged += new System.EventHandler(this.rdoUpdateCustomer_CheckedChanged);
            // 
            // cmbUpdatePartner
            // 
            this.cmbUpdatePartner.FormattingEnabled = true;
            this.cmbUpdatePartner.Location = new System.Drawing.Point(77, 224);
            this.cmbUpdatePartner.Name = "cmbUpdatePartner";
            this.cmbUpdatePartner.Size = new System.Drawing.Size(135, 24);
            this.cmbUpdatePartner.TabIndex = 37;
            // 
            // UpdateTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 278);
            this.Controls.Add(this.rdoUpdateSupplier);
            this.Controls.Add(this.rdoUpdateStaff);
            this.Controls.Add(this.rdoUpdateCustomer);
            this.Controls.Add(this.cmbUpdatePartner);
            this.Controls.Add(this.rdoSupplier);
            this.Controls.Add(this.rdoStaff);
            this.Controls.Add(this.rdoCustomer);
            this.Controls.Add(this.chooseUpdateFileBtn);
            this.Controls.Add(this.txtUpdateAttachment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPartner);
            this.Controls.Add(this.cmbUpdateFund);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUpdateDescription);
            this.Controls.Add(this.txtUpdateAmount);
            this.Controls.Add(this.cmbUpdateCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateTransactionBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateTransaction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateTransactionBtn;
        private System.Windows.Forms.Label exitLbl;
        private System.Windows.Forms.RadioButton rdoSupplier;
        private System.Windows.Forms.RadioButton rdoStaff;
        private System.Windows.Forms.RadioButton rdoCustomer;
        private System.Windows.Forms.Button chooseUpdateFileBtn;
        private System.Windows.Forms.TextBox txtUpdateAttachment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPartner;
        private System.Windows.Forms.ComboBox cmbUpdateFund;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateAmount;
        private System.Windows.Forms.ComboBox cmbUpdateCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoUpdateSupplier;
        private System.Windows.Forms.RadioButton rdoUpdateStaff;
        private System.Windows.Forms.RadioButton rdoUpdateCustomer;
        private System.Windows.Forms.ComboBox cmbUpdatePartner;
    }
}