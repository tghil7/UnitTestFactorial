using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFactorial
{
    [TestClass]
    public class UnitTest1
    {

        int Factorial(int n)
        {
            if (n <= -1 || n >= 13)
            {
                throw new ArgumentOutOfRangeException();
            }
          
            int result = 1;
           /* for (int i= n ; i > 1; i--)
            {
                //result *= i;
                
                
            }*/

            while (n > 1)
            {
                result *= n;
                n--;
            }

            return result;
            
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodMinValue() // Input: MinValue, Output: error
        {
            Factorial(int.MinValue);
        }

      



        [TestMethod]
        public void TestMethod0() // Input: 0, Output: 1
        {

            Assert.AreEqual(1, Factorial(0));
        }
        [TestMethod]
        public void TestMethod5() // Input: 5, Output: 120
        {
            Assert.AreEqual(120, Factorial(5));
        }

        [TestMethod]
        public void TestMethod10() // Input: 10, Output: 3,628,800
        {
            Assert.AreEqual(3628800, Factorial(10));
        }

        [TestMethod]
        public void TestMethodMaxValue10exp12() // Input: 12, Output: 479001600
        {
            Assert.AreEqual(479001600, Factorial(12));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodMaxValue10exp13() // Input: 13, Output: ERROR
        {
          Factorial(13);
        }


    }
}
