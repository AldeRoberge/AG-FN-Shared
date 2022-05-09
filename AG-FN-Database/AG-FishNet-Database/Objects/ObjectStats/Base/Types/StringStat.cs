namespace OpenAlienGarden.ObjectStats.Base.Types
{
    public class StringStat : Stat
    {
        public string Value { get; set; }

        public StringStat(StatType type, string defaultValue) : base(type)
        {
            Value = defaultValue;
        }

        public override string ToString()
        {
            return $"StringStat {Type} = {Value}";
        }
    }
}