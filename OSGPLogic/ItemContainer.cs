using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSGPData;
using OSGPAPI;

namespace OSGPLogic
{
    public class ItemContainer
    {
        private List<Item> items { get; set; }

        /// <summary>
        /// Converts a dataTable to a usable logic class
        /// </summary>
        /// <returns></returns>
        public Item dataTableToItem(DataTable itemTable)
        {
            // Create empty item object
            Item item = new Item();

            if (itemTable.Rows.Count > 0)
            {
                // This will work considering we only request 1 item, thus only having 1 row
                DataRow dataRow = itemTable.Rows[0];

                item = new Item(
                    dataRow["name"].ToString(),
                    dataRow["Type"].ToString(),
                    Convert.ToInt32(dataRow["StabAcc"]),
                    Convert.ToInt32(dataRow["SlashAcc"]),
                    Convert.ToInt32(dataRow["CrushAcc"]),
                    Convert.ToInt32(dataRow["MagicAcc"]),
                    Convert.ToInt32(dataRow["RangedAcc"]),
                    Convert.ToInt32(dataRow["StabDef"]),
                    Convert.ToInt32(dataRow["SlashDef"]),
                    Convert.ToInt32(dataRow["CrushDef"]),
                    Convert.ToInt32(dataRow["MagicDef"]),
                    Convert.ToInt32(dataRow["RangedDef"]),
                    Convert.ToInt32(dataRow["StrengthBonus"]),
                    Convert.ToInt32(dataRow["RangedStrength"]),
                    Convert.ToInt32(dataRow["MagicStrength"]),
                    Convert.ToInt32(dataRow["PrayerBonus"])
                );

            }

            return item;
        }

        /// <summary>
        /// Converts a DataTable to a list of Item objects
        /// </summary>
        /// <param name="itemTable"></param>
        /// <returns></returns>
        public List<Item> dataTableToList(DataTable itemTable)
        {
            List<Item> ItemList = new List<Item>();

            foreach(DataRow row in itemTable.Rows)
            {
                ItemList.Add(new Item(
                        row["name"].ToString(),
                        row["Type"].ToString(),
                        Convert.ToInt32(row["StabAcc"]),
                        Convert.ToInt32(row["SlashAcc"]),
                        Convert.ToInt32(row["CrushAcc"]),
                        Convert.ToInt32(row["RangedAcc"]),
                        Convert.ToInt32(row["MagicAcc"]),
                        Convert.ToInt32(row["StabDef"]),
                        Convert.ToInt32(row["SlashDef"]),
                        Convert.ToInt32(row["CrushDef"]),
                        Convert.ToInt32(row["RangedDef"]),
                        Convert.ToInt32(row["MagicDef"]),
                        Convert.ToInt32(row["StrengthBonus"]),
                        Convert.ToInt32(row["RangedStrength"]),
                        Convert.ToInt32(row["MagicStrength"]),
                        Convert.ToInt32(row["PrayerBonus"])
                    )
                );
            }

            return ItemList;
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
        public Item getItemByName(string itemName)
        {
            // Declare an empty handler so we can use it
            ItemHandler itemHandler = new ItemHandler();
            DataTable itemTable = itemHandler.getItemByName(itemName);

            // Convert the datatable to a usable logic class
            Item item = dataTableToItem(itemTable);

            // Item name must be lower case
            APIReturn apiReturn = APIContainer.GetInfoItem(itemName.ToLower());

            // Insert the data we need from the API return into the new Item object
            item.price = apiReturn.current.Price;
            item.imageLink = apiReturn.Icon;

            return item;
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

        public List<Item> getItemsFromType(string type)
        {
            ItemHandler itemHandler = new ItemHandler();
            DataTable itemsByType = itemHandler.getItemsFromType(type);

            List<Item> itemList = this.dataTableToList(itemsByType);

            return itemList;
        }
    }
}
