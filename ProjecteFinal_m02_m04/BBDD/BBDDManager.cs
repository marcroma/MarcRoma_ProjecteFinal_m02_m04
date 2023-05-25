using MySql.Data.MySqlClient;
using ProjecteFinal_m02_m04.Model;

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
        public static bool Connect()
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
        public static void Disconnect()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        // ===

        // Iniciar la BBDD
        public static void StartBD()
        {

        }

        // ===

        // Insertar Dades a BBDD
        // Insertar Customers
        public static int InsertCustomer(CustomerModel customer)
        {
            int insertedId = -1;
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO customers (name, email, phone, address) VALUES (@name, @email, @phone, @address);";
                    string selectQuery = "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = query; // Set the command text
                        cmd.Parameters.AddWithValue("@name", customer.Name);
                        cmd.Parameters.AddWithValue("@email", customer.Email);
                        cmd.Parameters.AddWithValue("@phone", customer.Phone);
                        cmd.Parameters.AddWithValue("@address", customer.Address);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine("Registres Inserits: " + rowsAffected);

                        using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                        {
                            insertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
                            Console.WriteLine("Registre insertat amb ID: " + insertedId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el registre: " + ex.Message);
            }

            return insertedId;
        }

        // Insertar Contact
        public static int InsertContact(ContactModel contact)
        {
            int insertedId = -1;
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO contacts (customerId, name, email, phone, company) VALUES (@customerId, @name, @email, @phone, @company);";
                    string selectQuery = "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = query; // Set the command text
                        cmd.Parameters.AddWithValue("@customerId", contact.CustomerId);
                        cmd.Parameters.AddWithValue("@name", contact.Name);
                        cmd.Parameters.AddWithValue("@email", contact.Email);
                        cmd.Parameters.AddWithValue("@phone", contact.Phone);
                        cmd.Parameters.AddWithValue("@company", contact.Company);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine("Registres Inserits: " + rowsAffected);

                        using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                        {
                            insertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
                            Console.WriteLine("Registre insertat amb ID: " + insertedId);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el registre: " + ex.Message);
            }

            return insertedId;
        }

        // Insertar Opportunity
        public static int InsertOpportunity(OpportunityModel opportunity)
        {
            int insertedId = -1;
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO opportunities (customerId, amount, status) VALUES (@customerId, @amount, @status);";
                    string selectQuery = "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.CommandText = query; // Set the command text to the SQL query
                        cmd.Parameters.AddWithValue("@customerId", opportunity.CustomerId);
                        cmd.Parameters.AddWithValue("@amount", opportunity.Amount);
                        cmd.Parameters.AddWithValue("@status", opportunity.Status);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine("Registres Inserits: " + rowsAffected);
                    }

                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        insertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
                        Console.WriteLine("Registre insertat amb ID: " + insertedId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el registre: " + ex.Message);
            }

            return insertedId;
        }

        // ===
    }
}
