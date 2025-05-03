using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class UpdateGoalForm : Form {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        private int GoalID;
        public UpdateGoalForm() {
            InitializeComponent();
        }

        public UpdateGoalForm(int GoalID, string goalName, decimal targetAmount, decimal currentAmount, DateTime dueDate) {
           InitializeComponent();

            if (txtUpdateGoalName == null) MessageBox.Show("txtName is NULL");
            if (txtUpdateTargetAmout == null) MessageBox.Show("txtTargetAmout is NULL");
            if (txtUpdateCurrentAmount == null) MessageBox.Show("txtCurrentAmount is NULL");
            if (dtUpdatePickerDealine == null) MessageBox.Show("dtPickerDealine is NULL");

            this.GoalID = GoalID;
            txtUpdateGoalName.Text = goalName;
            txtUpdateTargetAmout.Text = targetAmount.ToString();
            txtUpdateCurrentAmount.Text = currentAmount.ToString();
            dtUpdatePickerDealine.Value = dueDate;
        }

        private void updateGoalBtnk_Click(object sender, EventArgs e) {
            if (txtUpdateGoalName.Text == "" || txtUpdateTargetAmout.Text == "" || txtUpdateCurrentAmount.Text == "") {
                MessageBox.Show("Please fill all blank fields.");
                return;
            }
            if (dtUpdatePickerDealine.Value < DateTime.Now.Date) {
                MessageBox.Show("Please select a date after today.");
                return;
            }
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {
                    conn.Open();

                    // insert budget
                    string updateQuery = "UPDATE BusinessGoal " +
                        "SET GoalName=@GoalName, TargetAmount=@TargetAmount, CurrentAmount=@CurrentAmount, DueDate=@DueDate " +
                        "WHERE GoalID=@GoalID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn)) {
                        cmd.Parameters.AddWithValue("@GoalName", txtUpdateGoalName.Text.Trim());
                        cmd.Parameters.AddWithValue("@TargetAmount", txtUpdateTargetAmout.Text.Trim());
                        cmd.Parameters.AddWithValue("@CurrentAmount", txtUpdateCurrentAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@DueDate", dtUpdatePickerDealine.Value.Date);
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

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
