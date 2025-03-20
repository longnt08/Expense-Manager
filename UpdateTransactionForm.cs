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

        private void CancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void updateTransactionBtn_Click(object sender, EventArgs e) {
            if (txtCategory.Text == "") {
                MessageBox.Show("Please choose category!");
            }
            if (txtAmount.Text == "") {
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
                    string updateQuery = "UPDATE Transactions " +
                        " SET CategoryID=@CategoryID, Amount=@Amount, TransactionDate=@TransactionDate, Note=@Note " +
                        "WHERE TransactionID=@TransactionID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn)) {
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransactionDate", today);
                        cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());
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
    }
}
