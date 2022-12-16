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
    public partial class SignIn : Form
    {
        public static string userID, userName, passWord, fullName, email, age;

        
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = InUsername.Text;
            string password = InPassword.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("Enter Username");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Enter Password");
            }
            else
            {
                string query = "Select * from Users Where Username='" + username +"' AND Password = '" + password + "'";
                objDBAccess.readDatathroughAdapter(query, dtUsers);
                

                if(dtUsers.Rows.Count == 1)
                {
                    userID = dtUsers.Rows[0]["UserID"].ToString();
                    userName = dtUsers.Rows[0]["Username"].ToString();
                    passWord = dtUsers.Rows[0]["Password"].ToString();
                    fullName = dtUsers.Rows[0]["Fullname"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    age = dtUsers.Rows[0]["Age"].ToString();

                    MessageBox.Show("Logged In");
                    objDBAccess.closeConn();

                    this.Hide();
                    if (username=="admin")
                    {
                        AdminFirst admin = new AdminFirst();
                        admin.Show();
                    }
                    else
                    {
                        HomePage home = new HomePage();
                        home.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong!!!");
                }

            }
        }

        private void transSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
