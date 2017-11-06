using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace TestMatrix
{
    [TestClass]
    public class TestWalkInMatrix
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SizeSetterShouldThrowExceptionForSizeThatIsTooBig()
        {
            var walkInMatrix = new WalkInMatrix(160);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SizeSetterShouldThrowExceptionForSizeThatIsNegative()
        {
            var walkInMatrix = new WalkInMatrix(-1);
        }

        [TestMethod]
        public void TestIfWithThreeResultIsWillBeCorrect()
        {
            var walkInMatrix = new WalkInMatrix(3);
            var expectedResult = new string[]
            {
                "  1  7  8",
                "  6  2  9",
                "  5  4  3\r\n"
            };

            Assert.AreEqual(string.Join("\r\n", expectedResult),walkInMatrix.ToString(),"Result is incorrect");
        }

       [TestMethod]
       public void TestIfWithSixResultIsWillBeCorrect()
       {
           var walkInMatrix = new WalkInMatrix(6);
           var expectedResult = new string[]
           {
               "  1 16 17 18 19 20",
               " 15  2 27 28 29 21",
               " 14 31  3 26 30 22",
               " 13 36 32  4 25 23",
               " 12 35 34 33  5 24",
               " 11 10  9  8  7  6\r\n"
           };
          
           Assert.AreEqual(string.Join("\r\n",expectedResult), walkInMatrix.ToString(),"Result Is incorrect");
       }

    }
}