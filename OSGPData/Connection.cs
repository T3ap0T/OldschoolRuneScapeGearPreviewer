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

        private static MySqlConnection GeneralConnection = new MySqlConnection($"Server={host};Database={database};User Id={user};Password={pass};");

        /// <summary>
        /// Returns the MySqlConnection
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection getConnection()
        {
            return GeneralConnection;
        }
    }
}
