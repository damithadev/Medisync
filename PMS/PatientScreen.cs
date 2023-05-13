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

        private void label1_Click(object sender, EventArgs e)
        {
        }



        public void loadData()
        {
            dbConnection functions = new dbConnection();

            using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM userTable";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;

                    guna2DataGridView1.DataSource = bindingSource;
                    connection.Close();
                }
            }
        }

        private void frm_patient_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddNewPatientScreen obj = new AddNewPatientScreen();

            obj.Show();
        }
    }
}
