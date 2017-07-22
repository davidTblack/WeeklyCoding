using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_10
{
    static class GuessingGameApp
    {
        /// <summary>
        /// Programming exercises for week 8 - CITP180 Summer 2017; this is CHAPTER 9
        /// Exercise 10 is an application to create a guessing game app that has the
        /// user enter numbers to guess the randomly selected number.
        /// Author: David Black
        /// Date: 7/11/2017
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
