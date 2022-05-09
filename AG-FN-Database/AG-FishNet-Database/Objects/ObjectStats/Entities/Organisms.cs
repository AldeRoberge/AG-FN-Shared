using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectStats.Entities
{
    public class Organisms : IdentityList<OrganismType>
    {
        public static readonly OrganismType Plant    = new OrganismType(nameof(Plant));
        public static readonly OrganismType Animal   = new OrganismType(nameof(Animal));
        public static readonly OrganismType Human    = new OrganismType(nameof(Human));
        public static readonly OrganismType Mushroom = new OrganismType(nameof(Mushroom));
        public static readonly OrganismType Pet      = new OrganismType(nameof(Insect));
        public static readonly OrganismType Insect   = new OrganismType(nameof(Insect));
    }

    public class OrganismType : Identity
    {
        public OrganismType(string displayName) : base(displayName)
        {
        }
    }
}