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
    public partial class AdminAdd : Form
    {
        public AdminAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBAccess objDB = new DBAccess();

            string Title = title.Text;
            string Duration = duration.Text;
            string Director = director.Text;
            string Writer = writer.Text;
            string Star = star.Text;
            string Date = date.Text;
            string Imdb = imdb.Text;

            if (Title.Equals(""))
            {
                MessageBox.Show("Please enter Title");
            }
            else if (Duration.Equals(""))
            {
                MessageBox.Show("Please enter Duration");
            }
            else if (Director.Equals(""))
            {
                MessageBox.Show("Please enter Director");
            }
            else if (Writer.Equals(""))
            {
                MessageBox.Show("Please enter Writer");
            }
            else if (Star.Equals(""))
            {
                MessageBox.Show("Please enter Star");
            }
            else if (Date.Equals(""))
            {
                MessageBox.Show("Please enter Date");
            }
            else if (Imdb.Equals(""))
            {
                MessageBox.Show("Please enter Imdb");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Movies (Title, Duration, Director, Writer, Star, Date, Imdb) values(@Title, @Duration, @Director, @Writer, @Star, @Date, @Imdb)");

                insertCommand.Parameters.AddWithValue("@Title", Title);
                insertCommand.Parameters.AddWithValue("@Duration", Duration);
                insertCommand.Parameters.AddWithValue("@Director", Director);
                insertCommand.Parameters.AddWithValue("@Writer", Writer);
                insertCommand.Parameters.AddWithValue("@Star", Star);
                insertCommand.Parameters.AddWithValue("@Date", Date);
                insertCommand.Parameters.AddWithValue("@Imdb", Imdb);

                int row = objDB.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Movie Created");

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFirst admin = new AdminFirst();
            admin.Show();
        }
    }
}
