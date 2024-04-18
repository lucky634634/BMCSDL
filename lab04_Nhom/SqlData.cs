using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04_Nhom
{
    public class SqlData
    {
        public static SqlData Instance { private set; get; } = new SqlData();

        public SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
        {
            DataSource = "localhost",
            UserID = "DBUser",
            Password = "demo123456",
            InitialCatalog = "QLSVNhom",
            TrustServerCertificate = true
        };
        private SqlConnection _connection;
        public SqlConnection connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(builder.ConnectionString);
                }
                if (_connection.State != System.Data.ConnectionState.Open)
                    _connection.Open();
                return _connection;
            }
        }

        private SqlData()
        {

        }


        public string id;
        public string password;
    }
}
