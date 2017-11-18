namespace Casino.UI.WinForms
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OddsUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.spinsCountTextBox = new System.Windows.Forms.TextBox();
			this.RunButton = new System.Windows.Forms.Button();
			this.bankRollUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.minBetUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.historyListView = new System.Windows.Forms.ListView();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.historyListViewMin = new System.Windows.Forms.ListView();
			this.label5 = new System.Windows.Forms.Label();
			this.winLoseTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.playCountTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.minProfitTextBox = new System.Windows.Forms.TextBox();
			this.maxProfitTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.winLoseTextBoxMin = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.playCountTextBoxMin = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.minProfitTextBoxMin = new System.Windows.Forms.TextBox();
			this.maxProfitTextBoxMin = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.winLoseTextBoxHalf = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.playCountTextBoxHalf = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.minProfitTextBoxHalf = new System.Windows.Forms.TextBox();
			this.maxProfitTextBoxHalf = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.historyListViewHalf = new System.Windows.Forms.ListView();
			((System.ComponentModel.ISupportInitialize)(this.OddsUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankRollUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBetUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// OddsUpDown
			// 
			this.OddsUpDown.DecimalPlaces = 3;
			this.OddsUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.OddsUpDown.Location = new System.Drawing.Point(132, 207);
			this.OddsUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.OddsUpDown.Name = "OddsUpDown";
			this.OddsUpDown.Size = new System.Drawing.Size(71, 22);
			this.OddsUpDown.TabIndex = 42;
			this.OddsUpDown.Value = new decimal(new int[] {
            463,
            0,
            0,
            196608});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 209);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 17);
			this.label2.TabIndex = 41;
			this.label2.Text = "Even Probability:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 17);
			this.label1.TabIndex = 40;
			this.label1.Text = "Spins Count:";
			// 
			// spinsCountTextBox
			// 
			this.spinsCountTextBox.Location = new System.Drawing.Point(132, 78);
			this.spinsCountTextBox.Name = "spinsCountTextBox";
			this.spinsCountTextBox.Size = new System.Drawing.Size(71, 22);
			this.spinsCountTextBox.TabIndex = 39;
			this.spinsCountTextBox.Text = "2000";
			// 
			// RunButton
			// 
			this.RunButton.Location = new System.Drawing.Point(15, 281);
			this.RunButton.Name = "RunButton";
			this.RunButton.Size = new System.Drawing.Size(188, 35);
			this.RunButton.TabIndex = 30;
			this.RunButton.Text = "Run ";
			this.RunButton.UseVisualStyleBackColor = true;
			this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
			// 
			// bankRollUpDown
			// 
			this.bankRollUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.bankRollUpDown.Location = new System.Drawing.Point(132, 143);
			this.bankRollUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.bankRollUpDown.Name = "bankRollUpDown";
			this.bankRollUpDown.Size = new System.Drawing.Size(71, 22);
			this.bankRollUpDown.TabIndex = 29;
			this.bankRollUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 17);
			this.label4.TabIndex = 28;
			this.label4.Text = "Bankroll:";
			// 
			// minBetUpDown
			// 
			this.minBetUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.minBetUpDown.Location = new System.Drawing.Point(132, 15);
			this.minBetUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.minBetUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.minBetUpDown.Name = "minBetUpDown";
			this.minBetUpDown.Size = new System.Drawing.Size(71, 22);
			this.minBetUpDown.TabIndex = 27;
			this.minBetUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 26;
			this.label3.Text = "Min Bet:";
			// 
			// historyListView
			// 
			this.historyListView.Location = new System.Drawing.Point(260, 35);
			this.historyListView.Name = "historyListView";
			this.historyListView.Size = new System.Drawing.Size(212, 467);
			this.historyListView.TabIndex = 25;
			this.historyListView.UseCompatibleStateImageBehavior = false;
			this.historyListView.View = System.Windows.Forms.View.Tile;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(257, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(92, 17);
			this.label9.TabIndex = 43;
			this.label9.Text = "Oscars Grind";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(499, 15);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 17);
			this.label10.TabIndex = 45;
			this.label10.Text = "Oscars Grind Min";
			// 
			// historyListViewMin
			// 
			this.historyListViewMin.Location = new System.Drawing.Point(502, 35);
			this.historyListViewMin.Name = "historyListViewMin";
			this.historyListViewMin.Size = new System.Drawing.Size(212, 467);
			this.historyListViewMin.TabIndex = 44;
			this.historyListViewMin.UseCompatibleStateImageBehavior = false;
			this.historyListViewMin.View = System.Windows.Forms.View.Tile;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(257, 519);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 17);
			this.label5.TabIndex = 47;
			this.label5.Text = "Win/Lose";
			// 
			// winLoseTextBox
			// 
			this.winLoseTextBox.Location = new System.Drawing.Point(337, 516);
			this.winLoseTextBox.Name = "winLoseTextBox";
			this.winLoseTextBox.ReadOnly = true;
			this.winLoseTextBox.Size = new System.Drawing.Size(100, 22);
			this.winLoseTextBox.TabIndex = 46;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(275, 600);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 17);
			this.label8.TabIndex = 53;
			this.label8.Text = "Count:";
			// 
			// playCountTextBox
			// 
			this.playCountTextBox.Location = new System.Drawing.Point(337, 597);
			this.playCountTextBox.Name = "playCountTextBox";
			this.playCountTextBox.ReadOnly = true;
			this.playCountTextBox.Size = new System.Drawing.Size(100, 22);
			this.playCountTextBox.TabIndex = 52;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(257, 572);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 17);
			this.label7.TabIndex = 51;
			this.label7.Text = "Min Profit:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(257, 547);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 17);
			this.label6.TabIndex = 50;
			this.label6.Text = "Max Profit:";
			// 
			// minProfitTextBox
			// 
			this.minProfitTextBox.Location = new System.Drawing.Point(337, 569);
			this.minProfitTextBox.Name = "minProfitTextBox";
			this.minProfitTextBox.ReadOnly = true;
			this.minProfitTextBox.Size = new System.Drawing.Size(100, 22);
			this.minProfitTextBox.TabIndex = 49;
			// 
			// maxProfitTextBox
			// 
			this.maxProfitTextBox.Location = new System.Drawing.Point(337, 544);
			this.maxProfitTextBox.Name = "maxProfitTextBox";
			this.maxProfitTextBox.ReadOnly = true;
			this.maxProfitTextBox.Size = new System.Drawing.Size(100, 22);
			this.maxProfitTextBox.TabIndex = 48;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label11.Location = new System.Drawing.Point(502, 519);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(67, 17);
			this.label11.TabIndex = 55;
			this.label11.Text = "Win/Lose";
			// 
			// winLoseTextBoxMin
			// 
			this.winLoseTextBoxMin.Location = new System.Drawing.Point(582, 516);
			this.winLoseTextBoxMin.Name = "winLoseTextBoxMin";
			this.winLoseTextBoxMin.ReadOnly = true;
			this.winLoseTextBoxMin.Size = new System.Drawing.Size(100, 22);
			this.winLoseTextBoxMin.TabIndex = 54;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(520, 600);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(49, 17);
			this.label12.TabIndex = 61;
			this.label12.Text = "Count:";
			// 
			// playCountTextBoxMin
			// 
			this.playCountTextBoxMin.Location = new System.Drawing.Point(582, 597);
			this.playCountTextBoxMin.Name = "playCountTextBoxMin";
			this.playCountTextBoxMin.ReadOnly = true;
			this.playCountTextBoxMin.Size = new System.Drawing.Size(100, 22);
			this.playCountTextBoxMin.TabIndex = 60;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(502, 572);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(71, 17);
			this.label13.TabIndex = 59;
			this.label13.Text = "Min Profit:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(502, 547);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 17);
			this.label14.TabIndex = 58;
			this.label14.Text = "Max Profit:";
			// 
			// minProfitTextBoxMin
			// 
			this.minProfitTextBoxMin.Location = new System.Drawing.Point(582, 569);
			this.minProfitTextBoxMin.Name = "minProfitTextBoxMin";
			this.minProfitTextBoxMin.ReadOnly = true;
			this.minProfitTextBoxMin.Size = new System.Drawing.Size(100, 22);
			this.minProfitTextBoxMin.TabIndex = 57;
			// 
			// maxProfitTextBoxMin
			// 
			this.maxProfitTextBoxMin.Location = new System.Drawing.Point(582, 544);
			this.maxProfitTextBoxMin.Name = "maxProfitTextBoxMin";
			this.maxProfitTextBoxMin.ReadOnly = true;
			this.maxProfitTextBoxMin.Size = new System.Drawing.Size(100, 22);
			this.maxProfitTextBoxMin.TabIndex = 56;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label15.Location = new System.Drawing.Point(742, 519);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(67, 17);
			this.label15.TabIndex = 65;
			this.label15.Text = "Win/Lose";
			// 
			// winLoseTextBoxHalf
			// 
			this.winLoseTextBoxHalf.Location = new System.Drawing.Point(822, 516);
			this.winLoseTextBoxHalf.Name = "winLoseTextBoxHalf";
			this.winLoseTextBoxHalf.ReadOnly = true;
			this.winLoseTextBoxHalf.Size = new System.Drawing.Size(100, 22);
			this.winLoseTextBoxHalf.TabIndex = 64;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(760, 600);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(49, 17);
			this.label16.TabIndex = 71;
			this.label16.Text = "Count:";
			// 
			// playCountTextBoxHalf
			// 
			this.playCountTextBoxHalf.Location = new System.Drawing.Point(822, 597);
			this.playCountTextBoxHalf.Name = "playCountTextBoxHalf";
			this.playCountTextBoxHalf.ReadOnly = true;
			this.playCountTextBoxHalf.Size = new System.Drawing.Size(100, 22);
			this.playCountTextBoxHalf.TabIndex = 70;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(742, 572);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(71, 17);
			this.label17.TabIndex = 69;
			this.label17.Text = "Min Profit:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(742, 547);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(74, 17);
			this.label18.TabIndex = 68;
			this.label18.Text = "Max Profit:";
			// 
			// minProfitTextBoxHalf
			// 
			this.minProfitTextBoxHalf.Location = new System.Drawing.Point(822, 569);
			this.minProfitTextBoxHalf.Name = "minProfitTextBoxHalf";
			this.minProfitTextBoxHalf.ReadOnly = true;
			this.minProfitTextBoxHalf.Size = new System.Drawing.Size(100, 22);
			this.minProfitTextBoxHalf.TabIndex = 67;
			// 
			// maxProfitTextBoxHalf
			// 
			this.maxProfitTextBoxHalf.Location = new System.Drawing.Point(822, 544);
			this.maxProfitTextBoxHalf.Name = "maxProfitTextBoxHalf";
			this.maxProfitTextBoxHalf.ReadOnly = true;
			this.maxProfitTextBoxHalf.Size = new System.Drawing.Size(100, 22);
			this.maxProfitTextBoxHalf.TabIndex = 66;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(739, 15);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(121, 17);
			this.label19.TabIndex = 63;
			this.label19.Text = "Oscars Grind Half";
			// 
			// historyListViewHalf
			// 
			this.historyListViewHalf.Location = new System.Drawing.Point(742, 35);
			this.historyListViewHalf.Name = "historyListViewHalf";
			this.historyListViewHalf.Size = new System.Drawing.Size(212, 467);
			this.historyListViewHalf.TabIndex = 62;
			this.historyListViewHalf.UseCompatibleStateImageBehavior = false;
			this.historyListViewHalf.View = System.Windows.Forms.View.Tile;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1291, 727);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.winLoseTextBoxHalf);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.playCountTextBoxHalf);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.minProfitTextBoxHalf);
			this.Controls.Add(this.maxProfitTextBoxHalf);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.historyListViewHalf);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.winLoseTextBoxMin);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.playCountTextBoxMin);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.minProfitTextBoxMin);
			this.Controls.Add(this.maxProfitTextBoxMin);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.winLoseTextBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.playCountTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.minProfitTextBox);
			this.Controls.Add(this.maxProfitTextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.historyListViewMin);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.OddsUpDown);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.spinsCountTextBox);
			this.Controls.Add(this.RunButton);
			this.Controls.Add(this.bankRollUpDown);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.minBetUpDown);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.historyListView);
			this.Name = "Form1";
			this.Text = "Casino";
			((System.ComponentModel.ISupportInitialize)(this.OddsUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankRollUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBetUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown OddsUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox spinsCountTextBox;
		private System.Windows.Forms.Button RunButton;
		private System.Windows.Forms.NumericUpDown bankRollUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown minBetUpDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView historyListView;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ListView historyListViewMin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox winLoseTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox playCountTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox minProfitTextBox;
		private System.Windows.Forms.TextBox maxProfitTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox winLoseTextBoxMin;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox playCountTextBoxMin;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox minProfitTextBoxMin;
		private System.Windows.Forms.TextBox maxProfitTextBoxMin;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox winLoseTextBoxHalf;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox playCountTextBoxHalf;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox minProfitTextBoxHalf;
		private System.Windows.Forms.TextBox maxProfitTextBoxHalf;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ListView historyListViewHalf;
	}
}

