using OpenAlienGarden.ObjectEntity.Base;
using OpenAlienGarden.ObjectStats;
using OpenAlienGarden.ObjectStats.World.Time;

namespace OpenAlienGarden.ObjectEntity
{
    public class World : StatsEntity<WorldStats>
    {
        public DayPeriod DayPeriod => DayPeriods.GetFromTime(Stats.Time.Value);
        public WeatherType Weather => WeatherTypes.GetFromConditions(Stats.Clouds.Value, Stats.Precipitation.Value, Stats.Temperature.Value);

        public World()
        {
            Stats = new WorldStats();
        }

        public override WorldStats Stats { get; }
        public override void Update(double deltaTime)
        {
        }
    }
}