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
			Assert.AreEqual(1, Roman.Parse("V"));
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
			return 1;
		}
	}
}
