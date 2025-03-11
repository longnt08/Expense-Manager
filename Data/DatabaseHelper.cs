using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Data {
    public class DatabaseHelper {
        private readonly string _connectionString;
        public DatabaseHelper() {
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyCNN"].ConnectionString;
        }
        public SqlConnection GetConnection() {
            return new SqlConnection(_connectionString);
        }
    }
}
