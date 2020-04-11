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
		[Tests] // 1
		public void CreateGame_ZeroMoves()
		{
			Game game = new Game();
			Assert.AreEqual(0, game.MovesCounter);
		}
		
		[Tests] // 2
		public void MakeMove_CounterShifts()
		{
			Game game = new Game();
			game.MakeMove(1);
			Assert.AreEqual(1, game.MovesCounter);
		}
	}
	
	public class Game
	{
		public int MovesCounter { get; private set; }
		
		public void MakeMove(int index)
		{
			MovesCounter++;
		}
	}
}
