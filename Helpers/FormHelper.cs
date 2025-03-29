using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager.Helpers {
    public static class FormHelper {
        public static void AddButtonColumns(DataGridView dgv) {
            bool hasData = dgv.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow);

            if(!hasData) return;

            if(dgv.Columns["btnUpdate"] != null) dgv.Columns.Remove("btnUpdate");
            if(dgv.Columns["btnDelete"] != null) dgv.Columns.Remove("btnDelete");

            DataGridViewButtonColumn updateBtn = new DataGridViewButtonColumn{
                HeaderText = "Update",
                Text = "Update",
                Name = "btnUpdate",
                UseColumnTextForButtonValue = true,
            };
            dgv.Columns.Add(updateBtn);

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn {
                HeaderText = "Delete",
                Text = "Delete",
                Name = "btnDelete",
                UseColumnTextForButtonValue = true,
            };
            dgv.Columns.Add(deleteBtn);
        }

        public static void AddAmountButton(DataGridView dgv) {
            bool hasData = dgv.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow);

            if (!hasData) return;

            if (dgv.Columns["btnAddAmount"] != null) dgv.Columns.Remove("btnAddAmount");

            DataGridViewButtonColumn addAmountBtn = new DataGridViewButtonColumn {
                HeaderText = "AddAmount",
                Text = "+",
                Name = "btnAddAmount",
                UseColumnTextForButtonValue = true,
            };
            dgv.Columns.Add(addAmountBtn);
        }

        public static void LoadData(DataGridView dgv, string query, SqlConnection conn) {
            try {
                if (conn.State == ConnectionState.Closed) {
                    conn.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.AllowUserToAddRows = false;

                    if (dt.Rows.Count > 0) {
                        dgv.DataSource = dt;
                        dgv.Columns["FundID"].Visible = false;
                        dgv.Columns["CategoryID"].Visible = false;
                        dgv.Columns["PartnerID"].Visible = false;
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    } else {
                        dgv.DataSource = null;
                        dgv.Rows.Clear();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally {
                if (conn.State == ConnectionState.Open) {
                    conn.Close();
                }
            }
        }

        public static void loadDataAfterFilter(DataGridView dgv, DataTable dt) {
            dgv.AllowUserToAddRows = false;

            if (dt.Rows.Count > 0) {
                dgv.DataSource = dt;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            } else {
                dgv.DataSource = null;
                dgv.Rows.Clear();
            }
        }
    }
}
