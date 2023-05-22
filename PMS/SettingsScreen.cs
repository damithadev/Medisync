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

        private void updatebtnclick(object sender, EventArgs e)
        {
            string fname = fnamebox.Text;
            string lname = lnamebox.Text;
            string password1 = password1box.Text;
            string password2 = password2box.Text;

            if ((password1 == "" ||  password2 == "") && !(password1 == password2) || !(password1 == password2))
            {
                MessageBox.Show("Password doesn't match!");
            }
            else if ( !(password1 == password2) || (password1 == "" || password2 == ""))
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
                            command.CommandText = "UPDATE userTable SET fname = @fname, lname = @lname WHERE email = @email";
                            command.Parameters.AddWithValue("@fname", fname);
                            command.Parameters.AddWithValue("@lname", lname);
                            command.Parameters.AddWithValue("@email", email);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully updated
                                MessageBox.Show("Profile updated successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Profile update failed!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating profile: " + ex.Message);
                        }
                        finally
                        {
                            // Close the connection
                            connection.Close();
                        }
                    }
                }
            }
            else
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
                            command.CommandText = "UPDATE userTable SET fname = @fname, lname = @lname, password = @password WHERE email = @email";
                            command.Parameters.AddWithValue("@fname", fname);
                            command.Parameters.AddWithValue("@lname", lname);
                            command.Parameters.AddWithValue("@password", password1);
                            command.Parameters.AddWithValue("@email", email);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully updated
                                MessageBox.Show("Profile updated successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Profile update failed!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating profile: " + ex.Message);
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
