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
    public partial class AddAmountForm : Form {

        DatabaseHelper dbHelper = new DatabaseHelper();

        private int goalID;
        public AddAmountForm() {
            InitializeComponent();
        }

        public AddAmountForm(int goalID) {
            this.goalID = goalID;
            InitializeComponent();
        }

        private void exitLbl_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void addAmountBtn_Click(object sender, EventArgs e) {
            if(txtAmount.Text == "") {
                MessageBox.Show("Please enter amount!");
            } else{
                try{
                    using(SqlConnection conn = dbHelper.GetConnection()) {
                        conn.Open();
                        string query = "UPDATE Goals SET SavedAmount = SavedAmount + @addedAmount WHERE GoalID=@GoalID";
                        using(SqlCommand cmd = new SqlCommand(query, conn)) {
                            cmd.Parameters.AddWithValue("@addedAmount", decimal.Parse(txtAmount.Text));
                            cmd.Parameters.AddWithValue("@GoalID", goalID);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Saved amount updated successfully!",
                            "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    DialogResult = DialogResult.OK;
                    this.Close();

                } catch(Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
