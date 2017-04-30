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
            var primeUtility = new PrimeCalculatorSieve();
            var results = primeUtility.CalculatePrimesLessThan(3);
            
            Assert.Equal(2, results[0]);

        }

        [Fact]
        public void ReturnsEmptyListForPrimesLessThan2()
        {
            var primeUtility = new PrimeCalculatorSieve();
            var results = primeUtility.CalculatePrimesLessThan(2);

            Assert.True(results.Count == 0);
        }

        [Fact]
        public void Returns2_3_5ForPrimesLessThan6()
        {
            var primeUtility = new PrimeCalculatorSieve();
            var results = primeUtility.CalculatePrimesLessThan(6);
            Assert.Equal(2, results[0]);
            Assert.Equal(3, results[1]);
            Assert.Equal(5, results[2]);
        }


    }
}
