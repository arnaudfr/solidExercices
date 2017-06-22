using System;
using System.Collections.Generic;
using System.Linq;
using Regex =System.Text.RegularExpressions.Regex;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            var dico = new Dictionary<char, IOperation>
            {
                {'+', new OperationSum},
                {'-', new OperationSub},
                {'*', typeof(OperationProd)},
                {'/', typeof(OperationDiv)}
            };
            var opType = new OperationTypes(dico);
            
            IOperation op;

            // Vérification de la valeur insérée
            if (CheckValue(operation))
            {
                var type = opType.Detect(operation);
                if (type != null)
                {
                    var numbers = Cut(operation, type.Value.Key);
                }
                op.Calculate();
            }
            else
            {
                return 0;
            }
        }

        public bool CheckValue(string insertedValue)
        {
            var rgx = new Regex(@"^[-+]?[0-9]+([-+*/]+[-+]?[0-9]+)*$");
            var isValid = rgx.IsMatch(insertedValue);
            return isValid;
        }

        public List<decimal> Cut(string insertedValue, char splitChar)
        {
            List<decimal> numbers = null;

            var numbersStr = insertedValue.Split(splitChar);
            foreach (string num in numbersStr)
            {
                var number = Convert.ToDecimal(num);
                numbers.Add(number);
            }
            return numbers;
        }

    }
}