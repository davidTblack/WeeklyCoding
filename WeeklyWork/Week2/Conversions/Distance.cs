using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Conversions
{
    public static class Distance
    {
        private const uint FEET_IN_A_MILE = 5280;
        private const float KILOMETERS_IN_A_MILE = 1.609344f;

        /// <summary>
        /// Method to convert a value from miles into feet
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        /// <param name="mile">Miles in a double type to be converted</param>
        /// <returns></returns>
        public static double MilesToFeet(double mile)
        {
            return mile * FEET_IN_A_MILE;
        }

        /// <summary>
        /// Method to convert a value from miles into kilometers
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        /// <param name="mile">Miles in a double type to be converted</param>
        /// <returns></returns>
        public static double MilesToKilometers(double mile)
        {
            return mile * KILOMETERS_IN_A_MILE;
        }

    }
}
