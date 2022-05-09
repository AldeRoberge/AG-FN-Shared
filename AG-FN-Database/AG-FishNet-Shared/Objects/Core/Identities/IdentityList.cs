using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace AG_FishNet_Shared.Objects.Core.Identities
{
    public abstract class IdentityList<T> where T : Identity
    {
        private static T[] _values;

        public static T[] Values
        {
            get
            {
                if (_values == null) LoadFromReflection();
                return _values;
            }
        }

        /// <summary>
        /// Loads all of the fields (public static) of the parent Enumeration.
        /// This allows to have a public static field with all of the possible values,
        /// without having to manually define each one and to ensure each class implements it.
        /// </summary>
        private static void LoadFromReflection()
        {
            // Load all Enumerable of type T from reflection in project
            foreach (var i in typeof(T).Assembly.GetTypes())
                if (typeof(IdentityList<T>).IsAssignableFrom(i) && !i.IsAbstract)
                    _values = i.GetFields(BindingFlags.Public | BindingFlags.Static)
                        .Where(f => f.FieldType == typeof(T)).Select(f => (T)f.GetValue(null)).ToArray();
        }

        /// <summary>
        /// Creates instance of type <see cref="IdentityList{T}" />.
        /// </summary>
        /// <remarks>
        /// This constructor should not be called from the derived class.
        /// It is helpful in doing JSON Serialization or mapping through Automapper.
        /// </remarks>
        [ExcludeFromCodeCoverage]
        protected IdentityList()
        {
        }

        public static T GetFromName(string name) => Values.FirstOrDefault(x => x.Name == name);
    }
}