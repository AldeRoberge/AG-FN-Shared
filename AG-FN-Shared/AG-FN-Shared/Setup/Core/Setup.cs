namespace AG_FishNet_Shared.Setup.Core
{
    public abstract class Setup
    {
        public static string Version = "Pre-Alpha v0.0.13";

        public static Production Production = new Production();
        public static Testing Testing = new Testing();

        /// CHANGE SETUP HERE! ///
        public static Setup GetCurrentSetup()
        {
            // CURRENT SETUP
            return Testing;
        }

        public static string GetCurrentVersion()
        {
            return Version + " " + GetCurrentSetup().Name;
        }

        public abstract string GetDomainURL();

        public abstract string GetConnectionKey();

        /// <summary>
        /// Returns the Server name that matches the one in servers.json
        /// Used by the client to determine which world server to connect to.
        /// </summary>
        public abstract string GetWorldServerName();

        public abstract string Name { get; }

        #region Equality

        protected bool Equals(Setup other)
        {
            return Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Setup) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public static bool operator ==(Setup left, Setup right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Setup left, Setup right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}