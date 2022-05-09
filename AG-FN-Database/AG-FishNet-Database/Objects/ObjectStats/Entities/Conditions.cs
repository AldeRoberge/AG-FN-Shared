using System;
using OpenAlienGarden.Core.Identities;
using OpenAlienGarden.ObjectStats.Base;

namespace OpenAlienGarden.ObjectStats.Entities
{
    public class ConditionTypes : IdentityList<ConditionType>
    {
        public static ConditionType Poisoned  = new ConditionType(nameof(Poisoned), new[] {StatEffects.Bleeding});
        public static ConditionType Burning   = new ConditionType(nameof(Burning), new[] {StatEffects.Bleeding, StatEffects.Slowed});
        public static ConditionType Frozen    = new ConditionType(nameof(Frozen), new[] {StatEffects.Paralyzed, StatEffects.Stunned});
        public static ConditionType Paralyzed = new ConditionType(nameof(Paralyzed), new[] {StatEffects.Paralyzed});
        public static ConditionType Slowed    = new ConditionType(nameof(Slowed), new[] {StatEffects.Slowed});
        public static ConditionType Stunned   = new ConditionType(nameof(Stunned), new[] {StatEffects.Stunned});
        public static ConditionType Confused  = new ConditionType(nameof(Confused), new StatEffect[] { });
        public static ConditionType Blinded   = new ConditionType(nameof(Blinded), new StatEffect[] { });
        public static ConditionType Dazed     = new ConditionType(nameof(Dazed), new StatEffect[] { });
    }

    public class Condition
    {
        public ConditionType ConditionType;
        public DateTime      StartTime;
        public float         DurationMS;

        public Condition(ConditionType conditionType, DateTime startTime, float durationMS)
        {
            ConditionType = conditionType;
            StartTime = startTime;
            DurationMS = durationMS;
        }
    }

    public class ConditionType : Identity
    {
        public readonly StatEffect[] StatEffects;

        public ConditionType(string name, StatEffect[] statEffects) : base(name)
        {
            StatEffects = statEffects;
        }
    }
}