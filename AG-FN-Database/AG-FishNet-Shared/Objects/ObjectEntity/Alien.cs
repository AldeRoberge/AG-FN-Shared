using AG_FishNet_Shared.Objects.ObjectEntity.Base;
using AG_FishNet_Shared.Objects.ObjectStats;

namespace AG_FishNet_Shared.Objects.ObjectEntity
{
    public class Alien : LivingStatsEntity<AlienStats>
    {
        public override AlienStats Stats { get; }

        public Alien()
        {
            Stats = new AlienStats();
        }
    }
}