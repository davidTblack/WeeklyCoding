using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_05
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction()
        {
        }
        
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public void ReduceToLowestTerms()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator = Numerator / gcd;
            Denominator = Denominator / gcd;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public void CopyToFraction(Fraction CopyTo)
        {
            CopyTo.Numerator = Numerator;
            CopyTo.Denominator = Denominator;
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
