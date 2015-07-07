﻿using System;
using System.Globalization;
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
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }

        private void PlusClick(object sender, EventArgs e)
        {
            var nameButton = ((Button)sender).Name;
            var factory = FactoryTwoArgument.CreatCalculator(nameButton);
            var firstArgument = Convert.ToDouble(FirstValue.Text);
            var secondArgument = Convert.ToDouble(SecondValue.Text);
            Result.Text = Convert.ToString(factory.Calculate(firstArgument, secondArgument), CultureInfo.InvariantCulture);
        }

        private void SinClick(object sender, EventArgs e)
        {
            var nameButton = ((Button) sender).Name;
            var factory = FactoryOneArgument.CreatCalculator(nameButton);
            var firstArgument = Convert.ToDouble(FirstValue.Text);
            Result.Text = Convert.ToString(factory.Calculate(firstArgument), CultureInfo.InvariantCulture);
        }
    }
}
