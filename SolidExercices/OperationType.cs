using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class OperationType
    {
        private readonly string[] _types;

        public OperationType(string[] types)
        {
            _types = types;
        }

        public string Detect(string insertedValue)
        {
            var firstChar = insertedValue[0];
            string detected = "";

            // Isoler un signe négatif en début de chaîne
            var unsignedString = firstChar == '-' ? insertedValue.Substring(1, insertedValue.Length - 1) : insertedValue;

            foreach (var type in _types)
            {
                if (!unsignedString.Contains(type)) continue;
                detected = type;
                return detected;
            }

            return detected;
        }
    }
}
