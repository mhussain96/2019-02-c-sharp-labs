using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_112_collections;
using lab_113_arraylist;

namespace labs_test1
{
    [TestClass]
    public class LabsTest1
    {
        [TestMethod]
        public void Lab112CollectionsTest01()
        {
            // arrange
            var expected01 = 22400;
            
            var instanceLab112Collection = new Collections();
            // act
            var actual01 = instanceLab112Collection.Collections20minutelab(10,20,30);
           
            // assert
            Assert.AreEqual(expected01,actual01);
           
        }

        [TestMethod]
        public void Lab112CollectionsTest02()
        {
            // arrange
            
            var expected02 = 6944;
            var instanceLab112Collection = new Collections();
            // act
            
            var actual02 = instanceLab112Collection.Collections20minutelab(11, 12, 13);
            // assert
            
            Assert.AreEqual(expected02, actual02);
        }

        [TestMethod]
        public void lab113ArrayListTest()
        {
            // arrange
            var expected = -10;
            var instanceLab113 = new ArrayList();
            // act
            var actual = instanceLab113.arrayListMethod(10, 20, 30, 40);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
