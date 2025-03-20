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
    public partial class UpdateBudget : Form {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        private int BudgetID;
        public UpdateBudget() {
            InitializeComponent();
        }
        public UpdateBudget(int budgetID) {
            this.BudgetID = budgetID;
            InitializeComponent();
        }

        private void updateBudgetBtn_Click(object sender, EventArgs e) {
            if (txtCategory.Text == "" || txtAmount.Text == "") {
                MessageBox.Show("Please fill all blank fields!");
                return;
            }
            if (dtPickerStartDate.Value < DateTime.Now.Date || dtPickerStartDate.Value > dtPickerEndDate.Value || dtPickerEndDate.Value < DateTime.Now.Date) {
                MessageBox.Show("Please select valid date.");
                return;
            }
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {

                    // lay CategoryID theo CategoryName
                    string selectCategory = "SELECT CategoryID FROM Categories WHERE CategoryName=@CategoryName";
                    int categoryID = databaseHelper.GetIdFromDatabase(selectCategory, "@CategoryName", txtCategory.Text.Trim(), conn);

                    // insert budget
                    string updateQuery = "UPDATE Budgets " +
                        "SET CategoryID=@CategoryID, Amount=@Amount, StartDate=@StartDate, EndDate=@EndDate " +
                        "WHERE BudgetID=@BudgetID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn)) {
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@StartDate", dtPickerStartDate.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", dtPickerEndDate.Value.Date);
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
    }
}
