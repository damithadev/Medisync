using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class PatientScreen : Form
    {
        public PatientScreen()
        {
            InitializeComponent();
        }

        private DataTable dt; // Declare a class-level DataTable variable
        public void loadData()
        {
            dbConnection functions = new dbConnection();

            using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM patientTable";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    dt = new DataTable(); // Assign the DataTable to the class-level variable
                    adapter.Fill(dt);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;

                    guna2DataGridView1.DataSource = bindingSource;
                    connection.Close();
                }
            }
        }

        private void PatientScreenLoad(object sender, EventArgs e)
        {
            loadData();
            string hexColor = "#386CEC"; // Red color
            Color colorFromHex = ColorTranslator.FromHtml(hexColor);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = colorFromHex;

            //change table header font size
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);


            //change table body font size
            foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial", 10);
            }

            // Change the width of the id column
            guna2DataGridView1.Columns[0].Width = 40; // Adjust the desired width value

            // Change the width of the name column
            guna2DataGridView1.Columns[1].Width = 120; // Adjust the desired width value

            // Change the width of the nic column
            guna2DataGridView1.Columns[2].Width = 130; // Adjust the desired width value

            // Change the width of the age column
            guna2DataGridView1.Columns[3].Width = 50; // Adjust the desired width value

            // Change the width of the gender column
            guna2DataGridView1.Columns[4].Width = 80; // Adjust the desired width value

            // Change the width of the diagnosis column
            guna2DataGridView1.Columns[5].Width = 100; // Adjust the desired width value

            // Change the width of the blood column
            guna2DataGridView1.Columns[6].Width = 70; // Adjust the desired width value

            // Change the width of the weight column
            guna2DataGridView1.Columns[7].Width = 70; // Adjust the desired width value

            // Change the width of the height column
            guna2DataGridView1.Columns[8].Width = 70; // Adjust the desired width value

            //border radius
            Guna2Elipse elipse = new Guna2Elipse();
            elipse.TargetControl = guna2DataGridView1;
            elipse.BorderRadius = 20;


        }

        private void refreshbtnclick(object sender, EventArgs e)
        {
            loadData();

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            AddNewPatientScreen obj = new AddNewPatientScreen();

            obj.Show();
        }
    }
}
