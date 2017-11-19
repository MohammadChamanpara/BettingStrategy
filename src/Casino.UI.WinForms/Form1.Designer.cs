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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.NameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CountC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProfitC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.repetitionUpDown = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.historyDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.spinsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.OddsUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankRollUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minBetUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repetitionUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinsDataGridView)).BeginInit();
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
			this.OddsUpDown.Location = new System.Drawing.Point(132, 204);
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
			this.label2.Location = new System.Drawing.Point(13, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 17);
			this.label2.TabIndex = 41;
			this.label2.Text = "Even Probability:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 80);
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
			this.RunButton.Location = new System.Drawing.Point(15, 330);
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
			this.bankRollUpDown.Location = new System.Drawing.Point(132, 141);
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
			this.label4.Location = new System.Drawing.Point(64, 143);
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
			this.label3.Location = new System.Drawing.Point(68, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 26;
			this.label3.Text = "Min Bet:";
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameC,
            this.CountC,
            this.ProfitC});
			this.dataGridView.Location = new System.Drawing.Point(308, 15);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(455, 352);
			this.dataGridView.TabIndex = 43;
			// 
			// NameC
			// 
			this.NameC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameC.HeaderText = "Name";
			this.NameC.Name = "NameC";
			this.NameC.ReadOnly = true;
			// 
			// CountC
			// 
			this.CountC.HeaderText = "Count";
			this.CountC.Name = "CountC";
			this.CountC.ReadOnly = true;
			// 
			// ProfitC
			// 
			this.ProfitC.HeaderText = "Profit";
			this.ProfitC.Name = "ProfitC";
			this.ProfitC.ReadOnly = true;
			// 
			// repetitionUpDown
			// 
			this.repetitionUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.repetitionUpDown.Location = new System.Drawing.Point(132, 267);
			this.repetitionUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.repetitionUpDown.Name = "repetitionUpDown";
			this.repetitionUpDown.Size = new System.Drawing.Size(71, 22);
			this.repetitionUpDown.TabIndex = 45;
			this.repetitionUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(51, 269);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 17);
			this.label5.TabIndex = 44;
			this.label5.Text = "Repetition:";
			// 
			// historyDataGridView
			// 
			this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
			this.historyDataGridView.Location = new System.Drawing.Point(1040, 15);
			this.historyDataGridView.Name = "historyDataGridView";
			this.historyDataGridView.RowTemplate.Height = 24;
			this.historyDataGridView.Size = new System.Drawing.Size(265, 352);
			this.historyDataGridView.TabIndex = 46;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.HeaderText = "History";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// spinsDataGridView
			// 
			this.spinsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.spinsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
			this.spinsDataGridView.Location = new System.Drawing.Point(769, 15);
			this.spinsDataGridView.Name = "spinsDataGridView";
			this.spinsDataGridView.RowTemplate.Height = 24;
			this.spinsDataGridView.Size = new System.Drawing.Size(265, 352);
			this.spinsDataGridView.TabIndex = 47;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.HeaderText = "spins";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1291, 477);
			this.Controls.Add(this.spinsDataGridView);
			this.Controls.Add(this.historyDataGridView);
			this.Controls.Add(this.repetitionUpDown);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.OddsUpDown);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.spinsCountTextBox);
			this.Controls.Add(this.RunButton);
			this.Controls.Add(this.bankRollUpDown);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.minBetUpDown);
			this.Controls.Add(this.label3);
			this.Name = "Form1";
			this.Text = "Casino";
			((System.ComponentModel.ISupportInitialize)(this.OddsUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankRollUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minBetUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repetitionUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinsDataGridView)).EndInit();
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
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.NumericUpDown repetitionUpDown;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
		private System.Windows.Forms.DataGridViewTextBoxColumn CountC;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProfitC;
		private System.Windows.Forms.DataGridView historyDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView spinsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}

