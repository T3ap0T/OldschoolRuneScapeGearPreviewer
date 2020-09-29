using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSGPLogic
{
    class UserController
    {
        private List<User> Users { get; set; }

        public UserController() { }

        public UserController(List<User> users)
        {
            this.Users = users;
        }

        /// <summary>
        /// Checks whether the email has been used in the database
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool checkEmail(string email)
        {
            return true;
        }

        /// <summary>
        /// Checks whether the username has been used in the database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool checkUsername(string username)
        {
            return true;
        }

        /// <summary>
        /// Creates the user in the database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool createUser(string username, string email, string password)
        {
            return true;
        }

        /// <summary>
        /// Logs the user in
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool login(string username, string password)
        {
            return true;
        }

        /// <summary>
        /// Gets all the user info from their email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public User getUserByEmail(string email)
        {
            return new User();
        }

        /// <summary>
        /// Gets all the user info from their username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public User getUserByUsername(string username)
        {
            return new User();
        }
    }
}
