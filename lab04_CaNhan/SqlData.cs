using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_CaNhan
{
    public class SqlData
    {
        public static SqlData Instance { private set; get; } = new SqlData();

        public SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
        {
            DataSource = "localhost",
            UserID = "DBUser",
            Password = "demo123456",
            InitialCatalog = "QLSV",
            TrustServerCertificate = true
        };
        private SqlConnection _connection = null;
        public SqlConnection connection
        {
            get
            {
                _connection = new SqlConnection(builder.ConnectionString);
                if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();
                return _connection;
            }
        }
    }
}
