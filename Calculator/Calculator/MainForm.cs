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
    }
}
