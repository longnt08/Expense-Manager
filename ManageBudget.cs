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
    public partial class ManageBudget : UserControl {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        public ManageBudget() {
            InitializeComponent();
        }

        private void createBudgetBtn_Click(object sender, EventArgs e) {
            if(txtCategory.Text == "" || txtAmount.Text == "") {
                MessageBox.Show("Please fill all blank fields!");
                return;
            }
            if (dtPickerStartDate.Value < DateTime.Now.Date || dtPickerStartDate.Value > dtPickerEndDate.Value || dtPickerEndDate.Value < DateTime.Now.Date) {
                MessageBox.Show("Please select valid date.");
                return;
            }
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {
                    // lay userID theo username
                    string selectUser = "SELECT UserID FROM Users WHERE username=@username";
                    int userID = databaseHelper.GetIdFromDatabase(selectUser, "@username", Session.username, conn);

                    // lay CategoryID theo CategoryName
                    string selectCategory = "SELECT CategoryID FROM Categories WHERE CategoryName=@CategoryName";
                    int categoryID = databaseHelper.GetIdFromDatabase(selectCategory,"@CategoryName", txtCategory.Text.Trim(), conn);

                    // insert budget
                    string insertQuery = "INSERT INTO Budgets " +
                        "(UserID, CategoryID, Amount, StartDate, EndDate) " +
                        "VALUES(@UserID, @CategoryID, @Amount, @StartDate, @EndDate)";

                    using(SqlCommand cmd = new SqlCommand(insertQuery, conn)) {
                            cmd.Parameters.AddWithValue("@UserID", userID);
                            cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
                            cmd.Parameters.AddWithValue("@StartDate", dtPickerStartDate.Value.Date);
                            cmd.Parameters.AddWithValue("@EndDate", dtPickerEndDate.Value.Date);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Budget created successfully!",
                            "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormHelper.LoadData(dgvBudgets, "SELECT * FROM Budgets", conn);
                            FormHelper.AddButtonColumns(dgvBudgets);
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ManageBudget_Load(object sender, EventArgs e) {
            try{
                using(SqlConnection conn = databaseHelper.GetConnection()) {
                    string query = "SELECT * FROM Budgets";
                    FormHelper.LoadData(dgvBudgets, query, conn);

                    if(dgvBudgets.Rows.Count > 0 && !dgvBudgets.Rows[0].IsNewRow) {
                        FormHelper.AddButtonColumns(dgvBudgets);
                    }
                    dgvBudgets.CellClick -= dgvBudgets_CellClick;
                    dgvBudgets.CellClick += dgvBudgets_CellClick;

                    conn.Close();
                }
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvBudgets_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            int BudgetID;

            var cell = dgvBudgets.Rows[e.RowIndex].Cells["BudgetID"];

            if (cell == null || cell.Value == null) {
                return;
            } else {
                BudgetID = Convert.ToInt32(cell.Value);
            }

            //chuc nang update
            if (dgvBudgets.Columns[e.ColumnIndex].Name == "btnUpdate") {
                dgvBudgets.EndEdit();

                UpdateBudget updateBudget = new UpdateBudget(BudgetID);
                var result = updateBudget.ShowDialog();

                if (result == DialogResult.OK) {
                    using (SqlConnection conn = databaseHelper.GetConnection()) {
                        FormHelper.LoadData(dgvBudgets, "SELECT * FROM Budgets", conn);
                    }
                    FormHelper.AddButtonColumns(dgvBudgets);
                }
            }

            // chuc nang delete
            if (dgvBudgets.Columns[e.ColumnIndex].Name == "btnDelete") {

                DialogResult dialog = MessageBox.Show("Do you really want to delete this budget?", "Confirm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes) {
                    int budgetID = Convert.ToInt32(cell.Value);
                    try {
                        using (SqlConnection conn = databaseHelper.GetConnection()) {
                            string query = "DELETE FROM Budgets WHERE BudgetID=@BudgetID";
                            databaseHelper.deleteItem(query, "BudgetID", budgetID, conn);

                            FormHelper.LoadData(dgvBudgets, "SELECT * FROM Budgets", conn);
                            if (dgvBudgets.Columns["btnUpdate"] != null)
                                dgvBudgets.Columns.Remove("btnUpdate");
                            if (dgvBudgets.Columns["btnDelete"] != null)
                                dgvBudgets.Columns.Remove("btnDelete");

                            // chi them nut neu co du lieu
                            FormHelper.AddButtonColumns(dgvBudgets);
                            return;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void filterBudgetBtn_Click(object sender, EventArgs e) {
            try{
                using(SqlConnection conn = databaseHelper.GetConnection()) {
                    // lay CategoryID theo CategoryType
                    string query = "SELECT CategoryID FROM Categories WHERE CategoryType=@CategoryType";
                    int categoryID = databaseHelper.GetIdFromDatabase(query, "CategoryType", txtFilterBudgets.Text.Trim(), conn);

                    DataTable dt = databaseHelper.getDataFromFilters(categoryID, conn);
                    FormHelper.loadDataAfterFilter(dgvBudgets, dt);
                    if(dgvBudgets.Columns["btnUpdate"] != null)
                        dgvBudgets.Columns.Remove("btnUpdate");
                    if(dgvBudgets.Columns["bthDelete"] != null)
                        dgvBudgets.Columns.Remove("btnDelete");

                    // chi them nut neu co du lieu
                    FormHelper.AddButtonColumns(dgvBudgets);
                    return;
                }
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
