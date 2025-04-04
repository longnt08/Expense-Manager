using ExpenseManager.Helpers;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseManager {
    public partial class ManageDebt : UserControl {
        DatabaseHelper dbHelper = new DatabaseHelper();
        public ManageDebt() {
            InitializeComponent();
            LoadDebtStatusChart();
            LoadDebtTypeChart();
        }

        private void LoadDebtStatusChart()
        {
            statusChart.Series.Clear();
            statusChart.ChartAreas.Clear();
            statusChart.Titles.Clear();

            ChartArea area = new ChartArea();
            area.InnerPlotPosition = new ElementPosition(15, 15, 70, 70); // More space for center
            statusChart.ChartAreas.Add(area);

            Series series = new Series
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = false,
                Font = new Font("Segoe UI", 9)
            };

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT DebtStatus, COUNT(*) AS Count
                    FROM Debt
                    GROUP BY DebtStatus";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader.GetString(0); // e.g. 'Đã thanh toán'
                        int count = reader.GetInt32(1);

                        int pointIndex = series.Points.AddXY(status, count);
                        series.Points[pointIndex].LegendText = $"{status} - {count}";
                        series.Points[pointIndex]["PieLabelStyle"] = "Disabled";
                    }
                }
            }

            statusChart.Series.Add(series);
            statusChart.Titles.Add("Tổng quan");
        }

        private void LoadDebtTypeChart()
        {
            typeChart.Series.Clear();
            typeChart.ChartAreas.Clear();
            typeChart.Titles.Clear();

            ChartArea area = new ChartArea();
            typeChart.ChartAreas.Add(area);

            Series series = new Series
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9)
            };

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT DebtType, COUNT(*) AS Count
                FROM Debt
                GROUP BY DebtType";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string type = reader.GetString(0);
                        int count = reader.GetInt32(1);
                        series.Points.AddXY(type, count);
                    }
                }
            }

            typeChart.Series.Add(series);
            typeChart.Titles.Add("Chi tiết");
        }

    }
}
