using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week3_10
{
    class Program
    {
        const decimal ASSESSMENT_PERCENT_INCREASE = .027m;
        const decimal EXEMPTION_AMOUNT = 25000.00m;
        const decimal CURRENT_MILLAGE_PER_1000 = 10.03m;

        /// <summary>
        /// Programming exercises for week 3 - CITP180 Summer 2017
        /// Exercise 10 is to build an application to calculate Property tax
        /// -User enters address and previous year's assessed value
        /// -Assessment goes up by a percentage over previous year
        /// -An exemption applies, so take that off the assessed value
        /// Author: David Black
        /// Date: 5/30/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            decimal assessmentValue,
                currentYearAssessedValue,
                currentYearPropertyTax;

            InputAddress(out string[] address);
            if (InputAssessmentAmount(out assessmentValue))
            {
                currentYearAssessedValue = CalculateCurrentAssessment(assessmentValue);
                currentYearPropertyTax = CalculateCurrentYearTaxes(currentYearAssessedValue);
                DisplayPropertyTaxInfo(address, assessmentValue, currentYearAssessedValue, currentYearPropertyTax);
            }
            ReadLine();
        }

        /// <summary>
        /// Prompt user for a previously assessed amount.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="addr">String array representing address</param>
        private static void InputAddress(out string[] addr)
        {
            addr = new string[5];

            WriteLine("Enter the address.");

            do
            {
                Write("Line 1:  ");
                addr[0] = ReadLine();

            } while (addr[0] == "");
            
            Write("Line 2:  ");
            addr[1] = ReadLine();

            do
            {
                Write("City:  ");
                addr[2] = ReadLine();

            } while (addr[2] == "");

            do
            {
                Write("State:  ");
                addr[3] = ReadLine();

            } while (addr[3] == "");

            do
            {
                Write("Zip:  ");
                addr[4] = ReadLine();

            } while (addr[4] == "");
        }

        /// <summary>
        /// Prompt user for a previously assessed amount.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="a">Assessed value</param>
        /// <returns>True if valid input, false if invalid input</returns>
        private static bool InputAssessmentAmount(out decimal a)
        {
            bool returnValue = true;
            a = 0;

            WriteLine("Enter the previous year's assessed value.");
            try
            {
                Write("Assessment value:  ");
                a = decimal.Parse(ReadLine());
                //Enforce two decimal places for a bill
                if (Math.Round(a, 2) != a)
                    throw new FormatException("Assessed value can only include 2 decimal places");
            }
            catch (FormatException f)
            {
                WriteLine("Assessed value must be numeric and contain only two decimal places.  Invalid input.  Error: " + f.Message);
                returnValue = false;
            }
            return returnValue;
        }

        private static decimal CalculateCurrentAssessment(decimal previousYearAssessment)
        {
            return Math.Round(previousYearAssessment * (1 + ASSESSMENT_PERCENT_INCREASE), 2);
        }

        private static decimal CalculateCurrentYearTaxes(decimal assessedValue)
        {
            decimal calculatedTaxes,
                valueAfterExemption;

            if (assessedValue > EXEMPTION_AMOUNT)
                valueAfterExemption = assessedValue - EXEMPTION_AMOUNT;
            else
                valueAfterExemption = 0;

            calculatedTaxes = CURRENT_MILLAGE_PER_1000 * (valueAfterExemption / 1000m);

            return calculatedTaxes;
        }

        private static void DisplayPropertyTaxInfo(string[] addr, decimal oldAssessment, decimal newAssessment, decimal propertyTaxes)
        {

            WriteLine("***********************************************");
            WriteLine("Property Address:");
            WriteLine(addr[0]);
            if (addr[1] != "")
                WriteLine(addr[1]);
            WriteLine($"{addr[2]}, {addr[3]}    {addr[4]}");
            WriteLine("-----------------------------------------------");
            WriteLine($"Previous year's assessment:{oldAssessment,13:c}");
            WriteLine($"Current year's assessment:{newAssessment,14:c}");
            WriteLine($"Current year's property tax:{propertyTaxes,12:c}");
            WriteLine("***********************************************");
        }
    }
}
