using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSiteTry1
{
    public partial class AdminDelete : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtMovies = new DataTable();
        string[] titles;

        public AdminDelete()
        {
            InitializeComponent();
        }
        private void AdminDelete_Load(object sender, EventArgs e)
        {
            
            string query = "Select * from Movies";
            objDBAccess.readDatathroughAdapter(query, dtMovies);

            firstMovieName.Text = dtMovies.Rows[0]["Title"].ToString();
            secondMovieName.Text = dtMovies.Rows[1]["Title"].ToString();
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFirst admin = new AdminFirst();
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteMovie = "Delete from Movies Where Title='"+secondMovieName.Text+"'";
            SqlCommand deleteCommand = new SqlCommand(deleteMovie);

            int row = objDBAccess.executeQuery(deleteCommand);


            if (row == 1)
            {
                MessageBox.Show("Movie Deleted");

                this.Hide();
                SignIn signIn = new SignIn();
                signIn.Show();
            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }
    }
}
