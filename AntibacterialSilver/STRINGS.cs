using STRINGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntibacterialSilver
{
    internal class STRINGS
    {
        public class ELEMENTS
        {
            public class SILVERORE
            {
                public static LocString NAME = UI.FormatAsLink("Silver Ore", nameof(SILVERORE));
                public static LocString DESC = NAME + " is a soft metal. It is suitable for building Power systems and has minor antimicrobial properties.";
                public static LocString EFFECT = "So Tasty";
            }
            public class SILVER
            {
                public static LocString NAME = UI.FormatAsLink("Silver", nameof(SILVER));
                public static LocString DESC = "(Ag) "+ NAME + " is a conductive precious Metal. It is suitable for building Power systems and has antimicrobial properties.";
            }
            public class MOLTENSILVER
            {
                public static LocString NAME = UI.FormatAsLink("Molten Silver", nameof(MOLTENSILVER));
                public static LocString DESC = "(Ag) "+ SILVER.NAME + ", an antimicrobial precious Metal, heated into a Liquid state.";
            }
            public class SILVERGAS
            {
                public static LocString NAME = UI.FormatAsLink("Silver Gas", nameof(SILVERGAS));
                public static LocString DESC = "(Ag) " + SILVER.NAME + ", an antimicrobial precious Metal, heated into a Gaseous state.";
            }
        }
    }
}
