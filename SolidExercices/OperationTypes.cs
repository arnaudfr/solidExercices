using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class OperationTypes
    {
        readonly Dictionary<char, object> _types;
        

        public OperationTypes(Dictionary<char, object> types)
        {
            _types = types;
        }

        public object Detect(string insertedValue)
        {
            var firstChar = insertedValue[0];

            // Isoler un signe négatif en début de chaîne
            var unsignedString = firstChar == '-' ? insertedValue.Substring(1, insertedValue.Length - 1) : insertedValue;

            foreach (var type in _types)
            {
                if (!unsignedString.Contains(type.Key)) continue;
                var detected = type.Value;
                return detected;
            }

            return null;
        }
    }
}
