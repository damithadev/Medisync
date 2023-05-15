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
        }

       

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            AddNewPatientScreen obj = new AddNewPatientScreen();

            obj.Show();
        }

        private void refreshbtnclick(object sender, EventArgs e)
        {
            loadData();

        }

       
    }
}
