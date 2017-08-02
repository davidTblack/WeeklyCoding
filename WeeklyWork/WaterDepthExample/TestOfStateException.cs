using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDepthExample
{
    public class TestOfStateException : ApplicationException
    {
        public TestOfStateException(string exceptionType)
            : base(exceptionType)
        {
        }
    }
}
