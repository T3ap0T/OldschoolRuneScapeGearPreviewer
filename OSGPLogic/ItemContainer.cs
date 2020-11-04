using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSGPData;
using OSGPAPI;
using AutoMapper;

namespace OSGPLogic
{
    public class ItemContainer
    {
        private List<Item> items { get; set; }

        /// <summary>
        /// Converts a DTO object to a logic class
        /// </summary>
        /// <returns></returns>
        public Item itemDTOToItem(ItemDTO itemDTO)
        {
            // Create empty item object
            Item item = new Item();

            MapperConfiguration config = new MapperConfiguration(cfg => cfg.CreateMap<ItemDTO, Item>());
            Mapper mapper = new Mapper(config);

            item = mapper.Map<Item>(itemDTO);

            return item;
        }

        /// <summary>
        /// Converts a DataTable to a list of Item objects
        /// </summary>
        /// <param name="itemTable"></param>
        /// <returns></returns>
        public List<Item> itemDTOListToItem(List<ItemDTO> itemDTOList)
        {
            List<Item> ItemList = new List<Item>();

            MapperConfiguration config = new MapperConfiguration(cfg => cfg.CreateMap<ItemDTO, Item>());
            Mapper mapper = new Mapper(config);

            foreach (ItemDTO itemDTO in itemDTOList)
            {
                ItemList.Add(mapper.Map<Item>(itemDTO));
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
            ItemDTO itemDTO = itemHandler.getItemByName(itemName);

            // Convert the datatable to a usable logic class
            Item item = itemDTOToItem(itemDTO);

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
            List<ItemDTO> itemsByType = itemHandler.getItemsFromType(type);

            List<Item> itemList = this.itemDTOListToItem(itemsByType);

            return itemList;
        }
    }
}
