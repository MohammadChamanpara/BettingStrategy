using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
    public interface IStrategy
    {
		int NextBet(Outcome lastOutcome, int lastBet,int minimumBet, int currentProfit);
    }
}
