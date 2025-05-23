﻿namespace ExpenseManager {
    partial class ManageTransaction {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createTransactionBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterTransactionBtn = new System.Windows.Forms.Button();
            this.txtFilterTransaction = new System.Windows.Forms.ComboBox();
            this.dgvRecentlyTransaction = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFund = new System.Windows.Forms.ComboBox();
            this.cmbPartner = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.rdoCustomer = new System.Windows.Forms.RadioButton();
            this.rdoStaff = new System.Windows.Forms.RadioButton();
            this.rdoSupplier = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentlyTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.rdoSupplier);
            this.panel2.Controls.Add(this.rdoStaff);
            this.panel2.Controls.Add(this.rdoCustomer);
            this.panel2.Controls.Add(this.chooseFileBtn);
            this.panel2.Controls.Add(this.txtAttachment);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbPartner);
            this.panel2.Controls.Add(this.cmbFund);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.createTransactionBtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.BurlyWood;
            this.panel2.Location = new System.Drawing.Point(22, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 247);
            this.panel2.TabIndex = 3;
            // 
            // createTransactionBtn
            // 
            this.createTransactionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.createTransactionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTransactionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.createTransactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.createTransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTransactionBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTransactionBtn.ForeColor = System.Drawing.Color.White;
            this.createTransactionBtn.Location = new System.Drawing.Point(372, 191);
            this.createTransactionBtn.Name = "createTransactionBtn";
            this.createTransactionBtn.Size = new System.Drawing.Size(89, 36);
            this.createTransactionBtn.TabIndex = 10;
            this.createTransactionBtn.Text = "Create";
            this.createTransactionBtn.UseVisualStyleBackColor = false;
            this.createTransactionBtn.Click += new System.EventHandler(this.createTransactionBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Add new transaction";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(386, 59);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(135, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(112, 147);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(135, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Product Sales",
            "Service Revenue",
            "Investment Income",
            "Utilities Expense",
            "Salary Expense",
            "Office Supplies",
            "Tax Expense"});
            this.cmbCategory.Location = new System.Drawing.Point(112, 97);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(135, 21);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.Text = "Select";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(301, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.filterTransactionBtn);
            this.panel1.Controls.Add(this.txtFilterTransaction);
            this.panel1.Controls.Add(this.dgvRecentlyTransaction);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.BurlyWood;
            this.panel1.Location = new System.Drawing.Point(22, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 268);
            this.panel1.TabIndex = 2;
            // 
            // filterTransactionBtn
            // 
            this.filterTransactionBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTransactionBtn.ForeColor = System.Drawing.Color.Black;
            this.filterTransactionBtn.Location = new System.Drawing.Point(724, 18);
            this.filterTransactionBtn.Name = "filterTransactionBtn";
            this.filterTransactionBtn.Size = new System.Drawing.Size(75, 23);
            this.filterTransactionBtn.TabIndex = 4;
            this.filterTransactionBtn.Text = "Filter";
            this.filterTransactionBtn.UseVisualStyleBackColor = true;
            this.filterTransactionBtn.Click += new System.EventHandler(this.filterTransactionBtn_Click);
            // 
            // txtFilterTransaction
            // 
            this.txtFilterTransaction.FormattingEnabled = true;
            this.txtFilterTransaction.Items.AddRange(new object[] {
            "Expense",
            "Income"});
            this.txtFilterTransaction.Location = new System.Drawing.Point(597, 20);
            this.txtFilterTransaction.Name = "txtFilterTransaction";
            this.txtFilterTransaction.Size = new System.Drawing.Size(121, 21);
            this.txtFilterTransaction.TabIndex = 2;
            this.txtFilterTransaction.Text = "Select";
            // 
            // dgvRecentlyTransaction
            // 
            this.dgvRecentlyTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentlyTransaction.Location = new System.Drawing.Point(21, 56);
            this.dgvRecentlyTransaction.Name = "dgvRecentlyTransaction";
            this.dgvRecentlyTransaction.Size = new System.Drawing.Size(787, 192);
            this.dgvRecentlyTransaction.TabIndex = 1;
            this.dgvRecentlyTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentlyTransaction_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recently transactions";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fund";
            // 
            // cmbFund
            // 
            this.cmbFund.FormattingEnabled = true;
            this.cmbFund.Items.AddRange(new object[] {
            "Main Bank Account",
            "Cash on hand",
            "Petty Cash",
            "Savings Account"});
            this.cmbFund.Location = new System.Drawing.Point(112, 60);
            this.cmbFund.Name = "cmbFund";
            this.cmbFund.Size = new System.Drawing.Size(135, 21);
            this.cmbFund.TabIndex = 12;
            this.cmbFund.Text = "Select";
            // 
            // cmbPartner
            // 
            this.cmbPartner.FormattingEnabled = true;
            this.cmbPartner.Location = new System.Drawing.Point(664, 133);
            this.cmbPartner.Name = "cmbPartner";
            this.cmbPartner.Size = new System.Drawing.Size(135, 21);
            this.cmbPartner.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(594, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Partner";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(301, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Attachment";
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(386, 94);
            this.txtAttachment.Multiline = true;
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(135, 20);
            this.txtAttachment.TabIndex = 16;
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.ForeColor = System.Drawing.Color.Black;
            this.chooseFileBtn.Location = new System.Drawing.Point(446, 120);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseFileBtn.TabIndex = 17;
            this.chooseFileBtn.Text = "choose file";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            // 
            // rdoCustomer
            // 
            this.rdoCustomer.AutoSize = true;
            this.rdoCustomer.ForeColor = System.Drawing.Color.Black;
            this.rdoCustomer.Location = new System.Drawing.Point(664, 56);
            this.rdoCustomer.Name = "rdoCustomer";
            this.rdoCustomer.Size = new System.Drawing.Size(69, 17);
            this.rdoCustomer.TabIndex = 18;
            this.rdoCustomer.TabStop = true;
            this.rdoCustomer.Text = "Customer";
            this.rdoCustomer.UseVisualStyleBackColor = true;
            this.rdoCustomer.CheckedChanged += new System.EventHandler(this.rdoCustomer_CheckedChanged);
            // 
            // rdoStaff
            // 
            this.rdoStaff.AutoSize = true;
            this.rdoStaff.ForeColor = System.Drawing.Color.Black;
            this.rdoStaff.Location = new System.Drawing.Point(664, 110);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(47, 17);
            this.rdoStaff.TabIndex = 19;
            this.rdoStaff.TabStop = true;
            this.rdoStaff.Text = "Staff";
            this.rdoStaff.UseVisualStyleBackColor = true;
            this.rdoStaff.CheckedChanged += new System.EventHandler(this.rdoStaff_CheckedChanged);
            // 
            // rdoSupplier
            // 
            this.rdoSupplier.AutoSize = true;
            this.rdoSupplier.ForeColor = System.Drawing.Color.Black;
            this.rdoSupplier.Location = new System.Drawing.Point(664, 84);
            this.rdoSupplier.Name = "rdoSupplier";
            this.rdoSupplier.Size = new System.Drawing.Size(63, 17);
            this.rdoSupplier.TabIndex = 20;
            this.rdoSupplier.TabStop = true;
            this.rdoSupplier.Text = "Supplier";
            this.rdoSupplier.UseVisualStyleBackColor = true;
            this.rdoSupplier.CheckedChanged += new System.EventHandler(this.rdoSupplier_CheckedChanged);
            // 
            // ManageTransaction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageTransaction";
            this.Size = new System.Drawing.Size(875, 557);
            this.Load += new System.EventHandler(this.ManageTransaction_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentlyTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRecentlyTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button createTransactionBtn;
        private System.Windows.Forms.ComboBox txtFilterTransaction;
        private System.Windows.Forms.Button filterTransactionBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPartner;
        private System.Windows.Forms.ComboBox cmbFund;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdoCustomer;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.RadioButton rdoSupplier;
        private System.Windows.Forms.RadioButton rdoStaff;
    }
}
