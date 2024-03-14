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

namespace lab03_Nhom
{
    public partial class EditScore : Form
    {
        private string _masv;
        private string _mahp;

        public EditScore(string masv, string mahp, string diem)
        {
            InitializeComponent();
            _masv = masv;
            _mahp = mahp;
            diemText.Value = decimal.Parse(diem);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"
                    EXEC SP_UPDATE_DIEMTHI @MASV, @MAHP, @DIEM, @MANV
                ";  
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MASV", _masv);
                    cmd.Parameters.AddWithValue("@MAHP", _mahp);
                    cmd.Parameters.AddWithValue("@DIEM", (float)diemText.Value);
                    cmd.Parameters.AddWithValue("@MANV", SqlData.Instance.id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cập nhật điểm thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
