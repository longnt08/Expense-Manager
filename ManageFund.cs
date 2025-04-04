using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class ManageFund : UserControl {

        DatabaseHelper dbHelper = new DatabaseHelper();
        public ManageFund() {
            InitializeComponent();
        }

        private void addMainBankBtn_Click(object sender, EventArgs e) {
            AddFundForm addFundForm = new AddFundForm(mainBankLbl.Text.Trim());
            var result = addFundForm.ShowDialog();
            if (result == DialogResult.OK) {
                 LoadMainBankAmount();
            }
        }

        private void ManageFund_Load(object sender, EventArgs e) {
            LoadFundDonutChart();
        }

        private void addCashBtn_Click(object sender, EventArgs e) {
            AddFundForm addFundForm = new AddFundForm(cashOnHandLbl.Text.Trim());
            addFundForm.ShowDialog();
            if (addFundForm.DialogResult == DialogResult.OK) {
                LoadCashOnHandAmount();
            }
        }

        private void addPettyCashBtn_Click(object sender, EventArgs e) {
            AddFundForm addFundForm = new AddFundForm(pettyCashLbl.Text.Trim());
            addFundForm.ShowDialog();
            if (addFundForm.DialogResult == DialogResult.OK) {
                LoadPettyCashAmount();
            }
        }

        private void addSavingsBtn_Click(object sender, EventArgs e) {
            AddFundForm addFundForm = new AddFundForm(savingsAccountLbl.Text.Trim());
            addFundForm.ShowDialog();
            if (addFundForm.DialogResult == DialogResult.OK) {
                LoadSavingsAmount();
            }
        }

        public void LoadData() {
            try {
                using (SqlConnection conn = dbHelper.GetConnection()) {
                    if(conn.State == System.Data.ConnectionState.Closed) {
                        conn.Open();
                    }
                    string query = "SELECT FundName, SUM(Balance) AS TotalAmount FROM FundAccount GROUP BY FundName";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            decimal mainBank = 0;
                            decimal pettyCash = 0;
                            decimal savings = 0;
                            decimal cashOnHand = 0;

                            while (reader.Read()) {
                                string fundName = reader["FundName"].ToString();
                                decimal totalAmount = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);

                                if (fundName == "Main Bank Account") {
                                    mainBank = totalAmount;
                                } else if (fundName == "Petty Cash") {
                                    pettyCash = totalAmount;
                                } else if (fundName == "Savings Account") {
                                    savings = totalAmount;
                                } else if (fundName == "Cash on Hand") {
                                    cashOnHand = totalAmount;
                                }
                            }
                            mainBankAmountLbl.Text = mainBank.ToString("N0") + " USD";
                            pettyCashAmountLbl.Text = pettyCash.ToString("N0") + " USD";
                            savingsAmountLbl.Text = savings.ToString("N0") + " USD";
                            cashOnHandAmountLbl.Text = cashOnHand.ToString("N0") + " USD";

                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadMainBankAmount() {
            try {
                using (SqlConnection conn = dbHelper.GetConnection()) {
                    if(conn.State == System.Data.ConnectionState.Closed) {
                        conn.Open();
                    }
                    string query = "SELECT Balance FROM FundAccount WHERE  FundName = @FundName";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@FundName", mainBankLbl.Text.Trim());
                        object result = cmd.ExecuteScalar();
                        decimal TotalAmount = (result != null) ? Convert.ToDecimal(result) : 0;

                        mainBankAmountLbl.Text = TotalAmount.ToString("N0") + " USD";
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadCashOnHandAmount() {
            try {
                using (SqlConnection conn = dbHelper.GetConnection()) {
                    if (conn.State == System.Data.ConnectionState.Closed) {
                        conn.Open();
                    }
                    string query = "SELECT Balance FROM FundAccount WHERE  FundName = @FundName";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@FundName", cashOnHandLbl.Text.Trim());
                        object result = cmd.ExecuteScalar();
                        decimal TotalAmount = (result != null) ? Convert.ToDecimal(result) : 0;

                        cashOnHandAmountLbl.Text = TotalAmount.ToString("N0") + " USD";
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadPettyCashAmount() {
            try {
                using (SqlConnection conn = dbHelper.GetConnection()) {
                    if (conn.State == System.Data.ConnectionState.Closed) {
                        conn.Open();
                    }
                    string query = "SELECT Balance FROM FundAccount WHERE  FundName = @FundName";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@FundName", pettyCashLbl.Text.Trim());
                        object result = cmd.ExecuteScalar();
                        decimal TotalAmount = (result != null) ? Convert.ToDecimal(result) : 0;

                        pettyCashAmountLbl.Text = TotalAmount.ToString("N0") + " USD";
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadSavingsAmount() {
            try {
                using (SqlConnection conn = dbHelper.GetConnection()) {
                    if (conn.State == System.Data.ConnectionState.Closed) {
                        conn.Open();
                    }
                    string query = "SELECT Balance FROM FundAccount WHERE  FundName = @FundName";
                    using (SqlCommand cmd = new SqlCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@FundName", savingsAccountLbl.Text.Trim());
                        object result = cmd.ExecuteScalar();
                        decimal TotalAmount = (result != null) ? Convert.ToDecimal(result) : 0;

                        savingsAmountLbl.Text = TotalAmount.ToString("N0") + " USD";
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Visualizations
        private void LoadFundDonutChart()
        {
            fundChart.Series.Clear();
            fundChart.ChartAreas.Clear();
            fundChart.Titles.Clear();
            fundChart.Legends.Clear();

            Dictionary<string, decimal> fundData = new Dictionary<string, decimal>();

            decimal totalBalance = 0;

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT FundName, SUM(Balance) AS TotalAmount FROM FundAccount GROUP BY FundName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fundName = reader.GetString(0);
                            decimal balance = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);

                            if (balance > 0)
                            {
                                fundData[fundName] = balance;
                                totalBalance += balance;
                            }
                        }
                    }
                }
            }

            ChartArea area = new ChartArea();
            area.Position = new ElementPosition(0, 0, 100, 100);
            area.InnerPlotPosition = new ElementPosition(10, 10, 80, 80);
            fundChart.ChartAreas.Add(area);

            Series series = new Series
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = false,
                Font = new Font("Segoe UI", 9)
            };

            foreach (var fund in fundData)
            {
                int idx = series.Points.AddXY(fund.Key, fund.Value);
                DataPoint point = series.Points[idx];
                point.Label = ""; // No label on slice
                point["PieLabelStyle"] = "Disabled";
                point.LegendText = $"{fund.Key} - {fund.Value:N0} USD";
                point.ToolTip = $"{fund.Key}: {fund.Value:N0} USD";
            }

            fundChart.Series.Add(series);

            fundChart.Legends.Add(new Legend
            {
                Docking = Docking.Right,
                Font = new Font("Segoe UI", 9)
            });

            fundChart.Titles.Add(new Title
            {
                Text = $" ",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Alignment = ContentAlignment.MiddleCenter,
                Docking = Docking.Top
            });

            centerBalanceLbl.Text = $"Total Balance\n{totalBalance:N0} USD";
            centerBalanceLbl.Size = new Size(100, 40);
            centerBalanceLbl.BringToFront();

            // Optional: dynamically center the label inside fundChart
            int centerX = fundChart.Width / 2 - centerBalanceLbl.Width / 2;
            int centerY = fundChart.Height / 2 - centerBalanceLbl.Height / 2;
            centerBalanceLbl.Location = new Point(fundChart.Left + centerX, fundChart.Top + centerY);

            fundChart.Resize += fundChart_Resize;
        }

        private void fundChart_Resize(object sender, EventArgs e)
        {
            int centerX = fundChart.Width / 2 - centerBalanceLbl.Width / 2;
            int centerY = fundChart.Height / 2 - centerBalanceLbl.Height / 2;
            centerBalanceLbl.Location = new Point(fundChart.Left + centerX, fundChart.Top + centerY);
        }

    }
}
