using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    internal class dbConnection
    {
        public string connectionString = "server=139.59.62.182;port=3306;userid=damitha99;password=20020502;database=pms_db;sslmode=none;";

        public int checkUserTaken(string email)
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
        }
    }
}
