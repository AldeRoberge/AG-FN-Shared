using AG_FishNet_Shared.Objects.ObjectEntity.Base;
using AG_FishNet_Shared.Objects.ObjectStats;

namespace AG_FishNet_Shared.Objects.ObjectEntity
{
    public class Hazel : LivingStatsEntity<HazelStats>
    {
        public override HazelStats Stats { get; }
    }
}