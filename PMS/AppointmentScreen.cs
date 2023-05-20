using Guna.UI2.WinForms;
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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace PMS
{
    public partial class AppointmentScreen : Form
    {
        public AppointmentScreen()
        {
            InitializeComponent();
        }

        private void frm_appointment_Load(object sender, EventArgs e)
        {
          
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           //guna date
        }
    
        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //guna time
        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

            string nic = nicbox.Text;
            string diagnosis = diagnosisbox.Text;
            string Snotes = snotesbox.Text;
            
            //guna date picker
            DateTime selectedDate = guna2DateTimePicker1.Value;
            string date = selectedDate.ToString("yyyy-MM-dd");
            
            dbConnection functions = new dbConnection();



            //validate all fields are entered
            if (nic == "" || diagnosis == "" || selectedDate == new DateTime(2023, 5, 15) || textBoxTime.Text == "22:45")
            {
                MessageBox.Show("Enter all required information!");
            }
            else if (functions.PatientTaken(nic) == 0)
            {
                MessageBox.Show("Patient with the entered NIC does not exist.");
            }
            else
            {
                /*using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
                {
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Set the command text and parameters
                            command.CommandText = "INSERT INTO userTable (NIC, Date, Time, Diagnosis, Snotes) VALUES (@nic, @date, @time, @diagnosis, @snotes)";

                            command.Parameters.AddWithValue("@nic", nic);
                            command.Parameters.AddWithValue("@date", date);
                            command.Parameters.AddWithValue("@time", time);
                            command.Parameters.AddWithValue("@diagnosis", diagnosis);
                            command.Parameters.AddWithValue("@snotes", snotes);


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
                }*/
            }







            //Time textbox

            string enteredTime = textBoxTime.Text;

            // Parse the entered time to a DateTime object
            DateTime selectedDateTime;
            if (DateTime.TryParse(enteredTime, out selectedDateTime))
            {
                // Display the selected time in a MessageBox
                MessageBox.Show($"Selected time: {selectedDateTime.ToString("hh:mm tt")}");
            }
            else
            {
                MessageBox.Show("Invalid time format. Please enter a valid time.");
            }
        }
    }
}
