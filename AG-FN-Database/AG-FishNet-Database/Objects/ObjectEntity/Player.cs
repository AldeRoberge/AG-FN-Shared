using System;
using OpenAlienGarden.Core;
using OpenAlienGarden.ObjectEntity.Base;
using OpenAlienGarden.ObjectStats;
using OpenAlienGarden.ObjectStats.Base;

namespace OpenAlienGarden.ObjectEntity
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