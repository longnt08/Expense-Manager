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
using System.Configuration;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class ManageTransaction : UserControl {

        DatabaseHelper databaseHelper = new DatabaseHelper();

        public ManageTransaction() {
            InitializeComponent();
            //var cnnStr = ConfigurationManager.ConnectionStrings["MyCNN"]?.ConnectionString;
            //if (string.IsNullOrEmpty(cnnStr)) {
            //    MessageBox.Show("Không tìm thấy connection string MyCNN");
            //} else {
            //    MessageBox.Show("Đã load được connection string:\n" + cnnStr);
            //}

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void createTransactionBtn_Click(object sender, EventArgs e) {
            if(txtCategory.Text == "") {
                MessageBox.Show("Please choose category!");
            }
            if(txtAmount.Text == "") {
                MessageBox.Show("Please enter amount!");
            }
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {

                    // lay CategoryID theo CategoryName
                    string selectCategory = "SELECT CategoryID FROM Categories WHERE CategoryName = @CategoryName";
                    int categoryId = databaseHelper.GetIdFromDatabase(selectCategory, "@Categoryname", txtCategory.Text.Trim(), conn);

                    // lay userId
                    string selectUser = "SELECT UserID FROM Users WHERE username = @username";
                    int userId = databaseHelper.GetIdFromDatabase(selectUser, "@username", Session.username, conn);

                    // insert transaction
                    DateTime today = DateTime.Now;
                    string insertQuery = "INSERT INTO Transactions " +
                        "(UserID, CategoryID, Amount, TransactionDate, Note)" + 
                        "VALUES(@UserID, @CategoryID, @Amount, @TransactionDate, @Note)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn)) {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransactionDate", today);
                        cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Transaction added successfully!",
                        "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHelper.LoadData(dgvRecentlyTransaction, "SELECT * FROM Transactions", conn);
                        FormHelper.AddButtonColumns(dgvRecentlyTransaction);
                    }

                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void ManageTransaction_Load(object sender, EventArgs e) {
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {
                    string query = "SELECT * FROM Transactions";
                    FormHelper.LoadData(dgvRecentlyTransaction, query, conn);

                    if (dgvRecentlyTransaction.Rows.Count > 0 && !dgvRecentlyTransaction.Rows[0].IsNewRow) {
                        FormHelper.AddButtonColumns(dgvRecentlyTransaction);
                    }
                    dgvRecentlyTransaction.CellClick -= dgvRecentlyTransaction_CellClick;
                    dgvRecentlyTransaction.CellClick += dgvRecentlyTransaction_CellClick;

                    conn.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvRecentlyTransaction_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            int transactionID;
            var cell = dgvRecentlyTransaction.Rows[e.RowIndex].Cells["TransactionID"];
            if (cell == null || cell.Value == null) {
                return;
            } else {
                transactionID = Convert.ToInt32(cell.Value);
            }

            if (dgvRecentlyTransaction.Columns[e.ColumnIndex].Name == "btnUpdate") {
                dgvRecentlyTransaction.EndEdit();

                UpdateTransactionForm updateTransactionForm = new UpdateTransactionForm(transactionID);
                var result = updateTransactionForm.ShowDialog();

                if (result == DialogResult.OK) {
                    using (SqlConnection conn = databaseHelper.GetConnection()) {
                        FormHelper.LoadData(dgvRecentlyTransaction, "SELECT * FROM Transactions", conn);
                    }
                    FormHelper.AddButtonColumns(dgvRecentlyTransaction);
                }
            }

            if (dgvRecentlyTransaction.Columns[e.ColumnIndex].Name == "btnDelete") {
                DialogResult dialog = MessageBox.Show("Do you really want to delete this item?", "Confirm", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes) {
                    int transactionId = Convert.ToInt32(cell.Value);
                    try {
                        using (SqlConnection conn = databaseHelper.GetConnection()) {
                            string query = "DELETE FROM Transactions WHERE TransactionID = @transactionId";
                            databaseHelper.deleteItem(query, "@transactionId", transactionId, conn);

                            FormHelper.LoadData(dgvRecentlyTransaction, "SELECT * FROM Transactions", conn);
                            if (dgvRecentlyTransaction.Columns["btnUpdate"] != null)
                                dgvRecentlyTransaction.Columns.Remove("btnUpdate");
                            if (dgvRecentlyTransaction.Columns["btnDelete"] != null)
                                dgvRecentlyTransaction.Columns.Remove("btnDelete");

                            // Chỉ thêm nút nếu có dữ liệu
                            FormHelper.AddButtonColumns(dgvRecentlyTransaction);
                            return;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Error: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void filterTransactionBtn_Click(object sender, EventArgs e) {
            try{
                using (SqlConnection conn = databaseHelper.GetConnection()) {
                    // lay CategoryID theo CategoryType
                    string query = "SELECT CategoryID FROM Categories WHERE CategoryType = @CategoryType";
                    int categoryID = databaseHelper.GetIdFromDatabase(query, "@CategoryType", txtFilterTransaction.Text.Trim(), conn);

                    DataTable dt = databaseHelper.getDataFromFilters(categoryID, conn);
                    FormHelper.loadDataAfterFilter(dgvRecentlyTransaction, dt);
                    if (dgvRecentlyTransaction.Columns["btnUpdate"] != null)
                        dgvRecentlyTransaction.Columns.Remove("btnUpdate");
                    if (dgvRecentlyTransaction.Columns["btnDelete"] != null)
                        dgvRecentlyTransaction.Columns.Remove("btnDelete");

                    // Chỉ thêm nút nếu có dữ liệu
                    FormHelper.AddButtonColumns(dgvRecentlyTransaction);
                    return;
                }
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
