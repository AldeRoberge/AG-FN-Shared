namespace AG_LNL_Shared.Setup
{
    public class Testing : Setup
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