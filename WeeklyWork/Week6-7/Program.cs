using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week6_7
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 6 - CITP180 Summer 2017; this is CHAPTER 7
        /// Exercise 7 is an application to test user input area codes against an array of state area codes
        /// Author: David Black
        /// Date: 6/25/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] michiganCodes = 
                {"103", "001", "517",
                "484", "553", "227",
                "505", "444", "456",
                "789", "123", "321",
                "654", "987", "741" };

            string test1 = "555",
                test2 = "741";

            StateExchange michiganExchange = new StateExchange(michiganCodes);
            Write($"Is area code {test1} in the state exchange?  ");
            WriteLine(michiganExchange.IsCodeInExchange(test1));
            Write($"Is area code {test2} in the state exchange?  ");
            WriteLine(michiganExchange.IsCodeInExchange(test2));
            WriteLine("\nList of area codes in the exchange:");
            WriteLine(michiganExchange.ToString());
            ReadLine();
        }
    }
}
