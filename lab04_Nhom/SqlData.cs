using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public SqlConnection connection { get; private set; }

        private SqlData()
        {
            connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
        }
    }
}
