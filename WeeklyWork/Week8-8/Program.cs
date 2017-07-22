﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_8
{
    static class Program
    {
        /// <summary>
        /// Programming exercises for week 8 - CITP180 Summer 2017; this is CHAPTER 9
        /// Exercise 8 is an application to calculate distance based on speed and time
        /// Author: David Black
        /// Date: 7/11/2017
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDistanceApp());
        }
    }
}
