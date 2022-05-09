using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectStats.World.Time
{
    public class MoonPhases : IdentityList<MoonPhaseType>
    {
        public static MoonPhaseType NewMoon        = new MoonPhaseType(0, nameof(NewMoon), "🌑");
        public static MoonPhaseType WaxingCrescent = new MoonPhaseType(1, nameof(WaxingCrescent), "🌒");
        public static MoonPhaseType FirstQuarter   = new MoonPhaseType(2, nameof(FirstQuarter), "🌓");
        public static MoonPhaseType WaxingGibbous  = new MoonPhaseType(3, nameof(WaxingGibbous), "🌔");
        public static MoonPhaseType FullMoon       = new MoonPhaseType(4, nameof(FullMoon), "🌕");
        public static MoonPhaseType WaningGibbous  = new MoonPhaseType(5, nameof(WaningGibbous), "🌖");
        public static MoonPhaseType LastQuarter    = new MoonPhaseType(6, nameof(LastQuarter), "🌗");
        public static MoonPhaseType WaningCrescent = new MoonPhaseType(7, nameof(WaningCrescent), "🌘");
    }

    public class MoonPhaseType : Identity
    {
        private string Emoji;

        internal MoonPhaseType(int id, string name, string emoji) : base(name)
        {
            Emoji = emoji;
        }
    }
}