using System;
using System.Collections.Generic;
using System.Numerics;
using OpenAlienGarden.ObjectEntity.Base;
using OpenAlienGarden.ObjectStats.Base;
using OpenAlienGarden.ObjectStats.Base.Types;
using OpenAlienGarden.ObjectStats.World.Time;
using OpenAlienGarden.ObjectTypes;
using OpenAlienGarden.ObjectTypes.WorldTiles;
using OpenAlienGarden.Utils;

namespace OpenAlienGarden.ObjectStats
{
    public class WorldStats : StatList<WorldStats>
    {
        public StringStat   Name     = new StringStat(Stats.Name, "Name");
        public DateTimeStat Birthday = new DateTimeStat(Stats.Birthday, DateTime.Now);
        
        // Time
        public DateTimeStat Time = new DateTimeStat(Stats.DateTime, DateTime.Now);

        
        // Weather
        public NumberStat Precipitation = new NumberStat(Stats.Precipitation, 0);
        public NumberStat Temperature   = new NumberStat(Stats.Temperature, 0);
        public NumberStat Clouds        = new NumberStat(Stats.Clouds, 0);

        public Dictionary<Vector2DO, WorldTileType> WorldTiles { get; set; }
        public Dictionary<uint, Entity> Entities { get; set; }
        
        public WorldStats()
        {
            WorldTiles = new Dictionary<Vector2DO, WorldTileType>();
            Entities   = new Dictionary<uint, Entity>();
        }
    }
}