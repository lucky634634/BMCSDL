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
    public partial class SvForm : Form
    {
        private string _maLop;

        public SvForm(string maLop)
        {
            InitializeComponent();
            this._maLop = maLop;
        }

        private void SvForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (SvListView.SelectedIndices.Count > 0)
            {
                string maSv = SvListView.SelectedItems[0].Text;
                EditSvForm editSvForm = new EditSvForm(maSv);
                editSvForm.Show();
                editSvForm.FormClosed += delegate { LoadData(); };
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SvListView.Items.Clear();
            try
            {
                string sql = @"
                    SELECT MASV, HOTEN, NGAYSINH, DIACHI
                    FROM SINHVIEN, LOP
                    WHERE LOP.MALOP = SINHVIEN.MALOP AND LOP.MALOP = @MALOP
                ";
                using (SqlCommand cmd = new SqlCommand(sql, SqlData.Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@MALOP", _maLop);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = reader.GetString(0);
                                item.SubItems.Add(reader.GetString(1));
                                item.SubItems.Add(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                                item.SubItems.Add(reader.GetString(3));
                                SvListView.Items.Add(item);
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

        private void scoreButton_Click(object sender, EventArgs e)
        {
            if (SvListView.SelectedItems.Count > 0)
            {
                string maSv = SvListView.SelectedItems[0].Text;
                ScoreList scoreList = new ScoreList(maSv);
                scoreList.ShowDialog();
            }
        }
    }
}
