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
    public partial class SVForm : Form
    {
        private string _malop;
        private string _masv;
        private string _mode;

        public SVForm(string malop)
        {
            _malop = malop;
            InitializeComponent();
        }

        private void LoadData()
        {
            svTable.Rows.Clear();
            try
            {
                string sql = @"
                    SELECT MASV, HOTEN, NGAYSINH, DIACHI, MALOP
                    FROM SINHVIEN
                    WHERE MALOP = @MALOP
                ";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MALOP", _malop);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string masv = reader.GetString(0);
                                string hoten = reader.GetString(1);
                                string ngaysinh = reader.GetValue(2) == DBNull.Value ? "" : reader.GetDateTime(2).ToString("dd/MM/yyyy");
                                string diachi = reader.GetValue(3) == DBNull.Value ? "" : reader.GetString(3);
                                string malop = reader.GetString(4);
                                svTable.Rows.Add(masv, hoten, ngaysinh, diachi, malop);
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

        private void SVForm_Load(object sender, EventArgs e)
        {
            LoadData();
            DisableInput();
            _mode = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _mode = "add";
            EnableInput();
        }

        private void EnableInput()
        {
            masvText.Enabled = true;
            masvText.Clear();
            hotenText.Enabled = true;
            hotenText.Clear();
            datePicker.Enabled = true;
            diaChiText.Enabled = true;
            diaChiText.Clear();
            maLopText.Enabled = true;
            maLopText.Clear();
            tenDNText.Enabled = true;
            tenDNText.Clear();
            matKhauText.Enabled = true;
            matKhauText.Clear();
        }

        private void DisableInput()
        {
            masvText.Enabled = false;
            masvText.Clear();
            hotenText.Enabled = false;
            hotenText.Clear();
            datePicker.Enabled = false;
            diaChiText.Enabled = false;
            diaChiText.Clear();
            maLopText.Enabled = false;
            maLopText.Clear();
            tenDNText.Enabled = false;
            tenDNText.Clear();
            matKhauText.Enabled = false;
            matKhauText.Clear();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (svTable.SelectedRows.Count <= 0) return;
            EnableInput();
            masvText.Enabled = false;
            _mode = "edit";
            try
            {
                string sql = @"
                    SELECT MASV, HOTEN, NGAYSINH, DIACHI, MALOP, TENDN
                    FROM SINHVIEN
                    WHERE MASV = @MASV
                ";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@MASV", svTable.SelectedRows[0].Cells[0].Value.ToString());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                masvText.Text = reader.GetString(0);
                                hotenText.Text = reader.GetString(1);
                                datePicker.Value = reader.GetValue(2) == DBNull.Value ? DateTime.Now : reader.GetDateTime(2);
                                diaChiText.Text = reader.GetValue(3) == DBNull.Value ? "" : reader.GetString(3);
                                maLopText.Text = reader.GetString(4);
                                tenDNText.Text = reader.GetString(5);
                            }
                            _masv = masvText.Text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_mode == "add")
            {
                if (masvText.Text == "" || hotenText.Text == "" || maLopText.Text == "" || tenDNText.Text == "" || matKhauText.Text == "") return;
                try
                {
                    string sql = @"
                        INSERT INTO SINHVIEN
                        VALUES (@MASV, @HOTEN, CAST(@NGAYSINH AS DATE), @DIACHI, @MALOP, @TENDN, CONVERT(VARBINARY(MAX), @MATKHAU, 1))
                    ";
                    using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@MASV", masvText.Text);
                        cmd.Parameters.AddWithValue("@HOTEN", hotenText.Text);
                        cmd.Parameters.AddWithValue("@NGAYSINH", datePicker.Value.ToShortDateString());
                        if (diaChiText.Text == "")
                            cmd.Parameters.AddWithValue("@DIACHI", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@DIACHI", diaChiText.Text);
                        cmd.Parameters.AddWithValue("@MALOP", maLopText.Text);
                        cmd.Parameters.AddWithValue("@TENDN", tenDNText.Text);
                        cmd.Parameters.AddWithValue("@MATKHAU", "0x" + Cryptography.GetMd5Hash(matKhauText.Text));
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
                if (masvText.Text == "" || hotenText.Text == "" || maLopText.Text == "" || tenDNText.Text == "" || matKhauText.Text == "") return;
                try
                {
                    string sql = @"
                    UPDATE SINHVIEN 
                    SET HOTEN = @HOTEN, NGAYSINH = CAST(@NGAYSINH AS DATE), DIACHI = @DIACHI, MALOP = @MALOP, TENDN = @TENDN, MATKHAU = CONVERT(VARBINARY(MAX), @MATKHAU, 1)
                    WHERE MASV = @MASV";
                    using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                    {
                        cmd.Parameters.AddWithValue("@MASV", masvText.Text);
                        cmd.Parameters.AddWithValue("@HOTEN", hotenText.Text);
                        cmd.Parameters.AddWithValue("@NGAYSINH", datePicker.Value.ToShortDateString());
                        if (diaChiText.Text == "")
                            cmd.Parameters.AddWithValue("@DIACHI", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@DIACHI", diaChiText.Text);
                        cmd.Parameters.AddWithValue("@MALOP", maLopText.Text);
                        cmd.Parameters.AddWithValue("@TENDN", tenDNText.Text);
                        cmd.Parameters.AddWithValue("@MATKHAU", "0x" + Cryptography.GetMd5Hash(matKhauText.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
            _mode = "";
            DisableInput();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (svTable.SelectedRows.Count <= 0) return;
            string masv = svTable.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                string sql = @"DELETE FROM BANGDIEM WHERE MASV = @MASV";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MASV", masv);
                    cmd.ExecuteNonQuery();
                }

                sql = @"DELETE FROM SINHVIEN WHERE MASV = @MASV";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MASV", masv);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            if (svTable.SelectedRows.Count <= 0) return;
            var scoreForm = new ScoreForm(svTable.SelectedRows[0].Cells[0].Value.ToString());
            Hide();
            scoreForm.Show();
            scoreForm.Disposed += (s, args) => Show();
        }
    }
}
