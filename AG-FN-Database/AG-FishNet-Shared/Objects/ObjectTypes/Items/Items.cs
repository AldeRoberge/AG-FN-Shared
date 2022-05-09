using AG_FishNet_Shared.Objects.Core.Identities;
using AG_FishNet_Shared.Objects.ObjectStats.World.Events;

namespace AG_FishNet_Shared.Objects.ObjectTypes.Items
{
    public class Items : IdentityList<ItemType>
    {
        public static ItemType WateringCan = new ItemType(nameof(WateringCan), Rarities.Rarities.Common);
        public static ItemType Apple       = new ConsumableItemType(nameof(Apple), Rarities.Rarities.Common, new ItemUseEffect(new FoodConsumedEvent(10, 10)));
    }
}