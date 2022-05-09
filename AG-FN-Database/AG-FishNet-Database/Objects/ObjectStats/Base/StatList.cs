using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using AG_FishNet_Database.Objects.Core.Identities;
using AG_FishNet_Database.Objects.ObjectStats.Base.Types;

namespace AG_FishNet_Database.Objects.ObjectStats.Base
{
    public abstract class StatList<T>
    {
        private Stat[] _values;

        public Stat[] Values
        {
            get
            {
                if (_values == null) LoadFromReflection();
                return _values;
            }
        }
        
        private void LoadFromReflection()
        {
            // Get all fields in the class of type Stat
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.FieldType.IsSubclassOf(typeof(Stat)));

            // Get values from fields
            _values = fields.Select(f => (Stat)f.GetValue(this)).ToArray();
        }

        /// <summary>
        /// Creates instance of type <see cref="IdentityList{T}" />.
        /// </summary>
        /// <remarks>
        /// This constructor should not be called from the derived class.
        /// It is helpful in doing JSON Serialization or mapping through Automapper.
        /// </remarks>
        [ExcludeFromCodeCoverage]
        protected StatList()
        {
        }

        public StringStat GetStringStat(StatType type) => GetStat(type) as StringStat;
        
        public NumberStat GetNumberStat(StatType type) => GetStat(type) as NumberStat;
        
        public Stat GetStat(StatType type) => Values.FirstOrDefault(x => Equals(x.Type, type));
    }
}