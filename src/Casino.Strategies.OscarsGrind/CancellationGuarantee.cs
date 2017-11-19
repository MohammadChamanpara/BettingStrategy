using Casino.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Strategies.OscarsGrind
{
	public class CancellationGuarantee : IStrategy
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

			List<int> target = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

			int initialBankroll = bankroll;
			int guarantee = 0;

			int betSize = (target.First() + target.Last()) * minimumBet;

			for (int i = 0; i < spins.Count; i++)
			{
				int profit = (spins[i] == Outcome.Win) ? betSize : -betSize;
				if (profit > 0)
				{
					if (guarantee < initialBankroll)
						guarantee += profit;
					else
					{
						bankroll += profit / 2;
						guarantee += profit / 2;
					}
				}
				else
				{
					bankroll += profit;
				}

				gameHistory.Add(new GameHistoryItem(betSize, spins[i], bankroll + guarantee, (bankroll + guarantee) - initialBankroll));

				if (bankroll <= 0)
					return gameHistory;

				if (spins[i] == Outcome.Win)
				{
					target.RemoveAt(0);

					if (target.Count > 0)
						target.RemoveAt(Math.Min(target.Count - 1, 0));

					if (target.Count == 0)
						target = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
				}
				else
				{
					target.Add(betSize / minimumBet);
				}
				betSize = Math.Min(bankroll, (target.First() + target.Last()) * minimumBet);
			}
			return gameHistory;
		}
	}
}
