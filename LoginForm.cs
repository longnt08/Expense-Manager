using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseManager.Data;

namespace ExpenseManager {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void loginSignupBtn_Click(object sender, EventArgs e) {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void loginShowPass_CheckedChanged(object sender, EventArgs e) {
            txtLoginPassword.PasswordChar = loginShowPass.Checked ? '\0':'*';
        }

        private void loginBtn_Click(object sender, EventArgs e) {
            if(txtLoginUsername.Text == "" || txtLoginPassword.Text == "") {
                MessageBox.Show("Please fill all blank fields");
            } else {
                try {
                    DatabaseHelper dbHelper = new DatabaseHelper();
                    using (SqlConnection conn = dbHelper.GetConnection()) {
                        conn.Open();

                        string selectQuery = "SELECT *FROM Users WHERE username=@username AND passwordHash=@password";
                        using (SqlCommand cmd = new SqlCommand(selectQuery, conn)) {
                            cmd.Parameters.AddWithValue("@username", txtLoginUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", txtLoginPassword.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count >= 1) {
                                MessageBox.Show("Login successfully");

                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                            } else {
                                MessageBox.Show("Incorrect username or password");
                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error: " + ex);
                } 
            }
        }
    }
}
