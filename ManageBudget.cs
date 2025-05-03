using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExpenseManager.Helpers;
using System.Data;

namespace ExpenseManager {
    public partial class ManageBudget : UserControl {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        private int categoryID;
        public ManageBudget() {
            InitializeComponent();
        }

        private void createBudgetBtn_Click(object sender, EventArgs e) {
            if(txtCategory.Text == "" || txtAmount.Text == "" || txtBudgetYear.Text == "") {
                MessageBox.Show("Please fill all blank fields!");
                return;
            }
            if (!int.TryParse(txtBudgetYear.Text.Trim(), out int year)) {
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
                    categoryID = databaseHelper.GetIdFromDatabase(selectCategory,"@CategoryName", txtCategory.Text.Trim(), conn);

                    // insert budget
                    string insertQuery = "INSERT INTO Budget " +
                        "(BudgetYear, BudgetMonth, CategoryID, BudgetAmount, Note) " +
                        "VALUES(@BudgetYear, @BudgetMonth, @CategoryID, @BudgetAmount, @Note)";

                    using(SqlCommand cmd = new SqlCommand(insertQuery, conn)) {
                        cmd.Parameters.AddWithValue("@BudgetYear",txtBudgetYear.Text.Trim());
                        cmd.Parameters.AddWithValue("@BudgetMonth", cbBudgetMonth.Text.Trim());
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                        cmd.Parameters.AddWithValue("@BudgetAmount", txtAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Budget created successfully!",
                        "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHelper.LoadData(dgvBudgets, "SELECT * FROM Budget", conn);
                        FormHelper.AddButtonColumns(dgvBudgets);
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ManageBudget_Load(object sender, EventArgs e) {
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {
                    string query = "SELECT * FROM Budget";
                    FormHelper.LoadData(dgvBudgets, query, conn);

                    if (dgvBudgets.Rows.Count > 0 && !dgvBudgets.Rows[0].IsNewRow) {
                        FormHelper.AddButtonColumns(dgvBudgets);
                    }
                    dgvBudgets.CellClick -= dgvBudgets_CellClick;
                    dgvBudgets.CellClick += dgvBudgets_CellClick;

                    conn.Close();
                }
            } catch (Exception ex) {
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

                // Get values from the selected row
                int budgetYear = Convert.ToInt32(dgvBudgets.Rows[e.RowIndex].Cells["BudgetYear"].Value);
                int budgetMonth = Convert.ToInt32(dgvBudgets.Rows[e.RowIndex].Cells["BudgetMonth"].Value);
                decimal budgetAmount = Convert.ToDecimal(dgvBudgets.Rows[e.RowIndex].Cells["BudgetAmount"].Value);
                string note = dgvBudgets.Rows[e.RowIndex].Cells["Note"].Value.ToString();

                // get categoryName
                string categoryName = databaseHelper.GetCategoryNameByID("SELECT CategoryName FROM Category WHERE CategoryID=@CategoryID", "@CategoryID", categoryID, databaseHelper.GetConnection());

                UpdateBudget updateBudget = new UpdateBudget(BudgetID, budgetYear, budgetMonth, categoryName, budgetAmount, note);
                var result = updateBudget.ShowDialog();

                if (result == DialogResult.OK) {
                    using (SqlConnection conn = databaseHelper.GetConnection()) {
                        FormHelper.LoadData(dgvBudgets, "SELECT * FROM Budget", conn);
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
                            string query = "DELETE FROM Budget WHERE BudgetID=@BudgetID";
                            databaseHelper.deleteItem(query, "BudgetID", budgetID, conn);

                            FormHelper.LoadData(dgvBudgets, "SELECT * FROM Budget", conn);
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
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {
                    // lay CategoryID theo CategoryType
                    string query = "SELECT CategoryID FROM Category WHERE CategoryType=@CategoryType";
                    int categoryID = databaseHelper.GetIdFromDatabase(query, "CategoryType", txtFilterBudgets.Text.Trim(), conn);

                    DataTable dt = databaseHelper.getDataFromFilters(categoryID, conn);
                    FormHelper.loadDataAfterFilter(dgvBudgets, dt);
                    if (dgvBudgets.Columns["btnUpdate"] != null)
                        dgvBudgets.Columns.Remove("btnUpdate");
                    if (dgvBudgets.Columns["bthDelete"] != null)
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
