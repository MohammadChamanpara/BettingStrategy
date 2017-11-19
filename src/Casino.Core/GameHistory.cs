using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
	public class GameHistoryItem
	{
		public GameHistoryItem(int betSize, Outcome outcome, int bankroll, int profit)
		{
			this.BetSize = betSize;
			this.Outcome = outcome;
			this.Profit = profit;
			this.Bankroll = bankroll;
		}
		public int BetSize { get; set; }
		public Outcome Outcome { get; set; }
		public int Profit { get; set; }
		public int Bankroll { get; set; }

		public override string ToString()
		{
			return $"{BetSize} {Outcome} {Profit} { Bankroll}";
		}
	}
}
