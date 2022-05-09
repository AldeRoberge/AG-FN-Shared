using AG_FishNet_Shared.Objects.ObjectStats.Base;
using AG_FishNet_Shared.Objects.ObjectStats.World.Events.Base;

namespace AG_FishNet_Shared.Objects.ObjectStats.World.Events
{
    public class UpdateStat : WorldEvent
    {
        public StatType Stat;
        public float    Value;

        public UpdateStat(StatType stat, float value)
        {
            Stat = stat;
            Value = value;
        }
    }
}