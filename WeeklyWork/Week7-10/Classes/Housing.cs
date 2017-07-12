using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_10
{
    class Housing
    {
        public string Address { get; set; }
        public int YearBuilt { get; set; }

        public Housing()
        {
        }

        public Housing(string addr, int year)
        {
            Address = addr;
            YearBuilt = year;
        }

        public virtual decimal RentalAmount()
        {
            return 599.99m;
        }
    }
}
