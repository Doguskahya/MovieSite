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
    public partial class HomePage : Form
    {
        public static string movieID, title, duration, imdb, director, writer, star, date;
        public static string smovieID, stitle, sduration, simdb, sdirector, swriter, sstar, sdate;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtMovies = new DataTable();
        public HomePage()
        {
            InitializeComponent();
        }
        public void HomePage_Load_1(object sender, EventArgs e)
        {
            string query = "Select * from Movies";
            objDBAccess.readDatathroughAdapter(query, dtMovies);

            movieID = dtMovies.Rows[0]["MovieID"].ToString();
            title = dtMovies.Rows[0]["Title"].ToString();
            duration = dtMovies.Rows[0]["Duration"].ToString();
            imdb = dtMovies.Rows[0]["Imdb"].ToString();
            director = dtMovies.Rows[0]["Director"].ToString();
            writer = dtMovies.Rows[0]["Writer"].ToString();
            star = dtMovies.Rows[0]["Star"].ToString();
            date = dtMovies.Rows[0]["Date"].ToString();

            smovieID = dtMovies.Rows[1]["MovieID"].ToString();
            stitle = dtMovies.Rows[1]["Title"].ToString();
            sduration = dtMovies.Rows[1]["Duration"].ToString();
            simdb = dtMovies.Rows[1]["Imdb"].ToString();
            sdirector = dtMovies.Rows[1]["Director"].ToString();
            swriter = dtMovies.Rows[1]["Writer"].ToString();
            sstar = dtMovies.Rows[1]["Star"].ToString();
            sdate = dtMovies.Rows[1]["Date"].ToString();
            objDBAccess.closeConn();

            HomePageUsername.Text = "Welcome " + SignIn.fullName;
            movie_name.Text = title;
            movie_imdb.Text = "Imdb : "+ imdb;
            movie_time.Text = duration;
     
            second_name.Text = stitle;
            second_imdb.Text = "Imdb : " + simdb;
            second_time.Text = sduration;
        }
    }
}
