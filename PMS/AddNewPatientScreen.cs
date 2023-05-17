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
using System.Xml.Linq;

namespace PMS
{
    public partial class AddNewPatientScreen : Form
    {
        public AddNewPatientScreen()
        {
            InitializeComponent();
        }

        private void addbtnclick(object sender, EventArgs e)
        {
            string name = namebox.Text;
            string nic = nicbox.Text;
            string diagnosis = diagnosisbox.Text;
            string email = emailbox.Text;

            //numeric
            string stringage = agebox.Text;
            string stringweight = weightbox.Text;
            string stringheight = heightbox.Text;

            //radio input
            string gender = "";

            if (radiobtnMale.Checked)
            {
                gender = "Male";
            }
            else if (radiobtnFemale.Checked)
            {
                gender = "Female";
            }

            dbConnection functions = new dbConnection();

            //validate all fields are entered
            if (name == "" || nic == "" || diagnosis == "" || email == "" || stringage == "" || stringweight == "" || stringheight == "" || gender == "" || bloodcmbbox.SelectedIndex == -1)
            {
                MessageBox.Show("Enter all required information!");
            }

            else if (!IsNumeric(stringage))   //age should be a number validation
            {
                MessageBox.Show("Age should be a number!");
            }
            else if (!IsNumeric(stringweight))
            {
                MessageBox.Show("Weight should be a number!");
            }
            else if (!IsNumeric(stringheight))
            {
                MessageBox.Show("Height should be a number!");
            }
            else if (functions.PatientTaken(nic) == 1)
            {
                MessageBox.Show("Sorry, This patient already registered!");
            }
            else
            {
                //getting combobox input
                string bloodGroup = bloodcmbbox.SelectedItem.ToString();
                    
                int age = int.Parse(stringage);
                int weight = int.Parse(stringweight);
                int height = int.Parse(stringheight);

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
                            command.CommandText = "INSERT INTO patientTable (Name, NIC, Age, Gender, Diagnosis, Blood, Weight, Height, Email) VALUES (@name, @nic, @age, @gender, @diagnosis, @bloodGroup, @weight, @height, @email)";
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@NIC", nic);
                            command.Parameters.AddWithValue("@Age", age);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Diagnosis", diagnosis);
                            command.Parameters.AddWithValue("@bloodGroup", bloodGroup);
                            command.Parameters.AddWithValue("@Weight", weight);
                            command.Parameters.AddWithValue("@Height", height);
                            command.Parameters.AddWithValue("@Email", email);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully inserted
                                MessageBox.Show("Patient registered successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Patient added Failed!");
                            }
                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error registering account: " + ex.Message);
                        }
                        finally
                        {
                            nicbox.Text = "";
                            namebox.Text = "";
                            agebox.Text = "";
                            radiobtnMale.Checked = false;
                            radiobtnFemale.Checked = false;
                            diagnosisbox.Text = "";
                            bloodcmbbox.SelectedIndex = -1;
                            heightbox.Text = "";
                            weightbox.Text = "";
                            emailbox.Text = "";
                            this.Hide();
                            
                        }
                    }
                }
            }
        }



        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }



        private void cancelbtnclick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddNewPatientScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
