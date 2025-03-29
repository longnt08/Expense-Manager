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
    public partial class RegisterForm : Form {
        public RegisterForm() {
            InitializeComponent();
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

        private void registerBtn_Click(object sender, EventArgs e) {
            if (txtRegisterUsername.Text == "" || 
                txtRegisterPassword.Text == "" || 
                txtRegisterEmail.Text == "") {
                MessageBox.Show("Please fill all blank fields");
             } else {
                try{
                    DatabaseHelper dbHelper = new DatabaseHelper();
                    using (SqlConnection conn = dbHelper.GetConnection()) { 
                        conn.Open();
                        
                        // check email
                        string selectEmail = "SELECT COUNT(userID) FROM Users WHERE email = @email";
                        using (SqlCommand checkEmail = new SqlCommand(selectEmail, conn)) { 
                            checkEmail.Parameters.AddWithValue("@email", txtRegisterEmail.Text.Trim());
                            int count = (int)checkEmail.ExecuteScalar();

                            if(count >= 1) {
                                MessageBox.Show("This email is already exists, try another.");
                            } else {
                                // insert data
                                DateTime today = DateTime.Now;
                                string insertQuery = "INSERT INTO Users " +
                                    "(username, passwordHash, email, DateCreated)" +
                                    "VALUES(@username, @passwordHash, @email, @DateCreated)" +
                                    "SELECT SCOPE_IDENTITY();";

                                using (SqlCommand cmd = new SqlCommand(insertQuery, conn)) {
                                    cmd.Parameters.AddWithValue("@username", txtRegisterUsername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@passwordHash", txtRegisterPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", txtRegisterEmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@DateCreated", today);

                                    object result = cmd.ExecuteScalar();
                                    int userID = Convert.ToInt32(result);

                                    MessageBox.Show("Registered successfully",
                                    "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    frmLogin loginForm = new frmLogin(userID, txtRegisterUsername.Text.Trim(), txtRegisterEmail.Text.Trim(), today);
                                    loginForm.ShowDialog();
                                    this.Close();

                                    conn.Close();
                                }
                            }
                        }
                    }
                } catch(Exception ex) {
                    MessageBox.Show("Error: "+ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
        }
    }
}
