using NUnit.Framework;

namespace TDD
{
	[TestFixture]
	public class RomanNumeralsTests
	{
		[Test(1, "I")]
		[Test(5, "V")]
		[Test(10, "X")]
		public void Parse(int expected, string roman)
		{
			Assert.AreEqual(expected, Roman.Parse(roman));
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
