using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace OSGPData
{
    public class UserHandler
    {
        /// <summary>
        /// Updates the user in the database
        /// </summary>
        /// <returns></returns>
        public bool updateUser()
        {
            return true;
        }

        /// <summary>
        /// Creates a setup in the database
        /// </summary>
        /// <returns></returns>
        public bool createSetup()
        {
            return true;
        }

        /// <summary>
        /// Retrieves a setup
        /// </summary>
        /// <returns></returns>
        public DataTable getSetup()
        {
            return new DataTable();
        }

        /// <summary>
        /// Checks whether the email is already in use
        /// </summary>
        /// <returns></returns>
        public bool checkEmail(string email)
        {
            bool emailIsUsed = false;

            using (MySqlConnection conn = Connection.getConnection())
            {
                // Open the connection
                conn.Open();

                // Create a new MySqlCommand, query and parameters
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user WHERE Email = @email";
                cmd.Parameters.AddWithValue("@email", email);

                // Read what we get back and throw it in a datatable for Logic layer use
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        emailIsUsed = true;
                    }
                }

                // Close the connection
                conn.Close();
            }

            return emailIsUsed;
        }

        /// <summary>
        /// Checks whether the username is already in use
        /// </summary>
        /// <returns></returns>
        public bool checkUsername(string username)
        {
            bool usernameIsUsed = false;

            using (MySqlConnection conn = Connection.getConnection())
            {
                // Open the connection
                conn.Open();

                // Create a new MySqlCommand, query and parameters
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", username);

                // Read what we get back and throw it in a datatable for Logic layer use
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        usernameIsUsed = true;
                    }
                }

                // Close the connection
                conn.Close();
            }

            return usernameIsUsed;
        }

        /// <summary>
        /// Creates a user in the database
        /// </summary>
        /// <returns></returns>
        public bool createUser(string email, string username, string password)
        {
            bool success = false;

            using (MySqlConnection conn = Connection.getConnection())
            {
                // Open the connection
                conn.Open();

                // Create a new MySqlCommand, query and parameters
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO user (Username, Email, Password) VALUES (@username, @email, @password)";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                success = Convert.ToBoolean(cmd.ExecuteNonQuery());

                // Close the connection
                conn.Close();
            }

            return success;
        }

        /// <summary>
        /// Check whether the user can login using the data they gave us
        /// </summary>
        /// <returns></returns>
        public DataTable login(string email)
        {
            // Create empty datatable so we can fill it and return it
            DataTable dataTable = new DataTable();

            // Create a using clause so everything will be disposed when the block ends
            using (MySqlConnection conn = Connection.getConnection())
            {
                // Open the connection
                conn.Open();

                // Create a new MySqlCommand, query and parameters
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user WHERE Email = @email";
                cmd.Parameters.AddWithValue("@email", email);

                // Read what we get back and throw it in a datatable for Logic layer use
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    dataTable.Load(dr);
                }

                // Close the connection
                conn.Close();
            }

            return dataTable;
        }

        /// <summary>
        /// Gets a user from the database using their email adress
        /// </summary>
        /// <returns></returns>
        public DataTable getUserByEmail()
        {
            return new DataTable();
        }

        /// <summary>
        /// Gets a user from the database using their username
        /// </summary>
        /// <returns></returns>
        public DataTable getUserByUsername()
        {
            return new DataTable();
        }
    }
}
