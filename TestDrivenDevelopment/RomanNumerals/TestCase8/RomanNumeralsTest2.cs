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
		[Test(4, "IV")]
		[Test(14, "XIV")]
		[Test(9, "IX")]
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
				if(i + 1 < roman.Length && map[roman[i] < map[roman[1 + i])
				{
					result -= map[roman[i]];
				}
				else
				{
				 	result += map[roman[i]];
				}
			}
			
			return result;
		}
	}
}
