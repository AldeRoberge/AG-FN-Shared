using AG_FishNet_Database.Objects.ObjectStats.Base;

namespace AG_FishNet_Database.Objects.ObjectEntity.Base
{
    public abstract class StatsEntity<T> : Entity where T : StatList<T>
    {
        public abstract T Stats { get; }

    }
}