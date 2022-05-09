using AG_FishNet_Shared.Objects.Core.Identities;

namespace AG_FishNet_Shared.Objects.ObjectStats.Entities
{
    public class Moods : IdentityList<Mood>
    {
        public static readonly Mood Vigorous = new Mood(nameof(Vigorous));
        public static readonly Mood Healthy  = new Mood(nameof(Healthy));
        public static readonly Mood Weak     = new Mood(nameof(Weak));
        public static readonly Mood Dead     = new Mood(nameof(Dead));
    }

    public class Mood : Identity
    {
        public Mood(string displayName) : base(displayName)
        {
        }
    }
}