using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
	public class Game
	{
		public List<int> Run(int bankroll, int minimumBet, IStrategy strategy, int spinCount, double winProbability)
		{
			var spins = new SpinGenerator().Generate(spinCount, winProbability);
			return this.Run(bankroll, minimumBet, strategy, spins);
		}
		/// <summary>
		/// Runs the game.
		/// </summary>
		/// <param name="bankroll">The initial bankroll.</param>
		/// <param name="spins">The sample set of spins.</param>
		/// <param name="IStrategy">The strategy.</param>
		/// <returns>The history of profit during the game</returns>
		public List<int> Run(int bankroll, int minimumBet, IStrategy strategy, List<Outcome> spins)
		{

			List<int> profitHistory = new List<int>();

			if (
				spins.Count == 0 ||
				minimumBet <= 0 ||
				bankroll < minimumBet ||
				strategy == null ||
				spins == null
				)
				return profitHistory;

			int currentProfit = 0;

			int bet = minimumBet;

			currentProfit += (spins[0] == Outcome.Win) ? bet : -bet;

			for (int i = 1; i < spins.Count; i++)
			{
				if (bankroll - currentProfit <= 0)
					return profitHistory;

				bet = strategy.NextBet(spins[i], bet, minimumBet, currentProfit);

			}
			return profitHistory;
		}
	}
}
