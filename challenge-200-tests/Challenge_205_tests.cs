using challenge_200;
using System.Collections.Generic;
using Xunit;

namespace challenge_200_tests
{
    public class Challenge_205_tests
    {
        private readonly Challenge_205 _challenge205 = new Challenge_205();


        public Challenge_205_tests() { }

        [Theory]
        [InlineData("Hello", new int[] { 72, 29, 7, 0, 3 })]
        [InlineData("Sunshine", new int[] { 83, 34, -7, 5, -11, 1, 5, -9 })]
        public void Encrypt(string str, IEnumerable<int> expected)
        {
            Assert.Equal(expected, _challenge205.Encrypt(str));
        }

        [Theory]
        [InlineData(new int[] { 72, 33, -73, 84, -12, -3, 13, -13, -68 }, "Hi there!")]
        public void Decrypt(IEnumerable<int> list, string expected) 
        {
            Assert.Equal(expected, _challenge205.Decrypt(list));
        }



    }
}

