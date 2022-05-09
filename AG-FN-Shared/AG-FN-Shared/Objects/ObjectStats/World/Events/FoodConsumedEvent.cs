﻿using AG_FishNet_Shared.Objects.ObjectStats.World.Events.Base;

namespace AG_FishNet_Shared.Objects.ObjectStats.World.Events
{
    public class FoodConsumedEvent : WorldEvent
    {
        public uint HealthRestorePoints;
        public uint HungerRestorePoints;

        public FoodConsumedEvent(uint healthRestorePoints, uint hungerRestorePoints)
        {
            HealthRestorePoints = healthRestorePoints;
            HungerRestorePoints = hungerRestorePoints;
        }
    }
}