using AG_FishNet_Shared.Objects.Core.Identities;
using AG_FishNet_Shared.Objects.ObjectTypes.Rarities;

namespace AG_FishNet_Shared.Objects.ObjectTypes.Items
{
    public class ItemType : Identity
    {
        public Rarity Rarity { get; }

        public ItemType(string displayName, Rarity rarity) : base(displayName)
        {
            Rarity = rarity;
        }
    }


    public class LimitedUseItemType : ItemType
    {
        public uint DefaultUsesRemaining { get; }
        public ItemUseEffect UseEffect { get; }

        public LimitedUseItemType(string displayName, Rarity rarity, ItemUseEffect itemUseEffect, uint defaultUsesRemaining) : base(displayName, rarity)
        {
            DefaultUsesRemaining = defaultUsesRemaining;
            UseEffect = itemUseEffect;
        }
    }


    /// <summary>
    /// A type of UsableItemType that can only be used once.
    /// </summary>
    public class ConsumableItemType : LimitedUseItemType
    {
        public ConsumableItemType(string displayName, Rarity rarity, ItemUseEffect itemUseEffect) : base(displayName, rarity, itemUseEffect, 1)
        {
        }
    }
}