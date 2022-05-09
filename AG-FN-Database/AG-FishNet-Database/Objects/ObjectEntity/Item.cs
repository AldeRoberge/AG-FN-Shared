using OpenAlienGarden.Core;
using OpenAlienGarden.ObjectEntity.Base;
using OpenAlienGarden.ObjectStats;
using OpenAlienGarden.ObjectStats.Base;
using OpenAlienGarden.ObjectTypes;
using OpenAlienGarden.ObjectTypes.Items;

namespace OpenAlienGarden.ObjectEntity
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