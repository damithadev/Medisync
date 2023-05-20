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

        public void signUpBtn_Click(object sender, EventArgs e)
        {
            string fname = textBoxfname.Text;
            string lname = textBoxlname.Text;
            string email = textBoxemail.Text;
            string password = textBoxpassword1.Text;

            if (fname != "" && lname != "" && email != "" && password != "")
            {
                if (textBoxpassword1.Text == textBoxpassword2.Text)
                {
                    dbConnection functions = new dbConnection();

                    if (functions.UserTaken(email) == 0)
                    {
                        // Create MySqlConnection and MySqlCommand objects
                        using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
                        {
                            using (MySqlCommand command = connection.CreateCommand())
                            {
                                try
                                {
                                    // Open the connection
                                    connection.Open();

                                    // Set the command text and parameters
                                    command.CommandText = "INSERT INTO userTable (fname, lname, email, password) VALUES (@fname, @lname, @email, @password)";
                                    command.Parameters.AddWithValue("@fname", fname);
                                    command.Parameters.AddWithValue("@lname", lname);
                                    command.Parameters.AddWithValue("@email", email);
                                    command.Parameters.AddWithValue("@password", password);

                                    // Execute the command
                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        // Data successfully inserted
                                        MessageBox.Show("Account registered successfully! Please use email and password to login..");
                                    }
                                    else
                                    {
                                        // No rows affected
                                        MessageBox.Show("Failed registering account!");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error registering account: " + ex.Message);
                                }
                                finally
                                {
                                    textBoxfname.Text = "";
                                    textBoxlname.Text = "";
                                    textBoxemail.Text = "";
                                    textBoxpassword1.Text = "";
                                    textBoxpassword2.Text = "";
                                    this.Hide();
                                    SignInScreen obj = new SignInScreen();
                                    obj.Show();
                                }
                            }
                        }
                    }
                    else
                    {
                        new PopupMessage("Sorry, This email already have an account!").ShowDialog();
                        //MessageBox.Show("Sorry, The username is already taken!");
                        textBoxemail.Text = "";
                    }
                }
                else
                {
                    new PopupMessage("Password doesn't match!").ShowDialog();
                }
            }
            else
            {
                new PopupMessage("Enter all required information!").ShowDialog();
            }
        }

















        public int UserTaken(string email)
        {
            int result = 0;


            string selectQuery = "SELECT COUNT(*) FROM userTable WHERE email = @email";

            dbConnection functions = new dbConnection();

            using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        object queryResult = command.ExecuteScalar();
                        if (queryResult != null)
                        {
                            result = Convert.ToInt32(queryResult);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return result;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new SignInScreen().Show();
            this.Hide();
        }

        private void SignUpScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
