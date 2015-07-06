﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bthExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbFirstValue.Clear();
            tbSecondValue.Clear();
            tbResult.Clear();
        }


        private void tbFirstValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                
            }
            else if (e.KeyChar == ',' || e.KeyChar == '-')
            {

            }
            
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }


            ///Проверка запятой в строке
            ///Если запятая имеется то вставка запрещается
            ///

            if (e.KeyChar == '.' )
            {
                e.KeyChar = ','; //замена точки на запятую
            }

            else if (e.KeyChar == ',' || e.KeyChar == '-')
            {
                if (((sender as TextBox).Text.IndexOf(',') != -1) //запятая уже есть
                    || (sender as TextBox).Text.Length == 0) //число не введено
                {
                    e.Handled = true;
                }

                else if (((sender as TextBox).Text.IndexOf('-') != -1) //запятая уже есть
                   || (sender as TextBox).Text.Length == 0) //число не введено
                {
                    e.Handled = true;
                }

                return;
            }

            ///
            /// 
            /// 
               
            
        }

        private void bthPlus_Click(object sender, EventArgs e)
        {
            if (!CheckEnterValue())
            {
                return;
            }

            var a = Convert.ToDouble(tbFirstValue.Text);
            var b = Convert.ToDouble(tbSecondValue.Text);
            double result = 0;
            switch (((Button)sender).Name)
            {
                case "bthPlus":
                    result = a + b;break;
                case "bthMinus":
                    result = a - b; break;
                case "bthMultiply":
                    result = a * b; break;
                case "bthDivide":
                    if (b == 0)
                    {
                        MessageBox.Show("Деление на ноль не возможно ! ! !");
                    }
                    else
                    {
                        result = a / b; 
                    }
                    break;

                default: throw  new Exception("ERROR"); break;
            }

            tbResult.Text = Convert.ToString(result); 
        }

        private bool CheckEnterValue()
        {
            if (tbFirstValue.Text == "" || tbSecondValue.Text == "")
            {
                MessageBox.Show("Введены не все данные ! ! !");
                return false;
            }
            else
            return true;
        }
    }
}
