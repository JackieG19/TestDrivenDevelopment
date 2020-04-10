using NUnit.Framework;

namespace TDD
{
	[TestFixture]
	public class RomanNumeralsTests
	{
		[Test(1, "I")]
		[Test(5, "V")]
		[Test(10, "X")]
		[Test(2, "II")]
		public void Parse(int expected, string roman)
		{
			Assert.AreEqual(expected, Roman.Parse(roman));
		}
	}
	
	public class Roman
	{
		private static Dictionary<char, int> map = new Dictionary<char, int>()
		{
			{'I', 1},
			{'V', 5},
			{'X', 10},
			{'L', 50},
			{'C', 100},
			{'D', 500},
			{'M', 1000}
		};
		
		public static in Parse(string roman)
		{
			int result = 0;
			
			for(int i = 0; i < roman.Length; i++)
			{
				 result += map[roman[i]];
			}
			
			return result;
		}
	}
}
