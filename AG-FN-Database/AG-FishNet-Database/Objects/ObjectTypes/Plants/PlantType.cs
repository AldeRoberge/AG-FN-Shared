using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectTypes.Plants
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