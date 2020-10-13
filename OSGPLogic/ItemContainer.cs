using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSGPLogic
{
    class ItemContainer
    {
        private List<Item> items { get; set; }

        /// <summary>
        /// Converts a datasource to a usable logic class
        /// </summary>
        /// <returns></returns>
        public Item dataSourceToItem()
        {
            return new Item();
        }

        /// <summary>
        /// Creates a new item in the database
        /// </summary>
        /// <returns></returns>
        public bool createItem()
        {
            return true;
        }

        /// <summary>
        /// Gets the item object by its name
        /// </summary>
        /// <returns></returns>
        public Item getItemByName()
        {
            return new Item();
        }
        
        /// <summary>
        /// Gets the item object by its ID
        /// </summary>
        /// <returns></returns>
        public Item getItemByID()
        {
            return new Item();
        }

        /// <summary>
        /// Check whether the itemname is used in the database already
        /// </summary>
        /// <returns></returns>
        public bool checkItemName()
        {
            return true;
        }

        /// <summary>
        /// Retrieves the list of items in a setup
        /// </summary>
        /// <returns></returns>
        public List<Item> getSetupItems()
        {
            return new List<Item>();
        }
    }
}
