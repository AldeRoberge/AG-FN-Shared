using System;

namespace AG_FishNet_Database.Objects.ObjectStats.Base.Types
{
    public class DateTimeStat : Stat
    {
        public DateTime Value { get; set; }

        public DateTimeStat(StatType type, DateTime defaultValue) : base(type)
        {
            Value = defaultValue;
        }

        public override string ToString()
        {
            return $"StringStat {Type} = {Value}";
        }
    }
}