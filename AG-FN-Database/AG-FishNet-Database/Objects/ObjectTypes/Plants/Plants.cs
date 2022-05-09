using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectTypes.Plants
{
    public class Plants : IdentityList<PlantType>
    {
        public static PlantType Bruticlius       = new PlantType(nameof(Bruticlius), 5);
        public static PlantType Basil     = new PlantType(nameof(Basil), 4);
        public static PlantType AugustMoon = new PlantType(nameof(AugustMoon), 3);
    }
}