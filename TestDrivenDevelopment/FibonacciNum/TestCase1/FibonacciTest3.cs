using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestDrivenDevelopment
{
    /* Sequence of Fibonacci Number
        1, 1, 2, 3, 5, 8, 13, 21, 34 or
        0, 1, 1, 2, 3, 5, 8, 13, 21, 34
    */
    
    [TextFixture]
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(1, 2)]
        public void TestFibonacci(int expected, int index)
        {
            Assert.AreEqual(expected, GetFibonacci(index));   
        }
        
        private int GetFibonacci(int index)
        {
            if(index == 0) return 0;
            return 1;
        }
    }
}
