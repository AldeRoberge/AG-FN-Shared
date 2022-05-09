using AG_FishNet_Shared.Objects.Core.Identities;

namespace AG_FishNet_Shared.Objects.ObjectTypes.Mushrooms
{


    public class MushroomType : Identity
    {
        public uint DaysToMaturity { get; }

        public MushroomType(string displayName, uint daysToMaturity) : base(displayName)
        {
            DaysToMaturity = daysToMaturity;
        }
    }
}