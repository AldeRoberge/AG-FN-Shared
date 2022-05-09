namespace OpenAlienGarden.ObjectTypes.Rarities
{
    public class Rarities
    {
        public static Rarity Junk      = new Rarity(nameof(Junk), RarityColor.Grey);
        public static Rarity Common    = new Rarity(nameof(Common), RarityColor.White);
        public static Rarity Uncommon  = new Rarity(nameof(Uncommon), RarityColor.Green);
        public static Rarity Rare      = new Rarity(nameof(Rare), RarityColor.Blue);
        public static Rarity Epic      = new Rarity(nameof(Epic), RarityColor.Purple);
        public static Rarity Legendary = new Rarity(nameof(Legendary), RarityColor.Gold);
        public static Rarity Divine    = new Rarity(nameof(Divine), RarityColor.Pearlescent);
    }
}