using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectStats.Entities
{
    public class MaturityLevels : IdentityList<MaturityLevelType>
    {
        public static MaturityLevelType Newborn = new MaturityLevelType(nameof(Newborn));
        public static MaturityLevelType Baby    = new MaturityLevelType(nameof(Baby));
        public static MaturityLevelType Child   = new MaturityLevelType(nameof(Child));
        public static MaturityLevelType Teen    = new MaturityLevelType(nameof(Teen));
        public static MaturityLevelType Adult   = new MaturityLevelType(nameof(Adult));
        public static MaturityLevelType Elder   = new MaturityLevelType(nameof(Elder));

    }

    public class MaturityLevelType : Identity
    {
        public MaturityLevelType(string displayName) : base(displayName)
        {
        }
    }
}