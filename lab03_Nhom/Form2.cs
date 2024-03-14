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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT MALOP, TENLOP FROM LOP, NHANVIEN WHERE LOP.MANV = NHANVIEN.MANV AND NHANVIEN.MANV = @MANV";
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
                                ListViewItem item = new ListViewItem();
                                item.Text = reader.GetString(0);
                                item.SubItems.Add(reader.GetString(1));
                                lopListView.Items.Add(item);
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (lopListView.SelectedItems.Count > 0)
            {
                string maLop = lopListView.SelectedItems[0].Text;
                SvForm svForm = new SvForm(maLop);
                svForm.Show();
            }
        }
    }
}