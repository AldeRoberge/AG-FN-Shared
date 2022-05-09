using OpenAlienGarden.ObjectStats.Base;

namespace OpenAlienGarden.ObjectEntity.Base
{
    public abstract class StatsEntity<T> : Entity where T : StatList<T>
    {
        public abstract T Stats { get; }

    }
}