using System;
using OpenAlienGarden.ObjectStats.Base;
using OpenAlienGarden.ObjectStats.Base.Types;
using OpenAlienGarden.ObjectStats.Player;

namespace OpenAlienGarden.ObjectStats
{
    public class PlantStats : LivingStats<PlantStats>
    {
        public NumberStat Hunger  = new NumberStat(Stats.Hunger, 0);
        public NumberStat Humidity = new NumberStat(Stats.Humidity, 0);
    }
}