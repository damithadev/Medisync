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
            




            //validate all fields are entered
            if (nic == "" || diagnosis == "" || selectedDate == new DateTime(2023, 5, 15) || textBoxTime.Text == "22:45")
            {
                MessageBox.Show("Enter all required information!");
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
