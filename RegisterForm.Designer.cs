namespace ExpenseManager {
    partial class RegisterForm {
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
            this.registerPicture = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelRegisterExpenseManager = new System.Windows.Forms.Label();
            this.registerLoginBtn = new System.Windows.Forms.Button();
            this.labelRegisterLoginAccount = new System.Windows.Forms.Label();
            this.registerShowPass = new System.Windows.Forms.CheckBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.labelRegisterUsername = new System.Windows.Forms.Label();
            this.lableRegisterAccount = new System.Windows.Forms.Label();
            this.labelRegisterExit = new System.Windows.Forms.Label();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.labelResgiterEmail = new System.Windows.Forms.Label();
            this.txtRegisterPhone = new System.Windows.Forms.TextBox();
            this.labelRegisterPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registerPicture)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPicture
            // 
            this.registerPicture.Image = global::ExpenseManager.Properties.Resources.ExpenseManagerAppIcon;
            this.registerPicture.Location = new System.Drawing.Point(71, 27);
            this.registerPicture.Name = "registerPicture";
            this.registerPicture.Size = new System.Drawing.Size(129, 101);
            this.registerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.registerPicture.TabIndex = 10;
            this.registerPicture.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.registerPicture);
            this.panelLogin.Controls.Add(this.labelRegisterExpenseManager);
            this.panelLogin.Controls.Add(this.registerLoginBtn);
            this.panelLogin.Controls.Add(this.labelRegisterLoginAccount);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(296, 445);
            this.panelLogin.TabIndex = 9;
            // 
            // labelRegisterExpenseManager
            // 
            this.labelRegisterExpenseManager.AutoSize = true;
            this.labelRegisterExpenseManager.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterExpenseManager.ForeColor = System.Drawing.Color.White;
            this.labelRegisterExpenseManager.Location = new System.Drawing.Point(25, 169);
            this.labelRegisterExpenseManager.Name = "labelRegisterExpenseManager";
            this.labelRegisterExpenseManager.Size = new System.Drawing.Size(224, 33);
            this.labelRegisterExpenseManager.TabIndex = 9;
            this.labelRegisterExpenseManager.Text = "Expense Manager";
            // 
            // registerLoginBtn
            // 
            this.registerLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.registerLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLoginBtn.FlatAppearance.BorderSize = 0;
            this.registerLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.registerLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.registerLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerLoginBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLoginBtn.ForeColor = System.Drawing.Color.White;
            this.registerLoginBtn.Location = new System.Drawing.Point(11, 339);
            this.registerLoginBtn.Name = "registerLoginBtn";
            this.registerLoginBtn.Size = new System.Drawing.Size(266, 40);
            this.registerLoginBtn.TabIndex = 1;
            this.registerLoginBtn.Text = "SIGN IN";
            this.registerLoginBtn.UseVisualStyleBackColor = false;
            this.registerLoginBtn.Click += new System.EventHandler(this.registerLoginBtn_Click);
            // 
            // labelRegisterLoginAccount
            // 
            this.labelRegisterLoginAccount.AutoSize = true;
            this.labelRegisterLoginAccount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterLoginAccount.ForeColor = System.Drawing.Color.White;
            this.labelRegisterLoginAccount.Location = new System.Drawing.Point(68, 301);
            this.labelRegisterLoginAccount.Name = "labelRegisterLoginAccount";
            this.labelRegisterLoginAccount.Size = new System.Drawing.Size(131, 18);
            this.labelRegisterLoginAccount.TabIndex = 0;
            this.labelRegisterLoginAccount.Text = "Login your account";
            // 
            // registerShowPass
            // 
            this.registerShowPass.AutoSize = true;
            this.registerShowPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerShowPass.Location = new System.Drawing.Point(523, 352);
            this.registerShowPass.Name = "registerShowPass";
            this.registerShowPass.Size = new System.Drawing.Size(110, 18);
            this.registerShowPass.TabIndex = 17;
            this.registerShowPass.Text = "show password";
            this.registerShowPass.UseVisualStyleBackColor = true;
            this.registerShowPass.CheckedChanged += new System.EventHandler(this.registerShowPass_CheckedChanged);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(5)))), ((int)(((byte)(138)))));
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(5)))), ((int)(((byte)(138)))));
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(408, 393);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(123, 40);
            this.RegisterBtn.TabIndex = 16;
            this.RegisterBtn.Text = "SIGN UP";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(337, 302);
            this.txtRegisterPassword.Multiline = true;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(296, 33);
            this.txtRegisterPassword.TabIndex = 15;
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterPassword.Location = new System.Drawing.Point(337, 282);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(71, 17);
            this.labelRegisterPassword.TabIndex = 14;
            this.labelRegisterPassword.Text = "Password:";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(337, 102);
            this.txtRegisterUsername.Multiline = true;
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(296, 33);
            this.txtRegisterUsername.TabIndex = 13;
            // 
            // labelRegisterUsername
            // 
            this.labelRegisterUsername.AutoSize = true;
            this.labelRegisterUsername.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterUsername.Location = new System.Drawing.Point(334, 82);
            this.labelRegisterUsername.Name = "labelRegisterUsername";
            this.labelRegisterUsername.Size = new System.Drawing.Size(74, 17);
            this.labelRegisterUsername.TabIndex = 12;
            this.labelRegisterUsername.Text = "Username:";
            // 
            // lableRegisterAccount
            // 
            this.lableRegisterAccount.AutoSize = true;
            this.lableRegisterAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableRegisterAccount.Location = new System.Drawing.Point(333, 41);
            this.lableRegisterAccount.Name = "lableRegisterAccount";
            this.lableRegisterAccount.Size = new System.Drawing.Size(169, 22);
            this.lableRegisterAccount.TabIndex = 11;
            this.lableRegisterAccount.Text = "Register Account";
            this.lableRegisterAccount.Click += new System.EventHandler(this.lableLoginAccount_Click);
            // 
            // labelRegisterExit
            // 
            this.labelRegisterExit.AutoSize = true;
            this.labelRegisterExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegisterExit.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterExit.Location = new System.Drawing.Point(616, 9);
            this.labelRegisterExit.Name = "labelRegisterExit";
            this.labelRegisterExit.Size = new System.Drawing.Size(17, 18);
            this.labelRegisterExit.TabIndex = 10;
            this.labelRegisterExit.Text = "X";
            this.labelRegisterExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterEmail.Location = new System.Drawing.Point(337, 170);
            this.txtRegisterEmail.Multiline = true;
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(296, 33);
            this.txtRegisterEmail.TabIndex = 19;
            // 
            // labelResgiterEmail
            // 
            this.labelResgiterEmail.AutoSize = true;
            this.labelResgiterEmail.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResgiterEmail.Location = new System.Drawing.Point(334, 150);
            this.labelResgiterEmail.Name = "labelResgiterEmail";
            this.labelResgiterEmail.Size = new System.Drawing.Size(44, 17);
            this.labelResgiterEmail.TabIndex = 18;
            this.labelResgiterEmail.Text = "Email:";
            // 
            // txtRegisterPhone
            // 
            this.txtRegisterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPhone.Location = new System.Drawing.Point(337, 235);
            this.txtRegisterPhone.Multiline = true;
            this.txtRegisterPhone.Name = "txtRegisterPhone";
            this.txtRegisterPhone.Size = new System.Drawing.Size(296, 33);
            this.txtRegisterPhone.TabIndex = 21;
            // 
            // labelRegisterPhone
            // 
            this.labelRegisterPhone.AutoSize = true;
            this.labelRegisterPhone.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterPhone.Location = new System.Drawing.Point(334, 215);
            this.labelRegisterPhone.Name = "labelRegisterPhone";
            this.labelRegisterPhone.Size = new System.Drawing.Size(52, 17);
            this.labelRegisterPhone.TabIndex = 20;
            this.labelRegisterPhone.Text = "Phone:";
            this.labelRegisterPhone.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 445);
            this.Controls.Add(this.txtRegisterPhone);
            this.Controls.Add(this.labelRegisterPhone);
            this.Controls.Add(this.txtRegisterEmail);
            this.Controls.Add(this.labelResgiterEmail);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.registerShowPass);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.labelRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.labelRegisterUsername);
            this.Controls.Add(this.lableRegisterAccount);
            this.Controls.Add(this.labelRegisterExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.registerPicture)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox registerPicture;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelRegisterExpenseManager;
        private System.Windows.Forms.Button registerLoginBtn;
        private System.Windows.Forms.Label labelRegisterLoginAccount;
        private System.Windows.Forms.CheckBox registerShowPass;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label labelRegisterUsername;
        private System.Windows.Forms.Label lableRegisterAccount;
        private System.Windows.Forms.Label labelRegisterExit;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label labelResgiterEmail;
        private System.Windows.Forms.TextBox txtRegisterPhone;
        private System.Windows.Forms.Label labelRegisterPhone;
    }
}