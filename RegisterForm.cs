using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager {
    public partial class RegisterForm : Form {
        public RegisterForm() {
            InitializeComponent();
        }

        private void lableLoginAccount_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void registerLoginBtn_Click(object sender, EventArgs e) {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void registerShowPass_CheckedChanged(object sender, EventArgs e) {
            txtRegisterPassword.PasswordChar = registerShowPass.Checked ? '\0':'*';
        }
    }
}
