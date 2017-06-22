using System;
using System.Linq;
using Regex =System.Text.RegularExpressions.Regex;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            var types = new[] {'+', '-', '*', '/'};
            var opType = new OperationTypes(types);

            // Vérification de la valeur insérée
            if (CheckValue(operation))
            {
                var type = opType.Detect(operation);


            }
        }

        public bool CheckValue(string insertedValue)
        {
            var rgx = new Regex(@"^[-+]?[0-9]+([-+*/]+[-+]?[0-9]+)*$");
            var isValid = rgx.IsMatch(insertedValue);
            return isValid;
        }

        public string[] Cut(string insertedValue, char splitChar)
        {
            var op = insertedValue.Split(splitChar);
            return op;
        }

    }
}