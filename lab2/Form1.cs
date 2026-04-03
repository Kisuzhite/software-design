namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial: {result}";

        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        public int RecursiveFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtFibonacciInput.Text);
            int result = RecursiveFibonacci(number);
            lblFibonacciResult.Text = $"Fibonacci: {result}";
        }

        public double RecursivePower(double x, int n)
        {
            if (n == 0) return 1;
            return x * RecursivePower(x, n - 1);
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            double baseNum = double.Parse(txtBaseInput.Text);
            int exponent = int.Parse(txtExponentInput.Text);
            double result = RecursivePower(baseNum, exponent);
            lblPowerResult.Text = $"Power: {result}";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
