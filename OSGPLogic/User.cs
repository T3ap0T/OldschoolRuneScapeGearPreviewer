using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSGPLogic
{
    class User
    {
        private string Username { get; set; }

        private string Email { get; set; }

        private string Password { get; set; }

        private bool Admin { get; set; } = false;

        private List<Setup> Setups { get; set; }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public User() { }

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="admin"></param>
        /// <param name="setups"></param>
        public User(string username, string email, string password, bool admin, List<Setup> setups)
        {
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.Admin = admin;
            this.Setups = setups;
        }

        /// <summary>
        /// Create a setup for a user
        /// </summary>
        /// <returns></returns>
        public bool createSetup()
        {
            return true;
        }

        /// <summary>
        /// Update user info
        /// </summary>
        /// <returns></returns>
        public bool updateUser()
        {
            return true;
        }

        /// <summary>
        /// Retrieves a setup
        /// </summary>
        /// <returns></returns>
        public Setup getSetup()
        {
            return new Setup();
        }
    }
}
