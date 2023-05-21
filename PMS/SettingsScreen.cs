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

namespace PMS
{
    public partial class SettingsScreen : Form
    {
        public SettingsScreen()
        {
            InitializeComponent();
        }

        // Accessing the username
        string email = UserSession.Email;

        // Checking if the user is logged in
        bool isLoggedIn = UserSession.IsLoggedIn;

        dbConnection functions = new dbConnection();

        private void SettingsScreen_Load(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {

                using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
                {
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Set the command text and parameters
                            command.CommandText = "SELECT fname, lname FROM userTable WHERE email = @email";
                            command.Parameters.AddWithValue("@email", email);

                            // Execute the command and retrieve the first name and last name
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string firstName = reader.GetString("fname");
                                    string lastName = reader.GetString("lname");

                                    // Display the first name in a label control
                                    usernamelabel.Text = firstName + " " + lastName;
                                    fnamebox.Text = firstName;
                                    lnamebox.Text = lastName;
                                }
                                else
                                {
                                    // No rows returned
                                    MessageBox.Show("Invalid username");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error retrieving name: " + ex.Message);
                        }
                        finally
                        {
                            // Close the connection
                            connection.Close();
                        }
                    }
                }
            }   
            
        }
    }
}
