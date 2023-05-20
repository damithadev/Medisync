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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace PMS
{
    public partial class PerceptionScreen : Form
    {
        public PerceptionScreen()
        {
            InitializeComponent();
        }

        private void createbtnclick(object sender, EventArgs e)
        {
            string nic = nicbox.Text;
            string drug = drugbox.Text;
            string dose = dosebox.Text;
            string duration = durationbox.Text;
            string test = testbox.Text;
            string stringbill = billbox.Text;


            dbConnection functions = new dbConnection();

            if (nic == "" || drug == "" || dose == "" || duration == "" || stringbill == "")
            {
                MessageBox.Show("Enter all required information!");
            }
            else if (!functions.IsNumeric(stringbill))
            {
                MessageBox.Show("Bill amount should be a number!");
            }
            else if (functions.PatientTaken(nic) == 0)
            {
                MessageBox.Show("Patient with the entered NIC does not exist.");
            }
            else
            {
                int bill = int.Parse(billbox.Text);

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
                            command.CommandText = "INSERT INTO prescriptionTable (NIC, Drug, Dose, Duration, Tests, Bill) VALUES (@nic, @drug, @dose, @duration, @test, @bill)";
                            command.Parameters.AddWithValue("@NIC", nic);
                            command.Parameters.AddWithValue("@drug", drug);
                            command.Parameters.AddWithValue("@dose", dose);
                            command.Parameters.AddWithValue("@duration", duration);
                            command.Parameters.AddWithValue("@test", test);
                            command.Parameters.AddWithValue("@bill", bill);

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Data successfully inserted
                                MessageBox.Show("Prescription created successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Prescription created Failed!");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error creating prescription : " + ex.Message);
                        }
                        finally
                        {
                            nicbox.Text = "";
                            drugbox.Text = "";
                            dosebox.Text = "";
                            durationbox.Text = "";
                            testbox.Text = "";
                            billbox.Text = "";
                            connection.Close();

                        }
                    }
                }
            }
        }

        private void cancelbtnclick(object sender, EventArgs e)
        {
            nicbox.Text = "";
            drugbox.Text = "";
            dosebox.Text = "";
            durationbox.Text = "";
            testbox.Text = "";
            billbox.Text = "";
        }
    }
}
