using AG_FishNet_Shared.Objects.ObjectStats.Base;
using AG_FishNet_Shared.Objects.ObjectStats.Base.Types;

namespace AG_FishNet_Shared.Objects.ObjectStats
{
    public class PlantStats : LivingStats<PlantStats>
    {
        public NumberStat Hunger  = new NumberStat(Stats.Hunger, 0);
        public NumberStat Humidity = new NumberStat(Stats.Humidity, 0);
    }
}