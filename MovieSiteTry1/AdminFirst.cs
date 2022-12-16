using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSiteTry1
{
    public partial class AdminFirst : Form
    {
        public AdminFirst()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAdd admin = new AdminAdd();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDelete admin = new AdminDelete();
            admin.Show();
        }
    }
}
