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
        public bool checkEmail()
        {
            return true;
        }

        /// <summary>
        /// Checks whether the username is already in use
        /// </summary>
        /// <returns></returns>
        public bool checkUsername()
        {
            return true;
        }

        /// <summary>
        /// Creates a user in the database
        /// </summary>
        /// <returns></returns>
        public bool createUser()
        {
            return true;
        }

        /// <summary>
        /// Check whether the user can login using the data they gave us
        /// </summary>
        /// <returns></returns>
        public bool login()
        {
            return true;
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
