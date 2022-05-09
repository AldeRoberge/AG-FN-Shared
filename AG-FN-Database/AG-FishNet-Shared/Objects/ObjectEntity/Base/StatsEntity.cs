using AG_FishNet_Shared.Objects.ObjectStats.Base;

namespace AG_FishNet_Shared.Objects.ObjectEntity.Base
{
    public abstract class StatsEntity<T> : Entity where T : StatList<T>
    {
        public abstract T Stats { get; }

    }
}