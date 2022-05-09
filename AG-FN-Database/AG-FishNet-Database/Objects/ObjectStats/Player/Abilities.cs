using OpenAlienGarden.Core.Identities;
using OpenAlienGarden.ObjectStats.Base;

namespace OpenAlienGarden.ObjectStats.Player
{
    public class Abilities : IdentityList<AbilityType>
    {
        public static AbilityType Strength  = new AbilityType(nameof(Strength), "❤", StatColors.RedColors, new[] { Stats.Damage, Stats.Armor });
        public static AbilityType Agility   = new AbilityType(nameof(Agility), "💚", StatColors.GreenColors, new[] { Stats.Speed, Stats.Dexterity });
        public static AbilityType Endurance = new AbilityType(nameof(Endurance), "💙", StatColors.BlueColors, new[] { Stats.Cardio, Stats.HealthRegen });
    }

    public class AbilityType : Identity
    {
        // The colored heart emoji
        public string Emoji;

        // Food color that give this DNA
        public StatColor[] Colors;

        // StatEffects that are affected by this DNA
        public StatType[] EffectedStats;

        public AbilityType(string name, string emoji, StatColor[] colors, StatType[] effectedStats) : base(name)
        {
            Emoji = emoji;
            Colors = colors;
            EffectedStats = effectedStats;
        }
    }
}