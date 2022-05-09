using System.Collections.Generic;
using OpenAlienGarden.ObjectStats.World.Events.Base;

namespace OpenAlienGarden.ObjectTypes.Items
{
    public class ItemUseEffect
    {
        List<WorldEvent> _events = new List<WorldEvent>();

        public ItemUseEffect(params WorldEvent[] events)
        {
            _events.AddRange(events);
        }
    }
}