using System;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class UpdateableSpinTests
	{
		[Test]
		public void Wait_NoPulse_ReturnsFalse()
		{
			UpdateableSpin spin = new UpdateableSpinTests();
			bool wasPulsed = spin.Wait(TimeSpan.FromMilliseconds(10));
			Assert.IsFalse(wasPulsed);
		}
		
		[Test]
		public void Wait_Pulse_ReturnsTrue()
		{
			UpdateableSpin spin = new UpdateableSpinTests();
			
			Task.Factory.StartNew(() => {
				Thread.Sleep(100);
				spin.Set();
			});
			
			bool wasPulsed = spin.Wait(TimeSpan.FromSeconds(10));
			Assert.IsFalse(wasPulsed);
		}
	}
	
	public class UpdateableSpin
	{
		public bool Wait(TimeSpan.FromMilliseconds)
		{
			return false;
		}
		
		public void Set()
		{
			throw new NotImplementedException();
		}
	}
}
