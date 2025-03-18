namespace ExpenseManager {
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterTransactionBtn = new System.Windows.Forms.Button();
            this.txtFilterTransaction = new System.Windows.Forms.ComboBox();
            this.dgvRecentlyTransaction = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentlyTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.createTransactionBtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.txtCategory);
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
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(112, 200);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(135, 20);
            this.txtNote.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(112, 137);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(135, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // txtCategory
            // 
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Items.AddRange(new object[] {
            "Food",
            "Bill&Utilities",
            "Shopping",
            "Education",
            "Entertainment",
            "Investment",
            "Other expense",
            "Salary",
            "Collect interest",
            "Other income",
            "Loan",
            "Repayment",
            "Debt collection",
            "Debt"});
            this.txtCategory.Location = new System.Drawing.Point(112, 71);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(135, 21);
            this.txtCategory.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 138);
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
            this.label2.Location = new System.Drawing.Point(19, 71);
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
            "Income",
            "Debt/loan"});
            this.txtFilterTransaction.Location = new System.Drawing.Point(597, 20);
            this.txtFilterTransaction.Name = "txtFilterTransaction";
            this.txtFilterTransaction.Size = new System.Drawing.Size(121, 21);
            this.txtFilterTransaction.TabIndex = 2;
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
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox txtCategory;
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
    }
}
