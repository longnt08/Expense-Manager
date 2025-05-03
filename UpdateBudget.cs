using System;
using System.Windows.Forms;
using ExpenseManager.Helpers;
using System.Data.SqlClient;

namespace ExpenseManager {
    public partial class UpdateBudget : Form {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        private int BudgetID;
        public UpdateBudget() {
            InitializeComponent();
        }
        public UpdateBudget(int budgetID, int year, int month, string categoryName, decimal amount, string note) {
            InitializeComponent();
            this.BudgetID = budgetID;
            txtAmount.Text = amount.ToString();
            txtCategory.Text = categoryName;
            txtYear.Text = year.ToString();
            cbMonth.Text = month.ToString();
            txtNote.Text = note;
        }

        private void updateBudgetBtn_Click(object sender, EventArgs e) {
            if (txtCategory.Text == "" || txtAmount.Text == "") {
                MessageBox.Show("Please fill all blank fields!");
                return;
            }
            if (!int.TryParse(txtYear.Text.Trim(), out int year)) {
                MessageBox.Show("Invalid year format.");
                return;
            }

            if (year < DateTime.Now.Year) {
                MessageBox.Show("Please select a valid year.");
                return;
            }
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {

                    // lay CategoryID theo CategoryName
                    string selectCategory = "SELECT CategoryID FROM Category WHERE CategoryName=@CategoryName";
                    int categoryID = databaseHelper.GetIdFromDatabase(selectCategory, "@CategoryName", txtCategory.Text.Trim(), conn);

                    // insert budget
                    string updateQuery = "UPDATE Budget " +
                        "SET CategoryID=@CategoryID, BudgetAmount=@Amount, BudgetYear=@BudgetYear, BudgetMonth=@BudgetMonth, Note=@Note " +
                        "WHERE BudgetID=@BudgetID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn)) {
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@BudgetYear", txtYear.Text.Trim());
                        cmd.Parameters.AddWithValue("@BudgetMonth", cbMonth.Text.Trim());
                        cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());
                        cmd.Parameters.AddWithValue("@BudgetID", this.BudgetID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Budget updated successfully!",
                        "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
