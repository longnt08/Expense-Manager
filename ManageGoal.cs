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
    public partial class ManageGoal : UserControl {

        DatabaseHelper databaseHelper = new DatabaseHelper();
        public ManageGoal() {
            InitializeComponent();
        }

        private void createGoalBtn_Click(object sender, EventArgs e) {
            if(txtName.Text == "" || txtTargetAmout.Text == "" || txtSavedAmount.Text == "") {
                MessageBox.Show("Please fill all blank fields.");
                return;
            }
            if (dtPickerDealine.Value < DateTime.Now.Date) {
                MessageBox.Show("Please select a date after today.");
                return;
            }
            try {
                using(SqlConnection conn = databaseHelper.GetConnection()) {

                    // lay userId
                    string selectUser = "SELECT UserID FROM Users WHERE username = @username";
                    int userId = databaseHelper.GetIdFromDatabase(selectUser, "@username", Session.username, conn);

                    // insert budget
                    string insertQuery = "INSERT INTO Goals " +
                        "(UserID, GoalName, TargetAmount, SavedAmount, Deadline, GoalStatus) " +
                        "VALUES(@UserID, @GoalName, @TargetAmount, @SavedAmount, @Deadline, @GoalStatus)";

                    using(SqlCommand cmd = new SqlCommand(insertQuery, conn)) {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@GoalName", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@TargetAmount", txtTargetAmout.Text.Trim());
                        cmd.Parameters.AddWithValue("@SavedAmount", txtSavedAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@Deadline", dtPickerDealine.Value.Date);
                        cmd.Parameters.AddWithValue("@GoalStatus", "In Progress");

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Goal created successfully!",
                        "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHelper.LoadData(dgvGoals, "SELECT * FROM Goals", conn);
                        FormHelper.AddButtonColumns(dgvGoals);
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void filterGoalsBtn_Click(object sender, EventArgs e) {
            try{
                using(SqlConnection conn = databaseHelper.GetConnection()) {
                    string query = "SELECT * FROM Goals WHERE GoalStatus=@GoalStatus";
                    using(SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@GoalStatus", txtFilterGoals);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvGoals.AllowUserToAddRows = false;

                        if(dt.Rows.Count > 0) {
                            dgvGoals.DataSource = dt;
                            dgvGoals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        } else {
                            dgvGoals.DataSource = null;
                            dgvGoals.Rows.Clear();
                        }

                        if (dgvGoals.Columns["btnUpdate"] != null)
                            dgvGoals.Columns.Remove("btnUpdate");
                        if (dgvGoals.Columns["btnDelete"] != null)
                            dgvGoals.Columns.Remove("btnDelete");

                        // Chỉ thêm nút nếu có dữ liệu
                        FormHelper.AddButtonColumns(dgvGoals);
                        return;
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ManageGoal_Load(object sender, EventArgs e) {
            try {
                using (SqlConnection conn = databaseHelper.GetConnection()) {
                    // update GoalStatus
                    conn.Open();
                    string sql = @"
                    UPDATE Goals
                    SET GoalStatus = 'Completed'
                    WHERE Deadline <= GETDATE() AND GoalStatus != 'Completed';
                    ";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    // load du lieu ra dataGridView
                    string query = "SELECT * FROM Goals";
                    FormHelper.LoadData(dgvGoals, query, conn);

                    if (dgvGoals.Rows.Count > 0 && !dgvGoals.Rows[0].IsNewRow) {
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

            if (dgvGoals.Columns[e.ColumnIndex].Name == "btnUpdate") {
                dgvGoals.EndEdit();

                UpdateGoalForm updateGoalForm = new UpdateGoalForm(GoalID);
                var result = updateGoalForm.ShowDialog();

                if (result == DialogResult.OK) {
                    using (SqlConnection conn = databaseHelper.GetConnection()) {
                        FormHelper.LoadData(dgvGoals, "SELECT * FROM Goals", conn);
                    }
                    FormHelper.AddButtonColumns(dgvGoals);             
                }
            }

            if (dgvGoals.Columns[e.ColumnIndex].Name == "btnDelete") {
                DialogResult dialog = MessageBox.Show("Do you really want to delete this item?", "Confirm", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes) {
                    int goalId = Convert.ToInt32(cell.Value);
                    try {
                        using (SqlConnection conn = databaseHelper.GetConnection()) {
                            string query = "DELETE FROM Goals WHERE GoalID = @GoalId";
                            databaseHelper.deleteItem(query, "@GoalId", goalId, conn);

                            FormHelper.LoadData(dgvGoals, "SELECT * FROM Goals", conn);
                            if (dgvGoals.Columns["btnUpdate"] != null)
                                dgvGoals.Columns.Remove("btnUpdate");
                            if (dgvGoals.Columns["btnDelete"] != null)
                                dgvGoals.Columns.Remove("btnDelete");

                            // Chỉ thêm nút nếu có dữ liệu
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
