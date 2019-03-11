using System;
using Xunit;
using lab_16_NUnit_XUnit_Tests;

namespace lab_16_XUnit
{
    public class lab_16_XUnit_Tests
    {
        [Fact]
        public void Lab_16_Test_Math_Power()
        {
            // arrange
            var expected = 9765625.0;
            var instance03 = new TestMeNow();
            // act
            var actual = instance03.TestThisMethodS(5,5,5);


            // assert
            Assert.Equal(expected, actual);
        }
    }
}
