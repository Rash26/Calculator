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

        private void tbFirstValue_KeyUp(object sender, KeyEventArgs e)
        {

            int Simbol = new int();

            Simbol = Int32.Parse(tbFirstValue.Text);

            tbResult.Text = Convert.ToString(Simbol);



        }

        private void tbFirstValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                
            }
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }

        private void tbSecondValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }



    }
}
