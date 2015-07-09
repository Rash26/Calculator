using System;
using System.Globalization;
using System.Windows.Forms;
using Calculator.ClassesOneArguments;
using Calculator.ClassesSorts;
using Calculator.ClassesTwoArguments;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            FirstValue.Clear();
            SecondValue.Clear();
            Result.Clear();
        }

        private void FirstValueKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else if (e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ' ')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }

        private void PlusClick(object sender, EventArgs e)
        {
            var nameButton = ((Button)sender).Name;
            var calculate = FactoryTwoArgument.CreatCalculator(nameButton);
            var firstArgument = Convert.ToDouble(FirstValue.Text);
            var secondArgument = Convert.ToDouble(SecondValue.Text);
            Result.Text = calculate.Calculate(firstArgument, secondArgument).ToString();
        }

        private void SinClick(object sender, EventArgs e)
        {
            var nameButton = ((Button) sender).Name;
            var calculate = FactoryOneArgument.CreatCalculator(nameButton);
            var firstArgument = Convert.ToDouble(FirstValue.Text);
            Result.Text = calculate.Calculate(firstArgument).ToString();
        }

        private void Sorting_Click(object sender, EventArgs e)
        {
            var nameButton = ((Button)sender).Name;
            var calculate = FactorySort.CreatCalculator(nameButton);
            var firstArgument = FirstValue.Text;
            Result.Text = IntToStr(calculate.Sort(StrToInt(firstArgument)));

        }

        public string IntToStr(int[] A)
        {
            string[] split = new string[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (i != A.Length - 1)
                {
                    split[i] = A[i].ToString() + " ";
                }
                else
                {
                    split[i] = A[i].ToString();
                }
            }
            return string.Concat(split);
        }

        public int[] StrToInt(string argument)
        {
            string[] split = argument.Split(new char[] { ' ' });
            int[] a = new int[split.Length];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(split[i]);
            }
            return a;
        }
    }
}
