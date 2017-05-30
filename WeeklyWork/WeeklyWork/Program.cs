using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace WeeklyWork
{
    class Program
    {
        /// <summary>
        /// Exercises 1, 2, 8, 9, 10
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetBlackOneWhite();
            Exercise1();
            Exercise2();
            //Exercise8();
            //Exercise9();
            //Exercise10();
        }

        /// Exercise 1 is to write  Hello World! with black text on white background
        /// Add a message in a different language for added challenge
        /// Authors:        David Black
        /// Date Created:   5/21/2017
        /// Purpose:        
        /// </summary>
        private static void Exercise1()
        {
            WriteLine("Hello World!  My name is David Black.");
            WriteLine("Hello World!  Mi nombre es David Black.");
            ReadLine();
        }

        /// <summary>
        /// Exercise 2 is to display a banner with information about the project
        /// Authors:        David Black
        /// Date Created:   5/21/2017
        /// Purpose:        Provide internal Documentaiton
        /// </summary>
        private static void Exercise2()
        {
            WriteLine("**********************************************");
            WriteLine("** Programming assignment #2                **");
            WriteLine("** Developer: David Black                   **");
            WriteLine("** Date Submitted: 5/21/2017                **");
            WriteLine("** Purpose: Provide internal documentation  **");
            WriteLine("**********************************************");
            ReadLine();
        }

        /// <summary>
        /// Exercise 8 is to design a stick figure and print it in the console
        /// Authors:        David Black
        /// Date Created:   5/21/2017
        /// Purpose:        Demonstrate escaping characters
        /// </summary>
        private static void Exercise8()
        {
            WriteLine("  (^;^)  ");
            WriteLine("    |    ");
            WriteLine("./  |  \\.");
            WriteLine("    |    ");
            WriteLine("  _/ \\_  ");
            ReadLine();
        }

        /// <summary>
        /// Exercise 9 is to display several patterns/shapes in the console
        /// Authors:        David Black
        /// Date Created:   5/21/2017
        /// Purpose:        To get used to putting characters in line, and probably
        ///                 to start looking for ways to save time in generating output
        /// </summary>
        private static void Exercise9()
        {
            WriteLine("********             *               *        ");
            WriteLine("********            ***             ***       ");
            WriteLine("********           *****           *****      ");
            WriteLine("********          *******         *******     ");
            WriteLine("********         *********       *********    ");
            WriteLine("********        ***********       *******     ");
            WriteLine("********       *************       *****      ");
            WriteLine("********      ***************       ***       ");
            WriteLine("********     *****************       *        ");
            ReadLine();

        }

        /// <summary>
        /// Exercise 10 is to write your initials in a console banner, using letters for each initial
        /// Authors:        David Black
        /// Date Created:   5/21/2017
        /// Purpose:        Get more practice organizing a line of text for the console, accounting 
        ///                 for each space
        /// </summary>
        private static void Exercise10()
        {
            WriteLine("DDDDDDDD            TTTTTTTTTTTTTTTTT     BBBBBBBBBBBBBB       ");
            WriteLine("DD     DDD          TTTTTTTTTTTTTTTTT    BBB          BBB      ");
            WriteLine("DD      DDDD               TT            BB             BB     ");
            WriteLine("DD        DDDD             TT            BB            BBB     ");
            WriteLine("DD          DDD            TT            BB            BB      ");
            WriteLine("DD            DD           TT            BB           BB       ");
            WriteLine("DD            DD           TT            BBBBBBBBBBBBB         ");
            WriteLine("DD            DD           TT            BB           BB       ");
            WriteLine("DD          DDD            TT            BB            BB      ");
            WriteLine("DD         DD              TT            BB            BBB     ");
            WriteLine("DD       DDD               TT            BB             BB     ");
            WriteLine("DD     DDD                 TT            BBB          BBB      ");
            WriteLine("DDDDDDDD                   TT             BBBBBBBBBBBBBB       ");
            ReadLine();
        }

        private static void SetBlackOneWhite()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}
