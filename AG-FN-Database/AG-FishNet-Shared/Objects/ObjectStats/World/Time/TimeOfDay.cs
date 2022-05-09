using System;
using AG_FishNet_Shared.Objects.Core.Identities;

namespace AG_FishNet_Shared.Objects.ObjectStats.World.Time
{
    public class DayPeriods : IdentityList<DayPeriod>
    {
        public static DayPeriod Sunrise = new DayPeriod(0, nameof(Sunrise), "🐦️", 6, 11);
        public static DayPeriod Day     = new DayPeriod(1, nameof(Day), "☀", 6, 11);
        public static DayPeriod Sunset  = new DayPeriod(2, nameof(Sunset), "🛏", 6, 11);
        public static DayPeriod Night   = new DayPeriod(3, nameof(Night), "🌙", 6, 11);

        public static DayPeriod GetFromTime(DateTime time)
        {
            if (time.Hour < Sunrise.StartHour || time.Hour > Sunset.EndHour)
                return Night;

            if (time.Hour < Sunrise.StartHour)
                return Sunrise;

            if (time.Hour > Sunset.EndHour)
                return Sunset;

            return Day;
        }
    }

    public class DayPeriod : Identity
    {
        public string Emoji;
        public int    StartHour;
        public int    EndHour;

        internal DayPeriod(int id, string name, string emoji, int startHour, int endHour) : base(name)
        {
            Emoji = emoji;
            StartHour = startHour;
            EndHour = endHour;
        }
    }
}