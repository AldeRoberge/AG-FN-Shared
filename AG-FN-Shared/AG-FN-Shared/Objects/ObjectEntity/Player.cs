using AG_FishNet_Shared.Objects.ObjectEntity.Base;
using AG_FishNet_Shared.Objects.ObjectStats;

namespace AG_FishNet_Shared.Objects.ObjectEntity
{
    public class Player : LivingStatsEntity<PlayerStats>
    {
        public override PlayerStats Stats { get; }

        public Player(PlayerStats stats)
        {
            Stats = stats;
        }
    }
}