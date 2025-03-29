using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class UpdateTransactionForm : Form {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        private int transactionID;
        public UpdateTransactionForm() {
            InitializeComponent();
        }

        public UpdateTransactionForm(int transactionID) {
            this.transactionID = transactionID;
            InitializeComponent();
        }

        private void updateTransactionBtn_Click(object sender, EventArgs e) {
            if (cmbUpdateCategory.Text == "" || cmbUpdateFund.Text == "" || 
            cmbUpdatePartner.Text == "" || txtUpdateAmount.Text == "") {
                MessageBox.Show("Please fill all blank fields!");
                return;
            }

            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {

                    // lay CategoryID theo CategoryName
                    string selectCategory = "SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName";
                    int categoryId = databaseHelper.GetIdFromDatabase(selectCategory, "@CategoryName", cmbUpdateCategory.Text.Trim(), conn);

                    // lay FundId theo FundName
                    string selectFund = "SELECT FundID FROM FundAccount WHERE FundName = @FundName";
                    int fundId = databaseHelper.GetIdFromDatabase(selectFund, "@FundName", cmbUpdateFund.Text.Trim(), conn);

                    // lay PartnerID theo PartnerName
                    string selectPartner = "SELECT PartnerID FROM BussinessPartner WHERE PartnerName = @partnerName";
                    int partnerId = databaseHelper.GetIdFromDatabase(selectPartner, "@partnerName", cmbUpdatePartner.Text.Trim(), conn);

                    // insert transaction
                    DateTime today = DateTime.Now;
                    string updateQuery = "UPDATE Transactions " +
                        " SET FundID=@FundID, CategoryID=@CategoryID, PartnerID=@PartnerID, TransactionDate=@TransactionDate, Amount=@Amount, TransactionDescription=@Description, Attachment=@Attachment " +
                        "WHERE TransactionID=@TransactionID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn)) {
                        cmd.Parameters.AddWithValue("@FundID", fundId);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.Parameters.AddWithValue("@PartnerID", partnerId);
                        cmd.Parameters.AddWithValue("@Amount", txtUpdateAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransactionDate", today);
                        cmd.Parameters.AddWithValue("@Description", txtUpdateDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@Attachment", txtUpdateAttachment.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransactionID", this.transactionID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Transaction updated successfully!",
                        "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitLbl_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void rdoUpdateCustomer_CheckedChanged(object sender, EventArgs e) {
            if (rdoUpdateCustomer.Checked) {
                LoadPartnerByType("Customer");
            }
        }

        private void rdoUpdateSupplier_CheckedChanged(object sender, EventArgs e) {
            if(rdoUpdateSupplier.Checked) {
                LoadPartnerByType("Supplier");
            }
        }

        private void rdoUpdateStaff_CheckedChanged(object sender, EventArgs e) {
            if (rdoUpdateStaff.Checked) {
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
            cmbUpdatePartner.DataSource = partners;
        }
    }
}
