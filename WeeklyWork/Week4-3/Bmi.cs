using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_3
{
    /// <summary>
    /// Measurements will be taken in either Metric or Imperial units
    /// </summary>
    public enum MeasurementSystem
    {
        Metric,
        Imperial 
    }
    public class Bmi
    {
        public MeasurementSystem MeasureTypePreference { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Bmi()
        {
        }

        /// <summary>
        /// Constructor when provided values
        /// </summary>
        /// <param name="h"></param>
        /// <param name="w"></param>
        /// <param name="sys"></param>
        public Bmi(double h, double w, MeasurementSystem sys)
        {
            Height = h;
            Weight = w;
            MeasureTypePreference = sys;
        }

        /// <summary>
        /// Calculating the BMI of the object
        /// </summary>
        /// <returns>BMI</returns>
        public double CalculateBMI()
        {
            //const double LB_TO_KG_FACTOR = 0.45;
            //const double INCH_TO_METER_FACTOR = 0.025;

            double calculatedBmi;

            switch (MeasureTypePreference)
            {
                case MeasurementSystem.Imperial:
                    calculatedBmi = (Weight / Math.Pow(Height, 2)) * 703;
                    break;
                case MeasurementSystem.Metric:
                    calculatedBmi = Weight / Math.Pow(Height, 2);
                    break;
                default:
                    calculatedBmi = 0;
                    break;
            }
            return calculatedBmi;            
        }

        /// <summary>
        /// Determining the classification for this BMI
        /// </summary>
        /// <returns>String classification of BMI</returns>
        public string DetermineWeightStatus()
        {
            double bmi = CalculateBMI();
            string returnValue = "";
            if (bmi < 18.5)
                returnValue = "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                returnValue = "Normal";
            else if (bmi >= 25 && bmi < 30)
                returnValue = "Overweight";
            else if (bmi >= 30)
                returnValue = "Obese";
            
            return returnValue;
        }
        
    }
}
