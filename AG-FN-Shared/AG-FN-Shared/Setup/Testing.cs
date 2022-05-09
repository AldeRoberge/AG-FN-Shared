namespace AG_FishNet_Shared.Setup
{
    public class Testing : Core.Setup
    {
        public override string GetDomainURL()
        {
            return "http://localhost:5000/";
        }

        public override string GetConnectionKey()
        {
            return "SomeConnectionKey";
        }

        public override string GetWorldServerName()
        {
            return "Localhost";
        }

        public override string Name => "Testing";
    }
}