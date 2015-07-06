using System;
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
            if (OnlyNumbers((e)))
            {

            }
        }

        private void tbSecondValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (OnlyNumbers((e)))
            {
                
            }
        }

        private void bthPlus_Click(object sender, EventArgs e)
        {
            if (CheckEnterValue())
            {
                tbResult.Text = Convert.ToString(Int32.Parse(tbFirstValue.Text) + Int32.Parse(tbSecondValue.Text));
            }
            
        }

        public bool OnlyNumbers(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;     
                MessageBox.Show("Нужно ввести только цифры !");
                return false;
            }
            return true;
        }

        public bool CheckEnterValue()
        {
            if (tbFirstValue.Text == "" || tbSecondValue.Text == "")
            {
                MessageBox.Show("Введены не все данные ! ! !");
                return false;
            }
            else
            return true;
        }

        private void bthMinus_Click(object sender, EventArgs e)
        {
            CheckEnterValue();
        }

        private void bthMultiply_Click(object sender, EventArgs e)
        {
            CheckEnterValue();
        }

        private void bthDivide_Click(object sender, EventArgs e)
        {
            CheckEnterValue();
        }



    }
}
