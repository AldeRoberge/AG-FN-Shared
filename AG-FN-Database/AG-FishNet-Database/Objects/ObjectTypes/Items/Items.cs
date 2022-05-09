using System.Collections.Generic;
using OpenAlienGarden.Core.Identities;
using OpenAlienGarden.ObjectStats.World.Events;

namespace OpenAlienGarden.ObjectTypes.Items
{
    public class Items : IdentityList<ItemType>
    {
        public static ItemType WateringCan = new ItemType(nameof(WateringCan), Rarities.Rarities.Common);
        public static ItemType Apple       = new ConsumableItemType(nameof(Apple), Rarities.Rarities.Common, new ItemUseEffect(new FoodConsumedEvent(10, 10)));
    }
}