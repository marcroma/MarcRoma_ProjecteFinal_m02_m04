using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjecteFinal_m02_m04.BBDD
{
    public class BBDDManager
    {
        private const string server = "db4free.net";
        private const string port = "3306";
        private const string database = "m0204crm";
        private const string username = "marcroma";
        private const string password = "Marcroma1234";

        private const string connectionString = "Server=" + server + ";Port=" + port + ";Database=" + database + ";Uid=" + username + ";Pwd=" + password + ";OldGuids=true;";

        private static MySqlConnection? connection;

        // Connectar amb la BBDD
        private static bool Connect()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
            }
            return false;
        }

        // ===

        // Desconnectar de la BBDD
        private static void Disconnect()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        // ===
    }
}
