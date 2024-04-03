using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04_CaNhan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string role = "";
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            try
            {
                string sql = @"
                    SELECT 'SV', MASV, CONVERT(VARCHAR(MAX), MATKHAU, 1) FROM SINHVIEN WHERE TENDN = @TENDN
                    UNION ALL
                    SELECT 'NV', MANV, CONVERT(VARCHAR(MAX), MATKHAU, 1) FROM NHANVIEN WHERE TENDN = @TENDN
                ";


                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@TENDN", usernameTextBox.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                role = reader.GetString(0);
                                username = reader.GetString(1);
                                password = reader.GetString(2);
                            }
                        }
                    }
                }
                password = password.ToLower();
                password = password.Substring(2);
                if (role == "NV" && password == Crypto.GetSHA1Hash(passwordTextBox.Text))
                {
                    var nv = new NVForm();
                    nv.Show();
                    this.Hide();
                    nv.Disposed += (s, ev) => this.Show();
                }
                else if (role == "SV" && password == Crypto.GetMd5Hash(passwordTextBox.Text))
                {
                    var nv = new NVForm();
                    nv.Show();
                    this.Hide();
                    nv.Disposed += (s, ev) => this.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
