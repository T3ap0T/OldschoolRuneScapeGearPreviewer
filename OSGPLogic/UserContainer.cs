using OSGPData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OSGPLogic
{
    public class UserContainer
    {
        private List<User> Users { get; set; }

        public User dataTableToUser(DataTable userTable)
        {
            // Create empty item object
            User user = new User();

            if (userTable.Rows.Count > 0)
            {
                // This will work considering we only request 1 item, thus only having 1 row
                DataRow dataRow = userTable.Rows[0];

                user = new User(
                    dataRow["Username"].ToString(),
                    dataRow["Email"].ToString(),
                    dataRow["Password"].ToString(),
                    Convert.ToBoolean(dataRow["Admin"])
                );

            }

            return user;
        }

        /// <summary>
        /// Checks whether the email is used already
        /// </summary>
        /// <returns></returns>
        public bool checkEmail(string email)
        {
            UserHandler userHandler = new UserHandler();
            return userHandler.checkEmail(email);
        }

        /// <summary>
        /// Checks whether the username is used already
        /// </summary>
        /// <returns></returns>
        public bool checkUsername(string username)
        {
            UserHandler userHandler = new UserHandler();
            return userHandler.checkUsername(username);
        }

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <returns></returns>
        public string createUser(string email, string username, string password)
        {
            string resultString = "";
            UserHandler userHandler = new UserHandler();

            // First check if the email and username is already taken
            if (!this.checkEmail(email))
            {
                // Email was not already in use
                if (!this.checkUsername(username))
                {
                    // Username was not already in use
                    if (userHandler.createUser(email, username, password))
                    {
                        // Account was succesfully created
                        resultString = "User was successfully registered.";
                    }
                    else
                    {
                        resultString = "Failed to register; something went wrong when trying to add the user to the database.";
                    }
                }
                else
                {
                    resultString = "Failed to register; username already in use.";
                }
            }
            else
            {
                resultString = "Failed to register; email already in use.";
            }

            return resultString;
        }

        /// <summary>
        /// Checks whether the user can login
        /// </summary>
        /// <returns></returns>
        public User login(string email)
        {
            UserHandler userHandler = new UserHandler();
            DataTable userTable = userHandler.login(email);

            User user = this.dataTableToUser(userTable);

            return user;
        }

        /// <summary>
        /// Retrieves a user by their email
        /// </summary>
        /// <returns></returns>
        public User getUserByEmail()
        {
            return new User();
        }

        /// <summary>
        /// Retrives a user by their username
        /// </summary>
        /// <returns></returns>
        public User getUserByUsername()
        {
            return new User();
        }
    }
}
