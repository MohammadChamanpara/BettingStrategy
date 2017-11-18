using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
    public interface IGame
    {
		/// <summary>
		/// Runs the game.
		/// </summary>
		/// <param name="bankroll">The initial bankroll.</param>
		/// <param name="spins">The sample set of spins.</param>
		/// <param name="IStrategy">The strategy.</param>
		/// <returns>Profit of the game</returns>
		int Run(int bankroll, List<Outcome> spins, IStrategy strategy);
    }
}
