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
        public string Name { get; set; }

        public string Type { get; set; }

        public int StabAcc { get; set; }

        public int SlashAcc { get; set; }

        public int CrushAcc { get; set; }

        public int MagicAcc { get; set; }

        public int RangedAcc { get; set; }

        public int StabDef { get; set; }

        public int SlashDef { get; set; }

        public int CrushDef { get; set; }

        public int MagicDef { get; set; }

        public int RangedDef { get; set; }

        public int StrengthBonus { get; set; }

        public int RangedStrength { get; set; }

        public int MagicStrength { get; set; }

        public int PrayerBonus{ get; set; }

        public Item() { }

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
