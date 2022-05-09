﻿using System;
using OpenAlienGarden.ObjectStats.Base;
using OpenAlienGarden.ObjectStats.Base.Types;
using OpenAlienGarden.ObjectStats.Player;

namespace OpenAlienGarden.ObjectStats
{
    public class PlayerStats : LivingStats<PlayerStats>
    {
        public readonly NumberStat Stamina    = new NumberStat(Stats.Stamina, 0);
        public readonly NumberStat Hunger     = new NumberStat(Stats.Hunger, 0);
        public readonly NumberStat Money      = new NumberStat(Stats.Money, 0);
        public readonly NumberStat Experience = new NumberStat(Stats.Experience, 0);

        // Red DNA (Strength)
        public readonly NumberStat Damage = new NumberStat(Stats.Damage, 0);
        public readonly NumberStat Armor  = new NumberStat(Stats.Armor, 0);

        // Green DNA (Technique)
        public readonly NumberStat Speed     = new NumberStat(Stats.Speed, 0);
        public readonly NumberStat Dexterity = new NumberStat(Stats.Dexterity, 0);

        // Blue DNA (Endurance)
        public readonly NumberStat Cardio      = new NumberStat(Stats.Cardio, 0);
        public readonly NumberStat HealthRegen = new NumberStat(Stats.HealthRegen, 0);

        public PlayerRank Rank => PlayerRanks.GetFromExperience(Experience.Value);
    }
}