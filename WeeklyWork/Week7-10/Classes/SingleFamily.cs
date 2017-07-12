using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_10
{
    class SingleFamily : Housing, IUnits
    {
        public double SquareFeet { get; set; }
        public bool HasGarage { get; set; }

        public SingleFamily()
        {
        }

        public SingleFamily(string addr, int year, double squareFt, bool hasGarage)
            : base(addr, year)
        {
            SquareFeet = squareFt;
            HasGarage = hasGarage;
        }

        public override decimal RentalAmount()
        {
            return base.RentalAmount() * 1.5m;
        }

        public int NumberOfUnits()
        {
            return 1;
        }

        public override string ToString()
        {
            return $"Address:\t\t{Address}" +
                $"\r\nYear Built:\t{YearBuilt}" +
                $"\r\nSquare Footage:\t{SquareFeet}" +
                $"\r\nHas a garage:\t{HasGarage}" +
                $"\r\nNumber of Units:\t{NumberOfUnits()}" +
                $"\r\nRental Amount:\t{RentalAmount():c2}";

        }
    }
}
