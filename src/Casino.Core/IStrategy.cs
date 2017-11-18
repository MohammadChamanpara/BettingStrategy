using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
    public interface IStrategy
    {
		List<GameHistoryItem> Run(int bankroll, int minimumBet, List<Outcome> spins);
	}
}
