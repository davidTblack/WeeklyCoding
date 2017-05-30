using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Conversions
{
    static class Temperature
    {
        private const int FAHRENHEIGHT_FREEZING_TEMPERATURE = 32;

        /// <summary>
        /// Convert Celcius temperature to Fahrenheight
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        /// <param name="celcius">Integer value of degrees Celcius</param>
        /// <returns></returns>
        public static double  CelciusToFahrenheit(double celcius)
        {
            return celcius * 1.8 + FAHRENHEIGHT_FREEZING_TEMPERATURE;
        }

        /// <summary>
        /// Convert Fahrenheight temperature to Celcius
        /// Author: David Black
        /// Date: 5/27/2017
        /// </summary>
        /// <param name="fahrenheight">Integer value of degrees Fahrenheight</param>
        /// <returns></returns>
        public static double FahrenheitToCelcius(double fahrenheight)
        {
            return (fahrenheight - FAHRENHEIGHT_FREEZING_TEMPERATURE) / 1.8;
        }
    }
}
