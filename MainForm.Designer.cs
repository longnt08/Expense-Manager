namespace ExpenseManager {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelExitMain = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.manageAccBtn = new System.Windows.Forms.Button();
            this.SignoutBtn = new System.Windows.Forms.Button();
            this.manageBudgetBtn = new System.Windows.Forms.Button();
            this.manageGoalBtn = new System.Windows.Forms.Button();
            this.manageTransactionBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.MainFormUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new ExpenseManager.Dashboard();
            this.manageTransaction1 = new ExpenseManager.ManageTransaction();
            this.manageGoal1 = new ExpenseManager.ManageGoal();
            this.manageBudget1 = new ExpenseManager.ManageBudget();
            this.manageAccount1 = new ExpenseManager.ManageAccount();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelExitMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense Manager";
            // 
            // labelExitMain
            // 
            this.labelExitMain.AutoSize = true;
            this.labelExitMain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExitMain.ForeColor = System.Drawing.Color.White;
            this.labelExitMain.Location = new System.Drawing.Point(1071, 8);
            this.labelExitMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExitMain.Name = "labelExitMain";
            this.labelExitMain.Size = new System.Drawing.Size(15, 16);
            this.labelExitMain.TabIndex = 1;
            this.labelExitMain.Text = "X";
            this.labelExitMain.Click += new System.EventHandler(this.labelExitMain_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.BtnSetting);
            this.panel2.Controls.Add(this.manageAccBtn);
            this.panel2.Controls.Add(this.SignoutBtn);
            this.panel2.Controls.Add(this.manageBudgetBtn);
            this.panel2.Controls.Add(this.manageGoalBtn);
            this.panel2.Controls.Add(this.manageTransactionBtn);
            this.panel2.Controls.Add(this.dashboardBtn);
            this.panel2.Controls.Add(this.MainFormUsername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 557);
            this.panel2.TabIndex = 1;
            // 
            // BtnSetting
            // 
            this.BtnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.BtnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.BtnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.BtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetting.ForeColor = System.Drawing.Color.White;
            this.BtnSetting.Location = new System.Drawing.Point(142, 515);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(70, 30);
            this.BtnSetting.TabIndex = 8;
            this.BtnSetting.Text = "Settings";
            this.BtnSetting.UseVisualStyleBackColor = false;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // manageAccBtn
            // 
            this.manageAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.manageAccBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageAccBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.manageAccBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.manageAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageAccBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAccBtn.ForeColor = System.Drawing.Color.White;
            this.manageAccBtn.Location = new System.Drawing.Point(12, 434);
            this.manageAccBtn.Name = "manageAccBtn";
            this.manageAccBtn.Size = new System.Drawing.Size(200, 40);
            this.manageAccBtn.TabIndex = 7;
            this.manageAccBtn.Text = "YOUR ACCOUNT";
            this.manageAccBtn.UseVisualStyleBackColor = false;
            this.manageAccBtn.Click += new System.EventHandler(this.manageAccBtn_Click);
            // 
            // SignoutBtn
            // 
            this.SignoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.SignoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.SignoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.SignoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignoutBtn.ForeColor = System.Drawing.Color.White;
            this.SignoutBtn.Location = new System.Drawing.Point(12, 515);
            this.SignoutBtn.Name = "SignoutBtn";
            this.SignoutBtn.Size = new System.Drawing.Size(70, 30);
            this.SignoutBtn.TabIndex = 6;
            this.SignoutBtn.Text = "Sign out";
            this.SignoutBtn.UseVisualStyleBackColor = false;
            // 
            // manageBudgetBtn
            // 
            this.manageBudgetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.manageBudgetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageBudgetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.manageBudgetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.manageBudgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBudgetBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBudgetBtn.ForeColor = System.Drawing.Color.White;
            this.manageBudgetBtn.Location = new System.Drawing.Point(12, 377);
            this.manageBudgetBtn.Name = "manageBudgetBtn";
            this.manageBudgetBtn.Size = new System.Drawing.Size(200, 40);
            this.manageBudgetBtn.TabIndex = 5;
            this.manageBudgetBtn.Text = "MANAGE BUDGET";
            this.manageBudgetBtn.UseVisualStyleBackColor = false;
            this.manageBudgetBtn.Click += new System.EventHandler(this.manageBudgetBtn_Click);
            // 
            // manageGoalBtn
            // 
            this.manageGoalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.manageGoalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageGoalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.manageGoalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.manageGoalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageGoalBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageGoalBtn.ForeColor = System.Drawing.Color.White;
            this.manageGoalBtn.Location = new System.Drawing.Point(12, 320);
            this.manageGoalBtn.Name = "manageGoalBtn";
            this.manageGoalBtn.Size = new System.Drawing.Size(200, 40);
            this.manageGoalBtn.TabIndex = 4;
            this.manageGoalBtn.Text = "MANAGE GOAL";
            this.manageGoalBtn.UseVisualStyleBackColor = false;
            this.manageGoalBtn.Click += new System.EventHandler(this.manageGoalBtn_Click);
            // 
            // manageTransactionBtn
            // 
            this.manageTransactionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.manageTransactionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageTransactionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.manageTransactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.manageTransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageTransactionBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTransactionBtn.ForeColor = System.Drawing.Color.White;
            this.manageTransactionBtn.Location = new System.Drawing.Point(12, 264);
            this.manageTransactionBtn.Name = "manageTransactionBtn";
            this.manageTransactionBtn.Size = new System.Drawing.Size(200, 41);
            this.manageTransactionBtn.TabIndex = 3;
            this.manageTransactionBtn.Text = "MANAGE TRANSACTION";
            this.manageTransactionBtn.UseVisualStyleBackColor = false;
            this.manageTransactionBtn.Click += new System.EventHandler(this.manageTransactionBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(12, 208);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(200, 40);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Text = "DASHBOARD";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // MainFormUsername
            // 
            this.MainFormUsername.AutoSize = true;
            this.MainFormUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormUsername.ForeColor = System.Drawing.Color.White;
            this.MainFormUsername.Location = new System.Drawing.Point(56, 147);
            this.MainFormUsername.Name = "MainFormUsername";
            this.MainFormUsername.Size = new System.Drawing.Size(108, 19);
            this.MainFormUsername.TabIndex = 1;
            this.MainFormUsername.Text = "Welcome user";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.manageTransaction1);
            this.panel3.Controls.Add(this.manageGoal1);
            this.panel3.Controls.Add(this.manageBudget1);
            this.panel3.Controls.Add(this.manageAccount1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 557);
            this.panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(875, 557);
            this.dashboard1.TabIndex = 4;
            // 
            // manageTransaction1
            // 
            this.manageTransaction1.Location = new System.Drawing.Point(0, 0);
            this.manageTransaction1.Name = "manageTransaction1";
            this.manageTransaction1.Size = new System.Drawing.Size(875, 557);
            this.manageTransaction1.TabIndex = 3;
            // 
            // manageGoal1
            // 
            this.manageGoal1.Location = new System.Drawing.Point(0, 0);
            this.manageGoal1.Name = "manageGoal1";
            this.manageGoal1.Size = new System.Drawing.Size(875, 557);
            this.manageGoal1.TabIndex = 2;
            // 
            // manageBudget1
            // 
            this.manageBudget1.Location = new System.Drawing.Point(0, 0);
            this.manageBudget1.Name = "manageBudget1";
            this.manageBudget1.Size = new System.Drawing.Size(875, 557);
            this.manageBudget1.TabIndex = 1;
            // 
            // manageAccount1
            // 
            this.manageAccount1.Location = new System.Drawing.Point(0, 0);
            this.manageAccount1.Name = "manageAccount1";
            this.manageAccount1.Size = new System.Drawing.Size(875, 557);
            this.manageAccount1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelExitMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainFormUsername;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button manageGoalBtn;
        private System.Windows.Forms.Button manageTransactionBtn;
        private System.Windows.Forms.Button manageBudgetBtn;
        private System.Windows.Forms.Button SignoutBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button manageAccBtn;
        private System.Windows.Forms.Button BtnSetting;
        private ManageTransaction manageTransaction1;
        private ManageGoal manageGoal1;
        private ManageBudget manageBudget1;
        private ManageAccount manageAccount1;
        private Dashboard dashboard1;
    }
}