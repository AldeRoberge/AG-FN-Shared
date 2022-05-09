using AG_FishNet_Database.Objects.ObjectEntity.Base;
using AG_FishNet_Database.Objects.ObjectStats;

namespace AG_FishNet_Database.Objects.ObjectEntity
{
    public class Hazel : LivingStatsEntity<HazelStats>
    {
        public override HazelStats Stats { get; }
    }
}