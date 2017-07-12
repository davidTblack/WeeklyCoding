using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_10
{
    static class Program
    {
        /// <summary>
        /// Programming exercises for week 7 - CITP180 Summer 2017; this is CHAPTER 11
        /// Exercise 10 is an application to show housing properties
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
