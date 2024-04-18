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
    public partial class NVForm : Form
    {
        private string mode = "";
        private string pubKey = "";

        public NVForm()
        {
            InitializeComponent();
        }

        private void NVForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DisableInputForm()
        {
            manvText.Enabled = false;
            manvText.Clear();
            hotenText.Enabled = false;
            hotenText.Clear();
            emailText.Enabled = false;
            emailText.Clear();
            luongText.Enabled = false;
            luongText.Clear();
            tendnText.Enabled = false;
            tendnText.Clear();
            mkText.Enabled = false;
            mkText.Clear();
        }

        private void EnableInputForm()
        {
            manvText.Enabled = true;
            hotenText.Enabled = true;
            emailText.Enabled = true;
            luongText.Enabled = true;
            tendnText.Enabled = true;
            mkText.Enabled = true;
        }

        private void LoadData()
        {
            nvDataList.Rows.Clear();
            try
            {
                string sql = @"
                    SELECT MANV, HOTEN, EMAIL, PUBKEY,CONVERT(VARCHAR(MAX), LUONG, 1)
                    FROM NHANVIEN";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string manv = reader.GetString(0);
                                string hoten = reader.GetString(1);
                                string email = reader.GetString(2);
                                string pubKey = reader.GetString(3);
                                string luong = reader.GetValue(4) == DBNull.Value ? "0" : Cryptography.GetRSADecrypt(reader.GetString(4).Substring(2), pubKey);

                                nvDataList.Rows.Add(manv, hoten, email, luong);
                            }
                        }
                    }
                }
                nvDataList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lmButton_Click(object sender, EventArgs e)
        {
            LoadData();
            nvDataList.Enabled = true;
            nvDataList.ClearSelection();
            mode = "";
            DisableInputForm();
        }

        private void themButton_Click(object sender, EventArgs e)
        {
            mode = "add";
            nvDataList.ClearSelection();
            EnableInputForm();
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            if (mode == "") return;
            if (mode == "add")
            {
                if (manvText.Text == "" || hotenText.Text == "" || emailText.Text == "" || luongText.Text == "" || tendnText.Text == "" || mkText.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    pubKey = Cryptography.GetPublicKey();
                    try
                    {
                        string sql = @"EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN @MANV, @HOTEN, @EMAIL, @LUONG, @TENDN, @MATKHAU, @PUBKEY";
                        using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                        {
                            cmd.Parameters.AddWithValue("@MANV", manvText.Text);
                            cmd.Parameters.AddWithValue("@HOTEN", hotenText.Text);
                            cmd.Parameters.AddWithValue("@EMAIL", emailText.Text);
                            cmd.Parameters.AddWithValue("@LUONG", "0x" + Cryptography.GetRSAEncrypt(luongText.Text, pubKey));
                            cmd.Parameters.AddWithValue("@TENDN", tendnText.Text);
                            cmd.Parameters.AddWithValue("@MATKHAU", "0x" + Cryptography.GetSHA1Hash(mkText.Text));
                            cmd.Parameters.AddWithValue("@PUBKEY", pubKey);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (mode == "edit")
            {
                if (manvText.Text == "" || hotenText.Text == "" || emailText.Text == "" || luongText.Text == "" || tendnText.Text == "" || mkText.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    if (!Cryptography.CheckKey(pubKey))
                    {
                        pubKey = Cryptography.GetPublicKey();
                    }
                    try
                    {
                        string sql = @"
                            UPDATE NHANVIEN 
                            SET HOTEN = @HOTEN, EMAIL = @EMAIL, LUONG = @LUONG, TENDN = @TENDN, MATKHAU = @MATKHAU, PUBKEY = @PUBKEY  
                            WHERE MANV = @MANV";
                        using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                        {
                            cmd.Parameters.AddWithValue("@MANV", manvText.Text);
                            cmd.Parameters.AddWithValue("@HOTEN", hotenText.Text);
                            cmd.Parameters.AddWithValue("@EMAIL", emailText.Text);
                            cmd.Parameters.AddWithValue("@LUONG", Encoding.UTF8.GetBytes("0x" + Cryptography.GetRSAEncrypt(luongText.Text, pubKey)));
                            cmd.Parameters.AddWithValue("@TENDN", tendnText.Text);
                            cmd.Parameters.AddWithValue("@MATKHAU", Encoding.UTF8.GetBytes("0x" + Cryptography.GetSHA1Hash(mkText.Text)));
                            cmd.Parameters.AddWithValue("@PUBKEY", pubKey);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


            DisableInputForm();
            LoadData();
            mode = "";
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            if (nvDataList.SelectedRows.Count > 0)
            {
                string manv = nvDataList.SelectedRows[0].Cells[0].Value.ToString();
                string sql = @"DELETE FROM NHANVIEN WHERE MANV = @MANV";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                    {
                        cmd.Parameters.AddWithValue("@MANV", manv);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                LoadData();
            }
        }

        private void suaButton_Click(object sender, EventArgs e)
        {
            if (nvDataList.SelectedRows.Count > 0)
            {
                mode = "edit";
                EnableInputForm();


                string manv = nvDataList.SelectedRows[0].Cells[0].Value.ToString();
                string sql = @"SELECT MANV, HOTEN, EMAIL, CONVERT(VARCHAR(MAX), LUONG, 1), TENDN, CONVERT(VARCHAR(MAX), MATKHAU, 1), PUBKEY FROM NHANVIEN WHERE MANV = @MANV";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                    {
                        cmd.Parameters.AddWithValue("@MANV", manv);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                manvText.Text = reader.GetString(0);
                                hotenText.Text = reader.GetString(1);
                                emailText.Text = reader.GetValue(2) == DBNull.Value ? "" : reader.GetString(2);
                                luongText.Text = reader.GetValue(3) == DBNull.Value ? "0" : Cryptography.GetRSADecrypt(reader.GetString(3).Substring(2), pubKey);
                                tendnText.Text = reader.GetString(4);
                                mkText.Text = "";
                                pubKey = reader.GetValue(6) == DBNull.Value ? "" : reader.GetString(6);
                                if (!Cryptography.CheckKey(pubKey))
                                {
                                    pubKey = Cryptography.GetPublicKey();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
