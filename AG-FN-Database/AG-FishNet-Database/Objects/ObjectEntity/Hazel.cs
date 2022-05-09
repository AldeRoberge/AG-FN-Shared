using System;
using OpenAlienGarden.Core;
using OpenAlienGarden.ObjectEntity.Base;
using OpenAlienGarden.ObjectStats;
using OpenAlienGarden.ObjectStats.Base;

namespace OpenAlienGarden.ObjectEntity
{
    public class Hazel : LivingStatsEntity<HazelStats>
    {
        public override HazelStats Stats { get; }
    }
}