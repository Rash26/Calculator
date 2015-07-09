using System;
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

        private void TwoArgument(object sender, EventArgs e)
        {
            var nameButton = ((Button) sender).Name;
            var calculate = FactoryTwoArgument.CreatCalculator(nameButton);
            var firstArgument = Convert.ToDouble(FirstValue.Text);
            var secondArgument = Convert.ToDouble(SecondValue.Text);
            Result.Text = calculate.Calculate(firstArgument, secondArgument).ToString();
        }

        private void OneArgument(object sender, EventArgs e)
        {
            var nameButton = ((Button) sender).Name;
            var calculate = FactoryOneArgument.CreatCalculator(nameButton);
            var firstArgument = Convert.ToDouble(FirstValue.Text);
            Result.Text = calculate.Calculate(firstArgument).ToString();
        }

        private void SortingClick(object sender, EventArgs e)
        {
            var nameButton = ((Button) sender).Name;
            var calculate = FactorySort.CreatCalculator(nameButton);
            var firstArgument = FirstValue.Text;
            Result.Text = IntToStr(calculate.Sort(StrToInt(firstArgument)));

        }

        private static string IntToStr(int[] a)
        {
            string[] split = new string[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i != a.Length - 1)
                {
                    split[i] = a[i].ToString() + " ";
                }
                else
                {
                    split[i] = a[i].ToString();
                }
            }
            return string.Concat(split);
        }

        private static int[] StrToInt(string argument)
        {
            var split = argument.Split(' ');
            var a = new int[split.Length];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(split[i]);
            }
            return a;
        }
    }
}