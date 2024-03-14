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

namespace lab03_Nhom
{
    public partial class EditSvForm : Form
    {
        private string _masv;

        public EditSvForm(string maSv)
        {
            InitializeComponent();
            _masv = maSv;
        }

        private void EditSvForm_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = @"
                    SELECT HOTEN, NGAYSINH, DIACHI
                    FROM SINHVIEN
                    WHERE MASV = @MASV
                ";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@MASV", _masv);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                hoTenText.Text = reader.GetString(0);
                                ngaySinhPicker.Value = reader.GetDateTime(1);
                                diaChiText.Text = reader.GetString(2);
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"
                    UPDATE SINHVIEN SET HOTEN = @HOTEN, NGAYSINH = @NGAYSINH, DIACHI = @DIACHI
                    WHERE MASV = @MASV  
                ";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@HOTEN", hoTenText.Text);
                    cmd.Parameters.AddWithValue("@NGAYSINH", ngaySinhPicker.Value);
                    cmd.Parameters.AddWithValue("@DIACHI", diaChiText.Text);
                    cmd.Parameters.AddWithValue("@MASV", _masv);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thông tin sinh viên thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
