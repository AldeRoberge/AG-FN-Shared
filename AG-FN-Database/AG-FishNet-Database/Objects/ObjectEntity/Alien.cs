using AG_FishNet_Database.Objects.ObjectEntity.Base;
using AG_FishNet_Database.Objects.ObjectStats;

namespace AG_FishNet_Database.Objects.ObjectEntity
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