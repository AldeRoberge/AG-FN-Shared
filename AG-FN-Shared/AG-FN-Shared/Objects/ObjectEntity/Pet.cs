using AG_FishNet_Shared.Objects.ObjectEntity.Base;
using AG_FishNet_Shared.Objects.ObjectStats;
using AG_FishNet_Shared.Objects.ObjectTypes.Pets;

namespace AG_FishNet_Shared.Objects.ObjectEntity
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