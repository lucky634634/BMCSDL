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
    public partial class AddScoreForm : Form
    {
        private string _masv;

        public AddScoreForm(string masv)
        {
            InitializeComponent();
            _masv = masv;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (mahpText.Text == "")
            {
                return;
            }
            try
            {
                string sql = @"
                    EXEC SP_INS_DIEMTHI @MASV, @MAHP, @DIEM, @MANV
                ";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MASV", _masv);
                    cmd.Parameters.AddWithValue("@MAHP", mahpText.Text);
                    cmd.Parameters.AddWithValue("@DIEM", (float)diemText.Value);
                    cmd.Parameters.AddWithValue("@MANV", SqlData.Instance.id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Thêm điểm thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
