// ------------------------------------
// Cat Coven API
// ------------------------------------

using System.Drawing;

namespace CatCoven.Core.Models.Constants
{
    public static class ReagentCatalog
    {
        public const string Catnip = nameof(Catnip);

        public const string HumanzBlood = nameof(HumanzBlood);

        public static readonly Dictionary<string, string> ReagentsDictionary = new Dictionary<string, string>
        {
            {Catnip, "Mmm mmm kitty weed."},
            {HumanzBlood, "Sweet sweet humanz blood, joyfully extracted."},
        };
    }
}