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
		}
	}
	
	public class Roman
	{
		public static in Parse(string roman)
		{
			return 0;
		}
	}
} 
