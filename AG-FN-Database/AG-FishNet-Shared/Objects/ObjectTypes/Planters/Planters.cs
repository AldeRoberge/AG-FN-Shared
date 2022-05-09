using AG_FishNet_Shared.Objects.Core.Identities;

namespace AG_FishNet_Shared.Objects.ObjectTypes.Planters
{
    public class Planters : IdentityList<PlanterType>
    {
        public static readonly PlanterType Oak   = new PlanterType(nameof(Oak));
        public static readonly PlanterType Birch = new PlanterType(nameof(Birch));
        public static readonly PlanterType Stone = new PlanterType(nameof(Stone));
    }
}