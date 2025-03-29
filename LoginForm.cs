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
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class frmLogin : Form {

        private int userID;
        private string username;
        private string email;
        private DateTime dateCreated;
        public frmLogin() {
            InitializeComponent();
        }
        public frmLogin(int userID, string username, string email, DateTime dateCreated) {
            InitializeComponent();
            this.userID = userID;
            this.username = username;
            this.email = email;
            this.dateCreated = dateCreated;
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
            if (txtLoginUsername.Text == "" || txtLoginPassword.Text == "") {
                MessageBox.Show("Please fill all blank fields");
            } else {
                try {
                    DatabaseHelper dbHelper = new DatabaseHelper();
                    using (SqlConnection conn = dbHelper.GetConnection()) {
                        conn.Open();

                        string selectQuery = "SELECT * FROM Users WHERE Username=@username AND PasswordHash=@password";
                        using (SqlCommand cmd = new SqlCommand(selectQuery, conn)) {
                            cmd.Parameters.AddWithValue("@username", txtLoginUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", txtLoginPassword.Text.Trim());

                            using (SqlDataReader reader = cmd.ExecuteReader()) {
                                if (reader.Read()) {
                                    userID = reader.GetInt32(reader.GetOrdinal("UserID"));
                                    username = reader.GetString(reader.GetOrdinal("username"));
                                    email = reader.GetString(reader.GetOrdinal("email"));
                                    dateCreated = reader.GetDateTime(reader.GetOrdinal("dateCreated"));

                                    MessageBox.Show("Login successfully");

                                    MainForm mainForm = new MainForm(userID, username, email, dateCreated);
                                    mainForm.Show();
                                    this.Hide();
                                } else {
                                    MessageBox.Show("Incorrect username or password");
                                }
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
