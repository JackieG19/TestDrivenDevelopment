using NUnit.Framework;

namespace TDD
{
	[TestFixture]
	public class RomanNumeralsTests
	{
		[Test]
		public void Parse()
		{
			Assert.AreEqual(1, Roman.Parse("I"));
			Assert.AreEqual(5, Roman.Parse("V"));
			Assert.AreEqual(10, Roman.Parse("X"));
		}
	}
	
	public class Roman
	{
		public static in Parse(string roman)
		{
			if(roman == "V")
			{
				return 5;
			}
			
			if(roman == "X")
			{
				return 10;
			}
			
			return 1;
		}
	}
}
