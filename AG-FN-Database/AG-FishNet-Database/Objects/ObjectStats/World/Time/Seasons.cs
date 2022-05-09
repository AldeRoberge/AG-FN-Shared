using System;
using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectStats.World.Time
{
    public class Seasons : IdentityList<SeasonType>
    {
        public static SeasonType Winter = new SeasonType(0, nameof(Winter), "☃");
        public static SeasonType Spring = new SeasonType(1, nameof(Spring), "🌱");
        public static SeasonType Summer = new SeasonType(2, nameof(Summer), "😎");
        public static SeasonType Fall   = new SeasonType(3, nameof(Fall), "🍂");
    }

    public class SeasonType : Identity
    {
        public String Emoji;

        public SeasonType(int value, string displayName, string emoji) : base(displayName)
        {
            Emoji = emoji;
        }
    }
}