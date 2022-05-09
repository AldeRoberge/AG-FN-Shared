using OpenAlienGarden.ObjectEntity.Base;
using OpenAlienGarden.ObjectStats;
using OpenAlienGarden.ObjectStats.Base;
using OpenAlienGarden.ObjectTypes;
using OpenAlienGarden.ObjectTypes.Pets;

namespace OpenAlienGarden.ObjectEntity
{
    public class Pet : LivingStatsEntity<PetStats>
    {
        public PetType Type;

        public override PetStats Stats { get; }

        public Pet(PetType petType)
        {
            Type = petType;
            Stats = new PetStats();
        }
    }
}