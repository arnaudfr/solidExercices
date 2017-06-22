using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class OperationSub : IOperation
    {
        public decimal Calculate(List<decimal> numbers)
        {
            var result = numbers.First();
            numbers.Remove(result);

            foreach (var number in numbers)
            {
                result = result - number;
            }

            return result;
        }
    }
}
