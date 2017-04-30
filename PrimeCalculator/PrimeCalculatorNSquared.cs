using System;
using System.Collections.Generic;

namespace primecalculator
{
    public class PrimeCalculatorNSquared
    {
        public IList<int> CalculatePrimesLessThan(int limit)
        {
            var primes = new List<int>();

            if(limit <= 2)
            {
                return primes;
            }

            primes.Add(2);

            for(var i = 3; i < limit; i += 2)
            {
                if(IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        private bool IsPrime(int numberToCheck)
        {
            for(var j = 2; j <= Math.Sqrt(numberToCheck); j++)
            {
                if (numberToCheck % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}