namespace ExpenseManager {
    partial class ManageBudget {
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
            this.createBudgetBtn = new System.Windows.Forms.Button();
            this.dtPickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.AddNewTransactionLabel = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterBudgetBtn = new System.Windows.Forms.Button();
            this.txtFilterBudgets = new System.Windows.Forms.ComboBox();
            this.dgvBudgets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.createBudgetBtn);
            this.panel2.Controls.Add(this.dtPickerEndDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtPickerStartDate);
            this.panel2.Controls.Add(this.AddNewTransactionLabel);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.txtCategory);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.BurlyWood;
            this.panel2.Location = new System.Drawing.Point(23, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 247);
            this.panel2.TabIndex = 5;
            // 
            // createBudgetBtn
            // 
            this.createBudgetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.createBudgetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBudgetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.createBudgetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.createBudgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBudgetBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBudgetBtn.ForeColor = System.Drawing.Color.White;
            this.createBudgetBtn.Location = new System.Drawing.Point(376, 189);
            this.createBudgetBtn.Name = "createBudgetBtn";
            this.createBudgetBtn.Size = new System.Drawing.Size(89, 36);
            this.createBudgetBtn.TabIndex = 10;
            this.createBudgetBtn.Text = "Create";
            this.createBudgetBtn.UseVisualStyleBackColor = false;
            this.createBudgetBtn.Click += new System.EventHandler(this.createBudgetBtn_Click);
            // 
            // dtPickerEndDate
            // 
            this.dtPickerEndDate.Location = new System.Drawing.Point(112, 205);
            this.dtPickerEndDate.Name = "dtPickerEndDate";
            this.dtPickerEndDate.Size = new System.Drawing.Size(135, 20);
            this.dtPickerEndDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "End date";
            // 
            // dtPickerStartDate
            // 
            this.dtPickerStartDate.Location = new System.Drawing.Point(112, 156);
            this.dtPickerStartDate.Name = "dtPickerStartDate";
            this.dtPickerStartDate.Size = new System.Drawing.Size(135, 20);
            this.dtPickerStartDate.TabIndex = 7;
            // 
            // AddNewTransactionLabel
            // 
            this.AddNewTransactionLabel.AutoSize = true;
            this.AddNewTransactionLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.AddNewTransactionLabel.Location = new System.Drawing.Point(18, 18);
            this.AddNewTransactionLabel.Name = "AddNewTransactionLabel";
            this.AddNewTransactionLabel.Size = new System.Drawing.Size(150, 23);
            this.AddNewTransactionLabel.TabIndex = 6;
            this.AddNewTransactionLabel.Text = "Add new budget";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(112, 112);
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
            this.label4.Location = new System.Drawing.Point(19, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 116);
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
            this.panel1.Controls.Add(this.filterBudgetBtn);
            this.panel1.Controls.Add(this.txtFilterBudgets);
            this.panel1.Controls.Add(this.dgvBudgets);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.BurlyWood;
            this.panel1.Location = new System.Drawing.Point(23, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 268);
            this.panel1.TabIndex = 4;
            // 
            // filterBudgetBtn
            // 
            this.filterBudgetBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBudgetBtn.ForeColor = System.Drawing.Color.Black;
            this.filterBudgetBtn.Location = new System.Drawing.Point(731, 17);
            this.filterBudgetBtn.Name = "filterBudgetBtn";
            this.filterBudgetBtn.Size = new System.Drawing.Size(75, 23);
            this.filterBudgetBtn.TabIndex = 6;
            this.filterBudgetBtn.Text = "Filter";
            this.filterBudgetBtn.UseVisualStyleBackColor = true;
            this.filterBudgetBtn.Click += new System.EventHandler(this.filterBudgetBtn_Click);
            // 
            // txtFilterBudgets
            // 
            this.txtFilterBudgets.FormattingEnabled = true;
            this.txtFilterBudgets.Items.AddRange(new object[] {
            "Expense",
            "Income",
            "Debt/loan"});
            this.txtFilterBudgets.Location = new System.Drawing.Point(604, 19);
            this.txtFilterBudgets.Name = "txtFilterBudgets";
            this.txtFilterBudgets.Size = new System.Drawing.Size(121, 21);
            this.txtFilterBudgets.TabIndex = 5;
            // 
            // dgvBudgets
            // 
            this.dgvBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgets.Location = new System.Drawing.Point(21, 56);
            this.dgvBudgets.Name = "dgvBudgets";
            this.dgvBudgets.Size = new System.Drawing.Size(787, 192);
            this.dgvBudgets.TabIndex = 1;
            this.dgvBudgets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBudgets_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your\'s budgets";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ManageBudget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageBudget";
            this.Size = new System.Drawing.Size(875, 557);
            this.Load += new System.EventHandler(this.ManageBudget_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AddNewTransactionLabel;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBudgets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dtPickerEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPickerStartDate;
        private System.Windows.Forms.Button createBudgetBtn;
        private System.Windows.Forms.Button filterBudgetBtn;
        private System.Windows.Forms.ComboBox txtFilterBudgets;
    }
}
