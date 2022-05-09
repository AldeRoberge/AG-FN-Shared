using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectTypes.Rarities
{
    public class Rarity : Identity
    {
        public RarityColor Color { get; }

        public Rarity(string name, RarityColor color) : base(name)
        {
            Color = color;
        }
    }
}