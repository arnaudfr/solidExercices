using System;
using System.Linq;
using Regex =System.Text.RegularExpressions.Regex;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {

            throw new NotImplementedException();
        }

        public bool CheckValue(string insertedValue)
        {
            bool isValid;
            var rgx = new Regex(@"^[-+]?[0-9]+([-+*/]+[-+]?[0-9]+)*$");

            if (rgx.IsMatch(insertedValue))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        public string[] Cut(string insertedValue)
        {
            
        }

    }
}