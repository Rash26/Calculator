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

        /// <summary>
        /// numeric entry only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// the event handler for the button with two arguments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoArgument(object sender, EventArgs e)
        {
            var nameButton = ((Button) sender).Name;
            var calculate = FactoryTwoArgument.CreatCalculator(nameButton);
            var firstArgument = Convert.ToDouble(FirstValue.Text);
            var secondArgument = Convert.ToDouble(SecondValue.Text);
            Result.Text = calculate.Calculate(firstArgument, secondArgument).ToString();
        }

        /// <summary>
        /// the event handler for the button with one arguments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneArgument(object sender, EventArgs e)
        {
            var nameButton = ((Button) sender).Name;
            var calculate = FactoryOneArgument.CreatCalculator(nameButton);
            var firstArgument = Convert.ToDouble(FirstValue.Text);
            Result.Text = calculate.Calculate(firstArgument).ToString();
        }

        /// <summary>
        /// the event handler for the button sorts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortingClick(object sender, EventArgs e)
        {
            var nameButton = ((Button) sender).Name;
            var calculate = FactorySort.CreatCalculator(nameButton);
            var firstArgument = FirstValue.Text;
            Result.Text = IntToStr(calculate.Sort(StrToInt(firstArgument)));

        }

        /// <summary>
        /// function to convert the int to string
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
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

        /// <summary>
        /// function to convert the string to int
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
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