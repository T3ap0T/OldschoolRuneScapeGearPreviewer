using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSGPLogic
{
    class UserContainer
    {
        private List<User> Users { get; set; }

        /// <summary>
        /// Checks whether the email is used already
        /// </summary>
        /// <returns></returns>
        public bool checkEmail()
        {
            return true;
        }

        /// <summary>
        /// Checks whether the username is used already
        /// </summary>
        /// <returns></returns>
        public bool checkUsername()
        {
            return true;
        }

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <returns></returns>
        public bool createUser()
        {
            return true;
        }

        /// <summary>
        /// Checks whether the user can login
        /// </summary>
        /// <returns></returns>
        public bool login()
        {
            return true;
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
