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


            else
            {
                    //getting combobox input
                    string bloodGroup = bloodcmbbox.SelectedItem.ToString();
                    
                    int age = int.Parse(stringage);
                    int weight = int.Parse(stringweight);
                    int height = int.Parse(stringheight);


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
    }
}
