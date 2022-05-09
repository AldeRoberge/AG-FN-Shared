using AG_FishNet_Shared.Objects.ObjectEntity.Base;
using AG_FishNet_Shared.Objects.ObjectStats;
using AG_FishNet_Shared.Objects.ObjectTypes.Items;

namespace AG_FishNet_Shared.Objects.ObjectEntity
{
    public class Item : StatsEntity<ItemStats>
    {
        public ItemType Type;

        public override ItemStats Stats { get; }

        public Item(ItemType type)
        {
            Type = type;
            Stats = new ItemStats();
        }

        public override void Update(double deltaTime)
        {
        }
    }
}