using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WaterDepthExample
{
    class ShoalArea
    {
        private string state;
        public string Location { get; set; }
        public string State
        {
            get { return state; } 
            set { CheckStateOk(value); }
        }
        public double MileMarker { get; set; }
        public double[] LowTideDepth { get; set; }
        public double[] HiTideDepth { get; set; }

        public ShoalArea()
        {
            LowTideDepth = new double[4];
            HiTideDepth = new double[4];
        }

        public ShoalArea(string loc, string st, double mile, double[] low, double[] hi)
        {
            Location = loc;
            CheckStateOk(st);
            MileMarker = mile;
            LowTideDepth = low;
            HiTideDepth = hi;
        }

        public ShoalArea (string loc, string st, double mile)
            :this()
        {
            Location = loc;
            CheckStateOk(st);
            MileMarker = mile;
        }

        public double CalculateAverageDepth(double[] depthArray)
        {
            double sum = 0;
            double avg;
            try
            {
                foreach (double val in depthArray)
                {
                    sum += val;
                }
                avg = sum / depthArray.Length;
            }
            catch (DivideByZeroException e)
            {
                avg = 0;
                Trace.WriteLine("Attempted to Divide by Zero" +
                    "\nException Type: " + e.Message);
            }
            return avg;
        }

        public void CheckStateOk(string st)
        {
            switch (st.ToUpper())
            {
                case "FL":
                case "GA":
                case "NC":
                case "SC":
                case "VA":
                    state = st.ToUpper();
                    break;
                default:
                    TestOfStateException ex = new TestOfStateException("State not part of Atlantic ICW");
                    throw ex;
            }
        }

        public override string ToString()
        {
            return $"Location: {Location}" +
                $"\nState: {State}" +
                $"\nMile: {MileMarker}" +
                $"\nAverage Low Water Depth: {CalculateAverageDepth(LowTideDepth).ToString("F2")}" +
                $"\nAverage High Water Depth: {CalculateAverageDepth(HiTideDepth).ToString("F2")}" +
                $"\nOverall Average Water Depth: {((CalculateAverageDepth(LowTideDepth) + CalculateAverageDepth(HiTideDepth)) / 2.0).ToString("F2")}";
        }

        public string ShoalAreaRecord
        {
            get
            {
                string rec = Location + ", " + state.ToUpper() + ": " + MileMarker + "- ";
                foreach (double val in LowTideDepth)
                    rec += val + ", ";
                rec += "(" + CalculateAverageDepth(LowTideDepth).ToString("0.00") + ") ";
                foreach (double val in HiTideDepth)
                    rec += val + ", ";
                rec += "(" + CalculateAverageDepth(HiTideDepth).ToString("0.00") + ") ";
                return rec;
            }
        }
    }
}
