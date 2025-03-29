using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class ManageTransaction : UserControl {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        private int userID;

        public void setUserID(int userID) {
            this.userID = userID;
        }

        public ManageTransaction() {
            InitializeComponent();
            //var cnnStr = ConfigurationManager.ConnectionStrings["MyCNN"]?.ConnectionString;
            //if (string.IsNullOrEmpty(cnnStr)) {
            //    MessageBox.Show("Không tìm thấy connection string MyCNN");
            //} else {
            //    MessageBox.Show("Đã load được connection string:\n" + cnnStr);
            //}

        }

        private void createTransactionBtn_Click(object sender, EventArgs e) {
            if(cmbCategory.Text == "" || cmbFund.Text == "" || cmbPartner.Text == "" || 
            txtAmount.Text == "") {
                MessageBox.Show("Please fill all blank fields!");
                return;
            }
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {

                    // lay CategoryID theo CategoryName
                    string selectCategory = "SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName";
                    int categoryId = databaseHelper.GetIdFromDatabase(selectCategory, "@CategoryName", cmbCategory.Text.Trim(), conn);

                    // lay FundId theo FundName
                    string selectFund = "SELECT FundID FROM FundAccount WHERE FundName = @FundName";
                    int fundId = databaseHelper.GetIdFromDatabase(selectFund, "@FundName", cmbFund.Text.Trim(), conn);

                    // lay PartnerID theo PartnerName
                    string selectPartner = "SELECT PartnerID FROM BussinessPartner WHERE PartnerName = @partnerName";
                    int partnerId = databaseHelper.GetIdFromDatabase(selectPartner, "@partnerName", cmbPartner.Text.Trim(), conn);

                    // insert transaction
                    DateTime today = DateTime.Now;
                    string insertQuery = "INSERT INTO Transactions " +
                        "(FundID, CategoryID, PartnerID, TransactionDate, Amount, TransactionDescription, Attachment) " +
                        "VALUES(@FundID, @CategoryID, @PartnerID, @TransactionDate, @Amount, @Description, @Attachment)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn)) {
                        cmd.Parameters.AddWithValue("@FundID", fundId);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.Parameters.AddWithValue("@PartnerID", partnerId);
                        cmd.Parameters.AddWithValue("@TransactionDate", today);
                        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@Attachment", txtAttachment.Text.Trim());

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
            try {
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
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rdoCustomer_CheckedChanged(object sender, EventArgs e) {
            if (rdoCustomer.Checked) {
                LoadPartnerByType("Customer");
            }
        }

        private void rdoSupplier_CheckedChanged(object sender, EventArgs e) {
            if (rdoSupplier.Checked) {
                LoadPartnerByType("Supplier");
            }
        }

        private void rdoStaff_CheckedChanged(object sender, EventArgs e) {
            if (rdoStaff.Checked) {
                LoadPartnerByType("Staff");
            }
        }

        private void LoadPartnerByType(string partnerType) {
            List<string> partners = new List<string>();
            using (SqlConnection conn = databaseHelper.GetConnection()) {
                string query = "SELECT PartnerName FROM BussinessPartner WHERE PartnerType = @type";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@type", partnerType);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    partners.Add(reader["PartnerName"].ToString());
                }
            }
            cmbPartner.DataSource = partners;
        }
    }
}
