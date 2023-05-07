﻿using System;
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

        /*public int checkUserTaken(string email)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM userTable WHERE email= '" + email + "'";
            MySqlCommand command = new MySqlCommand(query, connection);

            connection.Open();
            int reservationExist = (int)command.ExecuteScalar();
            connection.Close();

            if (reservationExist > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }*/


        public int UserTaken(string email)
        {
            int result = 0;

            //string connectionString = "server=your_server_name;user id=your_username;password=your_password;database=pms_db;sslmode=none;";
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
    }
}
