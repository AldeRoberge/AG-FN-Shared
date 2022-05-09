using OpenAlienGarden.ObjectStats.Base;
using OpenAlienGarden.ObjectStats.Player;
using OpenAlienGarden.ObjectStats.World.Events.Base;

namespace OpenAlienGarden.ObjectStats.World.Events
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