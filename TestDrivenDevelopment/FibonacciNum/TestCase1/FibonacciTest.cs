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
        [Test]
        public void TestFibonacci()
        {
            Assert.AreEqual(0, GetFibonacci(0));
            Assert.AreEqual(0, GetFibonacci(0));
        }
        
        private int GetFibonacci(int index)
        {
            return 0;
        }
    }
}
