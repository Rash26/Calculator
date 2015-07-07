using System;
using System.Windows.Forms;

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
            else if (e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == '.')
            {

            }
            /*if (e.KeyChar == '.')
                {
                    e.KeyChar = ','; //замена точки на запятую

                    if (e.KeyChar == ',')
                    {
                        if ((sender as TextBox).Text.IndexOf(',') != -1) //запятая уже есть
                            //|| (sender as TextBox).Text.Length == 0) //число не введено
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }*/
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }

        private void PlusClick(object sender, EventArgs e)
        {
           /* if (FirstValue.Text == "" || SecondValue.Text == "")
            {
                MessageBox.Show("Введены не все данные");
                return;
            }

            var a = Convert.ToDouble(FirstValue.Text);
            var b = Convert.ToDouble(SecondValue.Text);
            double result = 0;
            switch (((Button)sender).Name)
            {
                case "Plus":
                    result = a + b;
                    break;
                case "Minus":
                    result = a - b; 
                    break;
                case "Multiply":
                    result = a * b;
                    break;
                case "Divide":
                    if (b == 0)
                    {
                        MessageBox.Show("Деление на ноль не возможно");
                    }
                    else
                    {
                        result = a / b; 
                    }
                    break;
                default: 
                    throw  new Exception("ERROR"); 
            }

            Result.Text = Convert.ToString(result); 
            */
            TwoArgument calc = FactoryTwoArgument.CreatCalculator(((Button)sender).Name);
            double x = Convert.ToDouble(FirstValue.Text);
            double y = Convert.ToDouble(SecondValue.Text);
            Result.Text = Convert.ToString(calc.calculate(x,y));
        }

        private void SinClick(object sender, EventArgs e)
        {
           /* if (FirstValue.Text == "")
            {
                MessageBox.Show("Введите данные");
                return;
            }

            var argument = Convert.ToDouble(FirstValue.Text);
            double result = 0;

            switch (((Button) sender).Name)
            {
                case "Sin":
                    result = Math.Sin(argument*Math.PI / 180);
                    break;
                case "Cos":
                    result = Math.Cos(argument*Math.PI / 180);
                    break;
             default: 
                 throw  new Exception("ERROR"); 
            }

            Result.Text = Convert.ToString(result);*/
            OneArgument calc = FactoryOneArgument.CreatCalculator(((Button)sender).Name);
            double x = Convert.ToDouble(FirstValue.Text);
            Result.Text = Convert.ToString(calc.calculate(x));
        }
    }
}
