using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectTypes.Pets
{
    public class PetType : Identity
    {
        public PetType(string displayName) : base(displayName)
        {
        }
    }
}