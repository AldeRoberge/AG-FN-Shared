using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectTypes.Pets
{
    public class Pets : IdentityList<PetType>
    {
        public static PetType Ducks    = new PetType(nameof(Ducks));
        public static PetType Rabbits  = new PetType(nameof(Rabbits));
        public static PetType Chickens = new PetType(nameof(Chickens));
        public static PetType Frogs    = new PetType(nameof(Frogs));
        public static PetType Dogs     = new PetType(nameof(Dogs));
        public static PetType Cats     = new PetType(nameof(Cats));
    }
}