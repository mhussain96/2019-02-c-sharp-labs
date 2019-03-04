using NUnit.Framework;
using lab_121_hash_set_to_excel;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Pass 3 numbers to an array
        // Double the numbers and pass to a linked list
        // Double the numbers and pass to a hash set 
        // Add 15 to each number, then treble numbers and pass to a dictionary
        // Stop the stopwatch
        // Return the test as a CUSTOM OBJECT CONTAINING
        //          ElapsedTime (integer, will be in milliseconds)
        //          First number
        //          Second number
        //          Third number
        // Test passes if stopwatch time less than time passed in (4th variable) (set to 10 seconds)
        // Not part of the test 
        // Output all values to .csv test file and append to existing file.
        //      INPUT 4 PARAMS
        //      OUTPUT 4 PARAMS
        // Finally launch excel to read this file using Process.Start...

        [TestCase(10,20,30,40)]
        public void HashSetExcelTest(int a, int b, int c, int d)
        {
            var instance = new HashSetToExcel();

            Custom actual = instance.HashSetToExcelTest(); 



            Assert.Pass();
            Assert.LessOrEqual(actual.time, d);
            Assert.AreEqual(actual, 165);
            Assert.AreEqual(actual, 285);
            Assert.AreEqual(actual, 405);
        }
    }
}