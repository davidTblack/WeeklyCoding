using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Conversions
{
    public static class Weight
    {
        private const float GRAMS_PER_POUND = 453.59237f;

        /// <summary>
        /// Convert amount in grams to pounds
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        /// <param name="grams">Amount in grams of type double</param>
        /// <returns></returns>
        public static double gramsToPounds(double grams)
        {
            return grams / GRAMS_PER_POUND;
        }

        /// <summary>
        /// Convert amount in pounds to grams
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        /// <param name="pounds">Amount in pounds of type double</param>
        /// <returns></returns>
        public static double poundsToGrams(double pounds)
        {
            return pounds * GRAMS_PER_POUND;
        }
    }
}
