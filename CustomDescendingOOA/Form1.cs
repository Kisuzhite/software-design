namespace CustomDescendingOOA
{
    // OOP Class to handle sorting logic
    public class DescendingSorter
    {
        private int[] numbers;

        public DescendingSorter(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int[] SortDescending()
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            return numbers;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // WinForms button click to display results
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };

            DescendingSorter sorter = new DescendingSorter(numbers);
            int[] sortedNumbers = sorter.SortDescending();

            listBoxResults.DataSource = sortedNumbers;
        }
    }
}
