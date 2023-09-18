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
        //digital ocean server = expired on (2023/06/25)
        //public string connectionString = "server=139.59.62.182;port=3306;userid=damitha99;password=20020502;database=pms_db;sslmode=none;";

        //Peek hosting server = expire on (2024/06/20)
        public string connectionString = "server=ip_address_here;port=3306;userid=userName_here;password=password_here;database=dbname_here;sslmode=none;";

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
