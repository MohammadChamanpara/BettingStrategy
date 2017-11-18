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
			this.Zodiac = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.listView2 = new System.Windows.Forms.ListView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// Zodiac
			// 
			this.Zodiac.Location = new System.Drawing.Point(12, 228);
			this.Zodiac.Name = "Zodiac";
			this.Zodiac.Size = new System.Drawing.Size(150, 35);
			this.Zodiac.TabIndex = 1;
			this.Zodiac.Text = "Generate Spins";
			this.Zodiac.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(25, 82);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 22);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "20";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Spins Count:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Controls.Add(this.Zodiac);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(298, 529);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Spins";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.DecimalPlaces = 3;
			this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown3.Location = new System.Drawing.Point(25, 174);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(71, 22);
			this.numericUpDown3.TabIndex = 13;
			this.numericUpDown3.Value = new decimal(new int[] {
            463,
            0,
            0,
            196608});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Even Probability:";
			// 
			// listView1
			// 
			this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
			this.listView1.Location = new System.Drawing.Point(172, 18);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(123, 508);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.numericUpDown2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.listView2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(298, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(358, 529);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Game";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(9, 219);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(77, 35);
			this.button3.TabIndex = 13;
			this.button3.Text = "Run ";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDown2.Location = new System.Drawing.Point(9, 154);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(71, 22);
			this.numericUpDown2.TabIndex = 12;
			this.numericUpDown2.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Bankroll:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(9, 83);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(71, 22);
			this.numericUpDown1.TabIndex = 10;
			this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Min Bet:";
			// 
			// listView2
			// 
			this.listView2.Dock = System.Windows.Forms.DockStyle.Right;
			this.listView2.Location = new System.Drawing.Point(143, 18);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(212, 508);
			this.listView2.TabIndex = 7;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 529);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button Zodiac;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
	}
}

