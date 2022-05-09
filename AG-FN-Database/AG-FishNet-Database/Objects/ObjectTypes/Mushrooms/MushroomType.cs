using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectTypes.Mushrooms
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