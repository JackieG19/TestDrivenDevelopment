using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDD
{
	[TestFixture]
	public class TicTacToeTests
	{
		[Tests]
		public void CreateGame_ZeroMoves()
		{
			Game game = new Game();
			Assert.AreEqual(0, game.MovesCounter);
		}
		
		[Tests]
		public void MakeMove_CounterShifts()
		{
			Game game = new Game();
			game.MakeMove(1);
			Assert.AreEqual(1, game.MovesCounter);
		}
		
		[Tests]
		public void MakeInvaildMove_ThrowsException()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() =>
			{
				var game = new Game();
				game.MakeMove(0);
			});
		}
		
		[Tests]
		public void MakeInvaildMove_ThrowsException()
		{
			Assert.Throws<InvaildOperationException>(() =>
			{
				var game = new Game();
				game.MakeMove(1);
				game.MakeMove(1);
			});
		}
	}
}
