using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectStats.World.Time
{
    public class WeatherTypes : IdentityList<WeatherType>
    {
        // Clouds
        public static WeatherType Clear  = new WeatherType(0, nameof(Clear), "☀");
        public static WeatherType Cloudy = new WeatherType(1, nameof(Cloudy), "☁");

        // Precipitation
        public static WeatherType Rainy = new WeatherType(2, nameof(Rainy), "☂");
        public static WeatherType Snowy = new WeatherType(3, nameof(Snowy), "☃");

        /*
   
        public static WeatherType Thunderstorm = new WeatherType(4, nameof(Thunderstorm), "☃");
        public static WeatherType Tornado      = new WeatherType(5, nameof(Tornado), "☃");
        public static WeatherType Hail         = new WeatherType(6, nameof(Hail), "☃");
        public static WeatherType Foggy        = new WeatherType(7, nameof(Foggy), "☃");
        public static WeatherType Windy        = new WeatherType(8, nameof(Windy), "☃");
        public static WeatherType Dusty        = new WeatherType(9, nameof(Dusty), "☃");
        public static WeatherType Sandstorm    = new WeatherType(10, nameof(Sandstorm), "☃");
        public static WeatherType Ash          = new WeatherType(11, nameof(Ash), "☃");
        public static WeatherType Dust         = new WeatherType(12, nameof(Dust), "☃");*/

        public static WeatherType GetFromConditions(float clouds, float precipitation, float temperature)
        {
            if (precipitation > 0.5f)
            {
                return temperature < 0 ? Snowy : Rainy;
            }

            return clouds > 0.5f ? Cloudy : Clear;
        }
    }

    public class WeatherType : Identity
    {
        internal WeatherType(int i, string name, string emoji) : base(name)
        {
        }
    }
}