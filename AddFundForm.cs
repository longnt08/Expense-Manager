using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class AddFundForm : Form {

        private string txtAccount;
        DatabaseHelper dbHelper = new DatabaseHelper();
        public AddFundForm() {
            InitializeComponent();
        }
        
        public AddFundForm(string account) {
            InitializeComponent();
            txtAccount = account;
        }

        private void addMainBankBtn_Click(object sender, EventArgs e) {
            if (txtAmount.Text == "" || txtDescription.Text == "") {
                MessageBox.Show("Please fill up all fields");
                return;
            } else {
                try {
                    using (SqlConnection conn = dbHelper.GetConnection()) {
                        if (conn.State == System.Data.ConnectionState.Closed) {
                            conn.Open();
                        }

                        // update Balance cho FundAccount
                        //string queryUpdate = "UPDATE FundAccount SET Balance = Balance + @Amount WHERE FundName = @FundName";
                        //using (SqlCommand cmd = new SqlCommand(queryUpdate, conn)) {
                        //    cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
                        //    cmd.Parameters.AddWithValue("@FundName", txtAccount.Trim());
                        //    cmd.ExecuteNonQuery();
                        //}

                        // ghi logs 
                        string queryInsert = "INSERT INTO Transactions " +
                        "(FundID, CategoryID, PartnerID, TransactionDate, Amount, TransactionDescription, Attachment) " +
                        "VALUES(@FundID, @CategoryID, @PartnerID, @TransactionDate, @Amount, @Description, @Attachment)";
                        // lay fundID theo FundName
                        string selectFund = "SELECT FundID FROM FundAccount WHERE FundName = @FundName";
                        int fundId = dbHelper.GetIdFromDatabase(selectFund, "@FundName", txtAccount.Trim(), conn);

                        using (SqlCommand cmd = new SqlCommand(queryInsert, conn)) {
                            cmd.Parameters.AddWithValue("@FundID", fundId);
                            cmd.Parameters.AddWithValue("@CategoryID", 10);
                            cmd.Parameters.AddWithValue("@PartnerID", 11);// xem lai phan nay
                            cmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
                            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                            cmd.Parameters.AddWithValue("@Attachment", "");
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Successfully added fund to " + txtAccount);
                    DialogResult = DialogResult.OK;
                    this.Close();
                } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void exitAddMainBankLbl_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
