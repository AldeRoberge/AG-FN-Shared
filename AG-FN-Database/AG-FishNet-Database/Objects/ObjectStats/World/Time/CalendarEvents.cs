using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectStats.World.Time
{
    public class CalendarEvents : IdentityList<CalendarEventType>
    {
        public static CalendarEventType Birthday   = new CalendarEventType(0, nameof(Birthday), "🎂");
        public static CalendarEventType Easter     = new CalendarEventType(1, nameof(Easter), "🎉");
        public static CalendarEventType Halloween  = new CalendarEventType(2, nameof(Halloween), "🎃");
        public static CalendarEventType Christmas  = new CalendarEventType(3, nameof(Christmas), "🎄");
        public static CalendarEventType NewYear    = new CalendarEventType(4, nameof(NewYear), "🎉");
        public static CalendarEventType Valentine  = new CalendarEventType(5, nameof(Valentine), "💘");
        public static CalendarEventType StPatricks = new CalendarEventType(6, nameof(StPatricks), "🎅");
    }

    public class CalendarEventType : Identity
    {
        public string Emoji { get; }

        internal CalendarEventType(int id, string name, string emoji) : base(name)
        {
            Emoji = emoji;
        }
    }
}