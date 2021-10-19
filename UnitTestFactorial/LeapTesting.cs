using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFactorial
{
    [TestClass]
    public class LeapTesting
    {
        // Your code starts here
        bool isLeap(int year)
        {
            if (year <= 1581)
            {
                throw new ArgumentOutOfRangeException();
            }
            return (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod1()
        {
            isLeap(1581);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, isLeap(1582));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(false, isLeap(1583));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(true, isLeap(1584));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(false, isLeap(1585));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(true, isLeap(1600));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(false, isLeap(1599));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(false, isLeap(1601));
        }




        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod9()
        {
            isLeap(int.MinValue + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod10()
        {
            isLeap(int.MinValue);
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(false, isLeap(int.MaxValue - 1));
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.AreEqual(false, isLeap(int.MaxValue));
        }

        [TestMethod]
        public void TestMethod13()
        {
            Assert.AreEqual(false, isLeap(1699));
        }

        [TestMethod]
        public void TestMethod14()
        {
            Assert.AreEqual(false, isLeap(1700));
        }

        [TestMethod]
        public void TestMethod15()
        {
            Assert.AreEqual(false, isLeap(1701));
        }

        // Your code ends here
    }
}
