using NUnit.Framework;
using lab_118_array_of_tests;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // any setup code eg generate a fresh database
            // any initialization before run any tests
        }

        [TestCase(1000, 7000)]
        [TestCase(10000, 60000)]
        [TestCase(1000, 5000)]
        public void TestFileSynchronousReadWrite(int numOfFiles, long maxTime)
        {
            // arrange
            var instance01 = new FileOperationSynchronous();
            // act
            long timetaken = instance01.FileReadWrite(numOfFiles);
            System.Console.WriteLine($"Time taken : {timetaken} milliseconds");
            // assert
            Assert.Less(timetaken, maxTime);
        }
    }
}