namespace AG_FishNet_Shared.Setup
{
    public class Production : Core.Setup
    {
        public override string GetDomainURL()
        {
            return "https://aliengarden.com/";
        }

        public override string GetConnectionKey()
        {
            return "SomeConnectionKey";
        }

        public override string GetWorldServerName()
        {
            return "Main Server (Virmach VPS)";
        }

        public override string Name => "Production";
    }
}