using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OSGPData
{
    public class ItemHandler
    {
        /// <summary>
        /// Update an item in the database
        /// </summary>
        /// <returns></returns>
        public bool updateItem()
        {
            return true;
        }

        /// <summary>
        /// Check whether the item name is used in the database already
        /// </summary>
        /// <returns></returns>
        public bool checkItemName()
        {
            return true;
        }

        /// <summary>
        /// Retrieves an item by its database ID
        /// </summary>
        /// <returns></returns>
        public DataTable getitemByID()
        {
            return new DataTable();
        }

        /// <summary>
        /// retrieves an item by its name
        /// </summary>
        /// <returns></returns>
        public DataTable getItemByName(string itemName)
        {
            // Create empty datatable so we can fill it and return it
            DataTable dataTable = new DataTable();

            using (var cmd = new MySqlCommand())
            {
                cmd.Connection = Connection.connect();

                cmd.CommandText = "SELECT * FROM item WHERE Name = @name";
                cmd.Parameters.AddWithValue("@name", itemName);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    dataTable.Load(dr);
                }
            }

            return dataTable;
        }

        /// <summary>
        /// creates an item in the database
        /// </summary>
        /// <returns></returns>
        public bool createItem()
        {
            return true;
        }

        /// <summary>
        /// Deletes an item in the database
        /// </summary>
        /// <returns></returns>
        public bool deleteItem()
        {
            return true;
        }

        /// <summary>
        /// Retrieves all the items used in a given setup
        /// </summary>
        /// <returns></returns>
        public DataTable getSetupItems()
        {
            return new DataTable();
        }
    }
}
