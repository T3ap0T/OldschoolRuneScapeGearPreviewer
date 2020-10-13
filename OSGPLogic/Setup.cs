using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSGPLogic
{
    class Setup
    {
        private string Name { get; set; }

        private bool Public { get; set; }

        private List<Item> Items { get; set; }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Setup() { }

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="_public"></param>
        /// <param name="items"></param>
        public Setup(string name, bool _public, List<Item> items)
        {
            this.Name = name;
            this.Public = _public;
            this.Items = items;
        }

        /// <summary>
        /// Updates the setup name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool updateName(string name)
        {
            return true;
        }

        /// <summary>
        /// Update the publicity of the setup
        /// </summary>
        /// <param name="_public"></param>
        /// <returns></returns>
        public bool updatePublicity(bool _public)
        {
            return true;
        }

        /// <summary>
        /// Add item to the current setup
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool addItem(Item item)
        {
            return true;
        }

        /// <summary>
        /// Removes item from the currect setup
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool removeItem(Item item)
        {
            return true;
        }
    }
}
