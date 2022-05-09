namespace OpenAlienGarden.ObjectStats.Base.Types
{
    public class BoolStat : Stat
    {
        public bool Value { get; set; }

        public BoolStat(StatType type, bool defaultValue) : base(type)
        {
            Value = defaultValue;
        }

        public override string ToString()
        {
            return $"BoolStat {Type} = {Value}";
        }
    }
}