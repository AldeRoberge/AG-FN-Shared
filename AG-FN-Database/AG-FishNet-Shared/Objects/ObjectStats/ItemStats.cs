using AG_FishNet_Shared.Objects.ObjectStats.Base;

namespace AG_FishNet_Shared.Objects.ObjectStats
{
    public class ItemStats : StatList<ItemStats>
    {
        public uint Uses { get; set; }
    }
}