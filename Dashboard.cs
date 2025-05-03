using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class Dashboard : UserControl {

        DatabaseHelper databaseHelper = new DatabaseHelper();

        public Dashboard() {
            InitializeComponent();
        }

        public void LoadData() {
            using (SqlConnection conn = databaseHelper.GetConnection()) {
                //conn.Open();
                //string query = "SELECT TotalIncome, TotalExpense FROM UserSummary WHERE UserID=@UserID";

                //using (SqlCommand cmd = new SqlCommand(query, conn)) {
                //    cmd.Parameters.AddWithValue("@userID", userID);
                //    using (SqlDataReader reader = cmd.ExecuteReader()) {
                //        if (reader.Read()) {
                //            decimal totalIncome = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                //            decimal totalExpense = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);

                //            totalIncomeLbl.Text = totalIncome.ToString("N0") + " USD";
                //            totalExpenseLbl.Text = totalExpense.ToString("N0") + " USD";
                //            balanceLbl.Text = (totalIncome - totalExpense).ToString("N0") + " USD";
                //        }
                //    }
                //}
            }

            LoadIncomeExpenseChart();

            categoryTypeComboBox.Items.Clear();
            categoryTypeComboBox.Items.AddRange(new[] { "Income", "Expense" });
            categoryTypeComboBox.SelectedIndex = 0; // Will auto trigger pie chart
        }

        private void LoadIncomeExpenseChart()
        {
            incomeExpenseChart.Series.Clear();
            incomeExpenseChart.ChartAreas.Clear();
            incomeExpenseChart.Legends.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisY.LabelStyle.Format = ""; // Currency format

            chartArea.AxisY.LabelStyle.IsEndLabelVisible = true;
            chartArea.AxisY.LabelStyle.Enabled = true;

            chartArea.AxisY.LabelStyle = new LabelStyle();
            chartArea.AxisY.LabelStyle.Interval = 0; // Let it auto-handle ticks

            chartArea.AxisY.LabelStyle.Enabled = true;

            // Custom formatting using event
            incomeExpenseChart.PostPaint += (s, e) =>
            {
                Axis axis = chartArea.AxisY;

                foreach (CustomLabel label in axis.CustomLabels)
                {
                    double val = (label.FromPosition + label.ToPosition) / 2;
                    label.Text = FormatCurrency(val);
                }
            };

            incomeExpenseChart.ChartAreas.Add(chartArea);

            Legend legend = new Legend();
            incomeExpenseChart.Legends.Add(legend);

            Series incomeSeries = new Series("Income")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SeaGreen,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            Series expenseSeries = new Series("Expense")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.IndianRed,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            using (SqlConnection conn = databaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT 
                                    FORMAT(TransactionDate, 'yyyy-MM') AS Month,
                                    SUM(CASE WHEN c.CategoryType = 'Income' THEN t.Amount ELSE 0 END) AS TotalIncome,
                                    SUM(CASE WHEN c.CategoryType = 'Expense' THEN t.Amount ELSE 0 END) AS TotalExpense
                                FROM Transactions t
                                JOIN Category c ON t.CategoryID = c.CategoryID
                                WHERE TransactionDate >= DATEADD(MONTH, -3, GETDATE())  -- ✅ Last 3 months
                                GROUP BY FORMAT(TransactionDate, 'yyyy-MM')
                                ORDER BY Month;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string month = reader.GetString(0);
                            decimal income = reader.GetDecimal(1);
                            decimal expense = reader.GetDecimal(2);

                            incomeSeries.Points.AddXY(month, income);
                            expenseSeries.Points.AddXY(month, expense);
                        }
                    }
                }
            }

            incomeExpenseChart.Series.Add(incomeSeries);
            incomeExpenseChart.Series.Add(expenseSeries);
        }

        private string FormatCurrency(double value)
        {
            if (value >= 1_000_000_000)
                return $"${value / 1_000_000_000:0.##}B";
            else if (value >= 1_000_000)
                return $"${value / 1_000_000:0.##}M";
            else if (value >= 1_000)
                return $"${value / 1_000:0.##}K";
            else
                return $"${value:0}";
        }

        private void LoadCategoryPieChart(string categoryType)
        {
            categoryPieChart.Series.Clear();
            categoryPieChart.ChartAreas.Clear();

            ChartArea area = new ChartArea();
            area.Position = new ElementPosition(0, 0, 100, 100); // Full control
            area.InnerPlotPosition = new ElementPosition(10, 10, 80, 80); // Pie fills most of area
            categoryPieChart.ChartAreas.Add(area);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = false,       // ⛔ Don’t auto-show label
                LegendText = "#VALX",
            };

            using (SqlConnection conn = databaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT c.CategoryName, SUM(t.Amount) AS Total
                    FROM Transactions t
                    JOIN Category c ON t.CategoryID = c.CategoryID
                    WHERE 
                        c.CategoryType = @CategoryType
                        AND t.TransactionDate >= DATEADD(MONTH, -3, GETDATE())  -- ✅ Only last 3 months
                    GROUP BY c.CategoryName
                    ORDER BY Total DESC;
                    ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryType", categoryType);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string category = reader.GetString(0);
                            decimal total = reader.GetDecimal(1);

                            int pointIndex = series.Points.AddXY(category, total);
                            DataPoint point = series.Points[pointIndex];

                            point.IsValueShownAsLabel = false;
                            point.Label = " "; // ← SPACE! not empty string
                            point["PieLabelStyle"] = "Disabled"; // ← THIS is the key trick
                            point.ToolTip = $"{category}: {total:N0} VND"; // optional
                        }
                    }
                }
            }

            categoryPieChart.Series.Add(series);
        }

        private void categoryTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = categoryTypeComboBox.SelectedItem.ToString();
            LoadCategoryPieChart(selectedType);
        }
    }
}
