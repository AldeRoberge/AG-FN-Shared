using System;
using System.Diagnostics.CodeAnalysis;

namespace AG_FishNet_Database.Objects.Core.Identities
{
    public class Identity : IEquatable<Identity>
    {
        /// <summary>
        /// Gets the <see cref="string"/> name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates instance of type <see cref="Identity" />.
        /// </summary>
        /// <remarks>
        /// This constructor should not be called from the derived class.
        /// It is helpful in doing JSON Serialization or mapping through Automapper.
        /// </remarks>
        [ExcludeFromCodeCoverage]
        protected Identity()
        {
        }

        /// <summary>
        /// Creates instance of type <see cref="Identity" />.
        /// </summary>
        /// <param name="name">The Enumerable name.</param>
        protected Identity(string name)
        {
            Name = name;
        }


        public static bool operator ==(Identity obj1, Identity obj2)
        {
            if (ReferenceEquals(obj1, obj2))
                return true;
            if (ReferenceEquals(obj1, null))
                return false;
            if (ReferenceEquals(obj2, null))
                return false;
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Identity obj1, Identity obj2) => !(obj1 == obj2);

        public bool Equals(Identity other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Name.Equals(other.Name);
        }

        public override bool Equals(object obj) => Equals(obj as Identity);

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}