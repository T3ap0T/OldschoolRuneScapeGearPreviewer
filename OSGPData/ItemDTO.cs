using System;
using System.Collections.Generic;
using System.Text;

namespace OSGPData
{
    public class ItemDTO
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

        public int PrayerBonus { get; set; }
    }
}
