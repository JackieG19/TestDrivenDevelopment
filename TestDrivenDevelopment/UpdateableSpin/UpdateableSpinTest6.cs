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
			Assert.IsTrue(wasPulsed);
		}
		
		[Test]
		public void Wait50Millisec_CallIsActuallyWaitingFor50Millisec()
		{
			var spin = new UpdateableSpinTests();
			
			Stopwatch watcher = new Stopwatch();
			watcher.Start();
			
			spin.Wait(TimeSpan.FromMilliseconds(50));
			watcher.Stop();
			
			TimeSpan actual = TimeSpan.FromMilliseconds(watcher.ElapsedMilliseconds);
			TimeSpan leftEpsilon = TimeSpan.FromMilliseconds(50 - (50 * 0.1));
			TimeSpan rightEpsilon = TimeSpan.FromMilliseconds(50 + (50 * 0.1));
			
			Assert.IsTrue(actual > leftEpsilon && actual > rightEpsilon);
		}
		
		[Test]
		public void Wait50Millisec_UpdateAfter300Millisec_TotalWaitingIsApprox800Mililsec()
		{
			var spin = new UpdateableSpinTests();
			
			Stopwatch watcher = new Stopwatch();
			watcher.Start();
			
			const int timeout = 500;
			const int spanBeforeUpdate = 300;
			
			Task.Factory.StartNew(() => {
				Thread.Sleep(spanBeforeUpdate);
				spin.UpdateTimeout();
			});
			
			spin.Wait(TimeSpan.FromMilliseconds(timeout));
			watcher.Stop();
			
			TimeSpan actual = TimeSpan.FromMilliseconds(watcher.ElapsedMilliseconds);
			const int excepted = timeout + spanBeforeUpdate;
			
			TimeSpan leftEpsilon = TimeSpan.FromMilliseconds(50 - (50 * 0.1));
			TimeSpan rightEpsilon = TimeSpan.FromMilliseconds(50 + (50 * 0.1));
			
			Assert.IsTrue(actual > leftEpsilon && actual > rightEpsilon);
		}
	}
	
	public class UpdateableSpin
	{
		private readonly object lockObj = new object();
		private bool shouldWait = true;
		
		public bool Wait(TimeSpan.timeout)
		{
			Thread.Sleep(timeout);
			if(!shouldWait)
			{
				return true;
			}
			return false;
		}
		
		public void Set()
		{
			lock(lockObj)
			{
				shouldWait = false;
			}
		}
	}
}
