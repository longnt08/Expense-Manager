namespace ExpenseManager {
    partial class AddFundForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.exitAddMainBankLbl = new System.Windows.Forms.Label();
            this.addMainBankBtn = new System.Windows.Forms.Button();
            this.formLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.formLbl);
            this.panel1.Controls.Add(this.exitAddMainBankLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(99, 47);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(166, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 84);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(166, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // exitAddMainBankLbl
            // 
            this.exitAddMainBankLbl.AutoSize = true;
            this.exitAddMainBankLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitAddMainBankLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAddMainBankLbl.Location = new System.Drawing.Point(250, 9);
            this.exitAddMainBankLbl.Name = "exitAddMainBankLbl";
            this.exitAddMainBankLbl.Size = new System.Drawing.Size(15, 16);
            this.exitAddMainBankLbl.TabIndex = 5;
            this.exitAddMainBankLbl.Text = "X";
            this.exitAddMainBankLbl.Click += new System.EventHandler(this.exitAddMainBankLbl_Click);
            // 
            // addMainBankBtn
            // 
            this.addMainBankBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addMainBankBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMainBankBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addMainBankBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addMainBankBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMainBankBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMainBankBtn.ForeColor = System.Drawing.Color.White;
            this.addMainBankBtn.Location = new System.Drawing.Point(99, 122);
            this.addMainBankBtn.Name = "addMainBankBtn";
            this.addMainBankBtn.Size = new System.Drawing.Size(75, 23);
            this.addMainBankBtn.TabIndex = 5;
            this.addMainBankBtn.Text = "Add";
            this.addMainBankBtn.UseVisualStyleBackColor = false;
            this.addMainBankBtn.Click += new System.EventHandler(this.addMainBankBtn_Click);
            // 
            // formLbl
            // 
            this.formLbl.AutoSize = true;
            this.formLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLbl.Location = new System.Drawing.Point(104, 9);
            this.formLbl.Name = "formLbl";
            this.formLbl.Size = new System.Drawing.Size(70, 14);
            this.formLbl.TabIndex = 6;
            this.formLbl.Text = "MAIN BANK";
            // 
            // AddFundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 159);
            this.Controls.Add(this.addMainBankBtn);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFundForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitAddMainBankLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button addMainBankBtn;
        private System.Windows.Forms.Label formLbl;
    }
}