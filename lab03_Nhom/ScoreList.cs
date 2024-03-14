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
    public partial class ScoreList : Form
    {
        private string _masv = "";

        public ScoreList(string masv)
        {
            InitializeComponent();
            _masv = masv;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addScoreForm = new AddScoreForm(_masv);
            addScoreForm.FormClosed += ScoreList_Load;
            addScoreForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (scoreListView.SelectedItems.Count > 0)
            {
                string maSv = scoreListView.SelectedItems[0].Text;
                try
                {
                    string sql = @"
                        EXEC SP_DEL_DIEMTHI @MASV, @MAHP
                    ";
                    using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@MASV", _masv);
                        cmd.Parameters.AddWithValue("@MAHP", scoreListView.SelectedItems[0].Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa điểm thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (scoreListView.SelectedItems.Count > 0)
            {
                string mahp = scoreListView.SelectedItems[0].Text;
                string diem = scoreListView.SelectedItems[0].SubItems[2].Text;
                var editScoreForm = new EditScore(_masv, mahp, diem);
                editScoreForm.FormClosed += ScoreList_Load;
                editScoreForm.ShowDialog();
            }
        }

        private void ScoreList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            scoreListView.Items.Clear();
            try
            {
                string sql = @"
                    EXEC SP_SEL_ALL_DIEMTHI @MASV, @TENDN, @MATKHAU
                ";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MASV", _masv);
                    cmd.Parameters.AddWithValue("@TENDN", SqlData.Instance.username);
                    cmd.Parameters.AddWithValue("@MATKHAU", SqlData.Instance.password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = reader.GetString(0);
                                item.SubItems.Add(reader.GetString(1));
                                item.SubItems.Add(reader.GetString(2));
                                scoreListView.Items.Add(item);
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
    }
}
