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
    public partial class UpdateGoalForm : Form {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        private int GoalID;
        public UpdateGoalForm() {
            InitializeComponent();
        }

        public UpdateGoalForm(int GoalID) {
            this.GoalID = GoalID;
            InitializeComponent();
        }

        private void updateGoalBtnk_Click(object sender, EventArgs e) {
            if (txtName.Text == "" || txtTargetAmout.Text == "" || txtSavedAmount.Text == "") {
                MessageBox.Show("Please fill all blank fields.");
                return;
            }
            if (dtPickerDealine.Value < DateTime.Now.Date) {
                MessageBox.Show("Please select a date after today.");
                return;
            }
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {

                    // insert budget
                    string updateQuery = "UPDATE Goals " +
                        "SET GoalName=@GoalName, TargetAmount=@TargetAmount, SavedAmount=@SavedAmount, Deadline=@Deadline " +
                        "WHERE GoalID=@GoalID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn)) {
                        cmd.Parameters.AddWithValue("@GoalName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@TargetAmount", txtTargetAmout.Text.Trim());
                        cmd.Parameters.AddWithValue("@SavedAmount", txtSavedAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@Deadline", dtPickerDealine.Value.Date);
                        cmd.Parameters.AddWithValue("@GoalID", this.GoalID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Goal updated successfully!",
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
