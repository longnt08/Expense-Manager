namespace ExpenseManager {
    partial class frmLogin {
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.labelLoginExpenseManager = new System.Windows.Forms.Label();
            this.loginSignupBtn = new System.Windows.Forms.Button();
            this.labelLoginRegisterAccount = new System.Windows.Forms.Label();
            this.labelLoginExit = new System.Windows.Forms.Label();
            this.lableLoginAccount = new System.Windows.Forms.Label();
            this.labelLoginUsername = new System.Windows.Forms.Label();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginShowPass = new System.Windows.Forms.CheckBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.loginPicture);
            this.panelLogin.Controls.Add(this.labelLoginExpenseManager);
            this.panelLogin.Controls.Add(this.loginSignupBtn);
            this.panelLogin.Controls.Add(this.labelLoginRegisterAccount);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(296, 390);
            this.panelLogin.TabIndex = 0;
            // 
            // loginPicture
            // 
            this.loginPicture.Image = global::ExpenseManager.Properties.Resources.ExpenseManagerAppIcon;
            this.loginPicture.Location = new System.Drawing.Point(71, 27);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(129, 101);
            this.loginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPicture.TabIndex = 10;
            this.loginPicture.TabStop = false;
            // 
            // labelLoginExpenseManager
            // 
            this.labelLoginExpenseManager.AutoSize = true;
            this.labelLoginExpenseManager.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginExpenseManager.ForeColor = System.Drawing.Color.White;
            this.labelLoginExpenseManager.Location = new System.Drawing.Point(25, 169);
            this.labelLoginExpenseManager.Name = "labelLoginExpenseManager";
            this.labelLoginExpenseManager.Size = new System.Drawing.Size(224, 33);
            this.labelLoginExpenseManager.TabIndex = 9;
            this.labelLoginExpenseManager.Text = "Expense Manager";
            // 
            // loginSignupBtn
            // 
            this.loginSignupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.loginSignupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginSignupBtn.FlatAppearance.BorderSize = 0;
            this.loginSignupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginSignupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginSignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginSignupBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSignupBtn.ForeColor = System.Drawing.Color.White;
            this.loginSignupBtn.Location = new System.Drawing.Point(11, 339);
            this.loginSignupBtn.Name = "loginSignupBtn";
            this.loginSignupBtn.Size = new System.Drawing.Size(266, 40);
            this.loginSignupBtn.TabIndex = 1;
            this.loginSignupBtn.Text = "SIGNUP";
            this.loginSignupBtn.UseVisualStyleBackColor = false;
            this.loginSignupBtn.Click += new System.EventHandler(this.loginSignupBtn_Click);
            // 
            // labelLoginRegisterAccount
            // 
            this.labelLoginRegisterAccount.AutoSize = true;
            this.labelLoginRegisterAccount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginRegisterAccount.ForeColor = System.Drawing.Color.White;
            this.labelLoginRegisterAccount.Location = new System.Drawing.Point(68, 301);
            this.labelLoginRegisterAccount.Name = "labelLoginRegisterAccount";
            this.labelLoginRegisterAccount.Size = new System.Drawing.Size(150, 18);
            this.labelLoginRegisterAccount.TabIndex = 0;
            this.labelLoginRegisterAccount.Text = "Register your account";
            // 
            // labelLoginExit
            // 
            this.labelLoginExit.AutoSize = true;
            this.labelLoginExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLoginExit.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginExit.Location = new System.Drawing.Point(609, 9);
            this.labelLoginExit.Name = "labelLoginExit";
            this.labelLoginExit.Size = new System.Drawing.Size(17, 18);
            this.labelLoginExit.TabIndex = 1;
            this.labelLoginExit.Text = "X";
            this.labelLoginExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lableLoginAccount
            // 
            this.lableLoginAccount.AutoSize = true;
            this.lableLoginAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableLoginAccount.Location = new System.Drawing.Point(326, 60);
            this.lableLoginAccount.Name = "lableLoginAccount";
            this.lableLoginAccount.Size = new System.Drawing.Size(141, 22);
            this.lableLoginAccount.TabIndex = 2;
            this.lableLoginAccount.Text = "Login Account";
            // 
            // labelLoginUsername
            // 
            this.labelLoginUsername.AutoSize = true;
            this.labelLoginUsername.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUsername.Location = new System.Drawing.Point(327, 110);
            this.labelLoginUsername.Name = "labelLoginUsername";
            this.labelLoginUsername.Size = new System.Drawing.Size(74, 17);
            this.labelLoginUsername.TabIndex = 3;
            this.labelLoginUsername.Text = "Username:";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsername.Location = new System.Drawing.Point(330, 140);
            this.txtLoginUsername.Multiline = true;
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(296, 33);
            this.txtLoginUsername.TabIndex = 4;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(330, 233);
            this.txtLoginPassword.Multiline = true;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(296, 33);
            this.txtLoginPassword.TabIndex = 6;
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.Location = new System.Drawing.Point(327, 194);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(71, 17);
            this.labelLoginPassword.TabIndex = 5;
            this.labelLoginPassword.Text = "Password:";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(5)))), ((int)(((byte)(138)))));
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(5)))), ((int)(((byte)(138)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(427, 340);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(123, 40);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginShowPass
            // 
            this.loginShowPass.AutoSize = true;
            this.loginShowPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginShowPass.Location = new System.Drawing.Point(516, 291);
            this.loginShowPass.Name = "loginShowPass";
            this.loginShowPass.Size = new System.Drawing.Size(110, 18);
            this.loginShowPass.TabIndex = 8;
            this.loginShowPass.Text = "show password";
            this.loginShowPass.UseVisualStyleBackColor = true;
            this.loginShowPass.CheckedChanged += new System.EventHandler(this.loginShowPass_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(640, 390);
            this.Controls.Add(this.loginShowPass);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.labelLoginUsername);
            this.Controls.Add(this.lableLoginAccount);
            this.Controls.Add(this.labelLoginExit);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelLoginExit;
        private System.Windows.Forms.Label lableLoginAccount;
        private System.Windows.Forms.Label labelLoginUsername;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox loginShowPass;
        private System.Windows.Forms.Button loginSignupBtn;
        private System.Windows.Forms.Label labelLoginRegisterAccount;
        private System.Windows.Forms.Label labelLoginExpenseManager;
        private System.Windows.Forms.PictureBox loginPicture;
    }
}