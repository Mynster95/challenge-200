using challenge_200;
using System.Collections.Generic;
using Xunit;

namespace challenge_200_tests
{
    public class Challenge_204_tests
    {
        private readonly Challenge_204 _challenge204 = new Challenge_204();


        public Challenge_204_tests() { }

        [Theory]
        [InlineData("potato", 1)]
        [InlineData("potatopotato", 2 )]
        [InlineData("potatoapple", 1)]
        public void Potatoes(string s, int expected)
        {
            Assert.Equal(expected, _challenge204.Potatoes(s));
        }





    }
}

