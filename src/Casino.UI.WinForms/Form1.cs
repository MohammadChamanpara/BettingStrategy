using Casino.Core;
using Casino.Strategies.OscarsGrind;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino.UI.WinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void RunButton_Click(object sender, EventArgs e)
		{
			var spins = new SpinGenerator().Generate(int.Parse(spinsCountTextBox.Text), (double)OddsUpDown.Value);

			int bankroll = (int)bankRollUpDown.Value;
			int minBet = (int)minBetUpDown.Value;

			var gameHistory = new OscarsGrind().Run(bankroll, minBet, spins);
			ShowResultsOG(gameHistory, spins, historyListView, playCountTextBox, winLoseTextBox, maxProfitTextBox, minProfitTextBox);

			gameHistory = new OscarsGrindMin().Run(bankroll, minBet, spins);
			ShowResultsOG(gameHistory, spins, historyListViewMin, playCountTextBoxMin, winLoseTextBoxMin, maxProfitTextBoxMin, minProfitTextBoxMin);

			gameHistory = new OscarsGrindHalf().Run(bankroll, minBet, spins);
			ShowResultsOG(gameHistory, spins, historyListViewHalf, playCountTextBoxHalf, winLoseTextBoxHalf, maxProfitTextBoxHalf, minProfitTextBoxHalf);

		}
		void ShowResultsOG(List<GameHistoryItem> gameHistory, List<Outcome> spins, ListView listView, TextBox playCountTextBox, TextBox winLoseTextBox, TextBox maxProfitTextBox, TextBox minProfitTextBox)
		{

			listView.Clear();
			foreach (var item in gameHistory)
				listView.Items.Add(item.ToString());

			int playCount = gameHistory.Count();
			playCountTextBox.Text = playCount.ToString();
			int winCount = spins.Take(playCount).Count(x => x == Outcome.Win);
			winLoseTextBox.Text = $"{winCount}/{playCount - winCount}";
			maxProfitTextBox.Text = gameHistory.Max(x => x.Profit).ToString();
			minProfitTextBox.Text = gameHistory.Min(x => x.Profit).ToString();
		}
	}
}
