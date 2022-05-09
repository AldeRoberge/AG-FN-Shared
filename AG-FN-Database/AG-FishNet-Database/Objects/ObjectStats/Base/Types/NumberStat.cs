namespace AG_FishNet_Database.Objects.ObjectStats.Base.Types
{
    public class NumberStat : Stat
    {
        public float Value { get; set; }

        public NumberStat(StatType type, float defaultValue) : base(type)
        {
            Value = defaultValue;
        }

        public override string ToString()
        {
            return $"NumberStat {Type} = {Value}";
        }
    }
}