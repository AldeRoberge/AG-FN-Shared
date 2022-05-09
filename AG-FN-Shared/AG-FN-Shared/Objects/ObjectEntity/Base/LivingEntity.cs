using System.Collections.Generic;
using AG_FishNet_Shared.Objects.Core.Data;
using AG_FishNet_Shared.Objects.ObjectStats.Base;
using AG_FishNet_Shared.Objects.ObjectStats.Entities;

namespace AG_FishNet_Shared.Objects.ObjectEntity.Base
{
    /// <summary>
    /// A living entity combines a <see cref="ObjectTypes"/> with <see cref="ObjectStats"/> to create a living object.
    /// The <see cref="ObjectTypes"/> defines the identity of the object (immutable characteristics)
    /// and the <see cref="ObjectStats"/> define it's personal traits (mutable characteristics).
    /// </summary>
    public abstract class LivingStatsEntity<T> : StatsEntity<T> where T : StatList<T>
    {
        public Position Position { get; set; }
        public List<Condition> Conditions { get; set; }

        public override void Update(double delta)
        {
            // Process condition effecting the stats
            foreach (Condition condition in Conditions)
            {
                foreach (var statEffect in condition.ConditionType.StatEffects)
                {
                    foreach (var stat in statEffect.Stats)
                    {
                        var match = Stats.GetNumberStat(stat);

                        if (statEffect.Mode == StatEffectMode.OverTimeDebuff)
                        {
                        }
                    }
                }
            }
        }
    }
}