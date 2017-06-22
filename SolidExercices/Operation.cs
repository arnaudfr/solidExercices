using System;
using System.Collections.Generic;

namespace SolidExercices
{
    public class Operation
    {
        public string Type;
        public List<double> Numbers;

        public Operation(string[] values)
        {
            var lastValue = values.Length;
            this.Type = values[0];
            this.Numbers = new List<double>();
            for (int i = 1; i <= lastValue; i++)
            {
                var number = Convert.ToDouble(values[i]);
                this.Numbers.Add(number);
            }
        }

    }
}