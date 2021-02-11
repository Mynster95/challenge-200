using challenge_200;
using System.Collections.Generic;
using Xunit;

namespace challenge_200_tests
{
    public class Challenge_201_tests
    {
        private readonly Challenge_201 _challenge201 = new Challenge_201();

        public Challenge_201_tests(){}

        [Theory]
        [InlineData("4556364607935616", "############5616")]
        [InlineData("64607935616","#######5616")]
        [InlineData("1","1")]
        [InlineData("", "")]
        public void Maskify(string str, string expected)
        {
            Assert.Equal(expected, _challenge201.Maskify(str));
        }
    }
}

