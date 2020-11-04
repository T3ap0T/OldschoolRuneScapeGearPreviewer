using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC.Multiplier;
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
        public ItemDTO getItemByName(string itemName)
        {
            // Create empty ItemDTO object so we can fill it and return it
            ItemDTO itemDTO = new ItemDTO();

            // Create a using clause so everything will be disposed when the block ends
            using (MySqlConnection conn = Connection.getConnection())
            {
                // Open the connection
                conn.Open();

                // Create a new MySqlCommand, query and parameters
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM item WHERE Name = @name";
                cmd.Parameters.AddWithValue("@name", itemName);

                // Fill the variables 
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    dr.Read();

                    itemDTO.Name = dr.GetString("Name");
                    itemDTO.Type = dr.GetString("Type");

                    itemDTO.StabAcc = dr.GetInt32("StabAcc");
                    itemDTO.SlashAcc = dr.GetInt32("StabAcc");
                    itemDTO.CrushAcc = dr.GetInt32("CrushAcc");
                    itemDTO.MagicAcc = dr.GetInt32("MagicAcc");
                    itemDTO.RangedAcc = dr.GetInt32("RangedAcc");

                    itemDTO.StabDef = dr.GetInt32("StabDef");
                    itemDTO.SlashDef = dr.GetInt32("SlashDef");
                    itemDTO.CrushDef = dr.GetInt32("CrushDef");
                    itemDTO.MagicDef = dr.GetInt32("MagicDef");
                    itemDTO.RangedDef = dr.GetInt32("RangedDef");

                    itemDTO.StrengthBonus = dr.GetInt32("StrengthBonus");
                    itemDTO.RangedStrength = dr.GetInt32("RangedStrength");
                    itemDTO.MagicStrength = dr.GetInt32("MagicStrength");
                    itemDTO.PrayerBonus = dr.GetInt32("PrayerBonus");

                    dr.Close();
                }

                // Close the connection
                conn.Close();
            }

            return itemDTO;
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

        /// <summary>
        /// Retrieve all the items from one type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<ItemDTO> getItemsFromType(string type)
        {
            // Create empty datatable so we can fill it and return it
            List<ItemDTO> itemDTOList = new List<ItemDTO>();

            // Create a using clause so everything will be disposed when the block ends
            using (MySqlConnection conn = Connection.getConnection())
            {
                // Open the connection
                conn.Open();

                // Create a new MySqlCommand, query and parameters
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM item WHERE Type = @type";
                cmd.Parameters.AddWithValue("@type", type);

                // Read and create a DTO Object
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // Create a DTO object and fill it
                        ItemDTO itemDTO = new ItemDTO();
                        itemDTO.Name = dr.GetString("Name");
                        itemDTO.Type = dr.GetString("Type");

                        itemDTO.StabAcc = dr.GetInt32("StabAcc");
                        itemDTO.SlashAcc = dr.GetInt32("StabAcc");
                        itemDTO.CrushAcc = dr.GetInt32("CrushAcc");
                        itemDTO.MagicAcc = dr.GetInt32("MagicAcc");
                        itemDTO.RangedAcc = dr.GetInt32("RangedAcc");

                        itemDTO.StabDef = dr.GetInt32("StabDef");
                        itemDTO.SlashDef = dr.GetInt32("SlashDef");
                        itemDTO.CrushDef = dr.GetInt32("CrushDef");
                        itemDTO.MagicDef = dr.GetInt32("MagicDef");
                        itemDTO.RangedDef = dr.GetInt32("RangedDef");

                        itemDTO.StrengthBonus = dr.GetInt32("StrengthBonus");
                        itemDTO.RangedStrength = dr.GetInt32("RangedStrength");
                        itemDTO.MagicStrength = dr.GetInt32("MagicStrength");
                        itemDTO.PrayerBonus = dr.GetInt32("PrayerBonus");
                        
                        // Add the new DTO object to the list
                        itemDTOList.Add(itemDTO);
                    }
                }

                // Close the connection
                conn.Close();
            }

            return itemDTOList;
        }
    }
}
