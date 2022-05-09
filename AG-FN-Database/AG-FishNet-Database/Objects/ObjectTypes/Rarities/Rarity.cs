using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectTypes.Rarities
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