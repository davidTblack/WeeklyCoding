using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week6_5
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 6 - CITP180 Summer 2017; this is CHAPTER 7
        /// Exercise 5 is an application to report monthly and total sales based on user input
        /// Author: David Black
        /// Date: 6/25/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int countMonths;
            decimal[] monthSalesNumbers;
            WriteLine("This program will show monthly sales contributions total sales.");
            Write("\nHow many months do you have to enter?  ");
            if (int.TryParse(ReadLine(), out countMonths))
            {
                monthSalesNumbers = new decimal[countMonths];
                InputMonthlySales(monthSalesNumbers);
                DisplayReport(monthSalesNumbers);
            }
            ReadLine();
        }

        /// <summary>
        /// Get each month of sales for a predetermined number of months
        /// </summary>
        /// <param name="monthSales">Array with length equal to the number input by user</param>
        private static void InputMonthlySales(decimal[] monthSales)
        {
            for (int i = 0; i < monthSales.Length; i++)
            {
                Write($"Month {i + 1}:  ");
                while(!decimal.TryParse(ReadLine(), out monthSales[i]))
                {
                    WriteLine("Invalid input.  Re-enter month sales value.");
                    Write($"Month {i + 1}:  ");
                }
            }
        }

        
        private static void DisplayReport(decimal[] monthSales)
        {
            decimal totalSales = monthSales.Sum();
            WriteLine($"\nTotal Sales:  {totalSales:c2}");
            WriteLine("************************************************");
            WriteLine("Month\t\tSales\tPercent of Total");
            for (int i = 0; i < monthSales.Length; i++)
            {
                WriteLine($"{i + 1,3}\t{monthSales[i],15:c2}\t{monthSales[i] / totalSales,10:p1}");
            }
            WriteLine("************************************************");
        }
    }
}
