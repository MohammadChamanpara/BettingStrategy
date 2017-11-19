﻿using Casino.Core;
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
			List<IStrategy> strategies = new List<IStrategy>
			{
				new OscarsGrind(),
				new OscarsGrindMin(),
				new OscarsGrindHalf(),
				new OscarsGrindDP(),
				new OscarsGrindDPM(),
				new OscarsGrindFB(),
				new MartinGale(),
			};

			int spinsCount = int.Parse(spinsCountTextBox.Text);
			int bankroll = (int)bankRollUpDown.Value;
			int minBet = (int)minBetUpDown.Value;
			double odds = (double)OddsUpDown.Value;
			int repetition = (int)repetitionUpDown.Value;

			dataGridView.Rows.Clear();

			foreach (var strategy in strategies)
			{
				int count = 0;
				int profit = 0;
				for (int j = 0; j < repetition; j++)
				{
					var spins = new SpinGenerator().Generate(spinsCount, odds);
					var gameHistory = strategy.Run(bankroll, minBet, spins);
					count += gameHistory.Count();
					profit += gameHistory.Max(x => x.Profit);
					if (j == 0) ShowSpins(spins.Take(count).ToList());
				}
				dataGridView.Rows.Add(strategy.GetType().Name, count / repetition, profit / repetition);
			}
		}

		private void ShowSpins(List<Outcome> spins)
		{
			spinsDataGridView.Rows.Clear();
			foreach (var spin in spins.Skip(spins.Count-20))
				spinsDataGridView.Rows.Add(spin);
		}
	}
}
