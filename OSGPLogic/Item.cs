using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OSGPLogic
{
    public class Item
    {
        #region Variable Declaration
        private string Name { get; set; }

        private string Type { get; set; }

        private string Price { get; set; }

        private string ImageLink { get; set; }

        private int StabAcc { get; set; }

        private int SlashAcc { get; set; }

        private int CrushAcc { get; set; }

        private int MagicAcc { get; set; }

        private int RangedAcc { get; set; }

        private int StabDef { get; set; }

        private int SlashDef { get; set; }

        private int CrushDef { get; set; }

        private int MagicDef { get; set; }

        private int RangedDef { get; set; }

        private int StrengthBonus { get; set; }

        private int RangedStrength { get; set; }

        private int MagicStrength { get; set; }

        private int PrayerBonus{ get; set; }
        #endregion

        #region Getters & Setters
        public string name
        {
            get { return Name; }   // get method
            set { Name = value; }
        }

        public string type
        {
            get { return Type; }   // get method
            set { Type = value; }
        }

        public string price
        {
            get { return Price; }   // get method
            set { Price = value; } // set method
        }

        public string imageLink
        {
            get { return ImageLink; }   // get method
            set { ImageLink = value; }
        }

        public int stabAcc
        {
            get { return StabAcc; }   // get method
            set { StabAcc = value; }
        }

        public int slashAcc
        {
            get { return SlashAcc; }   // get method
            set { SlashAcc = value; }
        }

        public int crushAcc
        {
            get { return CrushAcc; }   // get method
            set { CrushAcc = value; }
        }

        public int magicAcc
        {
            get { return MagicAcc; }   // get method
            set { MagicAcc = value; }
        }

        public int rangedAcc
        {
            get { return RangedAcc; }   // get method
            set { RangedAcc = value; }
        }

        public int stabDef
        {
            get { return StabDef; }   // get method
            set { StabDef = value; }
        }

        public int slashDef
        {
            get { return SlashDef; }   // get method
            set { SlashDef = value; }
        }

        public int crushDef
        {
            get { return CrushDef; }   // get method
            set { CrushDef = value; }
        }

        public int magicDef
        {
            get { return MagicDef; }   // get method
            set { MagicDef = value; }
        }

        public int rangedDef
        {
            get { return RangedDef; }   // get method
            set { RangedDef = value; }
        }

        public int strengthBonus
        {
            get { return StrengthBonus; }   // get method
            set { StrengthBonus = value; }
        }

        public int rangedStrength
        {
            get { return RangedStrength; }   // get method
            set { RangedStrength = value; }
        }

        public int magicStrength
        {
            get { return MagicStrength; }   // get method
            set { MagicStrength = value; }
        }

        public int prayerBonus
        {
            get { return PrayerBonus; }   // get method
            set { PrayerBonus = value; }
        }
        #endregion

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Item() { }

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="price"></param>
        /// <param name="imageLink"></param>
        /// <param name="stabacc"></param>
        /// <param name="slashacc"></param>
        /// <param name="crushacc"></param>
        /// <param name="rangeacc"></param>
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
        public Item(string name, string type, int stabacc, int slashacc, int crushacc, int rangeacc, int magicacc,
                    int stabdef, int slashdef, int crushdef, int rangeddef, int magicdef,
                    int strengthbonus, int rangedstrength, int magicstrength, int prayerbonus,
                    string price = "", string imageLink = "")
        {
            this.Name = name;
            this.Type = type;
            this.StabAcc = stabacc;
            this.SlashAcc = slashacc;
            this.CrushAcc = crushacc;
            this.RangedAcc = rangeacc;
            this.MagicAcc = magicacc;
            this.StabDef = stabdef;
            this.SlashDef = slashdef;
            this.CrushDef = crushdef;
            this.RangedDef = rangeddef;
            this.MagicDef = magicdef;
            this.StrengthBonus = strengthbonus;
            this.RangedStrength = rangedstrength;
            this.MagicStrength = magicstrength;
            this.PrayerBonus = prayerbonus;
            this.Price = price;
            this.ImageLink = imageLink;
        }

        /// <summary>
        /// Update the item name, type and stats
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="stabacc"></param>
        /// <param name="slashacc"></param>
        /// <param name="crushacc"></param>
        /// <param name="rangeacc"></param>
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
        public bool updateItem(string name, string type, int stabacc, int slashacc, int crushacc, int rangeacc, int magicacc,
                                int stabdef, int slashdef, int crushdef, int rangeddef, int magicdef,
                                int strengthbonus, int rangedstrength, int magicstrength, int prayerbonus)
        {
            return true;
        }

        /// <summary>
        /// Use the name to delete the item from the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool deleteItem(string name)
        {
            return true;
        }
    }
}
