﻿using Casino.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Strategies.OscarsGrind
{
	public class OscarsGrindLastBet : IStrategy
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

			int sessionProfit = 0;
			int initialBankroll = bankroll;

			int betSize = minimumBet;

			for (int i = 0; i < spins.Count; i++)
			{
				int spinProfit = (spins[i] == Outcome.Win) ? betSize : -betSize;

				sessionProfit += spinProfit;
				bankroll += spinProfit;

				if (sessionProfit > 0)
					sessionProfit = 0;

				gameHistory.Add(new GameHistoryItem(betSize, spins[i], bankroll, bankroll - initialBankroll));

				if (bankroll <= 0)
					return gameHistory;

				if (spins[i] == Outcome.Win)
				{
					betSize = Math.Min(betSize + minimumBet, bankroll);

					if (sessionProfit + betSize > minimumBet)
						betSize = minimumBet - sessionProfit;
				}
			}
			return gameHistory;
		}
	}
}
