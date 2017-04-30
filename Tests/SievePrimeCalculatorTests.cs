using System;
using Xunit;
using primecalculator;

namespace primecalculatortests
{
    public class SievePrimeCalculatorTests
    {
        [Fact]
        public void Returns2ForPrimesLessThan3()
        {
            var primeCalculator = new PrimeCalculatorSieve();
            var results = primeCalculator.CalculatePrimesLessThan(3);
            
            Assert.Equal(2, results[0]);

        }

        [Fact]
        public void ReturnsEmptyListForPrimesLessThan2()
        {
            var primeCalculator = new PrimeCalculatorSieve();
            var results = primeCalculator.CalculatePrimesLessThan(2);

            Assert.True(results.Count == 0);
        }

        [Fact]
        public void Returns2_3_5ForPrimesLessThan6()
        {
            var primeCalculator = new PrimeCalculatorSieve();
            var results = primeCalculator.CalculatePrimesLessThan(6);
            
            Assert.Equal(2, results[0]);
            Assert.Equal(3, results[1]);
            Assert.Equal(5, results[2]);
        }


    }
}
