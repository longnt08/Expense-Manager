using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class ManageGoal : UserControl {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        public ManageGoal() {
            InitializeComponent();
        }

        private void createGoalBtn_Click(object sender, EventArgs e) {
            if(txtName.Text == "" || txtTargetAmout.Text == "" || txtCurrentAmount.Text == "") {
                MessageBox.Show("Please fill all blank fields.");
                return;
            }
            if (dtPickerDealine.Value < DateTime.Now.Date) {
                MessageBox.Show("Please select a date after today.");
                return;
            }
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {
                    conn.Open();
                    // insert goal
                    string insertQuery = "INSERT INTO BusinessGoal " +
                        "(GoalName, TargetAmount, CurrentAmount, DueDate, GoalStatus) " +
                        "VALUES(@GoalName, @TargetAmount, @CurrentAmount, @DueDate, @GoalStatus)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn)) {
                        cmd.Parameters.AddWithValue("@GoalName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@TargetAmount", txtTargetAmout.Text.Trim());
                        cmd.Parameters.AddWithValue("@CurrentAmount", txtCurrentAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@DueDate", dtPickerDealine.Value.Date);
                        cmd.Parameters.AddWithValue("@GoalStatus", "In Progress");

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Goal created successfully!",
                        "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHelper.LoadData(dgvGoals, "SELECT * FROM BusinessGoal", conn);
                        FormHelper.AddAmountButton(dgvGoals);
                        FormHelper.AddButtonColumns(dgvGoals);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void filterGoalsBtn_Click(object sender, EventArgs e) {
            //try{
            //    using(SqlConnection conn = databaseHelper.GetConnection()) {
            //        string query = "SELECT * FROM BusinessGoal WHERE GoalStatus=@GoalStatus";
            //        using(SqlCommand cmd = new SqlCommand(query, conn)) {
            //            cmd.Parameters.AddWithValue("@GoalStatus", txtFilterGoals);
            //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //            DataTable dt = new DataTable();
            //            adapter.Fill(dt);

            //            dgvGoals.AllowUserToAddRows = false;

            //            if(dt.Rows.Count > 0) {
            //                dgvGoals.DataSource = dt;
            //                dgvGoals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //            } else {
            //                dgvGoals.DataSource = null;
            //                dgvGoals.Rows.Clear();
            //            }

            //            if (dgvGoals.Columns["btnUpdate"] != null)
            //                dgvGoals.Columns.Remove("btnUpdate");
            //            if (dgvGoals.Columns["btnDelete"] != null)
            //                dgvGoals.Columns.Remove("btnDelete");
            //            if (dgvGoals.Columns["btnAddAmount"] != null)
            //                dgvGoals.Columns.Remove("btnAddAmount");

            //            // Chỉ thêm nút nếu có dữ liệu
            //            FormHelper.AddAmountButton(dgvGoals);
            //            FormHelper.AddButtonColumns(dgvGoals);
            //            return;
            //        }
            //    }
            //} catch(Exception ex) {
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void ManageGoal_Load(object sender, EventArgs e) {
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {
                    // update GoalStatus
                    conn.Open();
                    string sql = @"
                    UPDATE BusinessGoal
                    SET GoalStatus = 'Completed'
                    WHERE DueDate <= GETDATE() AND GoalStatus != 'Completed';
                    ";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    // load du lieu ra dataGridView
                    string query = "SELECT * FROM BusinessGoal";
                    FormHelper.LoadData(dgvGoals, query, conn);

                    if (dgvGoals.Rows.Count > 0 && !dgvGoals.Rows[0].IsNewRow) {
                        FormHelper.AddAmountButton(dgvGoals);
                        FormHelper.AddButtonColumns(dgvGoals);
                    }
                    dgvGoals.CellClick -= dgvGoals_CellClick;
                    dgvGoals.CellClick += dgvGoals_CellClick;

                    conn.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvGoals_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            int GoalID;

            var cell = dgvGoals.Rows[e.RowIndex].Cells["GoalID"];
            if (cell == null || cell.Value == null) {
                return;
            } else {
                GoalID = Convert.ToInt32(cell.Value);
            }

            // xu ly nut Add new amount
            if(dgvGoals.Columns[e.ColumnIndex].Name == "btnAddAmount") {
                dgvGoals.EndEdit();

                AddAmountForm addAmountForm = new AddAmountForm(GoalID);
                var result = addAmountForm.ShowDialog();

                if (result == DialogResult.OK) {
                    using (SqlConnection conn = databaseHelper.GetConnection()) {
                        FormHelper.LoadData(dgvGoals, "SELECT * FROM BusinessGoal", conn);
                    }
                    FormHelper.AddAmountButton(dgvGoals);
                    FormHelper.AddButtonColumns(dgvGoals);
                }
            }

            // xu ly nut Update
            if (dgvGoals.Columns[e.ColumnIndex].Name == "btnUpdate") {
                //dgvGoals.EndEdit();

                // Get values from the selected row
                string goalName = dgvGoals.Rows[e.RowIndex].Cells["GoalName"].Value.ToString();
                decimal targetAmount = Convert.ToDecimal(dgvGoals.Rows[e.RowIndex].Cells["TargetAmount"].Value);
                decimal currentAmount = Convert.ToDecimal(dgvGoals.Rows[e.RowIndex].Cells["CurrentAmount"].Value);
                DateTime dueDate = Convert.ToDateTime(dgvGoals.Rows[e.RowIndex].Cells["DueDate"].Value);

                UpdateGoalForm updateGoalForm = new UpdateGoalForm(GoalID, goalName, targetAmount, currentAmount, dueDate);
                var result = updateGoalForm.ShowDialog();

                if (result == DialogResult.OK) {
                    using (SqlConnection conn = databaseHelper.GetConnection()) {
                        FormHelper.LoadData(dgvGoals, "SELECT * FROM BusinessGoal", conn);
                    }
                    FormHelper.AddAmountButton(dgvGoals);
                    FormHelper.AddButtonColumns(dgvGoals);
                }
            }
            
            // xu ly nut Delete
            if (dgvGoals.Columns[e.ColumnIndex].Name == "btnDelete") {
                DialogResult dialog = MessageBox.Show("Do you really want to delete this item?", "Confirm", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes) {
                    int goalId = Convert.ToInt32(cell.Value);
                    try {
                        using (SqlConnection conn = databaseHelper.GetConnection()) {
                            string query = "DELETE FROM BusinessGoal WHERE GoalID = @GoalId";
                            databaseHelper.deleteItem(query, "@GoalId", goalId, conn);

                            FormHelper.LoadData(dgvGoals, "SELECT * FROM BusinessGoal", conn);
                            if (dgvGoals.Columns["btnUpdate"] != null)
                                dgvGoals.Columns.Remove("btnUpdate");
                            if (dgvGoals.Columns["btnDelete"] != null)
                                dgvGoals.Columns.Remove("btnDelete");

                            // Chỉ thêm nút nếu có dữ liệu
                            FormHelper.AddAmountButton(dgvGoals);
                            FormHelper.AddButtonColumns(dgvGoals);
                            return;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Error: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
