using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7_8_Student;

namespace Week7_8_UndergraduateStudent
{
    public class UndergraduateStudent : Student
    {
        public string Classification { get; set; }
        public string ParentName { get; set; }
        public string ParentAddress { get; set; }

        public UndergraduateStudent()
        {
        }

        public UndergraduateStudent(string name, string id, string classification, string parentName, string parentAddress)
            : base(name, id)
        {
            Classification = classification;
            ParentName = parentName;
            ParentAddress = parentAddress;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\r\nClass:\t\t{Classification}" +
                $"\r\nParent Name:\t{ParentName}" +
                $"\r\nParent Address:\t{ParentAddress}";
        }
    }
}
