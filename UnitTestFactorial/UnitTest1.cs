using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFactorial
{
    [TestClass]
    public class UnitTest1
    {

        int Factorial(int n)
        {
            int result = 1;
            if (n <= -1 || n >= 13)
            {
                throw new ArgumentOutOfRangeException();
            }

           
          
            
           /* for (int i= n ; i > 1; i--)
            {
                //result *= i;
                
                
            }*/

            while (n >= 1)
            {
                result *= n;
                n--;
            }

            return result;
            
        }



        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Factorial(0));
        }
        //Your code starts here

        //Your code starts here
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod2() // Input: MinValue, Output: error
        {
            Factorial(int.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod3() // Input: -1, Output: error
        {
            Factorial(-1);
        }

        [TestMethod]
        public void TestMethod4() // Input: 1, Output: 1
        {

            Assert.AreEqual(1, Factorial(1));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod5() // Input: 5, Output: 120
        {
            Factorial(int.MinValue + 1);
        }

        [TestMethod]
        public void TestMethod6() // Input: 12, Output: 479001600
        {
            Assert.AreEqual(479001600, Factorial(12));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod7() // Input: 13, Output: ERROR
        {
            Factorial(13);
        }

        [TestMethod]

        public void TestMethod8()//Input:11, Output: Error
        {
            Assert.AreEqual(39916800, Factorial(11));
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod9()//Input:int.MaxValue, Output: Error
        {
            Factorial(int.MaxValue);
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod10()//Input:int.MaxValue, Output: Error
        {
            Factorial(int.MaxValue - 1);
        }


    }
}
