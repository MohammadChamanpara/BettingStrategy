using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core
{
	public class SpinGenerator
	{
		public List<Outcome> Generate(int count, double winProbability)
		{
			Outcome[] outcomes = new Outcome[count];

			var random = new Random(DateTime.Now.Second);

			for (int i = 0; i < count; i++)
			{
				outcomes[i] = (random.NextDouble() < winProbability) ? Outcome.Win : Outcome.Lose;
			}

			return outcomes.ToList();
		}
	}
}
