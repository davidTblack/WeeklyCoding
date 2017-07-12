using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_10
{
    public partial class Form1 : Form
    {
        int target, guess, guessCount = 0;

        private void btnGuess_Click(object sender, EventArgs e)
        {
            while(int.TryParse(txtGuess.Text, out guess) == false){
                MessageBox.Show("Must enter an integer number between 1 and 100");
                txtGuess.Focus();
            }
        }

        public Form1()
        {
            InitializeComponent();
            //target = (int) new Random();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
            guessCount = 0;

        }
    }
}
