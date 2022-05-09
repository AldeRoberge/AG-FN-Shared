using System;
using OpenAlienGarden.Core;
using OpenAlienGarden.ObjectEntity.Base;
using OpenAlienGarden.ObjectStats;
using OpenAlienGarden.ObjectStats.Base;
using OpenAlienGarden.ObjectTypes;
using OpenAlienGarden.ObjectTypes.Plants;

namespace OpenAlienGarden.ObjectEntity
{
    public class Plant : LivingStatsEntity<PlantStats>
    {
        public PlantType Type { get; }

        public override PlantStats Stats { get; }

        public Plant(PlantType type)
        {
            Type = type;
            Stats = new PlantStats();
        }
    }
}