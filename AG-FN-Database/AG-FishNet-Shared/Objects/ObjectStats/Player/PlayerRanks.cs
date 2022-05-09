using AG_FishNet_Shared.Objects.Core.Identities;

namespace AG_FishNet_Shared.Objects.ObjectStats.Player
{
    public class PlayerRanks : IdentityList<PlayerRank>
    {
        public static readonly PlayerRank Unknown    = new PlayerRank(0, "Unknown", "00_unknown", 0, 0);
        public static readonly PlayerRank Recruit    = new PlayerRank(1, "Recruit", "01_recruit", 0, 100);
        public static readonly PlayerRank Private    = new PlayerRank(2, "Private", "02_private", 0, 500);
        public static readonly PlayerRank Corporal   = new PlayerRank(3, "Corporal", "03_corporal", 0, 2000);
        public static readonly PlayerRank Sergeant   = new PlayerRank(4, "Sergeant", "04_sergeant", 0, 5000);
        public static readonly PlayerRank Lieutenant = new PlayerRank(5, "Lieutenant", "05_lieutenant", 1, 10000);
        public static readonly PlayerRank Captain    = new PlayerRank(6, "Captain", "06_captain", 1, 20000);
        public static readonly PlayerRank Major      = new PlayerRank(7, "Major", "07_major", 1, 50000);
        public static readonly PlayerRank Commander  = new PlayerRank(8, "Commander", "08_commander", 2, 100000);
        public static readonly PlayerRank Colonel    = new PlayerRank(9, "Colonel", "09_colonel", 3, 150000);
        public static readonly PlayerRank Brigadier  = new PlayerRank(10, "Brigadier", "10_brigadier", 5, 250000);
        public static readonly PlayerRank General    = new PlayerRank(11, "General", "11_general", 10, 500000);
        public static readonly PlayerRank Guardian   = new PlayerRank(12, "Guardian", "12_guardian", 25, 1000000);

        public static PlayerRank GetFromExperience(float experienceValue)
        {
            // Loads the playerRank from the maxXP
            foreach (var playerRank in Values)
            {
                if (experienceValue <= playerRank.MaxXP)
                {
                    return playerRank;
                }
            }
            
            return Unknown;
        }
    }

    public class PlayerRank : Identity
    {
        public readonly int    Id;
        public readonly string Name;
        public readonly string EmoteName;
        public readonly int    MaxXP;
        public readonly string RankImageURL;
        public readonly bool   IsHidden;
        public readonly int    LevelUpEpicKeys;

        public PlayerRank(int id, string name, string emoteName, int levelUpEpicKeys, int maxXp) : base(name)
        {
            Id = id;
            Name = name;
            EmoteName = emoteName;
            LevelUpEpicKeys = levelUpEpicKeys;
            MaxXP = maxXp;
        }
    }
}