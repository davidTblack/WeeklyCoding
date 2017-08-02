using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_06
{
    static class WeightConverter
    {
        private static double FACTOR_OUNCES_IN_POUND = 16.0;
        private static double FACTOR_GRAMS_IN_KILOGRAM = 1000.0;
        private static double FACTOR_KILOGRAMS_IN_POUND = 0.453592;

        //update return with new measurements when implementing new conversions
        public static string[] WeightMeasures()
        {
            return new string[]
            {
                "Grams",
                "Kilograms",
                "Pounds",
                "Ounces"
            };
        }

        public static double OuncesToPounds(double ounces)
        {
            return ounces * (1.0 / FACTOR_OUNCES_IN_POUND);
        }

        public static double OuncesToGrams(double ounces)
        {
            double kilograms = OuncesToPounds(ounces) * (1 / FACTOR_KILOGRAMS_IN_POUND);
            return KilogramsToGrams(kilograms);
        }
        
        public static double OuncesToKilograms(double ounces)
        {
            double pounds = OuncesToPounds(ounces);
            return PoundsToKilograms(pounds);
        }

        public static double PoundsToOunces(double pounds)
        {
            return pounds * FACTOR_OUNCES_IN_POUND;
        }

        public static double PoundsToGrams(double pounds)
        {
            double kilograms = PoundsToKilograms(pounds);
            return KilogramsToGrams(kilograms);
        }

        public static double PoundsToKilograms(double pounds)
        {
            return pounds * FACTOR_KILOGRAMS_IN_POUND;
        }
            
        public static double GramsToPounds(double grams)
        {
            double kilograms = GramsToKilograms(grams);
            return KilogramsToPounds(kilograms);
        }

        public static double GramsToOunces(double grams)
        {
            double kilograms = GramsToKilograms(grams);
            return KilogramsToOunces(kilograms);
        }

        public static double GramsToKilograms(double grams)
        {
            return grams * (1 / FACTOR_GRAMS_IN_KILOGRAM);
        }
            
        public static double KilogramsToPounds(double kilograms)
        {
            return kilograms * (1 / FACTOR_KILOGRAMS_IN_POUND);
        }

        public static double KilogramsToGrams(double kilograms)
        {
            return kilograms * FACTOR_GRAMS_IN_KILOGRAM;
        }

        public static double KilogramsToOunces(double kilograms)
        {
            double pounds = KilogramsToPounds(kilograms);
            return PoundsToOunces(pounds);
        }
        
    }
}
