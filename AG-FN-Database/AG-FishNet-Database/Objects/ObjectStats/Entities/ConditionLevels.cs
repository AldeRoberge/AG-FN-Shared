using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectStats.Entities
{
    public class ConditionLevels : IdentityList<ConditionLevel>
    {
        public static ConditionLevel One   = new ConditionLevel(nameof(One), 1);
        public static ConditionLevel Two   = new ConditionLevel(nameof(Two), 2);
        public static ConditionLevel Three = new ConditionLevel(nameof(Three), 3);
    }

    public class ConditionLevel : Identity
    {
        public uint Level;

        public ConditionLevel(string name, uint level) : base(name)
        {
            Level = level;
        }
    }
}