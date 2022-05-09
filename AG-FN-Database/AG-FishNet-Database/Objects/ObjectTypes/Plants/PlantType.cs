using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectTypes.Plants
{
    public class PlantType : Identity
    {
        public uint DaysToMaturity { get; }

        public PlantType(string name, uint daysToMaturity) : base(name)
        {
            DaysToMaturity = daysToMaturity;
        }
    }
}