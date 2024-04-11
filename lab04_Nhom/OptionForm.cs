using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04_Nhom
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void nvButton_Click(object sender, EventArgs e)
        {
            var form = new NVForm();
            Hide();
            form.Show();
            form.Disposed += (s, args) => Show();
        }
    }
}
