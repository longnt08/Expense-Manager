using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager.Helpers {
    public class DatabaseHelper {
        private readonly string _connectionString;
        public DatabaseHelper() {
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyCNN"].ConnectionString;
        }
        public SqlConnection GetConnection() {
            return new SqlConnection(_connectionString);
        }

        public int GetIdFromDatabase(string query, string paramName, object paramValue, SqlConnection conn) {
            if (conn.State == ConnectionState.Closed) {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(query, conn)) {
                cmd.Parameters.AddWithValue(paramName, paramValue);
                object result = cmd.ExecuteScalar();
                return (result != null) ? Convert.ToInt32(result) : 0;
            }
        }

        public void deleteItem(string query, string paramName, int id, SqlConnection conn) {
            using (SqlCommand cmd = new SqlCommand(query, conn)) {
                cmd.Parameters.AddWithValue(paramName, id);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable getDataFromFilters(int categoryId, SqlConnection conn) {
            if (conn.State == ConnectionState.Closed) {
                conn.Open();
            }
            string query = "SELECT * FROM Transactions WHERE CategoryID = @CategoryID";
            using (SqlCommand cmd = new SqlCommand(query, conn)) {
                cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
