using AG_FishNet_Shared.Objects.Core.Identities;
using AG_FishNet_Shared.Objects.ObjectStats.Base;
using AG_FishNet_Shared.Objects.ObjectStats.Player;

namespace AG_FishNet_Shared.Objects.ObjectStats.Entities
{
    public class StatEffects : IdentityList<StatEffect>
    {
        // Boosts
        public static readonly StatEffect StrengthBoost  = new StatEffect(nameof(StrengthBoost), Abilities.Strength.EffectedStats, StatEffectMode.InstantBoost, 10);
        public static readonly StatEffect AgilityBoost   = new StatEffect(nameof(AgilityBoost), Abilities.Strength.EffectedStats, StatEffectMode.InstantBoost, 10);
        public static readonly StatEffect EnduranceBoost = new StatEffect(nameof(EnduranceBoost), Abilities.Strength.EffectedStats, StatEffectMode.InstantBoost, 10);

        // Health
        public static readonly StatEffect Bleeding = new StatEffect(nameof(Bleeding), new[] {Stats.Health}, StatEffectMode.OverTimeDebuff, -0.05f);
        public static readonly StatEffect Healing  = new StatEffect(nameof(Bleeding), new[] {Stats.Health}, StatEffectMode.OverTimeBoost, 0.05f);

        // Speed
        public static readonly StatEffect Speedy = new StatEffect(nameof(Speedy), new[] {Stats.Speed}, StatEffectMode.InstantBoost, 1);
        public static readonly StatEffect Slowed = new StatEffect(nameof(Slowed), new[] {Stats.Speed}, StatEffectMode.InstantDebuff, -1);

        // Paralyzed
        public static readonly StatEffect Paralyzed = new StatEffect(nameof(Paralyzed), new[] {Stats.Speed}, StatEffectMode.AbsoluteValue, 0);
        public static readonly StatEffect Stunned   = new StatEffect(nameof(Stunned), new[] {Stats.Dexterity}, StatEffectMode.AbsoluteValue, 0);
    }

    public class StatEffect : Identity
    {
        public StatEffectMode Mode;
        public StatType[]     Stats;
        public float          Value;

        public StatEffect(string name, StatType[] stat, StatEffectMode mode, float value) :
            base(name)
        {
            this.Mode = mode;
            this.Stats = stat;
            this.Value = value;
        }
    }

    public enum StatEffectMode
    {
        InstantBoost,
        InstantDebuff,
        OverTimeBoost,
        OverTimeDebuff,
        AbsoluteValue
    }
}