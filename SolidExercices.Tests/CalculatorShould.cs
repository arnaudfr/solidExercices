using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1-2");
            Check.That(result).IsEqualTo(-1m);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("2*2,3");
            Check.That(result).IsEqualTo(4.6m);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("9/3");
            Check.That(result).IsEqualTo(3m);
        }
    }
}
