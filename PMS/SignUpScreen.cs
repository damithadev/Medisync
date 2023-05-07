using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PMS
{
    public partial class SignUpScreen : Form
    {
        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string fname = textBoxfname.Text;
            string lname = textBoxlname.Text;
            string email = textBoxemail.Text;
            string password = textBoxpassword1.Text;

            if (fname != "" && lname != "" && email != "" && password != "")
            {
                dbConnection functions = new dbConnection();

               /* if (functions.checkUserTaken(email) == 0)
                {
                    new PopupMessage("Sorry, The username is already taken!").ShowDialog();
                }
                else
                {*/
                    try
                    {
                        MySqlConnection connection = new MySqlConnection(functions.connectionString);
                        string query = "INSERT INTO userTable (fname, lname, email, password) VALUES ('" + fname + "','" + lname + "','" + email + "','" + password + "')";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        new PopupMessage("Account registered successfully! Please use username and password to login..").ShowDialog();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        new PopupMessage("Error registering account!" + ex).ShowDialog();
                    }
                    finally
                    {
                        textBoxfname.Text = "";
                        textBoxlname.Text = "";
                        textBoxemail.Text = "";
                        textBoxpassword1.Text = "";
                        textBoxpassword2.Text = "";
                }
               // }
            }
            else
            {
                new PopupMessage("Enter all required information!").ShowDialog();
            }



        }
    }
}
