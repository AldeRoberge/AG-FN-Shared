using OpenAlienGarden.ObjectEntity.Base;
using OpenAlienGarden.ObjectStats;
using OpenAlienGarden.ObjectStats.Base;

namespace OpenAlienGarden.ObjectEntity
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