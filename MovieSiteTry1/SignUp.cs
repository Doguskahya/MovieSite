using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MovieSiteTry1
{
    public partial class SignUp : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable checkTable = new DataTable();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string Fullname = txtFullname.Text;
            string Email = txtEmail.Text;
            string Age = intAge.Text;

            string userNameCheck = "Select * from Users Where Username='" + Username + "'";
            objDBAccess.readDatathroughAdapter(userNameCheck, checkTable);

            string eMailCheck = "Select * from Users Where Email='" + Email + "'";
            objDBAccess.readDatathroughAdapter(eMailCheck, checkTable);


            if (userNameCheck!=null)
            {
                MessageBox.Show("Username already exist");
                this.Hide();
                SignUp signUp = new SignUp();
                signUp.Show();
            }
            else if (eMailCheck!=null)
            {
                MessageBox.Show("Email already exist");
                this.Hide();
                SignUp signUp = new SignUp();
                signUp.Show();
            }
            else if (Username.Equals(""))
            {
                MessageBox.Show("Please enter UserName");
            }
            else if (Password.Equals(""))
            {
                MessageBox.Show("Please enter PassWord");
            }
            else if (Fullname.Equals(""))
            {
                MessageBox.Show("Please enter FullName");
            }
            else if (Email.Equals(""))
            {
                MessageBox.Show("Please enter Email");
            }
            else if (Age.Equals(""))
            {
                MessageBox.Show("Please enter Age");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users (Username,Password,Fullname,Email,Age) values(@Username, @Password, @Fullname, @Email, @Age)");

                insertCommand.Parameters.AddWithValue("@Username", Username);
                insertCommand.Parameters.AddWithValue("@Password", Password);
                insertCommand.Parameters.AddWithValue("@Fullname", Fullname);
                insertCommand.Parameters.AddWithValue("@Email", Email);
                insertCommand.Parameters.AddWithValue("@Age", Age);

                int row = objDBAccess.executeQuery(insertCommand);

                if(row == 1)
                {
                    MessageBox.Show("Account Created");

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
}
