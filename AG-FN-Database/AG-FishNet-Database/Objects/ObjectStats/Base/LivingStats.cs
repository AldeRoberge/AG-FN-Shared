using System;
using AG_FishNet_Database.Objects.ObjectStats.Base.Types;

namespace AG_FishNet_Database.Objects.ObjectStats.Base
{
    public abstract class LivingStats<T> : StatList<T>
    {
        public StringStat Name     = new StringStat(Stats.Name, "Name");
        public DateTimeStat   Birthday = new DateTimeStat(Stats.Birthday, DateTime.Now);

        // Living
        public NumberStat Health    = new NumberStat(Stats.Health, 100);
        public NumberStat MaxHealth = new NumberStat(Stats.MaxHealth, 100);
    }
}