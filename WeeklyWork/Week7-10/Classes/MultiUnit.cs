using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_10
{
    class MultiUnit : Housing, IUnits
    {
        private int numberUnits;

        public MultiUnit()
        {
        }

        public MultiUnit(string addr, int year, int units)
            : base(addr, year)
        {
            numberUnits = units;
        }

        public override decimal RentalAmount()
        {
            return base.RentalAmount() * (decimal)numberUnits;
        }

        public int NumberOfUnits()
        {
            return numberUnits;
        }

        public override string ToString()
        {
            return $"Address:\t\t{Address}" +
                $"\r\nYear Built:\t{YearBuilt}" +
                $"\r\nNumber of Units:\t{NumberOfUnits()}" +
                $"\r\nRental Amount:\t{RentalAmount():c2}";
        }
    }
}
