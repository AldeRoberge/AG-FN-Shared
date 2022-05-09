using AG_FishNet_Database.Objects.ObjectStats.Base;

namespace AG_FishNet_Database.Objects.ObjectStats
{
    public class ItemStats : StatList<ItemStats>
    {
        public uint Uses { get; set; }
    }
}