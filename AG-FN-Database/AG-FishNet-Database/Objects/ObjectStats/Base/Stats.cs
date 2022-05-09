using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectStats.Base
{
    public class Stats : IdentityList<StatType>
    {
        #region Living

        public static readonly StatType Health    = new StatType(nameof(Health));
        public static readonly StatType MaxHealth = new StatType(nameof(MaxHealth));

        public static readonly StatType Name     = new StatType(nameof(Name));
        public static readonly StatType Birthday = new StatType(nameof(Birthday));

        #endregion

        #region Player

        public static readonly StatType Stamina    = new StatType(nameof(Stamina));
        public static readonly StatType Hunger     = new StatType(nameof(Hunger));
        public static readonly StatType Money      = new StatType(nameof(Money));
        public static readonly StatType Experience = new StatType(nameof(Experience));

        // Red DNA (Strength)
        public static StatType Damage = new StatType(nameof(Damage));
        public static StatType Armor  = new StatType(nameof(Armor));

        // Green DNA (Technique)
        public static StatType Speed     = new StatType(nameof(Speed));
        public static StatType Dexterity = new StatType(nameof(Dexterity));

        // Blue DNA (Endurance)
        public static StatType Cardio      = new StatType(nameof(Cardio));
        public static StatType HealthRegen = new StatType(nameof(HealthRegen));

        #endregion

        #region Plant

        public static readonly StatType Humidity = new StatType(nameof(Humidity));

        #endregion

        #region World

        public static readonly StatType Precipitation = new StatType(nameof(Precipitation));
        public static readonly StatType Temperature   = new StatType(nameof(Temperature));
        public static readonly StatType Clouds   = new StatType(nameof(Clouds));

        #endregion
        
        public static readonly StatType DateTime = new StatType(nameof(DateTime));

    }

    public abstract class Stat
    {
        public StatType Type { get; }

        public Stat(StatType type)
        {
            Type = type;
        }
    }

    public class StatType : Identity
    {
        public StatType(string name) : base(name)
        {
        }
    }
}