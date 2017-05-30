using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Week2.Conversions;

namespace Week2
{
    public class Product
    {
        private string Name { get; set; }
        private float PricePerUnit { get; set; }
        private float GramsUnitWeight { get; set; }

        /// <summary>
        /// Product can be initialized with Product Name, the Price per unit of grams, and the number of grams per unit
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        /// <param name="name">Product name</param>
        /// <param name="price">Product price per unit in grams</param>
        /// <param name="grams">Weight in grams per unit</param>
        public Product(string name, float price, float grams)
        {
            Name = name;
            PricePerUnit = price;
            GramsUnitWeight = grams;
        }

        /// <summary>
        /// Display prices in both 100 gram increments and per pound
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        public void PrintInternationalPrices()
        {
            double pricePerPound;

            //To convert, find the price per gram, then multiply that by 1 over the number of grams in a pound
            //pricePerPound = PricePerUnit/GramsUnitWeight * Weight.poundsToGrams(1); //this also works
            pricePerPound = PricePerUnit / GramsUnitWeight * (1 / Weight.gramsToPounds(1));

            WriteLine("******************************");
            WriteLine($"Product:{Name, 22}");
            WriteLine($"Price per {GramsUnitWeight, 5:#,###} grams:{PricePerUnit, 8:c}");
            WriteLine($"Price per 1 pound:{pricePerPound, 12:c}");
            WriteLine("******************************");
        }
    }
}
/* Notes figuring out how to explain conversion
 * convert grams to lb, then find factor to get 1lb, then multiply that factor by original price
 * price per 100g = price per 1g * 100
 * price per 1g = price per 100g / 100
 * price per 1lb = price per 1g * (453g/1lb) --> 453g/1lb is the same as 1g / (1/453)lb
 * */