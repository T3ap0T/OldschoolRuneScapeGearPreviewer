using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSGPLogic
{
    class ItemController
    {
        private List<Item> Items { get; set; }

        public ItemController() { }

        public ItemController(List<Item> items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Creates an item using the parameters given
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="stabacc"></param>
        /// <param name="slashacc"></param>
        /// <param name="crushacc"></param>
        /// <param name="rangedacc"></param>
        /// <param name="magicacc"></param>
        /// <param name="stabdef"></param>
        /// <param name="slashdef"></param>
        /// <param name="crushdef"></param>
        /// <param name="rangeddef"></param>
        /// <param name="magicdef"></param>
        /// <param name="strengthbonus"></param>
        /// <param name="rangedstrength"></param>
        /// <param name="magicstrength"></param>
        /// <param name="prayerbonus"></param>
        /// <returns></returns>
        public bool createItem(string name, string type, int stabacc, int slashacc, int crushacc, int rangedacc, int magicacc,
                                int stabdef, int slashdef, int crushdef, int rangeddef, int magicdef,
                                int strengthbonus, int rangedstrength, int magicstrength, int prayerbonus)
        {
            return true;
        }

        /// <summary>
        /// Gets all the item information using only its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Item getItemByName(string name)
        {
            return new Item();
        }

        /// <summary>
        /// Check whether the item name has already been used in the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool checkItemName(string name)
        {
            return true;
        }
    }
}
