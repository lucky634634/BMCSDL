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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            classTable.Rows.Clear();
            try
            {
                string sql = @"
                    SELECT MALOP, TENLOP 
                    FROM LOP
                    WHERE MANV = @MANV
                ";
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
                                string malop = reader.GetString(0);
                                string tenlop = reader.GetString(1);
                                classTable.Rows.Add(malop, tenlop);
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

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (classTable.SelectedRows.Count > 0)
            {
                string malop = classTable.SelectedRows[0].Cells[0].Value.ToString();
                var form = new SVForm(malop);
                Hide();
                form.Show();
                form.Disposed += (s, args) => Show();
            }
        }
    }
}
