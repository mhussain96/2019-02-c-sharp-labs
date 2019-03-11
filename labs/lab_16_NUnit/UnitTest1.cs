using NUnit.Framework;
using lab_16_NUnit_XUnit_Tests;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test] 
        public void lab_16_NUnit_Test_01()
        {
            // arrange 
            var expected = 36.0;
            var instance02 = new TestMeNow();
            // act
            var actual = instance02.TestThisMethodS(2, 3, 2);

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}