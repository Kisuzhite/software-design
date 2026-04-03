namespace lab2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            button1 = new Button();
            lblResult = new Label();
            txtArrayInput = new TextBox();
            button2 = new Button();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            button3 = new Button();
            button4 = new Button();
            txtFibonacciInput = new TextBox();
            txtBaseInput = new TextBox();
            lblFibonacciResult = new Label();
            lblPowerResult = new Label();
            txtExponentInput = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(27, 104);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(176, 27);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(65, 159);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(85, 50);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(65, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "Factorial";
            lblResult.Click += label1_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(262, 104);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(176, 27);
            txtArrayInput.TabIndex = 3;
            txtArrayInput.Text = ",";
            // 
            // button2
            // 
            button2.Location = new Point(374, 180);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(298, 159);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(94, 29);
            btnCalculateSum.TabIndex = 5;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(332, 50);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(38, 20);
            lblSumResult.TabIndex = 6;
            lblSumResult.Text = "Sum";
            // 
            // button3
            // 
            button3.Location = new Point(65, 423);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnCalculateFibonacci_Click;
            // 
            // button4
            // 
            button4.Location = new Point(288, 423);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Calculate";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnCalculatePower_Click;
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(27, 377);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(176, 27);
            txtFibonacciInput.TabIndex = 9;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(262, 377);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(176, 27);
            txtBaseInput.TabIndex = 10;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(85, 312);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(72, 20);
            lblFibonacciResult.TabIndex = 11;
            lblFibonacciResult.Text = "Fibonacci";
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(332, 288);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(49, 20);
            lblPowerResult.TabIndex = 12;
            lblPowerResult.Text = "Power";
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(262, 344);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(176, 27);
            txtExponentInput.TabIndex = 13;
            txtExponentInput.TextChanged += textBox1_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(467, 501);
            Controls.Add(txtExponentInput);
            Controls.Add(lblPowerResult);
            Controls.Add(lblFibonacciResult);
            Controls.Add(txtBaseInput);
            Controls.Add(txtFibonacciInput);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(button2);
            Controls.Add(txtArrayInput);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button button1;
        private Label lblResult;
        private TextBox txtArrayInput;
        private Button button2;
        private Button btnCalculateSum;
        private Label lblSumResult;
        private Button button3;
        private Button button4;
        private TextBox txtFibonacciInput;
        private TextBox txtBaseInput;
        private Label lblFibonacciResult;
        private Label lblPowerResult;
        private TextBox txtExponentInput;
    }
}
