using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_2
{
    /// <summary>
    /// Programming exercises for week 8 - CITP180 Summer 2017; this is CHAPTER 9
    /// Exercise 2 is an application to create a form that has buttons to change
    /// the background color
    /// Author: David Black
    /// Date: 7/11/2017
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            MessageBox.Show("The form color has been changed to Red.");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            MessageBox.Show("The form color has been changed to Green.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            MessageBox.Show("The form color has been reset to Blue.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
