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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

            string nic = nicbox.Text;
            string diagnosis = diagnosisbox.Text;
            string snotes = snotesbox.Text;
            
            //guna date picker
            DateTime selectedDate = guna2DateTimePicker1.Value;
            string date = selectedDate.ToString("yyyy-MM-dd");
            
            dbConnection functions = new dbConnection();

            //time 
            string time = textBoxTime.Text + " " + ampmcmbbox.SelectedItem.ToString();


            //validate all fields are entered
            if (nic == "" || diagnosis == "" || selectedDate == new DateTime(2023, 5, 15) || textBoxTime.Text == "10:45")
            {
                MessageBox.Show("Enter all required information!");
            }
            else if (functions.PatientTaken(nic) == 0)
            {
                MessageBox.Show("Patient with the entered NIC does not exist.");
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
                            command.CommandText = "INSERT INTO appointmentTable (NIC, Date, Time, Diagnosis, Snotes) VALUES (@nic, @date, @time, @diagnosis, @snotes)";

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
                                MessageBox.Show("Appointment added successfully!");
                            }
                            else
                            {
                                // No rows affected
                                MessageBox.Show("Appointment added failed!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error adding appointment: " + ex.Message);
                        }
                        finally
                        {
                            nicbox.Text = "";
                            diagnosisbox.Text = "";
                            snotesbox.Text = "";
                            textBoxTime.Text = "";
                            ampmcmbbox.SelectedIndex = 0;

                        }
                    }
                }
            }   
        }
    }
}
