using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lab04_Nhom
{
    public partial class ScoreForm : Form
    {
        private string _masv;
        private string _mode;
        private string _pubKey;

        public ScoreForm(string masv)
        {
            _masv = masv;
            InitializeComponent();
        }

        private void LoadData()
        {
            scoreTable.Rows.Clear();
            try
            {
                string sql = @"
                    SELECT BANGDIEM.MAHP, TENHP, SOTC, CONVERT(VARCHAR(MAX), DIEMTHI, 1)
                    FROM BANGDIEM, HOCPHAN
                    WHERE BANGDIEM.MAHP = HOCPHAN.MAHP
                    AND MASV = @MASV";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MASV", _masv);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string mahp = reader.GetString(0);
                                string tenhp = reader.GetString(1);
                                int sotc = reader.GetInt32(2);
                                string diem = Cryptography.GetRSADecrypt(reader.GetString(3).Substring(2), _pubKey);


                                scoreTable.Rows.Add(mahp, tenhp, sotc, diem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            GetPublicKey();
            LoadData();
            DisableInput();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EnableInput();
            _mode = "add";
        }

        private void EnableInput()
        {
            mahpText.Enabled = true;
            mahpText.Clear();
            scoreBox.Enabled = true;
            scoreBox.ResetText();
        }

        private void DisableInput()
        {
            mahpText.Enabled = false;
            mahpText.Clear();
            scoreBox.Enabled = false;
            scoreBox.Value = 0;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (scoreTable.SelectedRows.Count <= 0) return;
            EnableInput();
            mahpText.Text = scoreTable.SelectedRows[0].Cells[0].Value.ToString();
            mahpText.Enabled = false;
            scoreBox.Value = Convert.ToDecimal(scoreTable.SelectedRows[0].Cells[3].Value.ToString());
            _mode = "edit";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_mode == "add")
            {
                if (mahpText.Text == "")
                {
                    return;
                }
                try
                {
                    string sql = @"
                        INSERT INTO BANGDIEM
                        VALUES (@MASV, @MAHP, CONVERT(VARBINARY(MAX), @DIEMTHI, 1))";
                    using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@MASV", _masv);
                        cmd.Parameters.AddWithValue("@MAHP", mahpText.Text);
                        cmd.Parameters.AddWithValue("@DIEMTHI", "0x" + Cryptography.GetRSAEncrypt(scoreBox.Value.ToString(), _pubKey));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_mode == "edit")
            {
                if (mahpText.Text == "")
                {
                    return;
                }
                try
                {
                    string sql = @"UPDATE BANGDIEM
                        SET DIEMTHI = CONVERT(VARBINARY(MAX), @DIEMTHI, 1)
                        WHERE MASV = @MASV AND MAHP = @MAHP";
                    using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@MASV", _masv);
                        cmd.Parameters.AddWithValue("@MAHP", mahpText.Text);
                        cmd.Parameters.AddWithValue("@DIEMTHI", "0x" + Cryptography.GetRSAEncrypt(scoreBox.Value.ToString(), _pubKey));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            DisableInput();
            LoadData();
            _mode = "";
        }

        private void GetPublicKey()
        {
            try
            {
                string sql = @"SELECT PUBKEY FROM NHANVIEN WHERE MANV = @MANV";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MANV", SqlData.Instance.id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                _pubKey = reader.GetString(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (scoreTable.SelectedRows.Count <= 0) return;
            string mahp = scoreTable.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                string sql = @"DELETE FROM BANGDIEM WHERE MASV = @MASV AND MAHP = @MAHP";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MASV", _masv);
                    cmd.Parameters.AddWithValue("@MAHP", mahp);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
