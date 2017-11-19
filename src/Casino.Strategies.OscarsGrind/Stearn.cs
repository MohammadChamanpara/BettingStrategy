using Casino.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Strategies.OscarsGrind
{
	public class Stearn : IStrategy
	{
		public List<GameHistoryItem> Run(int bankroll, int minimumBet, List<Outcome> spins)
		{
			List<GameHistoryItem> gameHistory = new List<GameHistoryItem>();

			if (
				spins.Count == 0 ||
				minimumBet <= 0 ||
				bankroll < minimumBet ||
				spins == null
				)
				return gameHistory;

			int initialBankroll = bankroll;

			List<int> bets = new List<int> { 1, 1, 1, 2, 2, 4, 4, 8, 8 };
			int betIndex = 0;

			int betSize = minimumBet;
			for (int i = 0; i < spins.Count; i++)
			{
				bankroll += (spins[i] == Outcome.Win) ? betSize : -betSize;

				gameHistory.Add(new GameHistoryItem(betSize, spins[i], bankroll, bankroll - initialBankroll));

				if (bankroll <= 0)
					return gameHistory;

				if (spins[i] == Outcome.Win)
				{
					if (spins[Math.Max(0, i - 1)] == Outcome.Win)
						betIndex = 0;
				}
				else
				{
					betIndex = Math.Min(betIndex + 1, bets.Count - 1); ;
				}

				betSize = Math.Min(bankroll, minimumBet * bets[betIndex]);
			}
			return gameHistory;
		}
	}
}
