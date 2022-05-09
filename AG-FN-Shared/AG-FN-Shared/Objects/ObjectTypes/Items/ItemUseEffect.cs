using System.Collections.Generic;
using AG_FishNet_Shared.Objects.ObjectStats.World.Events.Base;

namespace AG_FishNet_Shared.Objects.ObjectTypes.Items
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