using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TDD
{
	/*	If divisible by 3 -> return "Fizz"
		If divisible by 5 -> return "Buzz"
		If divisible by 3 and 5 -> "FizzBuzz"
		Otherwise -> return ""
	*/
	
	[TextFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void TestFizzBuzz()
		{
			Assert.AreEqual("Fizz", FizzBuzz(3));
			Assert.AreEqual("Buzz", FizzBuzz(5));
			Assert.AreEqual("Fizz", FizzBuzz(6));
		}
		
		private string FizzBuzz(int number)
		{
			if(number % 3 == 0)
			{
				return "Fizz";
			}
			return "Buzz";
		}
	}
}
