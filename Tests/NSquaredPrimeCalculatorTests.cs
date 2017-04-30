using System;
using Xunit;
using primecalculator;

namespace primecalculatortests
{
    public class NSquaredPrimeCalculatorTests
    {
        [Fact]
        public void Returns2_3_5ForPrimesLessThan6NSquared()
        {
            var primeCalculator = new PrimeCalculatorNSquared();
            var results = primeCalculator.CalculatePrimesLessThan(6);
            Assert.Equal(2, results[0]);
            Assert.Equal(3, results[1]);
            Assert.Equal(5, results[2]);
        }
    }
}