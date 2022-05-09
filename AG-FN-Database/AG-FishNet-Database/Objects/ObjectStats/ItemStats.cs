using OpenAlienGarden.ObjectStats.Base;

namespace OpenAlienGarden.ObjectStats
{
    public class ItemStats : StatList<ItemStats>
    {
        public uint Uses { get; set; }
    }
}