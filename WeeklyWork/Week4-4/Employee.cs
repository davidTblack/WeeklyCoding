using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_4
{
    public enum EmployeeType
    {
        salaried,
        hourly
    }

    public class Employee
    {
        public const int OT_HOURS_THRESHHOLD = 40;
        public const decimal OT_RATE = 1.5m;
        public const decimal FEDERAL_TAX_RATE = 0.18m;
        public const decimal RETIREMENT_CONTRIBUTION_RATE = 0.1m;
        public const decimal SOCIAL_SECURITY_TAX_RATE = 0.06m;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public EmployeeType Type { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Employee()
        {
        }

        /// <summary>
        /// Minimal constructor
        /// </summary>
        /// <param name="first">First Name</param>
        /// <param name="last">Last Name</param>
        public Employee(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        /// <summary>
        /// Partial constructor
        /// </summary>
        /// <param name="first">First Name</param>
        /// <param name="last">Last Name</param>
        /// <param name="id">Employee Id</param>
        public Employee(string first, string last, int id)
        {
            FirstName = first;
            LastName = last;
            Id = id;
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="first">First Name</param>
        /// <param name="last">Last Name</param>
        /// <param name="id">Employee Id</param>
        /// <param name="type">Employee type (salary/hourly)</param>
        public Employee(string first, string last, int id, EmployeeType type)
        {
            FirstName = first;
            LastName = last;
            Id = id;
            Type = type;
        }

        /// <summary>
        /// Calculate the week net pay for a salary worker
        /// </summary>
        /// <param name="salary">Yearly salary amount</param>
        /// <returns>The dollar amount of net pay for the week</returns>
        public decimal CalculateWeekSalary(decimal salary)
        {
            decimal weeklyGross = salary / 52;
            return weeklyGross - GetDeductionTotals(weeklyGross); 
        }

        /// <summary>
        /// Calculate the weekly net pay for an hourly worker
        /// </summary>
        /// <param name="hourlyRate">Hourly base rate</param>
        /// <param name="hours">Number of hours worked that week</param>
        /// <returns>The dollar amount of net pay for the week</returns>
        public decimal CalculateWeekHourly(decimal hourlyRate, decimal hours)
        {
            decimal weeklyGross, weeklyNet;
            if (hours <= OT_HOURS_THRESHHOLD)
            {
                weeklyGross = hourlyRate * hours;
            }
            else
            {
                weeklyGross = (hourlyRate * OT_HOURS_THRESHHOLD) + GetOverTimeAmount(hourlyRate, hours - OT_HOURS_THRESHHOLD);
            }
            //Gross - federal - retirement - social security
            weeklyNet = weeklyGross - GetDeductionTotals(weeklyGross);
            return weeklyNet;
        }

        /// <summary>
        /// Get the amount of overtime paid
        /// </summary>
        /// <param name="hourlyRate">Base hourly rate</param>
        /// <param name="hoursAfterThreshhold">Hours over weekly thresshold</param>
        /// <returns>The dollar amount of overtime pay</returns>
        public decimal GetOverTimeAmount(decimal hourlyRate, decimal hoursAfterThreshhold)
        {
            return Math.Round((hourlyRate * OT_RATE) * hoursAfterThreshhold);
        }

        /// <summary>
        /// Federal Tax amount
        /// </summary>
        /// <param name="takeHome">The base amount before deductions</param>
        /// <returns>The dollar amount of deduction for federal taxes</returns>
        public decimal GetFederalTaxAmount(decimal takeHome)
        {
            return Math.Round(takeHome * FEDERAL_TAX_RATE, 2);
        }

        /// <summary>
        /// Social Security Tax amount
        /// </summary>
        /// <param name="takeHome">The base amount before deductions</param>
        /// <returns>The dollar amount of deduction for social security taxes</returns>
        public decimal GetSocialSecurityTaxAmount(decimal takeHome)
        {
            return Math.Round(takeHome * SOCIAL_SECURITY_TAX_RATE, 2);
        }

        /// <summary>
        /// Retirement contribution amount
        /// </summary>
        /// <param name="takeHome">The base amount before deductions</param>
        /// <returns>The dollar amount of deduction for retirement</returns>
        public decimal GetRetirementContributionAmount(decimal takeHome)
        {
            return Math.Round(takeHome * RETIREMENT_CONTRIBUTION_RATE, 2);
        }

        /// <summary>
        /// Calculate the amount taken out for all deductions
        /// </summary>
        /// <param name="grossAmount">The base amount before deductions</param>
        /// <returns>The dollar amount of deductions</returns>
        private decimal GetDeductionTotals(decimal grossAmount)
        {
            return GetFederalTaxAmount(grossAmount) + GetRetirementContributionAmount(grossAmount) + GetSocialSecurityTaxAmount(grossAmount);
        }

    }
}
