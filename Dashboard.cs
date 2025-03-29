using System.Data.SqlClient;
using System.Windows.Forms;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class Dashboard : UserControl {

        DatabaseHelper databaseHelper = new DatabaseHelper();

        public Dashboard() {
            InitializeComponent();
        }

        public void LoadData(int userID) {
            using (SqlConnection conn = databaseHelper.GetConnection()) {
                //    conn.Open();
                //    string query = "SELECT TotalIncome, TotalExpense FROM UserSummary WHERE UserID=@UserID";

                //    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                //        cmd.Parameters.AddWithValue("@userID", userID);
                //        using (SqlDataReader reader = cmd.ExecuteReader()) {
                //            if (reader.Read()) {
                //                decimal totalIncome = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                //                decimal totalExpense = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);

                //                totalIncomeLbl.Text = totalIncome.ToString("N0") + " USD";
                //                totalExpenseLbl.Text = totalExpense.ToString("N0") + " USD";
                //                balanceLbl.Text = (totalIncome-totalExpense).ToString("N0") + " USD";
                //            }
                //        }
                //    }
            }
        }

    }
}
