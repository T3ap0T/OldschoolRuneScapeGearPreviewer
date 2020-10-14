using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OSGPLogic
{
    class Item
    {
        private string Name { get; set; }

        private string Type { get; set; }

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

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Item() { }

        /// <summary>
        /// Full Constructor
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
        public Item(string name, string type, int stabacc, int slashacc, int crushacc, int rangeacc, int magicacc,
                    int stabdef, int slashdef, int crushdef, int rangeddef, int magicdef,
                    int strengthbonus, int rangedstrength, int magicstrength, int prayerbonus)
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
