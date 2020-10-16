using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OSGPData
{
    public static class Connection
    {
        private static string database = "osgp";

        private static string host = "localhost";

        private static string user = "root";

        private static string pass = "";

        private static MySqlConnection GeneralConnection = new MySqlConnection();

        /// <summary>
        /// Connect to the database
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection connect()
        {
            try
            {
                disconnect();

                GeneralConnection.ConnectionString = $"Server={host};" +
                                                    $"Database={database};" +
                                                    $"User Id={user};" +
                                                    $"Password={pass};";
                // Open the connection. If I understand this right because this method is only called in the using block.
                // Because of this the connection gets closed when the using block ends.
                GeneralConnection.Open();

                return GeneralConnection;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message.ToString());

                return new MySqlConnection();
            }
        }

        private static void disconnect()
        {
            if (GeneralConnection.State.ToString() == "Open")
               GeneralConnection.Close();
        }
    }
}
