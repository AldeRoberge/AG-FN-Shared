using AG_FishNet_Shared.Objects.Core.Identities;

namespace AG_FishNet_Shared.Objects.ObjectTypes.Rarities
{
    public class RarityColor : Identity
    {
        public static RarityColor Grey        = new RarityColor(0, nameof(Grey));
        public static RarityColor White       = new RarityColor(1, nameof(White));
        public static RarityColor Green       = new RarityColor(2, nameof(Green));
        public static RarityColor Blue        = new RarityColor(3, nameof(Blue));
        public static RarityColor Purple      = new RarityColor(4, nameof(Purple));
        public static RarityColor Gold        = new RarityColor(5, nameof(Gold));
        public static RarityColor Pearlescent = new RarityColor(6, nameof(Pearlescent));

        private RarityColor(int id, string name) : base(name)
        {
        }
    }
}