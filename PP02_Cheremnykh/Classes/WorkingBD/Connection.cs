using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PP02_Cheremnykh.Classes.WorkingBD
{
    public class Connection
    {

        public static MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;uid=root;database=Takelaz");
            connection.Open();
            return connection;
        }

        public static MySqlDataReader Query(string sql, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            return command.ExecuteReader();
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);
        }
    }
}
