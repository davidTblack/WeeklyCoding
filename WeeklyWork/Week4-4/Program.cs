using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week4_4
{
    class Program
    {
        /// <summary>
        /// Programming exercises for week 4 - CITP180 Summer 2017; this is CHAPTER 5
        /// Exercise 4 is an application to calculate take-home pay for salaried or hourly
        /// Inputs First and last name, id, and type.
        /// Salary takes one value, hourly takes rate and hours
        /// Include taxes, retirement, social security, and overtime considerations
        /// Calculate for the week
        /// Author: David Black
        /// Date: 6/6/2017
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            decimal salary, hourlyRate, hoursWorked;
            if (InputEmployee(out Employee currentWorker))
            {
                do
                {
                    switch (currentWorker.Type)
                    {
                        case EmployeeType.hourly:
                            if (InputHourlyInfoForWeek(out hourlyRate, out hoursWorked))
                            {
                                DisplayHourlyWeek(currentWorker, hourlyRate, hoursWorked);
                            }
                            else
                            {
                                WriteLine("Invalid Input.");
                            }
                            break;
                        case EmployeeType.salaried:
                            if (InputSalaryForWeek(out salary))
                            {
                                DisplaySalaryWeek(currentWorker, salary);
                            }
                            else
                            {
                                WriteLine("Invalid Input.");
                            }
                            break;
                        default:
                            WriteLine("Invalid worker type.");
                            break;
                    }

                    WriteLine("Press enter to calculate another week, or 9 to exit");
                } while (ReadLine() != "9");
            }
        }

        /// <summary>
        /// Prompt user for employee information.  Boolean returns if input was valid or not.
        /// </summary>
        /// <param name="worker">An Employee Object</param>
        /// <returns>True if valid input, false if invalid input</returns>
        private static bool InputEmployee(out Employee worker)
        {
            bool returnValue = true;
            worker = new Employee();

            WriteLine("Enter Employee information to calculate weekly take home pay");
            WriteLine("Is the employee Salaried or Hourly?");
            switch (ReadLine().ToUpper())
            {
                case "SALARIED":
                    worker.Type = EmployeeType.salaried;
                    break;
                case "HOURLY":
                    worker.Type = EmployeeType.hourly;
                    break;
                default:
                    returnValue = false;
                    break;
            }

            //Get First Name
            if (returnValue)
            {
                Write("Please enter employee's first name:  ");
                worker.FirstName = ReadLine();
            }

            //Get Last Name
            if (returnValue)
            {
                Write("Please enter employee's last name:  ");
                worker.LastName = ReadLine();
            }

            //Get Employee ID
            if (returnValue)
            {
                Write("Please enter employee's ID:  ");
                returnValue = int.TryParse(ReadLine(), out int employeeIdNumber);
                worker.Id = employeeIdNumber;
            }

            if (!returnValue)
                WriteLine("Invalid input.");
            
            return returnValue;
        }

        /// <summary>
        /// Get user input for salary 
        /// </summary>
        /// <param name="salary">Yearly salary</param>
        /// <returns>True if valid input, false if invalid</returns>
        public static bool InputSalaryForWeek(out decimal salary)
        {
            Write("Please enter employee's yearly salary as of the end of the week:  ");
            bool returnValue = decimal.TryParse(ReadLine(), out salary);
                        
            if (!returnValue)
                WriteLine("Invalid input.");
            return returnValue;
        }

        /// <summary>
        /// Get user input for hours worked and rate
        /// </summary>
        /// <param name="hourlyRate">Hourly wage</param>
        /// <param name="hoursWorked">Hours worked that week</param>
        /// <returns>True if valid input, false if invalid</returns>
        public static bool InputHourlyInfoForWeek(out decimal hourlyRate, out decimal hoursWorked)
        {
            hourlyRate = 0m;
            hoursWorked = 0m;
            Write("Please enter employee's hourly rate as of the end of the week:  ");
            bool returnValue = decimal.TryParse(ReadLine(), out hourlyRate);

            if (returnValue)
            {
                Write("Please enter the number of hours the employee worked during this week:  ");
                returnValue = decimal.TryParse(ReadLine(), out hoursWorked);
            }

            if (!returnValue)
                WriteLine("Invalid input.");
            return returnValue;
        }

        /// <summary>
        /// Display the weekly wage breakdown for an hourly employee
        /// </summary>
        /// <param name="worker">Employee</param>
        /// <param name="hourlyRate">Hourly rate</param>
        /// <param name="hoursWorked">Hours worked during one week</param>
        public static void DisplayHourlyWeek(Employee worker, decimal hourlyRate, decimal hoursWorked)
        {
            decimal basePay = Math.Round(hourlyRate * (hoursWorked > Employee.OT_HOURS_THRESHHOLD ? Employee.OT_HOURS_THRESHHOLD : hoursWorked), 2);
            decimal overtimePay = Math.Round(worker.GetOverTimeAmount(hourlyRate, hoursWorked - Employee.OT_HOURS_THRESHHOLD), 2);
            decimal totalPay = basePay + overtimePay;
            WriteLine("***********************************************");
            WriteLine($"Employee:  {worker.LastName}, {worker.FirstName}");
            WriteLine($"Employee ID:  {worker.Id}");
            WriteLine("Employed as an hourly worker.");
            WriteLine($"Hourly Rate:\t\t\t{hourlyRate, 11:c2}");
            WriteLine($"Hours Worked:\t\t\t{hoursWorked, 11:#.00}");
            WriteLine($"Base Pay:\t\t\t{basePay,11:c2}");
            WriteLine($"Overtime Pay:\t\t\t{overtimePay,11:c2}");
            WriteLine("-----------------------------------------------");
            WriteLine("Deductions");
            WriteLine($"Federal Tax Rate:\t\t{Employee.FEDERAL_TAX_RATE,11:p00}");
            WriteLine($"Federal Tax Amount:\t\t{worker.GetFederalTaxAmount(totalPay), 11:c2}");
            WriteLine($"Social Security Tax Rate:\t{Employee.SOCIAL_SECURITY_TAX_RATE,11:p00}");
            WriteLine($"Social Security Tax Amount:\t{worker.GetSocialSecurityTaxAmount(totalPay),11:c2}");
            WriteLine($"Retirement Contribution Rate:\t{Employee.RETIREMENT_CONTRIBUTION_RATE,11:p00}");
            WriteLine($"Retirement Contribution Amount:\t{worker.GetRetirementContributionAmount(totalPay),11:c2}");
            WriteLine("-----------------------------------------------");
            WriteLine($"Net Pay:\t\t\t{worker.CalculateWeekHourly(hourlyRate, hoursWorked),11:c2}");
            WriteLine("***********************************************");
        }

        /// <summary>
        /// Display the weekly wage breakdown for salaried employee
        /// </summary>
        /// <param name="worker">Employee</param>
        /// <param name="salary">Yearly Salary</param>
        public static void DisplaySalaryWeek(Employee worker, decimal salary)
        {
            decimal basePay = salary / 52;
            WriteLine("***********************************************");
            WriteLine($"Employee:  {worker.LastName}, {worker.FirstName}");
            WriteLine($"Employee ID:  {worker.Id}");
            WriteLine("Employed as salaried worker.");
            WriteLine($"Salary:\t\t\t\t{salary,11:c2}");
            WriteLine($"Base Pay:\t\t\t{basePay,11:c2}");
            WriteLine("-----------------------------------------------");
            WriteLine("Deductions");
            WriteLine($"Federal Tax Rate:\t\t{Employee.FEDERAL_TAX_RATE,11:p00}");
            WriteLine($"Federal Tax Amount:\t\t{worker.GetFederalTaxAmount(basePay),11:c2}");
            WriteLine($"Social Security Tax Rate:\t{Employee.SOCIAL_SECURITY_TAX_RATE,11:p00}");
            WriteLine($"Social Security Tax Amount:\t{worker.GetSocialSecurityTaxAmount(basePay),11:c2}");
            WriteLine($"Retirement Contribution Rate:\t{Employee.RETIREMENT_CONTRIBUTION_RATE,11:p00}");
            WriteLine($"Retirement Contribution Amount:\t{worker.GetRetirementContributionAmount(basePay),11:c2}");
            WriteLine("-----------------------------------------------");
            WriteLine($"Net Pay:\t\t\t{worker.CalculateWeekSalary(salary),11:c2}");
            WriteLine("***********************************************");
        }
    }
}
