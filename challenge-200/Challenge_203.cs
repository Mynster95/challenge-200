using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace challenge_200
{
    public class Challenge_203 : IChallenge_203
    {
        public Challenge_203() { }


        // Use Binary Search algorithm
        public string IsPrime(IEnumerable<int> primes, int number) 
        {

            return BinarySearchAlgorithm(primes.ToList(), number);

        
        }


        private string BinarySearchAlgorithm(List<int> array, int value) 
        {

            array.Sort();
            var n = array.Count();

            var lowerBound = 1;
            var upperBound = n;

            while (true) 
            {
                if (upperBound < lowerBound) 
                {
                    return "no";
                }

                var midPoint = lowerBound + (upperBound - lowerBound) / 2;

                if (array[midPoint] < value) lowerBound = midPoint + 1;

                if (array[midPoint] > value) upperBound = midPoint - 1;

                if (array[midPoint] == value) return "yes";

            }
        }

    }
}
