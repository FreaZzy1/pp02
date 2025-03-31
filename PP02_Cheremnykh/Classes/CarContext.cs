using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PP02_Cheremnykh.Classes.WorkingBD;

namespace PP02_Cheremnykh.Classes
{
    public class CarContext:Models.Car
    {
        public CarContext(int Id, string Name, string Marks, string Gos_Number, string Voditel)
      : base(Id, Name, Marks, Gos_Number, Voditel) { }

        public static List<CarContext> AllCar()
        {
            List<CarContext> list = new List<CarContext>();
            MySqlConnection connection = Connection.OpenConnection();
            MySqlDataReader query = Connection.Query("Select * From Car", connection);
            while (query.Read())
            {
                list.Add(new CarContext(
                    query.GetInt32(0),
                    query.GetString(1),
                    query.GetString(2),
                    query.GetString(3),
                    query.GetString(4)
                    

                    ));

            }
            connection.Close();
            MySqlConnection.ClearPool(connection);
            return list;
        }
    }
}
}
