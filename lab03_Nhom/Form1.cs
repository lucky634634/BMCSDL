using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lab03_Nhom
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = "";
            string password = "";
            string userType = "";
            try
            {
                string sql = @"
                    SELECT 'SV', MASV, CONVERT(VARCHAR(MAX), MATKHAU, 1) FROM SINHVIEN WHERE TENDN = @TENDN
                    UNION ALL
                    SELECT 'NV', MANV, CONVERT(VARCHAR(MAX), MATKHAU, 1) FROM NHANVIEN WHERE TENDN = @TENDN
                ";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@TENDN", usernameText.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                userType = reader.GetString(0);
                                id = reader.GetString(1);
                                password = reader.GetString(2);
                            }
                        }
                    }
                }

                if (userType == "SV" && password == "0x" + Cryptography.GetMd5Hash(passwordText.Text))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (userType == "NV" && password == "0x" + Cryptography.GetSHA1Hash(passwordText.Text))
                {
                    SqlData.Instance.id = id;
                    SqlData.Instance.username = usernameText.Text;
                    SqlData.Instance.password = passwordText.Text;
                    Hide();
                    form2 = new Form2();
                    form2.FormClosed += delegate { Show(); };
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            passwordText.Clear();
        }
    }
}
