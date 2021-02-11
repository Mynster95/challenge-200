using challenge_200;
using System.Collections.Generic;
using Xunit;

namespace challenge_200_tests
{
    public class Challenge_203_tests
    {
        private readonly Challenge_203 _challenge203 = new Challenge_203();

        int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        public Challenge_203_tests(){}

        [Theory]
        [InlineData(3, "yes")]
        [InlineData(4, "no")]
        [InlineData(67, "yes")]
        [InlineData(36, "no")]
        public void IsPrime(int number, string expected)
        {
            Assert.Equal(expected, _challenge203.IsPrime(primes, number));
        }


    }
}

