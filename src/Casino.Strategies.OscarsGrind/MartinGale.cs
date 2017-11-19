using Casino.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Strategies.OscarsGrind
{
	public class MartinGale : IStrategy
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

			int betSize = minimumBet;

			for (int i = 0; i < spins.Count; i++)
			{
				bankroll += (spins[i] == Outcome.Win) ? betSize : -betSize;

				gameHistory.Add(new GameHistoryItem(betSize, spins[i], bankroll, bankroll - initialBankroll));

				if (spins[i] == Outcome.Win)
				{
					betSize = minimumBet;
				}
				else
				{
					betSize *= 2;
				}

				if (betSize > bankroll)
					return gameHistory;

			}
			return gameHistory;
		}
	}
}
