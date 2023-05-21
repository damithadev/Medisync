using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PMS
{
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new SignUpScreen().Show();
            this.Hide();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            

            string email = textBoxemail.Text;
            string password = textBoxpassword.Text;

            //string connectionString = "server=your_server_name;user id=your_username;password=your_password;database=pms_db;sslmode=none;";
            
            if (email !="" && password !="")
            {
                dbConnection functions = new dbConnection();

                string selectQuery = "SELECT COUNT(*) FROM userTable WHERE email = @email AND password = @password";

                using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@password", password);

                            int result = Convert.ToInt32(command.ExecuteScalar());

                            if (result > 0)
                            {
                                // Login successful
                                //MessageBox.Show("Login successful!");
                                UserSession.Email = email;
                                UserSession.IsLoggedIn = true;
                                new frm_main().Show();
                                this.Hide();
                            }
                            else
                            {
                                // Invalid credentials
                                MessageBox.Show("Invalid email or password!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter all required information!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void SignInScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
