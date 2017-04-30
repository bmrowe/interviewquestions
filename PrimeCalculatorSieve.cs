using System;
using System.Collections.Generic;

namespace primecalculator
{
    public class PrimeCalculatorSieve
    {
        public IList<int> CalculatePrimesLessThan(int limit)
        {
            var numberArray = new bool[limit];
            var results = new List<int>();
            
            numberArray = InitializeArrayToTrue(numberArray);

            var index = 2;
            
            while(index < limit)
            {
                if(numberArray[index])
                {
                    results.Add(index);
                }
                
                numberArray = CrossOutMultiplesOfFactorInArray(numberArray, index, limit);
                index++;
            }

            return results;
        }
        
        private bool[] CrossOutMultiplesOfFactorInArray(bool[]arrayToCrossOut, int factor, int limit)
        {
            var multiple = factor * 2;
            while(multiple < limit)
            {
                arrayToCrossOut[multiple] = false;
                multiple += factor;
            }
            return arrayToCrossOut;
        }

        private bool[] InitializeArrayToTrue(bool[] arrayToInitialize)
        {
            for(var i = 0; i < arrayToInitialize.Length; i++)
                arrayToInitialize[i] = true;
            
            return arrayToInitialize;
        }
    }
}
