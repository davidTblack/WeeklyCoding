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
    /// <summary>
    /// Programming exercises for week 8 - CITP180 Summer 2017; this is CHAPTER 9
    /// Exercise 10 is an application to create a guessing game app that has the
    /// user enter numbers to guess the randomly selected number.
    /// Author: David Black
    /// Date: 7/11/2017
    /// </summary>
    public partial class Form1 : Form
    {
        private int target, guess, guessCount = 0;
        private Random rand = new Random();

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out guess) == false){
                MessageBox.Show("Must enter an integer number between 1 and 100");
            }
            else if (guess < 1 || guess > 100)
            {
                MessageBox.Show("Must enter an integer number between 1 and 100");
            } else if (guess < target)
            {
                BackColor = Color.DarkBlue;
                guessCount++;
                txtLastGuess.Text = txtGuess.Text;
            } else if (guess > target)
            {
                BackColor = Color.Yellow;
                guessCount++;
                txtLastGuess.Text = txtGuess.Text;
            } else if (guess == target)
            {
                guessCount++;
                txtGuess.Enabled = false;
                BackColor = Color.Green;
                btnGuess.Enabled = false;
                lblWinMessage.Text = $"You won the game with {guessCount} guesses.";
                txtLastGuess.Text = txtGuess.Text;
            }
            else
            {
                MessageBox.Show("Unknown error.  Try another guess, or restart the game if stuck.");
            }
            txtGuessCount.Text = guessCount.ToString();
            txtGuess.Text = "";
            txtGuess.Focus();
        }

        public Form1()
        {
            InitializeComponent();
            //target = (int) new Random();
            ResetGame();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }


        private void ResetGame()
        {
            guessCount = 0;
            guess = 0;
            target = rand.Next(1, 101);
            BackColor = DefaultBackColor;
            txtGuess.Enabled = true;
            btnGuess.Enabled = true;
            lblWinMessage.Text = "";
            txtGuessCount.Text = guessCount.ToString();
            txtLastGuess.Text = "";
        }
    }
}
