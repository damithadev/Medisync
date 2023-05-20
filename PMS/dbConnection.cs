using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    internal class dbConnection
    {
        public string connectionString = "server=139.59.62.182;port=3306;userid=damitha99;password=20020502;database=pms_db;sslmode=none;";



        public int UserTaken(string email)
        {
            int result = 0;

            string selectQuery = "SELECT COUNT(*) FROM userTable WHERE email = @email";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        object queryResult = command.ExecuteScalar();
                        if (queryResult != null)
                        {
                            result = Convert.ToInt32(queryResult);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return result;
        }










        public int PatientTaken(string nic)
        {
            int result = 0;

            string selectQuery = "SELECT COUNT(*) FROM patientTable WHERE nic = @NIC";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NIC", nic);

                        object queryResult = command.ExecuteScalar();
                        if (queryResult != null)
                        {
                            result = Convert.ToInt32(queryResult);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return result;
        }



        public bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }


    }
}
