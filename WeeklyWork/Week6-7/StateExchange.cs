using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_7
{
    /// <summary>
    /// Class Holding state data
    /// </summary>
    public class StateExchange
    {
        private string[] registeredAreaCodes { get; set; }

        public StateExchange()
        {
        }

        /// <summary>
        /// Constructor where area codes are provided
        /// </summary>
        /// <param name="registerCodes">Array of formatted area codes</param>
        public StateExchange(string[] registerCodes)
        {
            registeredAreaCodes = new string[registerCodes.Length];
            Array.Copy(registerCodes, registeredAreaCodes, registerCodes.Length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkCode"></param>
        /// <returns></returns>
        public bool IsCodeInExchange(string checkCode)
        {
            return (Array.IndexOf(registeredAreaCodes, checkCode) != -1);
        }

        /// <summary>
        /// Return a formatted string containing all the area codes.
        /// </summary>
        /// <returns>Formatted list of area codes</returns>
        public override string ToString()
        {
            string areaCodeList = "";
            for (int i = 0; i < registeredAreaCodes.Length; i++)
            {
                areaCodeList += $"({registeredAreaCodes[i]})";
                //Add a comma unless it is the last value
                if (i + 1 != registeredAreaCodes.Length)
                {
                    areaCodeList += ",";

                    //display 3 codes per line; offset i by 1 since 0/3 is 0 and we already wrote one.
                    if ((i + 1) % 3 == 0)
                    {
                        areaCodeList += "\n";
                    }
                    else
                    {
                        areaCodeList += " ";
                    }
                }                
            }
            return areaCodeList;
        }
    }
}
