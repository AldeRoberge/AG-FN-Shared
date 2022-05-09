using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectTypes.Mushrooms
{
    public class Mushrooms : IdentityList<MushroomType>
    {
        public static MushroomType Bolet       = new MushroomType(nameof(Bolet), 5);
        public static MushroomType Amanite     = new MushroomType(nameof(Amanite), 4);
        public static MushroomType Chanterelle = new MushroomType(nameof(Chanterelle), 3);
    }
}