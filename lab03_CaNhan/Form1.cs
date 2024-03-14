using System;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace lab03_CaNhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                {
                    DataSource = "localhost",
                    UserID = "DBUser",
                    Password = "demo123456",
                    InitialCatalog = "QLSV",
                    TrustServerCertificate = true
                };

                string passwordHash = "";
                string userType = "";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql = @"
                        SELECT 'SV', CONVERT(VARCHAR(MAX), MATKHAU, 1) 
                        FROM SINHVIEN 
                        WHERE TENDN = @username 
                        UNION ALL 
                        SELECT 'NV', CONVERT(VARCHAR(MAX), MATKHAU, 1) 
                        FROM NHANVIEN WHERE TENDN = @username";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernameText.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userType = reader.GetString(0);
                                passwordHash = reader.GetString(1);
                            }
                        }
                    }
                }

                if (userType == "SV" && passwordHash == "0x" + GetMd5Hash(passwordText.Text))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (userType == "NV" && passwordHash == "0x" + GetSHA1Hash(passwordText.Text))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static string GetMd5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        static string GetSHA1Hash(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
