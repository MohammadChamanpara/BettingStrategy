using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
	public class GameHistoryItem
	{
		public GameHistoryItem(int betSize, Outcome outcome, int bankroll, int profit,int sessionProfit)
		{
			this.BetSize = betSize;
			this.Outcome = outcome;
			this.Profit = profit;
			this.Bankroll = bankroll;
			this.SessionProfit = sessionProfit;
		}
		public int BetSize { get; set; }
		public Outcome Outcome { get; set; }
		public int Profit { get; set; }
		public int Bankroll { get; set; }
		public int SessionProfit { get; set; }

		public override string ToString()
		{
			return $"{BetSize} {Outcome} {Profit} { Bankroll} {SessionProfit}";
		}
	}
}
