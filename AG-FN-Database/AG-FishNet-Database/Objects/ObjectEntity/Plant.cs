using AG_FishNet_Database.Objects.ObjectEntity.Base;
using AG_FishNet_Database.Objects.ObjectStats;
using AG_FishNet_Database.Objects.ObjectTypes.Plants;

namespace AG_FishNet_Database.Objects.ObjectEntity
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