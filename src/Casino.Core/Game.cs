using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
	public class Game
	{
		/// <summary>
		/// Runs the game.
		/// </summary>
		/// <param name="bankroll">The initial bankroll.</param>
		/// <param name="spins">The sample set of spins.</param>
		/// <param name="IStrategy">The strategy.</param>
		/// <returns>The history of profit during the game</returns>
		List<int> Run(int bankroll, int minimumBet, List<Outcome> spins, IStrategy strategy)
		{

			List<int> profitHistory = new List<int>();

			if (spins.Count == 0)
				return profitHistory;

			int currentProfit = 0;

			int bet = minimumBet;

			currentProfit += (spins[0] == Outcome.Win) ? bet : -bet;

			for (int i = 1; i < spins.Count; i++)
			{
				strategy.NextBet(spins[i],)
			}

			return profitHistory;
		}
	}
}
