using Casino.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Strategies.OscarsGrind
{
	public class OscarsGrindStrategy : IStrategy
	{
		public int NextBet(Outcome lastOutcome, int lastBet, int minimumBet, int currentProfit)
		{
			if (currentProfit > 0)
				return minimumBet;

			if (lastOutcome == Outcome.Lose)
				return lastBet;

			int nextBet = lastBet + minimumBet;

			if (currentProfit + nextBet > minimumBet)
				nextBet = minimumBet - currentProfit;

			return nextBet;
		}
	}
}
